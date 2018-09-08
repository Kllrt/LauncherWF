namespace LauncherWindowsForms
{
    partial class Launcher
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.LaunchGame = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AddonList = new System.Windows.Forms.CheckedListBox();
            this.FilePatching = new System.Windows.Forms.CheckBox();
            this.SkipIntro = new System.Windows.Forms.CheckBox();
            this.CustomParams = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LaunchGame
            // 
            resources.ApplyResources(this.LaunchGame, "LaunchGame");
            this.LaunchGame.Name = "LaunchGame";
            this.LaunchGame.UseVisualStyleBackColor = true;
            this.LaunchGame.Click += new System.EventHandler(this.LaunchGame_Click);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AddonList
            // 
            resources.ApplyResources(this.AddonList, "AddonList");
            this.AddonList.FormattingEnabled = true;
            this.AddonList.Name = "AddonList";
            this.AddonList.SelectedIndexChanged += new System.EventHandler(this.AddonList_SelectedIndexChanged);
            // 
            // FilePatching
            // 
            resources.ApplyResources(this.FilePatching, "FilePatching");
            this.FilePatching.Name = "FilePatching";
            this.FilePatching.UseVisualStyleBackColor = true;
            this.FilePatching.CheckedChanged += new System.EventHandler(this.FilePatching_CheckedChanged);
            // 
            // SkipIntro
            // 
            resources.ApplyResources(this.SkipIntro, "SkipIntro");
            this.SkipIntro.Name = "SkipIntro";
            this.SkipIntro.UseVisualStyleBackColor = true;
            this.SkipIntro.CheckedChanged += new System.EventHandler(this.SkipIntro_CheckedChanged);
            // 
            // CustomParams
            // 
            resources.ApplyResources(this.CustomParams, "CustomParams");
            this.CustomParams.Name = "CustomParams";
            this.CustomParams.TextChanged += new System.EventHandler(this.CustomParams_TextChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Launcher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CustomParams);
            this.Controls.Add(this.SkipIntro);
            this.Controls.Add(this.FilePatching);
            this.Controls.Add(this.AddonList);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LaunchGame);
            this.Name = "Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchGame;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox AddonList;
        private System.Windows.Forms.CheckBox FilePatching;
        private System.Windows.Forms.CheckBox SkipIntro;
        private System.Windows.Forms.TextBox CustomParams;
        private System.Windows.Forms.TextBox textBox1;
    }
}

