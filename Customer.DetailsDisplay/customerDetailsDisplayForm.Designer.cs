﻿namespace Customer.DetailsDisplay
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
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToOrderColumns = true;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(960, 423);
            this.customerDataGridView.TabIndex = 0;
            // 
            // customerDetailsDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 423);
            this.Controls.Add(this.customerDataGridView);
            this.Name = "customerDetailsDisplayForm";
            this.Text = "Customer Data";
            this.Load += new System.EventHandler(this.customerDetailsDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGridView;
    }
}

