using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaitlynDelmain_C968
{
    public partial class AddPart : Form
    {
        bool isInhouse;

        public AddPart()
        {
            InitializeComponent();
            saveButton.Enabled = false;
            idTB.Text = Part.partCount.ToString();
            idTB.Enabled = false;
        }


        private void inhouseRB_CheckedChanged(object sender, EventArgs e)
        {
            inhouseOutsourcedLabel.Text = "Machine ID";
            isInhouse = true;
            radioSwitch();

        }

        private void outsourcedRB_CheckedChanged(object sender, EventArgs e)
        {
            inhouseOutsourcedLabel.Text = "Company Name";
            isInhouse = false;
            radioSwitch();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(isInhouse)
            {
                Part part = new Inhouse(Part.partCount, nameTB.Text, Convert.ToDecimal(priceTB.Text), Convert.ToInt32(inventoryTB.Text), Convert.ToInt32(minTB.Text), Convert.ToInt32(maxTB.Text), Convert.ToInt32(inhouseOutsourcedTB.Text));
                Inventory.addPart(part);
            }
            else
            {
                Part part = new Outsourced(Part.partCount, nameTB.Text, Convert.ToDecimal(priceTB.Text), Convert.ToInt32(inventoryTB.Text), Convert.ToInt32(minTB.Text), Convert.ToInt32(maxTB.Text), inhouseOutsourcedTB.Text);
                Inventory.addPart(part);
            }

            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to cancel? \n Warning: All progress will be lost if you cancel", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool formValidation()
        {
            bool areValidEntries = false;

            if (!string.IsNullOrWhiteSpace(inventoryTB.Text) && !string.IsNullOrWhiteSpace(maxTB.Text)
                    && !string.IsNullOrWhiteSpace(minTB.Text))
            {

                int minTBValue;
                Int32.TryParse(minTB.Text, out minTBValue);

                int maxTBValue;
                Int32.TryParse(maxTB.Text, out maxTBValue);

                int inventoryTBValue;
                Int32.TryParse(inventoryTB.Text, out inventoryTBValue);

                if (minTBValue > 0 && minTBValue < maxTBValue)
                {
                    areValidEntries = true;
                }
                else
                {
                    minTB.BackColor = System.Drawing.Color.Salmon;
                }

                if (maxTBValue > minTBValue)
                {
                    areValidEntries = true;
                }
                else
                {
                    maxTB.BackColor = System.Drawing.Color.Salmon;
                }

                if (inventoryTBValue <= maxTBValue && inventoryTBValue >= minTBValue)
                {
                    areValidEntries = true;
                }
                else
                {
                    inventoryTB.BackColor = System.Drawing.Color.Salmon;
                }

            }

            if (string.IsNullOrWhiteSpace(priceTB.Text) || string.IsNullOrWhiteSpace(nameTB.Text) || string.IsNullOrWhiteSpace(inhouseOutsourcedTB.Text)
                || string.IsNullOrWhiteSpace(inventoryTB.Text) || string.IsNullOrWhiteSpace(maxTB.Text) || string.IsNullOrWhiteSpace(minTB.Text))
            {
                areValidEntries = false;
            }

            if (areValidEntries)
            {
                inventoryTB.BackColor = System.Drawing.Color.White;
                maxTB.BackColor = System.Drawing.Color.White;
                minTB.BackColor = System.Drawing.Color.White;
            }

            return areValidEntries;
        }

        private void radioSwitch()
        {
            int number;
            if (string.IsNullOrWhiteSpace(inhouseOutsourcedTB.Text) || (isInhouse && !Int32.TryParse(inhouseOutsourcedTB.Text, out number)))
            {
                inhouseOutsourcedTB.BackColor = System.Drawing.Color.Salmon;
                saveButton.Enabled = false;
            }
            else
            {
                inhouseOutsourcedTB.BackColor = System.Drawing.Color.White;
                saveButton.Enabled = formValidation();
            }
            
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(nameTB.Text))
            {
                nameTB.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                nameTB.BackColor = System.Drawing.Color.White;
                saveButton.Enabled = formValidation();
            }
           
        }

        private void inventoryTB_TextChanged(object sender, EventArgs e)
        {
            int isNumber;

            if (string.IsNullOrWhiteSpace(inventoryTB.Text) || (!Int32.TryParse(inventoryTB.Text, out isNumber)))
            {
                inventoryTB.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                inventoryTB.BackColor = System.Drawing.Color.White;
                saveButton.Enabled = formValidation();
            }
        }

        private void priceTB_TextChanged(object sender, EventArgs e)
        {
            decimal isNumber;

            if (string.IsNullOrWhiteSpace(priceTB.Text) || (!Decimal.TryParse(priceTB.Text, out isNumber)))
            {
                priceTB.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                priceTB.BackColor = System.Drawing.Color.White;
                saveButton.Enabled = formValidation();
            }
        }

        private void maxTB_TextChanged(object sender, EventArgs e)
        {
            int isNumber;

            if (string.IsNullOrWhiteSpace(maxTB.Text) || (!Int32.TryParse(maxTB.Text, out isNumber)))
            {
                maxTB.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                maxTB.BackColor = System.Drawing.Color.White;
                saveButton.Enabled = formValidation();
            }
        }

        private void minTB_TextChanged(object sender, EventArgs e)
        {
            int isNumber;

            if (string.IsNullOrWhiteSpace(minTB.Text) || (!Int32.TryParse(minTB.Text, out isNumber)))
            {
                minTB.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                minTB.BackColor = System.Drawing.Color.White;
                saveButton.Enabled = formValidation();
            }
        }

        private void inhouseOutsourcedTB_TextChanged(object sender, EventArgs e)
        {
            radioSwitch();
        }

    }
}
