namespace Зачетное_задание_Евтушевская
{
    partial class addSizForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lifeTimeSiz = new System.Windows.Forms.TextBox();
            this.nameSizTextBox = new System.Windows.Forms.TextBox();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Срок службы";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Наименование СИЗ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lifeTimeSiz
            // 
            this.lifeTimeSiz.Location = new System.Drawing.Point(123, 32);
            this.lifeTimeSiz.Name = "lifeTimeSiz";
            this.lifeTimeSiz.Size = new System.Drawing.Size(100, 20);
            this.lifeTimeSiz.TabIndex = 21;
            this.lifeTimeSiz.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // nameSizTextBox
            // 
            this.nameSizTextBox.Location = new System.Drawing.Point(123, 6);
            this.nameSizTextBox.Name = "nameSizTextBox";
            this.nameSizTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameSizTextBox.TabIndex = 20;
            this.nameSizTextBox.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Location = new System.Drawing.Point(70, 55);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.errorMessageLabel.TabIndex = 25;
            // 
            // addSizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 106);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lifeTimeSiz);
            this.Controls.Add(this.nameSizTextBox);
            this.Name = "addSizForm";
            this.Text = "Добавление нового СИЗ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lifeTimeSiz;
        private System.Windows.Forms.TextBox nameSizTextBox;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}