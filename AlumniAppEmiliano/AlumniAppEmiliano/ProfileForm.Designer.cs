namespace AlumniAppEmiliano
{
    partial class ProfileForm
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
            this.profile_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fullname_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.usertype_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profile_label
            // 
            this.profile_label.AutoSize = true;
            this.profile_label.Location = new System.Drawing.Point(341, 64);
            this.profile_label.Name = "profile_label";
            this.profile_label.Size = new System.Drawing.Size(48, 17);
            this.profile_label.TabIndex = 0;
            this.profile_label.Text = "Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fullname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // fullname_label
            // 
            this.fullname_label.AutoSize = true;
            this.fullname_label.Location = new System.Drawing.Point(415, 145);
            this.fullname_label.Name = "fullname_label";
            this.fullname_label.Size = new System.Drawing.Size(68, 17);
            this.fullname_label.TabIndex = 5;
            this.fullname_label.Text = "------------";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(415, 191);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(68, 17);
            this.address_label.TabIndex = 6;
            this.address_label.Text = "------------";
            // 
            // usertype_label
            // 
            this.usertype_label.AutoSize = true;
            this.usertype_label.Location = new System.Drawing.Point(415, 237);
            this.usertype_label.Name = "usertype_label";
            this.usertype_label.Size = new System.Drawing.Size(68, 17);
            this.usertype_label.TabIndex = 7;
            this.usertype_label.Text = "------------";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(415, 288);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(68, 17);
            this.username_label.TabIndex = 8;
            this.username_label.Text = "------------";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(36, 397);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 30);
            this.back_button.TabIndex = 9;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.usertype_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.fullname_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profile_label);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profile_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fullname_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label usertype_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button back_button;
    }
}