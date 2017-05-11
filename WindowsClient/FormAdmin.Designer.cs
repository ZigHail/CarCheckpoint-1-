namespace WindowsClient
{
    partial class FormAdmin
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.addCardButton = new System.Windows.Forms.Button();
            this.writeOffButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.allInfoButton = new System.Windows.Forms.Button();
            this.oneUserInfoButton = new System.Windows.Forms.Button();
            this.writeOffsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(43, 48);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Padding = new System.Windows.Forms.Padding(15);
            this.addUserButton.Size = new System.Drawing.Size(150, 75);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // addCardButton
            // 
            this.addCardButton.Location = new System.Drawing.Point(43, 129);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Padding = new System.Windows.Forms.Padding(15);
            this.addCardButton.Size = new System.Drawing.Size(150, 75);
            this.addCardButton.TabIndex = 1;
            this.addCardButton.Text = "Add card to user";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // writeOffButton
            // 
            this.writeOffButton.Location = new System.Drawing.Point(199, 48);
            this.writeOffButton.Name = "writeOffButton";
            this.writeOffButton.Padding = new System.Windows.Forms.Padding(15);
            this.writeOffButton.Size = new System.Drawing.Size(150, 75);
            this.writeOffButton.TabIndex = 2;
            this.writeOffButton.Text = "Add write Off";
            this.writeOffButton.UseVisualStyleBackColor = true;
            this.writeOffButton.Click += new System.EventHandler(this.writeOffButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(511, 129);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(15);
            this.SettingsButton.Size = new System.Drawing.Size(150, 75);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(199, 129);
            this.payButton.Name = "payButton";
            this.payButton.Padding = new System.Windows.Forms.Padding(15);
            this.payButton.Size = new System.Drawing.Size(150, 75);
            this.payButton.TabIndex = 4;
            this.payButton.Text = "Add pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // allInfoButton
            // 
            this.allInfoButton.Location = new System.Drawing.Point(355, 48);
            this.allInfoButton.Name = "allInfoButton";
            this.allInfoButton.Padding = new System.Windows.Forms.Padding(15);
            this.allInfoButton.Size = new System.Drawing.Size(150, 75);
            this.allInfoButton.TabIndex = 5;
            this.allInfoButton.Text = "Info about all users";
            this.allInfoButton.UseVisualStyleBackColor = true;
            this.allInfoButton.Click += new System.EventHandler(this.allInfoButton_Click);
            // 
            // oneUserInfoButton
            // 
            this.oneUserInfoButton.Location = new System.Drawing.Point(355, 129);
            this.oneUserInfoButton.Name = "oneUserInfoButton";
            this.oneUserInfoButton.Padding = new System.Windows.Forms.Padding(15);
            this.oneUserInfoButton.Size = new System.Drawing.Size(150, 75);
            this.oneUserInfoButton.TabIndex = 6;
            this.oneUserInfoButton.Text = "Full info about one";
            this.oneUserInfoButton.UseVisualStyleBackColor = true;
            this.oneUserInfoButton.Click += new System.EventHandler(this.oneUserInfoButton_Click);
            // 
            // writeOffsButton
            // 
            this.writeOffsButton.Location = new System.Drawing.Point(511, 48);
            this.writeOffsButton.Name = "writeOffsButton";
            this.writeOffsButton.Padding = new System.Windows.Forms.Padding(15);
            this.writeOffsButton.Size = new System.Drawing.Size(150, 75);
            this.writeOffsButton.TabIndex = 7;
            this.writeOffsButton.Text = "WriteOffs info";
            this.writeOffsButton.UseVisualStyleBackColor = true;
            this.writeOffsButton.Click += new System.EventHandler(this.writeOffsButton_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 248);
            this.Controls.Add(this.writeOffsButton);
            this.Controls.Add(this.oneUserInfoButton);
            this.Controls.Add(this.allInfoButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.writeOffButton);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.addUserButton);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.Button writeOffButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button allInfoButton;
        private System.Windows.Forms.Button oneUserInfoButton;
        private System.Windows.Forms.Button writeOffsButton;
    }
}