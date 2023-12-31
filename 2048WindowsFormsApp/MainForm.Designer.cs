﻿namespace _2048WindowsFormsApp
{
    partial class MainForm
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestScoreLabel = new System.Windows.Forms.Label();
            this.HighScoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рахунок:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(138, 24);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(13, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(320, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticGameToolStripMenuItem,
            this.mapSizeToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // statisticGameToolStripMenuItem
            // 
            this.statisticGameToolStripMenuItem.Name = "statisticGameToolStripMenuItem";
            this.statisticGameToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.statisticGameToolStripMenuItem.Text = "Статистика гри";
            this.statisticGameToolStripMenuItem.Click += new System.EventHandler(this.статистикаИгрыToolStripMenuItem_Click);
            // 
            // mapSizeToolStripMenuItem
            // 
            this.mapSizeToolStripMenuItem.Name = "mapSizeToolStripMenuItem";
            this.mapSizeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.mapSizeToolStripMenuItem.Text = "Вибір розміру поля";
            this.mapSizeToolStripMenuItem.Click += new System.EventHandler(this.выборРазмераПоляToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.restartToolStripMenuItem.Text = "Рестарт";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.рестартToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // bestScoreLabel
            // 
            this.bestScoreLabel.AutoSize = true;
            this.bestScoreLabel.Location = new System.Drawing.Point(268, 24);
            this.bestScoreLabel.Name = "bestScoreLabel";
            this.bestScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.bestScoreLabel.TabIndex = 4;
            this.bestScoreLabel.Text = "0";
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.AutoSize = true;
            this.HighScoreLabel.Location = new System.Drawing.Point(169, 24);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(93, 13);
            this.HighScoreLabel.TabIndex = 3;
            this.HighScoreLabel.Text = "Кращий рахунок:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 382);
            this.Controls.Add(this.bestScoreLabel);
            this.Controls.Add(this.HighScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Игра 2048";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label bestScoreLabel;
        private System.Windows.Forms.Label HighScoreLabel;
    }
}

