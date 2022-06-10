namespace KaitlynDelmain_C968
{
    partial class AddPart
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
            this.inhouseRB = new System.Windows.Forms.RadioButton();
            this.outsourcedRB = new System.Windows.Forms.RadioButton();
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
            this.inhouseOutsourcedLabel = new System.Windows.Forms.Label();
            this.inhouseOutsourcedTB = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inhouseRB
            // 
            this.inhouseRB.AutoSize = true;
            this.inhouseRB.Location = new System.Drawing.Point(59, 91);
            this.inhouseRB.Name = "inhouseRB";
            this.inhouseRB.Size = new System.Drawing.Size(63, 17);
            this.inhouseRB.TabIndex = 0;
            this.inhouseRB.TabStop = true;
            this.inhouseRB.Text = "Inhouse";
            this.inhouseRB.UseVisualStyleBackColor = true;
            this.inhouseRB.CheckedChanged += new System.EventHandler(this.inhouseRB_CheckedChanged);
            // 
            // outsourcedRB
            // 
            this.outsourcedRB.AutoSize = true;
            this.outsourcedRB.Location = new System.Drawing.Point(146, 91);
            this.outsourcedRB.Name = "outsourcedRB";
            this.outsourcedRB.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRB.TabIndex = 1;
            this.outsourcedRB.TabStop = true;
            this.outsourcedRB.Text = "Outsourced";
            this.outsourcedRB.UseVisualStyleBackColor = true;
            this.outsourcedRB.CheckedChanged += new System.EventHandler(this.outsourcedRB_CheckedChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(31, 136);
            this.idLabel.Name = "idLabel";
            this.idLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idLabel.Size = new System.Drawing.Size(40, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "Part ID";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(126, 133);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(31, 186);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(126, 183);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 5;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(31, 237);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.inventoryLabel.TabIndex = 6;
            this.inventoryLabel.Text = "Inventory";
            // 
            // inventoryTB
            // 
            this.inventoryTB.Location = new System.Drawing.Point(126, 234);
            this.inventoryTB.Name = "inventoryTB";
            this.inventoryTB.Size = new System.Drawing.Size(100, 20);
            this.inventoryTB.TabIndex = 7;
            this.inventoryTB.TextChanged += new System.EventHandler(this.inventoryTB_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(31, 289);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(126, 286);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(100, 20);
            this.priceTB.TabIndex = 9;
            this.priceTB.TextChanged += new System.EventHandler(this.priceTB_TextChanged);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(31, 341);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 10;
            this.maxLabel.Text = "Max";
            // 
            // maxTB
            // 
            this.maxTB.Location = new System.Drawing.Point(71, 338);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(51, 20);
            this.maxTB.TabIndex = 11;
            this.maxTB.TextChanged += new System.EventHandler(this.maxTB_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(143, 341);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 12;
            this.minLabel.Text = "Min";
            // 
            // minTB
            // 
            this.minTB.Location = new System.Drawing.Point(175, 338);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(51, 20);
            this.minTB.TabIndex = 13;
            this.minTB.TextChanged += new System.EventHandler(this.minTB_TextChanged);
            // 
            // inhouseOutsourcedLabel
            // 
            this.inhouseOutsourcedLabel.AutoSize = true;
            this.inhouseOutsourcedLabel.Location = new System.Drawing.Point(31, 395);
            this.inhouseOutsourcedLabel.Name = "inhouseOutsourcedLabel";
            this.inhouseOutsourcedLabel.Size = new System.Drawing.Size(82, 13);
            this.inhouseOutsourcedLabel.TabIndex = 14;
            this.inhouseOutsourcedLabel.Text = "Company Name";
            // 
            // inhouseOutsourcedTB
            // 
            this.inhouseOutsourcedTB.Location = new System.Drawing.Point(126, 392);
            this.inhouseOutsourcedTB.Name = "inhouseOutsourcedTB";
            this.inhouseOutsourcedTB.Size = new System.Drawing.Size(100, 20);
            this.inhouseOutsourcedTB.TabIndex = 15;
            this.inhouseOutsourcedTB.TextChanged += new System.EventHandler(this.inhouseOutsourcedTB_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(151, 440);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(151, 487);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add a Part";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inhouseOutsourcedTB);
            this.Controls.Add(this.inhouseOutsourcedLabel);
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
            this.Controls.Add(this.outsourcedRB);
            this.Controls.Add(this.inhouseRB);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inhouseRB;
        private System.Windows.Forms.RadioButton outsourcedRB;
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
        private System.Windows.Forms.Label inhouseOutsourcedLabel;
        private System.Windows.Forms.TextBox inhouseOutsourcedTB;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
    }
}