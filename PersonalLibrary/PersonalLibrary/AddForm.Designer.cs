namespace PersonalLibrary
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonChangeImage = new System.Windows.Forms.Button();
            this.numericUpDownScore = new System.Windows.Forms.NumericUpDown();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labeltitle = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(344, 198);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 1;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(632, 223);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(156, 34);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(464, 223);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(156, 34);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonChangeImage
            // 
            this.buttonChangeImage.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeImage.ForeColor = System.Drawing.Color.White;
            this.buttonChangeImage.Location = new System.Drawing.Point(102, 223);
            this.buttonChangeImage.Name = "buttonChangeImage";
            this.buttonChangeImage.Size = new System.Drawing.Size(156, 34);
            this.buttonChangeImage.TabIndex = 5;
            this.buttonChangeImage.Text = "Select image";
            this.buttonChangeImage.UseVisualStyleBackColor = false;
            this.buttonChangeImage.Click += new System.EventHandler(this.button_ChangeImage);
            // 
            // numericUpDownScore
            // 
            this.numericUpDownScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownScore.Location = new System.Drawing.Point(448, 100);
            this.numericUpDownScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownScore.Name = "numericUpDownScore";
            this.numericUpDownScore.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownScore.TabIndex = 2;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(448, 132);
            this.textBoxYear.MaxLength = 4;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(293, 26);
            this.textBoxYear.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(448, 67);
            this.textBoxTitle.MaxLength = 100;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(293, 26);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.White;
            this.labelYear.Location = new System.Drawing.Point(383, 138);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(47, 20);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "Year:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(383, 102);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(55, 20);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "Score:";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(383, 70);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(42, 20);
            this.labeltitle.TabIndex = 7;
            this.labeltitle.Text = "Title:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "SERIE",
            "MOVIE",
            "ANIME",
            "BOOK"});
            this.comboBoxType.Location = new System.Drawing.Point(448, 33);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 28);
            this.comboBoxType.TabIndex = 0;
            this.comboBoxType.TextChanged += new System.EventHandler(this.comboBoxType_TextChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(383, 36);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(47, 20);
            this.labelType.TabIndex = 14;
            this.labelType.Text = "Type:";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Crimson;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(700, 12);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(88, 34);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Visible = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.Color.White;
            this.labelState.Location = new System.Drawing.Point(383, 167);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(52, 20);
            this.labelState.TabIndex = 17;
            this.labelState.Text = "State:";
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "Watching",
            "Completed",
            "Plan to watch"});
            this.comboBoxState.Location = new System.Drawing.Point(448, 164);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 28);
            this.comboBoxState.TabIndex = 4;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(770, 197);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "ID";
            this.labelID.Visible = false;
            // 
            // AddForm
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(800, 271);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.numericUpDownScore);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.buttonChangeImage);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.pictureBoxImage);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing);
            this.Shown += new System.EventHandler(this.AddForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonChangeImage;
        private System.Windows.Forms.NumericUpDown numericUpDownScore;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label labelID;
    }
}