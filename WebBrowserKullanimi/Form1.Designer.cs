namespace WebBrowserKullanimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_geri = new System.Windows.Forms.ToolStripButton();
            this.btn_ileri = new System.Windows.Forms.ToolStripButton();
            this.btn_yenile = new System.Windows.Forms.ToolStripButton();
            this.btn_home = new System.Windows.Forms.ToolStripButton();
            this.tb_ara = new System.Windows.Forms.ToolStripTextBox();
            this.btn_git = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_geri,
            this.btn_ileri,
            this.btn_yenile,
            this.btn_home,
            this.tb_ara,
            this.btn_git});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_geri
            // 
            this.btn_geri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_geri.Image = ((System.Drawing.Image)(resources.GetObject("btn_geri.Image")));
            this.btn_geri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(23, 22);
            this.btn_geri.Text = "toolStripButton1";
            this.btn_geri.Click += new System.EventHandler(this.Btn_geri_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ileri.Image = ((System.Drawing.Image)(resources.GetObject("btn_ileri.Image")));
            this.btn_ileri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(23, 22);
            this.btn_ileri.Text = "toolStripButton2";
            this.btn_ileri.Click += new System.EventHandler(this.Btn_ileri_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_yenile.Image = ((System.Drawing.Image)(resources.GetObject("btn_yenile.Image")));
            this.btn_yenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(23, 22);
            this.btn_yenile.Text = "toolStripButton3";
            this.btn_yenile.Click += new System.EventHandler(this.Btn_yenile_Click);
            // 
            // btn_home
            // 
            this.btn_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(23, 22);
            this.btn_home.Text = "toolStripButton4";
            // 
            // tb_ara
            // 
            this.tb_ara.Name = "tb_ara";
            this.tb_ara.Size = new System.Drawing.Size(400, 25);
            this.tb_ara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_ara_KeyDown);
            // 
            // btn_git
            // 
            this.btn_git.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_git.Image = ((System.Drawing.Image)(resources.GetObject("btn_git.Image")));
            this.btn_git.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_git.Name = "btn_git";
            this.btn_git.Size = new System.Drawing.Size(23, 22);
            this.btn_git.Text = "toolStripButton1";
            this.btn_git.Click += new System.EventHandler(this.Btn_git_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 49);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 401);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_geri;
        private System.Windows.Forms.ToolStripButton btn_ileri;
        private System.Windows.Forms.ToolStripButton btn_yenile;
        private System.Windows.Forms.ToolStripButton btn_home;
        private System.Windows.Forms.ToolStripTextBox tb_ara;
        private System.Windows.Forms.ToolStripButton btn_git;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

