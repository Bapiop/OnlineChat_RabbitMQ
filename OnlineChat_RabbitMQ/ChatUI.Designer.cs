namespace OnlineChat_RabbitMQ
{
    partial class ChatUI
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
            this.oy_listView1 = new System.Windows.Forms.ListView();
            this.oy_textBox1 = new System.Windows.Forms.TextBox();
            this.oy_button3 = new System.Windows.Forms.Button();
            this.oy_panel1 = new System.Windows.Forms.Panel();
            this.oy_listBox1 = new System.Windows.Forms.ListBox();
            this.oy_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oy_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oy_listView1
            // 
            this.oy_listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.oy_listView1.BackColor = System.Drawing.Color.White;
            this.oy_listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oy_listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oy_listView1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.oy_listView1.GridLines = true;
            this.oy_listView1.HideSelection = false;
            this.oy_listView1.Location = new System.Drawing.Point(3, 72);
            this.oy_listView1.Margin = new System.Windows.Forms.Padding(1);
            this.oy_listView1.MultiSelect = false;
            this.oy_listView1.Name = "oy_listView1";
            this.oy_listView1.Size = new System.Drawing.Size(197, 322);
            this.oy_listView1.TabIndex = 11;
            this.oy_listView1.TileSize = new System.Drawing.Size(100, 30);
            this.oy_listView1.UseCompatibleStateImageBehavior = false;
            this.oy_listView1.View = System.Windows.Forms.View.Tile;
            this.oy_listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // oy_textBox1
            // 
            this.oy_textBox1.BackColor = System.Drawing.Color.White;
            this.oy_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oy_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oy_textBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.oy_textBox1.Location = new System.Drawing.Point(3, 3);
            this.oy_textBox1.Multiline = true;
            this.oy_textBox1.Name = "oy_textBox1";
            this.oy_textBox1.Size = new System.Drawing.Size(268, 59);
            this.oy_textBox1.TabIndex = 8;
            this.oy_textBox1.Text = "...text to...";
            // 
            // oy_button3
            // 
            this.oy_button3.BackColor = System.Drawing.Color.Silver;
            this.oy_button3.FlatAppearance.BorderSize = 0;
            this.oy_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oy_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oy_button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.oy_button3.Location = new System.Drawing.Point(486, 332);
            this.oy_button3.Name = "oy_button3";
            this.oy_button3.Size = new System.Drawing.Size(111, 65);
            this.oy_button3.TabIndex = 14;
            this.oy_button3.Text = "Massage";
            this.oy_button3.UseVisualStyleBackColor = false;
            this.oy_button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // oy_panel1
            // 
            this.oy_panel1.Controls.Add(this.oy_textBox1);
            this.oy_panel1.Location = new System.Drawing.Point(209, 332);
            this.oy_panel1.Name = "oy_panel1";
            this.oy_panel1.Size = new System.Drawing.Size(271, 65);
            this.oy_panel1.TabIndex = 13;
            // 
            // oy_listBox1
            // 
            this.oy_listBox1.BackColor = System.Drawing.Color.White;
            this.oy_listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oy_listBox1.ForeColor = System.Drawing.Color.Black;
            this.oy_listBox1.FormattingEnabled = true;
            this.oy_listBox1.ItemHeight = 16;
            this.oy_listBox1.Location = new System.Drawing.Point(206, 9);
            this.oy_listBox1.Name = "oy_listBox1";
            this.oy_listBox1.Size = new System.Drawing.Size(391, 320);
            this.oy_listBox1.TabIndex = 15;
            // 
            // oy_label1
            // 
            this.oy_label1.AutoSize = true;
            this.oy_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oy_label1.ForeColor = System.Drawing.Color.Black;
            this.oy_label1.Location = new System.Drawing.Point(47, 9);
            this.oy_label1.Name = "oy_label1";
            this.oy_label1.Size = new System.Drawing.Size(106, 25);
            this.oy_label1.TabIndex = 16;
            this.oy_label1.Text = "Friend list";
            // 
            // oy_label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "oy_label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "(choose friend to start a chat)";
            // 
            // ChatUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oy_label1);
            this.Controls.Add(this.oy_listView1);
            this.Controls.Add(this.oy_listBox1);
            this.Controls.Add(this.oy_button3);
            this.Controls.Add(this.oy_panel1);
            this.Name = "ChatUI";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.userChat_Load);
            this.oy_panel1.ResumeLayout(false);
            this.oy_panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView oy_listView1;
        private System.Windows.Forms.TextBox oy_textBox1;
        private System.Windows.Forms.Button oy_button3;
        private System.Windows.Forms.Panel oy_panel1;
        private System.Windows.Forms.ListBox oy_listBox1;
        private System.Windows.Forms.Label oy_label1;
        private System.Windows.Forms.Label label1;
    }
}
