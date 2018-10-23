namespace AlumniAppEmiliano
{
    partial class MenuForm
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
            this.grades_button = new System.Windows.Forms.Button();
            this.profile_button = new System.Windows.Forms.Button();
            this.downloadgrades_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grades_button
            // 
            this.grades_button.Location = new System.Drawing.Point(12, 168);
            this.grades_button.Name = "grades_button";
            this.grades_button.Size = new System.Drawing.Size(227, 95);
            this.grades_button.TabIndex = 0;
            this.grades_button.Text = "Grades";
            this.grades_button.UseVisualStyleBackColor = true;
            this.grades_button.Click += new System.EventHandler(this.grades_button_Click);
            // 
            // profile_button
            // 
            this.profile_button.Location = new System.Drawing.Point(285, 168);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(237, 95);
            this.profile_button.TabIndex = 1;
            this.profile_button.Text = "Profile";
            this.profile_button.UseVisualStyleBackColor = true;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // downloadgrades_button
            // 
            this.downloadgrades_button.Location = new System.Drawing.Point(563, 168);
            this.downloadgrades_button.Name = "downloadgrades_button";
            this.downloadgrades_button.Size = new System.Drawing.Size(203, 101);
            this.downloadgrades_button.TabIndex = 2;
            this.downloadgrades_button.Text = "Download Grades";
            this.downloadgrades_button.UseVisualStyleBackColor = true;
            this.downloadgrades_button.Click += new System.EventHandler(this.downloadgrades_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(691, 384);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 41);
            this.logout_button.TabIndex = 3;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.downloadgrades_button);
            this.Controls.Add(this.profile_button);
            this.Controls.Add(this.grades_button);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button grades_button;
        private System.Windows.Forms.Button profile_button;
        private System.Windows.Forms.Button downloadgrades_button;
        private System.Windows.Forms.Button logout_button;
    }
}