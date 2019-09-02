namespace WindowsFormsApplication2
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
            this.lblnumber1 = new System.Windows.Forms.Label();
            this.lblnumber2 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.TextBox();
            this.txtnumber2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btntoplama = new System.Windows.Forms.Button();
            this.btncikarma = new System.Windows.Forms.Button();
            this.btncarpma = new System.Windows.Forms.Button();
            this.btnbolme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumber1
            // 
            this.lblnumber1.AutoSize = true;
            this.lblnumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnumber1.Location = new System.Drawing.Point(25, 70);
            this.lblnumber1.Name = "lblnumber1";
            this.lblnumber1.Size = new System.Drawing.Size(66, 16);
            this.lblnumber1.TabIndex = 0;
            this.lblnumber1.Text = "Number 1";
            this.lblnumber1.Click += new System.EventHandler(this.lblnumber1_Click);
            // 
            // lblnumber2
            // 
            this.lblnumber2.AutoSize = true;
            this.lblnumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnumber2.Location = new System.Drawing.Point(28, 113);
            this.lblnumber2.Name = "lblnumber2";
            this.lblnumber2.Size = new System.Drawing.Size(63, 16);
            this.lblnumber2.TabIndex = 1;
            this.lblnumber2.Text = "Number2";
            this.lblnumber2.Click += new System.EventHandler(this.lblnumber2_Click);
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(97, 69);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(100, 20);
            this.txtnumber1.TabIndex = 2;
            this.txtnumber1.TextChanged += new System.EventHandler(this.txtnumber1_TextChanged);
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(97, 112);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(100, 20);
            this.txtnumber2.TabIndex = 3;
            this.txtnumber2.TextChanged += new System.EventHandler(this.txtnumber2_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(111, 170);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 16);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btntoplama
            // 
            this.btntoplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntoplama.Location = new System.Drawing.Point(225, 51);
            this.btntoplama.Name = "btntoplama";
            this.btntoplama.Size = new System.Drawing.Size(29, 23);
            this.btntoplama.TabIndex = 5;
            this.btntoplama.Text = "+";
            this.btntoplama.UseVisualStyleBackColor = true;
            this.btntoplama.Click += new System.EventHandler(this.btntoplama_Click);
            // 
            // btncikarma
            // 
            this.btncikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikarma.Location = new System.Drawing.Point(226, 80);
            this.btncikarma.Name = "btncikarma";
            this.btncikarma.Size = new System.Drawing.Size(28, 23);
            this.btncikarma.TabIndex = 6;
            this.btncikarma.Text = "-";
            this.btncikarma.UseVisualStyleBackColor = true;
            this.btncikarma.Click += new System.EventHandler(this.btncikarma_Click);
            // 
            // btncarpma
            // 
            this.btncarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncarpma.Location = new System.Drawing.Point(226, 109);
            this.btncarpma.Name = "btncarpma";
            this.btncarpma.Size = new System.Drawing.Size(28, 23);
            this.btncarpma.TabIndex = 7;
            this.btncarpma.Text = "*";
            this.btncarpma.UseVisualStyleBackColor = true;
            this.btncarpma.Click += new System.EventHandler(this.btncarpma_Click);
            // 
            // btnbolme
            // 
            this.btnbolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbolme.Location = new System.Drawing.Point(226, 138);
            this.btnbolme.Name = "btnbolme";
            this.btnbolme.Size = new System.Drawing.Size(28, 23);
            this.btnbolme.TabIndex = 8;
            this.btnbolme.Text = "/";
            this.btnbolme.UseVisualStyleBackColor = true;
            this.btnbolme.Click += new System.EventHandler(this.btnbolme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnbolme);
            this.Controls.Add(this.btncarpma);
            this.Controls.Add(this.btncikarma);
            this.Controls.Add(this.btntoplama);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.lblnumber2);
            this.Controls.Add(this.lblnumber1);
            this.Name = "Form1";
            this.Text = "LAB 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumber1;
        private System.Windows.Forms.Label lblnumber2;
        private System.Windows.Forms.TextBox txtnumber1;
        private System.Windows.Forms.TextBox txtnumber2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btntoplama;
        private System.Windows.Forms.Button btncikarma;
        private System.Windows.Forms.Button btncarpma;
        private System.Windows.Forms.Button btnbolme;
    }
}

