namespace Quiz2
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
            this.txt_size = new System.Windows.Forms.TextBox();
            this.txt_star = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_size
            // 
            this.txt_size.Location = new System.Drawing.Point(38, 20);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(100, 20);
            this.txt_size.TabIndex = 0;
            this.txt_size.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_star
            // 
            this.txt_star.Location = new System.Drawing.Point(69, 72);
            this.txt_star.Multiline = true;
            this.txt_star.Name = "txt_star";
            this.txt_star.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_star.Size = new System.Drawing.Size(126, 139);
            this.txt_star.TabIndex = 1;
            this.txt_star.TextChanged += new System.EventHandler(this.txt_star_TextChanged);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(162, 18);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "SHOW";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.txt_star);
            this.Controls.Add(this.txt_size);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.TextBox txt_star;
        private System.Windows.Forms.Button btn_show;
    }
}

