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
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            configureForm();
        }

        private void configureForm()
        { 

            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.DefaultCellStyle.SelectionBackColor = dgvProducts.DefaultCellStyle.BackColor;
            dgvProducts.DefaultCellStyle.SelectionForeColor = dgvProducts.DefaultCellStyle.ForeColor;

            dgvParts.DefaultCellStyle.SelectionBackColor = dgvParts.DefaultCellStyle.BackColor;
            dgvParts.DefaultCellStyle.SelectionForeColor = dgvParts.DefaultCellStyle.ForeColor;

            dgvProducts.ClearSelection();
            dgvParts.ClearSelection();

            dgvProducts.DataSource = Inventory.ProdList;
            dgvParts.DataSource = Inventory.PartList;

            Inventory.prodIndex = -1;
            Inventory.partIndex = -1;

        }


        /***** Parts Search *****/

        private void searchParts_Click(object sender, EventArgs e)
        {
            dgvParts.ClearSelection();
            dgvParts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (searchPartsTB.Text != "")
            {
                for (int i = 0; i < Inventory.PartList.Count; i++)
                {
                    if (Inventory.PartList[i].Name.ToUpper().Contains(searchPartsTB.Text.ToUpper()))
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


        /***** Products Search *****/

        private void searchProducts_Click(object sender, EventArgs e)
        {
            dgvProducts.ClearSelection();
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (searchProductsTB.Text != "")
            {
                for (int i = 0; i < Inventory.ProdList.Count; i++)
                {
                    if (Inventory.ProdList[i].Name.ToUpper().Contains(searchProductsTB.Text.ToUpper()))
                    {
                        dgvProducts.Rows[i].Selected = true;
                        found = true;


                        Inventory.prodIndex = i;
                        Inventory.currentProduct = Inventory.ProdList[Inventory.prodIndex];

                    }
                }
            }
            if (!found)
                MessageBox.Show("No Matches.");
        }


        /***** Add, Modify, and Delete Part *****/

        private void addPart_Click(object sender, EventArgs e)
        {
            dgvParts.ClearSelection();
            AddPart addPart = new AddPart();
            addPart.Show();
        }

        private void modPart_Click(object sender, EventArgs e)
        {

            if (Inventory.partIndex >= 0)
            {
                ModPart modPart = new ModPart();
                modPart.Show();
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            if (Inventory.partIndex >= 0)
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete the selected part?", "Delete Part", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Inventory.PartList.RemoveAt(Inventory.partIndex);
                }
                
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }

            dgvParts.ClearSelection();
        }


        /***** Add, Modify, and Delete Product *****/ 

        private void addProduct_Click(object sender, EventArgs e)
        {
            dgvProducts.ClearSelection();
            AddProduct addProd = new AddProduct();
            addProd.Show();
        }

        private void modProduct_Click(object sender, EventArgs e)
        {
            if (Inventory.prodIndex >= 0)
            {
                ModProduct modProd = new ModProduct();
                modProd.Show();
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (Inventory.prodIndex >= 0)
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete the selected product?", "Delete Product", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Inventory.ProdList.RemoveAt(Inventory.prodIndex);
                }
                
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }

            dgvProducts.ClearSelection();
        }


        /***** Exit Application *****/

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to exit the application?", "Exit Application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        /***** Cell Click Selection *****/

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
                dgvParts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                Inventory.partIndex = dgvParts.CurrentCell.RowIndex;
                Inventory.currentPart = Inventory.PartList[Inventory.partIndex];

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            
                Inventory.prodIndex = dgvProducts.CurrentCell.RowIndex;
                Inventory.currentProduct = Inventory.ProdList[Inventory.prodIndex];
                dgvProducts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            
        }
    }


}
