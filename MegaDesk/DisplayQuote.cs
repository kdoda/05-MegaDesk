using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        private static string FILE_PATH = AppDomain.CurrentDomain.BaseDirectory + @"\quotes.txt";
        private DeskQuote deskQuote;

        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            this.deskQuote = deskQuote;
            populateLabels();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void populateLabels()
        {
            lblCustomerName.Text = deskQuote.CustomerName;
            lblWidth.Text = deskQuote.Desk.Width.ToString();
            lblDepth.Text = deskQuote.Desk.Depth.ToString();
            lblNrDrawers.Text = deskQuote.Desk.NrDrawers.ToString();
            lblSurfaceMaterial.Text = deskQuote.Desk.Material.ToString();
            lblOrderDays.Text = deskQuote.DaysOrdered.ToString();
            lblTotalPrice.Text = deskQuote.Price.ToString();
        }

        private void WriteToFile()
        {
            // First time adding text to the file 
            if (!File.Exists(FILE_PATH))
            {
                List<DeskQuote> deskQuotes = new List<DeskQuote>();
                deskQuotes.Add(deskQuote);
                File.WriteAllText(FILE_PATH, JsonConvert.SerializeObject(deskQuotes));
            }
            else
            {
                string jsonQuotes = File.ReadAllText(FILE_PATH);
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonQuotes);
                deskQuotes.Add(deskQuote);
                File.WriteAllText(FILE_PATH, JsonConvert.SerializeObject(deskQuotes));
            }

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            WriteToFile();
            GoBack();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            var addQuote = (AddQuote)Tag;
            addQuote.Show();
            Close();
        }
    }
}
