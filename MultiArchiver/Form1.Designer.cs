namespace MultiArchiver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規アーカイブNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アーカイブを開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規アーカイブNToolStripMenuItem,
            this.アーカイブを開くOToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規アーカイブNToolStripMenuItem
            // 
            this.新規アーカイブNToolStripMenuItem.Name = "新規アーカイブNToolStripMenuItem";
            this.新規アーカイブNToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.新規アーカイブNToolStripMenuItem.Text = "新規アーカイブ(&N)…";
            // 
            // アーカイブを開くOToolStripMenuItem
            // 
            this.アーカイブを開くOToolStripMenuItem.Name = "アーカイブを開くOToolStripMenuItem";
            this.アーカイブを開くOToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.アーカイブを開くOToolStripMenuItem.Text = "既存アーカイブを開く(&O)…";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "マルチアーカイバー";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 新規アーカイブNToolStripMenuItem;
        private ToolStripMenuItem アーカイブを開くOToolStripMenuItem;
    }
}