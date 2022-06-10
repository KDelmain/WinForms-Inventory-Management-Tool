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
    public partial class AddProduct : Form
    {
        private BindingList<Part> tempPartList = new BindingList<Part>(); //temp list to hold associated parts until new product object creation
        public AddProduct()
        {
            InitializeComponent();
            configureForm();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dgvParts.ClearSelection();

            dgvParts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (searchTB.Text != "")
            {
                for (int i = 0; i < Inventory.PartList.Count; i++)
                {
                    if (Inventory.PartList[i].Name.ToUpper().Contains(searchTB.Text.ToUpper()))
                    {
                        dgvParts.Rows[i].Selected = true;
                        found = true;
                        Inventory.partIndex = i;
                        Inventory.currentPart = Inventory.PartList[Inventory.partIndex];
                    }
                }
            }
            if (!found)
                MessageBox.Show("No Matches.");
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            if(Inventory.partIndex >= 0)
            {
                tempPartList.Add(Inventory.currentPart);
                dgvAssocParts.DataSource = tempPartList;
            }
            else
            {
                MessageBox.Show("Please select a part to add.");
            }

        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            if (Product.assocPartIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete the associated part? \n Note: This does not delete the part from inventory.", "Delete Associated Part", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tempPartList.RemoveAt(Product.assocPartIndex);
                }
                else
                {
                    MessageBox.Show("Please select a part to add.");
                }

            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }

            dgvAssocParts.ClearSelection();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Product prod = new Product(Product.prodCount, nameTB.Text, Convert.ToDecimal(priceTB.Text), Convert.ToInt32(inventoryTB.Text), Convert.ToInt32(minTB.Text), Convert.ToInt32(maxTB.Text));
            prod.assocPartList = tempPartList;
            Inventory.addProd(prod);

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

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvParts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            Inventory.partIndex = dgvParts.CurrentCell.RowIndex;
            Inventory.currentPart = Inventory.PartList[Inventory.partIndex];
        }

        private void dgvAssocParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAssocParts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            Product.assocPartIndex = dgvAssocParts.CurrentCell.RowIndex;
            Inventory.currentPart = tempPartList[Product.assocPartIndex];
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

            if (string.IsNullOrWhiteSpace(priceTB.Text) || string.IsNullOrWhiteSpace(nameTB.Text)
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

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTB.Text))
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

        private void configureForm()
        {
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssocParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvAssocParts.DefaultCellStyle.SelectionBackColor = dgvAssocParts.DefaultCellStyle.BackColor;
            dgvAssocParts.DefaultCellStyle.SelectionForeColor = dgvAssocParts.DefaultCellStyle.ForeColor;

            dgvParts.DefaultCellStyle.SelectionBackColor = dgvParts.DefaultCellStyle.BackColor;
            dgvParts.DefaultCellStyle.SelectionForeColor = dgvParts.DefaultCellStyle.ForeColor;

            dgvAssocParts.ClearSelection();
            dgvParts.ClearSelection();

            dgvParts.DataSource = Inventory.PartList;

            saveButton.Enabled = false;

            idTB.Text = Product.prodCount.ToString();
            idTB.Enabled = false;

            Inventory.partIndex = -1;
            Product.assocPartIndex = -1;
        }
    }
}
