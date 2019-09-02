namespace Quiz_1
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
            this.txt_array = new System.Windows.Forms.TextBox();
            this.btn_array = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.lbl_size = new System.Windows.Forms.Label();
            this.btn_ave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_array
            // 
            this.txt_array.Location = new System.Drawing.Point(23, 85);
            this.txt_array.Multiline = true;
            this.txt_array.Name = "txt_array";
            this.txt_array.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_array.Size = new System.Drawing.Size(136, 138);
            this.txt_array.TabIndex = 0;
            this.txt_array.TextChanged += new System.EventHandler(this.txt_array_TextChanged);
            // 
            // btn_array
            // 
            this.btn_array.Location = new System.Drawing.Point(23, 42);
            this.btn_array.Name = "btn_array";
            this.btn_array.Size = new System.Drawing.Size(75, 23);
            this.btn_array.TabIndex = 1;
            this.btn_array.Text = "Show array";
            this.btn_array.UseVisualStyleBackColor = true;
            this.btn_array.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_min
            // 
            this.btn_min.Location = new System.Drawing.Point(104, 42);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(75, 23);
            this.btn_min.TabIndex = 2;
            this.btn_min.Text = "Min Value";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Location = new System.Drawing.Point(185, 42);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(75, 23);
            this.btn_max.TabIndex = 3;
            this.btn_max.Text = "Max Value";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // txt_size
            // 
            this.txt_size.Location = new System.Drawing.Point(106, 16);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(100, 20);
            this.txt_size.TabIndex = 4;
            this.txt_size.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_size_MouseClick);
            this.txt_size.TextChanged += new System.EventHandler(this.txt_size_TextChanged);
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(35, 19);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(65, 13);
            this.lbl_size.TabIndex = 5;
            this.lbl_size.Text = "Size of array";
            // 
            // btn_ave
            // 
            this.btn_ave.Location = new System.Drawing.Point(173, 85);
            this.btn_ave.Name = "btn_ave";
            this.btn_ave.Size = new System.Drawing.Size(87, 23);
            this.btn_ave.TabIndex = 6;
            this.btn_ave.Text = "Average value";
            this.btn_ave.UseVisualStyleBackColor = true;
            this.btn_ave.Click += new System.EventHandler(this.btn_ave_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_array;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_ave);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.txt_size);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_array);
            this.Controls.Add(this.txt_array);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_array;
        private System.Windows.Forms.Button btn_array;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Button btn_ave;
    }
}

