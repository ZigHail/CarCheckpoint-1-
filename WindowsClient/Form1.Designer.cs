namespace WindowsClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.garageLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.ballanceLabel = new System.Windows.Forms.Label();
            this.rebootButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cardIdTextBox
            // 
            this.cardIdTextBox.Location = new System.Drawing.Point(126, 381);
            this.cardIdTextBox.Name = "cardIdTextBox";
            this.cardIdTextBox.Size = new System.Drawing.Size(189, 22);
            this.cardIdTextBox.TabIndex = 0;
            this.cardIdTextBox.TextChanged += new System.EventHandler(this.cardIdTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Гараж №";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Балланс";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(212, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 17);
            this.nameLabel.TabIndex = 6;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(212, 72);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(0, 17);
            this.surnameLabel.TabIndex = 7;
            // 
            // garageLabel
            // 
            this.garageLabel.AutoSize = true;
            this.garageLabel.Location = new System.Drawing.Point(212, 118);
            this.garageLabel.Name = "garageLabel";
            this.garageLabel.Size = new System.Drawing.Size(0, 17);
            this.garageLabel.TabIndex = 8;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(212, 155);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(0, 17);
            this.phoneLabel.TabIndex = 9;
            // 
            // ballanceLabel
            // 
            this.ballanceLabel.AutoSize = true;
            this.ballanceLabel.Location = new System.Drawing.Point(212, 197);
            this.ballanceLabel.Name = "ballanceLabel";
            this.ballanceLabel.Size = new System.Drawing.Size(0, 17);
            this.ballanceLabel.TabIndex = 10;
            // 
            // rebootButton
            // 
            this.rebootButton.Location = new System.Drawing.Point(416, 33);
            this.rebootButton.Name = "rebootButton";
            this.rebootButton.Size = new System.Drawing.Size(243, 181);
            this.rebootButton.TabIndex = 11;
            this.rebootButton.Text = "Перезагрузка";
            this.rebootButton.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(125, 306);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 561);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.rebootButton);
            this.Controls.Add(this.ballanceLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.garageLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardIdTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label garageLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label ballanceLabel;
        private System.Windows.Forms.Button rebootButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

