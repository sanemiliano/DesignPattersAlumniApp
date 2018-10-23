namespace AlumniAppEmiliano
{
    partial class DownloadGradesForm
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
            this.word_button = new System.Windows.Forms.Button();
            this.textfile_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.path_textbox = new System.Windows.Forms.TextBox();
            this.textfile_label = new System.Windows.Forms.Label();
            this.word_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // word_button
            // 
            this.word_button.Location = new System.Drawing.Point(228, 187);
            this.word_button.Name = "word_button";
            this.word_button.Size = new System.Drawing.Size(122, 69);
            this.word_button.TabIndex = 0;
            this.word_button.Text = "Word file(.docx)";
            this.word_button.UseVisualStyleBackColor = true;
            this.word_button.Click += new System.EventHandler(this.word_button_Click);
            // 
            // textfile_button
            // 
            this.textfile_button.Location = new System.Drawing.Point(439, 187);
            this.textfile_button.Name = "textfile_button";
            this.textfile_button.Size = new System.Drawing.Size(125, 69);
            this.textfile_button.TabIndex = 1;
            this.textfile_button.Text = "Text file(.txt)";
            this.textfile_button.UseVisualStyleBackColor = true;
            this.textfile_button.Click += new System.EventHandler(this.textfile_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(43, 368);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(96, 40);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // path_textbox
            // 
            this.path_textbox.Location = new System.Drawing.Point(181, 106);
            this.path_textbox.Name = "path_textbox";
            this.path_textbox.Size = new System.Drawing.Size(479, 22);
            this.path_textbox.TabIndex = 3;
            this.path_textbox.Text = "Ejemplo: C:\\\\Users\\\\cajad\\\\Desktop\\\\";
            // 
            // textfile_label
            // 
            this.textfile_label.AutoSize = true;
            this.textfile_label.Location = new System.Drawing.Point(483, 281);
            this.textfile_label.Name = "textfile_label";
            this.textfile_label.Size = new System.Drawing.Size(0, 17);
            this.textfile_label.TabIndex = 4;
            // 
            // word_label
            // 
            this.word_label.AutoSize = true;
            this.word_label.Location = new System.Drawing.Point(60, 281);
            this.word_label.Name = "word_label";
            this.word_label.Size = new System.Drawing.Size(0, 17);
            this.word_label.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Por favor ingrese la ruta donde desea descargar el archivo";
            // 
            // DownloadGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.word_label);
            this.Controls.Add(this.textfile_label);
            this.Controls.Add(this.path_textbox);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.textfile_button);
            this.Controls.Add(this.word_button);
            this.Name = "DownloadGradesForm";
            this.Text = "DownloadGradesForm";
            this.Load += new System.EventHandler(this.DownloadGradesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button word_button;
        private System.Windows.Forms.Button textfile_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox path_textbox;
        private System.Windows.Forms.Label textfile_label;
        private System.Windows.Forms.Label word_label;
        private System.Windows.Forms.Label label1;
    }
}