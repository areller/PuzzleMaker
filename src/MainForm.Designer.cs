namespace PuzzleMaker
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.puzzlePanel = new PuzzleMaker.PuzzlePanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.puzzleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // puzzleToolStripMenuItem
            // 
            this.puzzleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordsToolStripMenuItem,
            this.showHideSolutionToolStripMenuItem});
            this.puzzleToolStripMenuItem.Name = "puzzleToolStripMenuItem";
            this.puzzleToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.puzzleToolStripMenuItem.Text = "Puzzle";
            // 
            // wordsToolStripMenuItem
            // 
            this.wordsToolStripMenuItem.Name = "wordsToolStripMenuItem";
            this.wordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wordsToolStripMenuItem.Text = "Words";
            this.wordsToolStripMenuItem.Click += new System.EventHandler(this.wordsToolStripMenuItem_Click);
            // 
            // showHideSolutionToolStripMenuItem
            // 
            this.showHideSolutionToolStripMenuItem.Name = "showHideSolutionToolStripMenuItem";
            this.showHideSolutionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showHideSolutionToolStripMenuItem.Text = "Show/Hide Solution";
            this.showHideSolutionToolStripMenuItem.Click += new System.EventHandler(this.showHideSolutionToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "bmp";
            this.saveFileDialog.Filter = "*.bmp|*.jpeg";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // puzzlePanel
            // 
            this.puzzlePanel.Location = new System.Drawing.Point(12, 27);
            this.puzzlePanel.Name = "puzzlePanel";
            this.puzzlePanel.Size = new System.Drawing.Size(760, 522);
            this.puzzlePanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.puzzlePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Puzzle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem puzzleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem;
        private PuzzlePanel puzzlePanel;
        private System.Windows.Forms.ToolStripMenuItem showHideSolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

