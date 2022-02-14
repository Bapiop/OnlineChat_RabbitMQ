namespace OnlineChat_RabbitMQ
{
    partial class LoginUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oy_button1 = new System.Windows.Forms.Button();
            this.oy_textBox1 = new System.Windows.Forms.TextBox();
            this.oy_textBox2 = new System.Windows.Forms.TextBox();
            this.oy_label1 = new System.Windows.Forms.Label();
            this.oy_label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oy_button1
            // 
            this.oy_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oy_button1.Location = new System.Drawing.Point(247, 317);
            this.oy_button1.Name = "oy_button1";
            this.oy_button1.Size = new System.Drawing.Size(114, 34);
            this.oy_button1.TabIndex = 0;
            this.oy_button1.Text = "LOGIN";
            this.oy_button1.UseVisualStyleBackColor = true;
            this.oy_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oy_textBox1
            // 
            this.oy_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oy_textBox1.Location = new System.Drawing.Point(220, 155);
            this.oy_textBox1.Name = "oy_textBox1";
            this.oy_textBox1.Size = new System.Drawing.Size(173, 22);
            this.oy_textBox1.TabIndex = 1;
            // 
            // oy_textBox2
            // 
            this.oy_textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oy_textBox2.Location = new System.Drawing.Point(220, 242);
            this.oy_textBox2.Name = "oy_textBox2";
            this.oy_textBox2.PasswordChar = '*';
            this.oy_textBox2.Size = new System.Drawing.Size(173, 22);
            this.oy_textBox2.TabIndex = 2;
            // 
            // oy_label1
            // 
            this.oy_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oy_label1.AutoSize = true;
            this.oy_label1.ForeColor = System.Drawing.Color.Black;
            this.oy_label1.Location = new System.Drawing.Point(282, 135);
            this.oy_label1.Name = "oy_label1";
            this.oy_label1.Size = new System.Drawing.Size(51, 17);
            this.oy_label1.TabIndex = 3;
            this.oy_label1.Text = "LOGIN";
            // 
            // oy_label2
            // 
            this.oy_label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oy_label2.AutoSize = true;
            this.oy_label2.ForeColor = System.Drawing.Color.Black;
            this.oy_label2.Location = new System.Drawing.Point(261, 222);
            this.oy_label2.Name = "oy_label2";
            this.oy_label2.Size = new System.Drawing.Size(88, 17);
            this.oy_label2.TabIndex = 4;
            this.oy_label2.Text = "PASSWORD";
            // 
            // oy_label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 28);
            this.label1.Name = "oy_label1";
            this.label1.Size = new System.Drawing.Size(376, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter username and password to log in into system";
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oy_label2);
            this.Controls.Add(this.oy_label1);
            this.Controls.Add(this.oy_textBox2);
            this.Controls.Add(this.oy_textBox1);
            this.Controls.Add(this.oy_button1);
            this.Name = "LoginUI";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.userLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oy_button1;
        private System.Windows.Forms.TextBox oy_textBox1;
        private System.Windows.Forms.TextBox oy_textBox2;
        private System.Windows.Forms.Label oy_label1;
        private System.Windows.Forms.Label oy_label2;
        private System.Windows.Forms.Label label1;
    }
}
