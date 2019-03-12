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

//TODO when adding show he order
namespace MegaDesk
{
    public partial class AddQuote : Form
    {


        public AddQuote()
        {
            InitializeComponent();
            PopulateMaterials();
            PopulateOrderDays();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void textWidth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(_reqTextWidth.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                _reqTextWidth.Select(0, _reqTextWidth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(_reqTextWidth, errorMsg);
            }
        }

        private void textWidth_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(_reqTextWidth, "");
        }

        private bool ValidWidth(string width, out string errorMessage)
        {
            // Confirm that the email address string is not empty.

            int parsedWidth;
            if (!int.TryParse(width, out parsedWidth))
            {
                errorMessage = "Please enter a number.";
                return false;
            }

            if (parsedWidth < 24 || parsedWidth > 96)
            {
                errorMessage = "The width should be from 24 to 96.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void textDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textDepth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDepth(_reqTextDepth.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                _reqTextDepth.Select(0, _reqTextDepth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(_reqTextDepth, errorMsg);
            }
        }

        private bool ValidDepth(string depth, out string errorMessage)
        {
            // Confirm that the email address string is not empty.

            int parsedDepth;
            if (!int.TryParse(depth, out parsedDepth))
            {
                errorMessage = "Please enter a number.";
                return false;
            }

            if (parsedDepth < 12 || parsedDepth > 48)
            {
                errorMessage = "The depth should be from 12 to 48.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void textDepth_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(_reqTextDepth, "");
        }

        private void PopulateMaterials()
        {
            var materials = Enum.GetValues(typeof(Desk.SurfaceMaterial))
                                .Cast<Desk.SurfaceMaterial>()
                                .ToList();

            _reqComboBoxMaterials.DataSource = materials;
            // don't select anything when the page loads
            _reqComboBoxMaterials.SelectedIndex = -1;
        }

        private void PopulateOrderDays()
        {
            _reqComboBoxOrderDays.DataSource = DeskQuote.getFriendlyDaysOrdered();
            _reqComboBoxOrderDays.DisplayMember = "Key";
            _reqComboBoxOrderDays.ValueMember = "Value";

            // don't select anything when the page loads
            _reqComboBoxOrderDays.SelectedIndex = -1;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                DeskQuote deskQuote = createDesk();
                DisplayQuote displayQuote = new DisplayQuote(deskQuote);
                displayQuote.Tag = this;
                displayQuote.Show(this);
                clearForm();
                Hide();
            }
        }

        private DeskQuote createDesk()
        {
            var desk = new Desk
            {
                Width = int.Parse(_reqTextWidth.Text),
                Depth = int.Parse(_reqTextDepth.Text),
                NrDrawers = (int)_reqNumericUpDownNumberDrawers.Value,
                Material = EnumUtil.ParseEnum<Desk.SurfaceMaterial>(_reqComboBoxMaterials.Text.ToString())
            };

            return new DeskQuote
            {
                CustomerName = _reqTextCustomerName.Text.ToString(),
                DateOrdered = DateTime.Now,
                DaysOrdered = int.Parse(_reqComboBoxOrderDays.SelectedValue.ToString()),
                Desk = desk
            };
        }

        /// <summary>
        /// Check all buttons ifthey are empty and show an error message
        /// </summary>
        private bool Valid()
        {
            bool valid = true;
            foreach (Control control in Controls)
            {

                int index = control.Name.ToString().IndexOf("_req");

                if ((index >= 0) &&
                   ((control is TextBox && control.Text.ToString() == "") ||
                    (control is ComboBox && ((ComboBox)control).SelectedIndex == -1) ||
                    (control is NumericUpDown && ((NumericUpDown)control).Value == 0)))
                {
                    errorProvider.SetError(control, "Plese enter a value");
                    valid = false;
                }
            }

            return valid;
        }

        private void clearForm()
        {
            //empty everything
            foreach (Control control in Controls)
            {

                if (control is TextBox)
                {
                    control.Text = "";
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
            }
        }
    }
}
