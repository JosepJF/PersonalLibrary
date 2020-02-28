namespace PersonalLibrary
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelServerName = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxServers = new System.Windows.Forms.ComboBox();
            this.buttonChargeServers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(466, 79);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonalLibrary.Properties.Resources.IconoPl;
            this.pictureBox1.Location = new System.Drawing.Point(99, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "PERSONAL LIBRARY ";
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerName.ForeColor = System.Drawing.Color.White;
            this.labelServerName.Location = new System.Drawing.Point(13, 24);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(103, 20);
            this.labelServerName.TabIndex = 16;
            this.labelServerName.Text = "Server name:";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(158, 73);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(156, 34);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Text = "CONNECT";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxServers
            // 
            this.comboBoxServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServers.FormattingEnabled = true;
            this.comboBoxServers.Location = new System.Drawing.Point(122, 21);
            this.comboBoxServers.Name = "comboBoxServers";
            this.comboBoxServers.Size = new System.Drawing.Size(299, 28);
            this.comboBoxServers.TabIndex = 15;
            // 
            // buttonChargeServers
            // 
            this.buttonChargeServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.buttonChargeServers.FlatAppearance.BorderSize = 0;
            this.buttonChargeServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChargeServers.Image = global::PersonalLibrary.Properties.Resources.IconoDB1;
            this.buttonChargeServers.Location = new System.Drawing.Point(425, 21);
            this.buttonChargeServers.Name = "buttonChargeServers";
            this.buttonChargeServers.Size = new System.Drawing.Size(28, 28);
            this.buttonChargeServers.TabIndex = 18;
            this.buttonChargeServers.UseVisualStyleBackColor = false;
            this.buttonChargeServers.Click += new System.EventHandler(this.buttonChargeServers_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxServers);
            this.panel1.Controls.Add(this.buttonChargeServers);
            this.panel1.Controls.Add(this.labelServerName);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 133);
            this.panel1.TabIndex = 19;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(466, 212);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxServers;
        private System.Windows.Forms.Button buttonChargeServers;
        private System.Windows.Forms.Panel panel1;
    }
}