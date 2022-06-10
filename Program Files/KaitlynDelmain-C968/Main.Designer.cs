namespace KaitlynDelmain_C968
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.searchParts = new System.Windows.Forms.Button();
            this.searchProducts = new System.Windows.Forms.Button();
            this.searchPartsTB = new System.Windows.Forms.TextBox();
            this.searchProductsTB = new System.Windows.Forms.TextBox();
            this.addPart = new System.Windows.Forms.Button();
            this.modPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.modProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(28, 72);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(640, 232);
            this.dgvParts.TabIndex = 0;
            this.dgvParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(792, 72);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(640, 232);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(24, 32);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(46, 20);
            this.partsLabel.TabIndex = 2;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(788, 32);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(72, 20);
            this.productsLabel.TabIndex = 3;
            this.productsLabel.Text = "Products";
            // 
            // searchParts
            // 
            this.searchParts.Location = new System.Drawing.Point(394, 32);
            this.searchParts.Name = "searchParts";
            this.searchParts.Size = new System.Drawing.Size(75, 23);
            this.searchParts.TabIndex = 4;
            this.searchParts.Text = "Search";
            this.searchParts.UseVisualStyleBackColor = true;
            this.searchParts.Click += new System.EventHandler(this.searchParts_Click);
            // 
            // searchProducts
            // 
            this.searchProducts.Location = new System.Drawing.Point(1158, 32);
            this.searchProducts.Name = "searchProducts";
            this.searchProducts.Size = new System.Drawing.Size(75, 23);
            this.searchProducts.TabIndex = 5;
            this.searchProducts.Text = "Search";
            this.searchProducts.UseVisualStyleBackColor = true;
            this.searchProducts.Click += new System.EventHandler(this.searchProducts_Click);
            // 
            // searchPartsTB
            // 
            this.searchPartsTB.Location = new System.Drawing.Point(487, 34);
            this.searchPartsTB.Name = "searchPartsTB";
            this.searchPartsTB.Size = new System.Drawing.Size(181, 20);
            this.searchPartsTB.TabIndex = 6;
            // 
            // searchProductsTB
            // 
            this.searchProductsTB.Location = new System.Drawing.Point(1251, 34);
            this.searchProductsTB.Name = "searchProductsTB";
            this.searchProductsTB.Size = new System.Drawing.Size(181, 20);
            this.searchProductsTB.TabIndex = 7;
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(405, 322);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(75, 23);
            this.addPart.TabIndex = 8;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // modPart
            // 
            this.modPart.Location = new System.Drawing.Point(499, 322);
            this.modPart.Name = "modPart";
            this.modPart.Size = new System.Drawing.Size(75, 23);
            this.modPart.TabIndex = 9;
            this.modPart.Text = "Modify";
            this.modPart.UseVisualStyleBackColor = true;
            this.modPart.Click += new System.EventHandler(this.modPart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(593, 322);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 23);
            this.deletePart.TabIndex = 10;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(1171, 322);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 23);
            this.addProduct.TabIndex = 11;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // modProduct
            // 
            this.modProduct.Location = new System.Drawing.Point(1265, 322);
            this.modProduct.Name = "modProduct";
            this.modProduct.Size = new System.Drawing.Size(75, 23);
            this.modProduct.TabIndex = 12;
            this.modProduct.Text = "Modify";
            this.modProduct.UseVisualStyleBackColor = true;
            this.modProduct.Click += new System.EventHandler(this.modProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(1357, 322);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.deleteProduct.TabIndex = 13;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1357, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 441);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.modProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.modPart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.searchProductsTB);
            this.Controls.Add(this.searchPartsTB);
            this.Controls.Add(this.searchProducts);
            this.Controls.Add(this.searchParts);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Name = "Main";
            this.Text = "Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button searchParts;
        private System.Windows.Forms.Button searchProducts;
        private System.Windows.Forms.TextBox searchPartsTB;
        private System.Windows.Forms.TextBox searchProductsTB;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button modPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button modProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button exitButton;
    }
}

