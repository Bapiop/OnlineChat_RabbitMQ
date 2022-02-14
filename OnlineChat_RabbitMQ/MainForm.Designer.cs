namespace OnlineChat_RabbitMQ
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
            this.oy_button1 = new System.Windows.Forms.Button();
            this.oy_button2 = new System.Windows.Forms.Button();
            this.oy_mainContainer = new System.Windows.Forms.Panel();
            this.oy_label1 = new System.Windows.Forms.Label();
            this.oy_label2 = new System.Windows.Forms.Label();
            this.oy_MenuHeader = new System.Windows.Forms.MenuStrip();
            this.onlineChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oy_MenuHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // oy_button1
            // 
            this.oy_button1.BackColor = System.Drawing.Color.Gray;
            this.oy_button1.FlatAppearance.BorderSize = 0;
            this.oy_button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.oy_button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.oy_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oy_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oy_button1.ForeColor = System.Drawing.Color.Black;
            this.oy_button1.Location = new System.Drawing.Point(552, -3);
            this.oy_button1.Name = "oy_button1";
            this.oy_button1.Size = new System.Drawing.Size(48, 30);
            this.oy_button1.TabIndex = 4;
            this.oy_button1.TabStop = false;
            this.oy_button1.Text = "X";
            this.oy_button1.UseVisualStyleBackColor = false;
            this.oy_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oy_button2
            // 
            this.oy_button2.BackColor = System.Drawing.Color.Gray;
            this.oy_button2.FlatAppearance.BorderSize = 0;
            this.oy_button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(100)))));
            this.oy_button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(81)))));
            this.oy_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oy_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oy_button2.ForeColor = System.Drawing.Color.Black;
            this.oy_button2.Location = new System.Drawing.Point(498, -3);
            this.oy_button2.Name = "oy_button2";
            this.oy_button2.Size = new System.Drawing.Size(48, 30);
            this.oy_button2.TabIndex = 5;
            this.oy_button2.TabStop = false;
            this.oy_button2.Text = "—";
            this.oy_button2.UseVisualStyleBackColor = false;
            this.oy_button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oy_mainContainer
            // 
            this.oy_mainContainer.BackColor = System.Drawing.Color.White;
            this.oy_mainContainer.Location = new System.Drawing.Point(0, 27);
            this.oy_mainContainer.Name = "oy_mainContainer";
            this.oy_mainContainer.Size = new System.Drawing.Size(600, 400);
            this.oy_mainContainer.TabIndex = 6;
            this.oy_mainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.oy_mainContainer_Paint);
            // 
            // oy_label1
            // 
            this.oy_label1.AutoSize = true;
            this.oy_label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.oy_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oy_label1.ForeColor = System.Drawing.Color.White;
            this.oy_label1.Location = new System.Drawing.Point(12, 0);
            this.oy_label1.Name = "oy_label1";
            this.oy_label1.Size = new System.Drawing.Size(0, 29);
            this.oy_label1.TabIndex = 0;
            // 
            // oy_label2
            // 
            this.oy_label2.AutoSize = true;
            this.oy_label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.oy_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oy_label2.ForeColor = System.Drawing.Color.White;
            this.oy_label2.Location = new System.Drawing.Point(302, 0);
            this.oy_label2.Name = "oy_label2";
            this.oy_label2.Size = new System.Drawing.Size(0, 29);
            this.oy_label2.TabIndex = 7;
            // 
            // oy_MenuHeader
            // 
            this.oy_MenuHeader.BackColor = System.Drawing.Color.Gray;
            this.oy_MenuHeader.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.oy_MenuHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineChatToolStripMenuItem});
            this.oy_MenuHeader.Location = new System.Drawing.Point(0, 0);
            this.oy_MenuHeader.Name = "oy_MenuHeader";
            this.oy_MenuHeader.Padding = new System.Windows.Forms.Padding(0);
            this.oy_MenuHeader.Size = new System.Drawing.Size(600, 24);
            this.oy_MenuHeader.TabIndex = 1;
            this.oy_MenuHeader.Text = "menuStrip1";
            this.oy_MenuHeader.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.onlineChatMenuStrip_ItemClicked);
            this.oy_MenuHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onlineChatMenuStrip_MouseDown);
            // 
            // onlineChatToolStripMenuItem
            // 
            this.onlineChatToolStripMenuItem.Name = "onlineChatToolStripMenuItem";
            this.onlineChatToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.onlineChatToolStripMenuItem.Text = "OnlineChat_Yanovskyi48753";
            this.onlineChatToolStripMenuItem.Click += new System.EventHandler(this.onlineChatToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 430);
            this.Controls.Add(this.oy_button1);
            this.Controls.Add(this.oy_button2);
            this.Controls.Add(this.oy_MenuHeader);
            this.Controls.Add(this.oy_label2);
            this.Controls.Add(this.oy_label1);
            this.Controls.Add(this.oy_mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.oy_MenuHeader;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.oy_MenuHeader.ResumeLayout(false);
            this.oy_MenuHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button oy_button1;
        private System.Windows.Forms.Button oy_button2;
        private System.Windows.Forms.Panel oy_mainContainer;
        private System.Windows.Forms.Label oy_label1;
        private System.Windows.Forms.Label oy_label2;
        private System.Windows.Forms.MenuStrip oy_MenuHeader;
        private System.Windows.Forms.ToolStripMenuItem onlineChatToolStripMenuItem;
    }
}

