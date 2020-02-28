namespace PersonalLibrary
{
    partial class TemplateUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelAnimeTitle = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(54, 5);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(348, 192);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 5;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(5, 2);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 198);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "0";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAnimeTitle
            // 
            this.labelAnimeTitle.AutoSize = true;
            this.labelAnimeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAnimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnimeTitle.ForeColor = System.Drawing.Color.White;
            this.labelAnimeTitle.Location = new System.Drawing.Point(410, 2);
            this.labelAnimeTitle.Name = "labelAnimeTitle";
            this.labelAnimeTitle.Size = new System.Drawing.Size(253, 198);
            this.labelAnimeTitle.TabIndex = 2;
            this.labelAnimeTitle.Text = "Anime title";
            this.labelAnimeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(671, 2);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(253, 198);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.White;
            this.labelYear.Location = new System.Drawing.Point(932, 2);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(135, 198);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "0";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.509695F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.32272F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52031F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.72844F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.312188F));
            this.tableLayoutPanel1.Controls.Add(this.labelYear, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelScore, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAnimeTitle, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxImage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonEdit, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelState, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1362, 202);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonEdit.Location = new System.Drawing.Point(1275, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(82, 192);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(1075, 2);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(192, 198);
            this.labelState.TabIndex = 8;
            this.labelState.Text = "State";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemplateUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TemplateUC";
            this.Size = new System.Drawing.Size(1362, 202);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelAnimeTitle;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelState;
    }
}
