namespace WindowsClient
{
    partial class FormWriteOFFs
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
            this.writeOffGridView = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.writeOffGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // writeOffGridView
            // 
            this.writeOffGridView.AllowUserToAddRows = false;
            this.writeOffGridView.AllowUserToDeleteRows = false;
            this.writeOffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.writeOffGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Payment});
            this.writeOffGridView.Location = new System.Drawing.Point(12, 12);
            this.writeOffGridView.Name = "writeOffGridView";
            this.writeOffGridView.ReadOnly = true;
            this.writeOffGridView.RowHeadersVisible = false;
            this.writeOffGridView.RowTemplate.Height = 24;
            this.writeOffGridView.Size = new System.Drawing.Size(240, 265);
            this.writeOffGridView.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // FormWriteOFFs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 478);
            this.Controls.Add(this.writeOffGridView);
            this.Name = "FormWriteOFFs";
            this.Text = "FormWriteOFFs";
            this.Load += new System.EventHandler(this.FormWriteOFFs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.writeOffGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView writeOffGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
    }
}