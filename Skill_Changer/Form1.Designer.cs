namespace Skill_Changer
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimateInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evasiveInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupLst1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SupLst2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SupLst3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SupLst4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UltLst2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UltLst1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EvaLst = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LstChar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(312, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.superInfoToolStripMenuItem,
            this.ultimateInfoToolStripMenuItem,
            this.evasiveInfoToolStripMenuItem});
            this.infoToolStripMenuItem.Enabled = false;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Visible = false;
            // 
            // superInfoToolStripMenuItem
            // 
            this.superInfoToolStripMenuItem.Name = "superInfoToolStripMenuItem";
            this.superInfoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.superInfoToolStripMenuItem.Text = "Super Info";
            // 
            // ultimateInfoToolStripMenuItem
            // 
            this.ultimateInfoToolStripMenuItem.Name = "ultimateInfoToolStripMenuItem";
            this.ultimateInfoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ultimateInfoToolStripMenuItem.Text = "Ultimate Info";
            // 
            // evasiveInfoToolStripMenuItem
            // 
            this.evasiveInfoToolStripMenuItem.Name = "evasiveInfoToolStripMenuItem";
            this.evasiveInfoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.evasiveInfoToolStripMenuItem.Text = "Evasive Info";
            // 
            // SupLst1
            // 
            this.SupLst1.FormattingEnabled = true;
            this.SupLst1.Location = new System.Drawing.Point(84, 22);
            this.SupLst1.Name = "SupLst1";
            this.SupLst1.Size = new System.Drawing.Size(183, 21);
            this.SupLst1.TabIndex = 1;
            this.SupLst1.SelectedIndexChanged += new System.EventHandler(this.SupLst1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Super #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Super #2";
            // 
            // SupLst2
            // 
            this.SupLst2.FormattingEnabled = true;
            this.SupLst2.Location = new System.Drawing.Point(84, 49);
            this.SupLst2.Name = "SupLst2";
            this.SupLst2.Size = new System.Drawing.Size(183, 21);
            this.SupLst2.TabIndex = 3;
            this.SupLst2.SelectedIndexChanged += new System.EventHandler(this.SupLst2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Super #3";
            // 
            // SupLst3
            // 
            this.SupLst3.FormattingEnabled = true;
            this.SupLst3.Location = new System.Drawing.Point(84, 76);
            this.SupLst3.Name = "SupLst3";
            this.SupLst3.Size = new System.Drawing.Size(183, 21);
            this.SupLst3.TabIndex = 5;
            this.SupLst3.SelectedIndexChanged += new System.EventHandler(this.SupLst3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Super #4";
            // 
            // SupLst4
            // 
            this.SupLst4.FormattingEnabled = true;
            this.SupLst4.Location = new System.Drawing.Point(84, 103);
            this.SupLst4.Name = "SupLst4";
            this.SupLst4.Size = new System.Drawing.Size(183, 21);
            this.SupLst4.TabIndex = 7;
            this.SupLst4.SelectedIndexChanged += new System.EventHandler(this.SupLst4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ultimate #2";
            // 
            // UltLst2
            // 
            this.UltLst2.FormattingEnabled = true;
            this.UltLst2.Location = new System.Drawing.Point(84, 159);
            this.UltLst2.Name = "UltLst2";
            this.UltLst2.Size = new System.Drawing.Size(183, 21);
            this.UltLst2.TabIndex = 11;
            this.UltLst2.SelectedIndexChanged += new System.EventHandler(this.UltLst2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ultimate #1";
            // 
            // UltLst1
            // 
            this.UltLst1.FormattingEnabled = true;
            this.UltLst1.Location = new System.Drawing.Point(84, 132);
            this.UltLst1.Name = "UltLst1";
            this.UltLst1.Size = new System.Drawing.Size(183, 21);
            this.UltLst1.TabIndex = 9;
            this.UltLst1.SelectedIndexChanged += new System.EventHandler(this.UltLst1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Evasive #1";
            // 
            // EvaLst
            // 
            this.EvaLst.FormattingEnabled = true;
            this.EvaLst.Location = new System.Drawing.Point(84, 186);
            this.EvaLst.Name = "EvaLst";
            this.EvaLst.Size = new System.Drawing.Size(183, 21);
            this.EvaLst.TabIndex = 13;
            this.EvaLst.SelectedIndexChanged += new System.EventHandler(this.EvaLst_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Character/Costume";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // LstChar
            // 
            this.LstChar.FormattingEnabled = true;
            this.LstChar.Location = new System.Drawing.Point(128, 34);
            this.LstChar.Name = "LstChar";
            this.LstChar.Size = new System.Drawing.Size(151, 21);
            this.LstChar.TabIndex = 16;
            this.LstChar.SelectedIndexChanged += new System.EventHandler(this.LstChar_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UltLst1);
            this.groupBox1.Controls.Add(this.SupLst1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SupLst2);
            this.groupBox1.Controls.Add(this.EvaLst);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SupLst3);
            this.groupBox1.Controls.Add(this.UltLst2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SupLst4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 230);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skills";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Language";
            this.label9.Visible = false;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(118, 297);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 19;
            this.comboBox8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 332);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LstChar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Skill Changer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ComboBox SupLst1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SupLst2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SupLst3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SupLst4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox UltLst2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox UltLst1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EvaLst;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox LstChar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem superInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimateInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evasiveInfoToolStripMenuItem;
    }
}

