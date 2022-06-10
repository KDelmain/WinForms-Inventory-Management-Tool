namespace KaitlynDelmain_C968
{
    partial class AddProduct
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
            this.idLabel = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.inventoryTB = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxTB = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.minTB = new System.Windows.Forms.TextBox();
            this.partsLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.addPartButton = new System.Windows.Forms.Button();
            this.assocPartsLabel = new System.Windows.Forms.Label();
            this.dgvAssocParts = new System.Windows.Forms.DataGridView();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.formLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssocParts)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(30, 237);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(104, 234);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(30, 282);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(104, 279);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 3;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(30, 329);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 4;
            this.inventoryLabel.Text = "Inventory";
            // 
            // inventoryTB
            // 
            this.inventoryTB.Location = new System.Drawing.Point(104, 326);
            this.inventoryTB.Name = "inventoryTB";
            this.inventoryTB.Size = new System.Drawing.Size(100, 20);
            this.inventoryTB.TabIndex = 5;
            this.inventoryTB.TextChanged += new System.EventHandler(this.inventoryTB_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(30, 372);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(104, 369);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(100, 20);
            this.priceTB.TabIndex = 7;
            this.priceTB.TextChanged += new System.EventHandler(this.priceTB_TextChanged);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(30, 414);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 8;
            this.maxLabel.Text = "Max";
            // 
            // maxTB
            // 
            this.maxTB.Location = new System.Drawing.Point(104, 411);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(54, 20);
            this.maxTB.TabIndex = 9;
            this.maxTB.TextChanged += new System.EventHandler(this.maxTB_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(30, 455);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 10;
            this.minLabel.Text = "Min";
            // 
            // minTB
            // 
            this.minTB.Location = new System.Drawing.Point(104, 452);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(54, 20);
            this.minTB.TabIndex = 11;
            this.minTB.TextChanged += new System.EventHandler(this.minTB_TextChanged);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(264, 30);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(96, 13);
            this.partsLabel.TabIndex = 12;
            this.partsLabel.Text = "All Candidate Parts";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(544, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(643, 30);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(152, 20);
            this.searchTB.TabIndex = 14;
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(267, 75);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(528, 193);
            this.dgvParts.TabIndex = 15;
            this.dgvParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(720, 287);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 23);
            this.addPartButton.TabIndex = 16;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // assocPartsLabel
            // 
            this.assocPartsLabel.AutoSize = true;
            this.assocPartsLabel.Location = new System.Drawing.Point(264, 355);
            this.assocPartsLabel.Name = "assocPartsLabel";
            this.assocPartsLabel.Size = new System.Drawing.Size(167, 13);
            this.assocPartsLabel.TabIndex = 17;
            this.assocPartsLabel.Text = "Parts Associated with this Product";
            // 
            // dgvAssocParts
            // 
            this.dgvAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssocParts.Location = new System.Drawing.Point(267, 401);
            this.dgvAssocParts.Name = "dgvAssocParts";
            this.dgvAssocParts.Size = new System.Drawing.Size(528, 150);
            this.dgvAssocParts.TabIndex = 18;
            this.dgvAssocParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssocParts_CellClick);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(720, 568);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(75, 23);
            this.deletePartButton.TabIndex = 19;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(623, 651);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(720, 651);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(30, 157);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(66, 13);
            this.formLabel.TabIndex = 22;
            this.formLabel.Text = "Add Product";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 704);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deletePartButton);
            this.Controls.Add(this.dgvAssocParts);
            this.Controls.Add(this.assocPartsLabel);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.minTB);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxTB);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryTB);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.idLabel);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssocParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox inventoryTB;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox maxTB;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Label assocPartsLabel;
        private System.Windows.Forms.DataGridView dgvAssocParts;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label formLabel;
    }
}