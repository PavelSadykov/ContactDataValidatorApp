namespace ContactDataValidatorApp
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
            this.checkButton = new System.Windows.Forms.Button();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailStatusLabel = new System.Windows.Forms.Label();
            this.phoneStatusLabel = new System.Windows.Forms.Label();
            this.ageStatusLabel = new System.Windows.Forms.Label();
            this.fullNameStatusLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(187, 157);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "ENTER";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(187, 53);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(187, 131);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(195, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(187, 105);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(195, 20);
            this.phoneTextBox.TabIndex = 3;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(187, 79);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(195, 20);
            this.ageTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите ФИО";
            // 
            // emailStatusLabel
            // 
            this.emailStatusLabel.AutoSize = true;
            this.emailStatusLabel.Location = new System.Drawing.Point(410, 138);
            this.emailStatusLabel.Name = "emailStatusLabel";
            this.emailStatusLabel.Size = new System.Drawing.Size(19, 13);
            this.emailStatusLabel.TabIndex = 6;
            this.emailStatusLabel.Text = "....";
            // 
            // phoneStatusLabel
            // 
            this.phoneStatusLabel.AutoSize = true;
            this.phoneStatusLabel.Location = new System.Drawing.Point(410, 112);
            this.phoneStatusLabel.Name = "phoneStatusLabel";
            this.phoneStatusLabel.Size = new System.Drawing.Size(19, 13);
            this.phoneStatusLabel.TabIndex = 7;
            this.phoneStatusLabel.Text = "....";
            // 
            // ageStatusLabel
            // 
            this.ageStatusLabel.AutoSize = true;
            this.ageStatusLabel.Location = new System.Drawing.Point(410, 86);
            this.ageStatusLabel.Name = "ageStatusLabel";
            this.ageStatusLabel.Size = new System.Drawing.Size(19, 13);
            this.ageStatusLabel.TabIndex = 8;
            this.ageStatusLabel.Text = "....";
            // 
            // fullNameStatusLabel
            // 
            this.fullNameStatusLabel.AutoSize = true;
            this.fullNameStatusLabel.Location = new System.Drawing.Point(410, 56);
            this.fullNameStatusLabel.Name = "fullNameStatusLabel";
            this.fullNameStatusLabel.Size = new System.Drawing.Size(19, 13);
            this.fullNameStatusLabel.TabIndex = 9;
            this.fullNameStatusLabel.Text = "....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Введите e-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Введите тел номер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Введите возраст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fullNameStatusLabel);
            this.Controls.Add(this.ageStatusLabel);
            this.Controls.Add(this.phoneStatusLabel);
            this.Controls.Add(this.emailStatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.checkButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailStatusLabel;
        private System.Windows.Forms.Label phoneStatusLabel;
        private System.Windows.Forms.Label ageStatusLabel;
        private System.Windows.Forms.Label fullNameStatusLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

