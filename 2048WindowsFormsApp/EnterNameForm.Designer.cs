namespace _2048WindowsFormsApp
{
    partial class EnterNameForm
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
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rulesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть ваше ім\'я";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNameTextBox.Location = new System.Drawing.Point(64, 144);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.Size = new System.Drawing.Size(155, 31);
            this.enterNameTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.okButton.Location = new System.Drawing.Point(84, 314);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 33);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Нова гра";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "2048";
            // 
            // rulesButton
            // 
            this.rulesButton.Location = new System.Drawing.Point(84, 275);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(114, 23);
            this.rulesButton.TabIndex = 4;
            this.rulesButton.Text = "Правила гри";
            this.rulesButton.UseVisualStyleBackColor = true;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // EnterNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 410);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.enterNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EnterNameForm";
            this.Text = "EnterNameForm";
            this.Load += new System.EventHandler(this.EnterNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterNameTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rulesButton;
    }
}