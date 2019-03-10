namespace lesson7
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumLabel = new System.Windows.Forms.Label();
            this.CurValLabel = new System.Windows.Forms.Label();
            this.StepLabel = new System.Windows.Forms.Label();
            this.StepLabelNum = new System.Windows.Forms.Label();
            this.FinishLabel = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.MenuItemGusNum = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Enabled = false;
            this.btnCommand1.Location = new System.Drawing.Point(472, 27);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(101, 25);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "button1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Enabled = false;
            this.btnCommand2.Location = new System.Drawing.Point(472, 68);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(101, 25);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "button2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(472, 109);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 25);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "button3";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(100, 60);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayToolStripMenuItem,
            this.MenuItemGusNum});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.MenuToolStripMenuItem.Text = "Меню игры";
            // 
            // PlayToolStripMenuItem
            // 
            this.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem";
            this.PlayToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.PlayToolStripMenuItem.Text = "Играть в удвоитель";
            this.PlayToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(12, 37);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(207, 13);
            this.NumLabel.TabIndex = 5;
            this.NumLabel.Text = "Число которое должен получить игрок:";
            // 
            // CurValLabel
            // 
            this.CurValLabel.AutoSize = true;
            this.CurValLabel.Location = new System.Drawing.Point(13, 60);
            this.CurValLabel.Name = "CurValLabel";
            this.CurValLabel.Size = new System.Drawing.Size(87, 13);
            this.CurValLabel.TabIndex = 6;
            this.CurValLabel.Text = "Текущее число:";
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Location = new System.Drawing.Point(15, 81);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(76, 13);
            this.StepLabel.TabIndex = 7;
            this.StepLabel.Text = "Число шагов:";
            // 
            // StepLabelNum
            // 
            this.StepLabelNum.AutoSize = true;
            this.StepLabelNum.Location = new System.Drawing.Point(102, 81);
            this.StepLabelNum.Name = "StepLabelNum";
            this.StepLabelNum.Size = new System.Drawing.Size(13, 13);
            this.StepLabelNum.TabIndex = 8;
            this.StepLabelNum.Text = "0";
            // 
            // FinishLabel
            // 
            this.FinishLabel.AutoSize = true;
            this.FinishLabel.Location = new System.Drawing.Point(223, 37);
            this.FinishLabel.Name = "FinishLabel";
            this.FinishLabel.Size = new System.Drawing.Size(13, 13);
            this.FinishLabel.TabIndex = 9;
            this.FinishLabel.Text = "0";
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(472, 150);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(101, 25);
            this.btnReverse.TabIndex = 10;
            this.btnReverse.Text = "Отменить";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // MenuItemGusNum
            // 
            this.MenuItemGusNum.Name = "MenuItemGusNum";
            this.MenuItemGusNum.Size = new System.Drawing.Size(190, 22);
            this.MenuItemGusNum.Text = "Играть в угадай число";
            this.MenuItemGusNum.Click += new System.EventHandler(this.MenuItemGusNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(596, 459);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.FinishLabel);
            this.Controls.Add(this.StepLabelNum);
            this.Controls.Add(this.StepLabel);
            this.Controls.Add(this.CurValLabel);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayToolStripMenuItem;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.Label CurValLabel;
        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.Label StepLabelNum;
        private System.Windows.Forms.Label FinishLabel;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGusNum;
    }
}

