namespace WindowsClient
{
    partial class FormSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.card1TextBox = new System.Windows.Forms.TextBox();
            this.card2TextBox = new System.Windows.Forms.TextBox();
            this.card3TextBox = new System.Windows.Forms.TextBox();
            this.card4TextBox = new System.Windows.Forms.TextBox();
            this.USBPortTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Card 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Card 3";
            // 
            // card1TextBox
            // 
            this.card1TextBox.Location = new System.Drawing.Point(139, 35);
            this.card1TextBox.Name = "card1TextBox";
            this.card1TextBox.Size = new System.Drawing.Size(153, 22);
            this.card1TextBox.TabIndex = 4;
            // 
            // card2TextBox
            // 
            this.card2TextBox.Location = new System.Drawing.Point(139, 72);
            this.card2TextBox.Name = "card2TextBox";
            this.card2TextBox.Size = new System.Drawing.Size(153, 22);
            this.card2TextBox.TabIndex = 5;
            // 
            // card3TextBox
            // 
            this.card3TextBox.Location = new System.Drawing.Point(139, 109);
            this.card3TextBox.Name = "card3TextBox";
            this.card3TextBox.Size = new System.Drawing.Size(153, 22);
            this.card3TextBox.TabIndex = 6;
            // 
            // card4TextBox
            // 
            this.card4TextBox.Location = new System.Drawing.Point(139, 144);
            this.card4TextBox.Name = "card4TextBox";
            this.card4TextBox.Size = new System.Drawing.Size(153, 22);
            this.card4TextBox.TabIndex = 7;
            // 
            // USBPortTextBox
            // 
            this.USBPortTextBox.Location = new System.Drawing.Point(139, 188);
            this.USBPortTextBox.Name = "USBPortTextBox";
            this.USBPortTextBox.Size = new System.Drawing.Size(153, 22);
            this.USBPortTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "USB Port";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(48, 238);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(244, 64);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 499);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.USBPortTextBox);
            this.Controls.Add(this.card4TextBox);
            this.Controls.Add(this.card3TextBox);
            this.Controls.Add(this.card2TextBox);
            this.Controls.Add(this.card1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox card1TextBox;
        private System.Windows.Forms.TextBox card2TextBox;
        private System.Windows.Forms.TextBox card3TextBox;
        private System.Windows.Forms.TextBox card4TextBox;
        private System.Windows.Forms.TextBox USBPortTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
    }
}