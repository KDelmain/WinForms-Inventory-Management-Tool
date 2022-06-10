namespace KaitlynDelmain_C968
{
    partial class ModProduct
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
            this.formLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.dgvAssocParts = new System.Windows.Forms.DataGridView();
            this.assocPartsLabel = new System.Windows.Forms.Label();
            this.addPartButton = new System.Windows.Forms.Button();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.partsLabel = new System.Windows.Forms.Label();
            this.minTB = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxTB = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryTB = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssocParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(36, 158);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(78, 13);
            this.formLabel.TabIndex = 45;
            this.formLabel.Text = "Modify Product";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(726, 652);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 44;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(629, 652);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 43;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(726, 569);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(75, 23);
            this.deletePartButton.TabIndex = 42;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // dgvAssocParts
            // 
            this.dgvAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssocParts.Location = new System.Drawing.Point(273, 402);
            this.dgvAssocParts.Name = "dgvAssocParts";
            this.dgvAssocParts.Size = new System.Drawing.Size(528, 150);
            this.dgvAssocParts.TabIndex = 41;
            this.dgvAssocParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssocParts_CellClick);
            // 
            // assocPartsLabel
            // 
            this.assocPartsLabel.AutoSize = true;
            this.assocPartsLabel.Location = new System.Drawing.Point(270, 356);
            this.assocPartsLabel.Name = "assocPartsLabel";
            this.assocPartsLabel.Size = new System.Drawing.Size(167, 13);
            this.assocPartsLabel.TabIndex = 40;
            this.assocPartsLabel.Text = "Parts Associated with this Product";
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(726, 288);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 23);
            this.addPartButton.TabIndex = 39;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(273, 76);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(528, 193);
            this.dgvParts.TabIndex = 38;
            this.dgvParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(649, 31);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(152, 20);
            this.searchTB.TabIndex = 37;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(550, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 36;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(270, 31);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(96, 13);
            this.partsLabel.TabIndex = 35;
            this.partsLabel.Text = "All Candidate Parts";
            // 
            // minTB
            // 
            this.minTB.Location = new System.Drawing.Point(110, 453);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(54, 20);
            this.minTB.TabIndex = 34;
            this.minTB.TextChanged += new System.EventHandler(this.minTB_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(36, 456);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 33;
            this.minLabel.Text = "Min";
            // 
            // maxTB
            // 
            this.maxTB.Location = new System.Drawing.Point(110, 412);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(54, 20);
            this.maxTB.TabIndex = 32;
            this.maxTB.TextChanged += new System.EventHandler(this.maxTB_TextChanged);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(36, 415);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "Max";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(110, 370);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(100, 20);
            this.priceTB.TabIndex = 30;
            this.priceTB.TextChanged += new System.EventHandler(this.priceTB_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(36, 373);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 29;
            this.priceLabel.Text = "Price";
            // 
            // inventoryTB
            // 
            this.inventoryTB.Location = new System.Drawing.Point(110, 327);
            this.inventoryTB.Name = "inventoryTB";
            this.inventoryTB.Size = new System.Drawing.Size(100, 20);
            this.inventoryTB.TabIndex = 28;
            this.inventoryTB.TextChanged += new System.EventHandler(this.inventoryTB_TextChanged);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(36, 330);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 27;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(110, 280);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 26;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(36, 283);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Name";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(110, 235);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 24;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(36, 238);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 23;
            this.idLabel.Text = "ID";
            // 
            // ModProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 704);
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
            this.Name = "ModProduct";
            this.Text = "ModProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssocParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.DataGridView dgvAssocParts;
        private System.Windows.Forms.Label assocPartsLabel;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox maxTB;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox inventoryTB;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label idLabel;
    }
}