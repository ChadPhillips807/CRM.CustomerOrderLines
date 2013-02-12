namespace Customer.DetailsDisplay
{
    partial class customerDetailsDisplayForm
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
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.topOfListButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.bottomOfListButton = new System.Windows.Forms.Button();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contactTitleTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AllowUserToOrderColumns = true;
            this.customerDataGridView.AllowUserToResizeRows = false;
            this.customerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(6, 259);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(760, 205);
            this.customerDataGridView.TabIndex = 0;
            // 
            // topOfListButton
            // 
            this.topOfListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topOfListButton.Location = new System.Drawing.Point(5, 194);
            this.topOfListButton.Name = "topOfListButton";
            this.topOfListButton.Size = new System.Drawing.Size(112, 40);
            this.topOfListButton.TabIndex = 1;
            this.topOfListButton.Text = "Top of List";
            this.topOfListButton.UseVisualStyleBackColor = true;
            this.topOfListButton.Click += new System.EventHandler(this.topOfListButton_Click);
            // 
            // upButton
            // 
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upButton.Location = new System.Drawing.Point(276, 194);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(112, 40);
            this.upButton.TabIndex = 2;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Location = new System.Drawing.Point(141, 194);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(112, 40);
            this.downButton.TabIndex = 3;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // bottomOfListButton
            // 
            this.bottomOfListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomOfListButton.Location = new System.Drawing.Point(410, 194);
            this.bottomOfListButton.Name = "bottomOfListButton";
            this.bottomOfListButton.Size = new System.Drawing.Size(112, 40);
            this.bottomOfListButton.TabIndex = 4;
            this.bottomOfListButton.Text = "Bottom of List";
            this.bottomOfListButton.UseVisualStyleBackColor = true;
            this.bottomOfListButton.Click += new System.EventHandler(this.bottomOfListButton_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerNameTextBox.Location = new System.Drawing.Point(90, 28);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.ReadOnly = true;
            this.customerNameTextBox.Size = new System.Drawing.Size(172, 22);
            this.customerNameTextBox.TabIndex = 5;
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactNameTextBox.Location = new System.Drawing.Point(90, 70);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.ReadOnly = true;
            this.contactNameTextBox.Size = new System.Drawing.Size(172, 22);
            this.contactNameTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Orders:";
            // 
            // contactTitleTextBox
            // 
            this.contactTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTitleTextBox.Location = new System.Drawing.Point(340, 70);
            this.contactTitleTextBox.Name = "contactTitleTextBox";
            this.contactTitleTextBox.ReadOnly = true;
            this.contactTitleTextBox.Size = new System.Drawing.Size(172, 22);
            this.contactTitleTextBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Location = new System.Drawing.Point(90, 113);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(172, 22);
            this.addressTextBox.TabIndex = 10;
            // 
            // cityTextBox
            // 
            this.cityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityTextBox.Location = new System.Drawing.Point(340, 111);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(172, 22);
            this.cityTextBox.TabIndex = 13;
            // 
            // regionTextBox
            // 
            this.regionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regionTextBox.Location = new System.Drawing.Point(90, 154);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.ReadOnly = true;
            this.regionTextBox.Size = new System.Drawing.Size(172, 22);
            this.regionTextBox.TabIndex = 12;
            // 
            // zipTextBox
            // 
            this.zipTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zipTextBox.Location = new System.Drawing.Point(594, 109);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.ReadOnly = true;
            this.zipTextBox.Size = new System.Drawing.Size(172, 22);
            this.zipTextBox.TabIndex = 15;
            // 
            // countryTextBox
            // 
            this.countryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryTextBox.Location = new System.Drawing.Point(340, 154);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(172, 22);
            this.countryTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Region:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Zip Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Country:";
            // 
            // customerDetailsDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 472);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(this.contactTitleTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactNameTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.bottomOfListButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.topOfListButton);
            this.Controls.Add(this.customerDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "customerDetailsDisplayForm";
            this.Text = "Customer Data";
            this.Load += new System.EventHandler(this.customerDetailsDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button topOfListButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button bottomOfListButton;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contactTitleTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

