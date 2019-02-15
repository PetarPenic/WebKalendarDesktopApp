namespace WebKalendarDesktopApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tekstTabPage = new System.Windows.Forms.TabPage();
            this.misaTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tekstTabPage);
            this.tabControl1.Controls.Add(this.misaTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tekstTabPage
            // 
            this.tekstTabPage.Location = new System.Drawing.Point(4, 22);
            this.tekstTabPage.Name = "tekstTabPage";
            this.tekstTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tekstTabPage.Size = new System.Drawing.Size(792, 424);
            this.tekstTabPage.TabIndex = 0;
            this.tekstTabPage.Text = "tekst";
            this.tekstTabPage.UseVisualStyleBackColor = true;
            // 
            // misaTabPage
            // 
            this.misaTabPage.Location = new System.Drawing.Point(4, 22);
            this.misaTabPage.Name = "misaTabPage";
            this.misaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.misaTabPage.Size = new System.Drawing.Size(792, 424);
            this.misaTabPage.TabIndex = 1;
            this.misaTabPage.Text = "misa";
            this.misaTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Unos podataka za web kalendar";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tekstTabPage;
        private System.Windows.Forms.TabPage misaTabPage;
    }
}

