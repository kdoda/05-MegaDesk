using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
   
    public partial class SearchQuotes : Form
    {
        private static string FILE_PATH = AppDomain.CurrentDomain.BaseDirectory + @"\quotes.txt";
        private List<DeskQuote> deskQuotes;

        public SearchQuotes()
        {
            InitializeComponent();
            ReadQuotes();
            PopulateMaterials();
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void PopulateMaterials()
        {
            var materials = Enum.GetValues(typeof(Desk.SurfaceMaterial))
                                .Cast<Desk.SurfaceMaterial>()
                                .ToList();

            
            comboBoxMaterials.DataSource = materials;
            // don't select anything when the page loads
            comboBoxMaterials.SelectedIndex = -1;

        }

        private void comboBoxMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMaterials.SelectedIndex == -1)
            {
                txtQuotes.Text = "";
            }
            else
            {
                Desk.SurfaceMaterial material = EnumUtil.ParseEnum<Desk.SurfaceMaterial>(comboBoxMaterials.SelectedValue.ToString());
                var sb = new StringBuilder();
                
                foreach (DeskQuote deskQuote in deskQuotes)
                {
                    if (deskQuote.Desk.Material == material)
                    {
                        sb.AppendLine(deskQuote.ToString());
                    }
                }

                if (sb.Length != 0)
                {
                    txtQuotes.Text = DeskQuote.CSVHeader() + "\n" +  sb.ToString();
                }
                else
                {
                    txtQuotes.Text = sb.ToString();
                }
                
            }
           
        }

        private void ReadQuotes()
        {
            try
            {
                using (var reader = new StreamReader(FILE_PATH))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.RegisterClassMap<DeskQuoteMap>();
                    deskQuotes = csv.GetRecords<DeskQuote>().ToList();
                }
            }
            catch(FileNotFoundException ex)
            {
                deskQuotes = new List<DeskQuote>();
            }
           
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}
