namespace MultiArchiver
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            新規アーカイブNToolStripMenuItem = new ToolStripMenuItem();
            アーカイブを開くOToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            デバッグDToolStripMenuItem = new ToolStripMenuItem();
            openArchiveFormToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, デバッグDToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(658, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 新規アーカイブNToolStripMenuItem, アーカイブを開くOToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規アーカイブNToolStripMenuItem
            // 
            新規アーカイブNToolStripMenuItem.Name = "新規アーカイブNToolStripMenuItem";
            新規アーカイブNToolStripMenuItem.Size = new Size(196, 22);
            新規アーカイブNToolStripMenuItem.Text = "新規アーカイブ(&N)…";
            // 
            // アーカイブを開くOToolStripMenuItem
            // 
            アーカイブを開くOToolStripMenuItem.Name = "アーカイブを開くOToolStripMenuItem";
            アーカイブを開くOToolStripMenuItem.Size = new Size(196, 22);
            アーカイブを開くOToolStripMenuItem.Text = "既存アーカイブを開く(&O)…";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 379);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(658, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // デバッグDToolStripMenuItem
            // 
            デバッグDToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openArchiveFormToolStripMenuItem });
            デバッグDToolStripMenuItem.Name = "デバッグDToolStripMenuItem";
            デバッグDToolStripMenuItem.Size = new Size(71, 20);
            デバッグDToolStripMenuItem.Text = "デバッグ(&D)";
            // 
            // openArchiveFormToolStripMenuItem
            // 
            openArchiveFormToolStripMenuItem.Name = "openArchiveFormToolStripMenuItem";
            openArchiveFormToolStripMenuItem.Size = new Size(180, 22);
            openArchiveFormToolStripMenuItem.Text = "Open Archive Form";
            openArchiveFormToolStripMenuItem.Click += openArchiveFormToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 401);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Multi Archiver";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 新規アーカイブNToolStripMenuItem;
        private ToolStripMenuItem アーカイブを開くOToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem デバッグDToolStripMenuItem;
        private ToolStripMenuItem openArchiveFormToolStripMenuItem;
    }
}