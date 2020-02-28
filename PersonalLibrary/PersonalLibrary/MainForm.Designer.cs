namespace PersonalLibrary
{
    partial class MainForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonMovies = new System.Windows.Forms.Button();
            this.buttonSeries = new System.Windows.Forms.Button();
            this.buttonAnimes = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonFilters = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelMenuFilters = new System.Windows.Forms.Panel();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.radioButtonScore = new System.Windows.Forms.RadioButton();
            this.radioButtonTitle = new System.Windows.Forms.RadioButton();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.pictureBoxAnimesButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxBooksButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoviesButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxSeriesButton = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelMenuFilters.SuspendLayout();
            this.panelScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooksButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoviesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeriesButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTop.Controls.Add(this.pictureBoxAnimesButton);
            this.panelTop.Controls.Add(this.pictureBoxBooksButton);
            this.panelTop.Controls.Add(this.pictureBoxMoviesButton);
            this.panelTop.Controls.Add(this.pictureBoxSeriesButton);
            this.panelTop.Controls.Add(this.buttonBooks);
            this.panelTop.Controls.Add(this.buttonMovies);
            this.panelTop.Controls.Add(this.buttonSeries);
            this.panelTop.Controls.Add(this.buttonAnimes);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1022, 57);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseClick);
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBooks.FlatAppearance.BorderSize = 0;
            this.buttonBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooks.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBooks.Location = new System.Drawing.Point(671, 3);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(166, 54);
            this.buttonBooks.TabIndex = 2;
            this.buttonBooks.Text = "BOOKS";
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonMovies
            // 
            this.buttonMovies.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonMovies.FlatAppearance.BorderSize = 0;
            this.buttonMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMovies.ForeColor = System.Drawing.Color.White;
            this.buttonMovies.Location = new System.Drawing.Point(348, 3);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Size = new System.Drawing.Size(166, 54);
            this.buttonMovies.TabIndex = 2;
            this.buttonMovies.Text = "MOVIES";
            this.buttonMovies.UseVisualStyleBackColor = false;
            this.buttonMovies.Click += new System.EventHandler(this.buttonMovies_Click);
            // 
            // buttonSeries
            // 
            this.buttonSeries.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSeries.FlatAppearance.BorderSize = 0;
            this.buttonSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeries.ForeColor = System.Drawing.Color.White;
            this.buttonSeries.Location = new System.Drawing.Point(184, 3);
            this.buttonSeries.Name = "buttonSeries";
            this.buttonSeries.Size = new System.Drawing.Size(166, 54);
            this.buttonSeries.TabIndex = 2;
            this.buttonSeries.Text = "SERIES";
            this.buttonSeries.UseVisualStyleBackColor = false;
            this.buttonSeries.Click += new System.EventHandler(this.buttonSeries_Click);
            // 
            // buttonAnimes
            // 
            this.buttonAnimes.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAnimes.FlatAppearance.BorderSize = 0;
            this.buttonAnimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnimes.ForeColor = System.Drawing.Color.White;
            this.buttonAnimes.Location = new System.Drawing.Point(508, 3);
            this.buttonAnimes.Name = "buttonAnimes";
            this.buttonAnimes.Size = new System.Drawing.Size(166, 54);
            this.buttonAnimes.TabIndex = 0;
            this.buttonAnimes.Text = "ANIMES";
            this.buttonAnimes.UseVisualStyleBackColor = false;
            this.buttonAnimes.Click += new System.EventHandler(this.buttonAnimes_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelBottom.Controls.Add(this.buttonChangeColor);
            this.panelBottom.Controls.Add(this.buttonFilters);
            this.panelBottom.Controls.Add(this.buttonAdd);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 601);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1022, 57);
            this.panelBottom.TabIndex = 1;
            // 
            // buttonFilters
            // 
            this.buttonFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilters.FlatAppearance.BorderSize = 0;
            this.buttonFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilters.ForeColor = System.Drawing.Color.White;
            this.buttonFilters.Location = new System.Drawing.Point(766, 6);
            this.buttonFilters.Name = "buttonFilters";
            this.buttonFilters.Size = new System.Drawing.Size(148, 39);
            this.buttonFilters.TabIndex = 1;
            this.buttonFilters.Text = "FILTERS";
            this.buttonFilters.UseVisualStyleBackColor = true;
            this.buttonFilters.Visible = false;
            this.buttonFilters.Click += new System.EventHandler(this.buttonFilters_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(932, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(68, 39);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // panelMenuFilters
            // 
            this.panelMenuFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuFilters.Controls.Add(this.buttonApplyFilters);
            this.panelMenuFilters.Controls.Add(this.radioButtonYear);
            this.panelMenuFilters.Controls.Add(this.radioButtonScore);
            this.panelMenuFilters.Controls.Add(this.radioButtonTitle);
            this.panelMenuFilters.Location = new System.Drawing.Point(758, 361);
            this.panelMenuFilters.Name = "panelMenuFilters";
            this.panelMenuFilters.Size = new System.Drawing.Size(156, 177);
            this.panelMenuFilters.TabIndex = 0;
            this.panelMenuFilters.Visible = false;
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonApplyFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyFilters.ForeColor = System.Drawing.Color.White;
            this.buttonApplyFilters.Location = new System.Drawing.Point(0, 146);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(154, 29);
            this.buttonApplyFilters.TabIndex = 3;
            this.buttonApplyFilters.Text = "Apply";
            this.buttonApplyFilters.UseVisualStyleBackColor = false;
            this.buttonApplyFilters.Click += new System.EventHandler(this.buttonApplyFilters_Click);
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYear.ForeColor = System.Drawing.Color.White;
            this.radioButtonYear.Location = new System.Drawing.Point(16, 100);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(125, 24);
            this.radioButtonYear.TabIndex = 2;
            this.radioButtonYear.TabStop = true;
            this.radioButtonYear.Text = "Order by Year";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            // 
            // radioButtonScore
            // 
            this.radioButtonScore.AutoSize = true;
            this.radioButtonScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonScore.ForeColor = System.Drawing.Color.White;
            this.radioButtonScore.Location = new System.Drawing.Point(16, 57);
            this.radioButtonScore.Name = "radioButtonScore";
            this.radioButtonScore.Size = new System.Drawing.Size(133, 24);
            this.radioButtonScore.TabIndex = 1;
            this.radioButtonScore.TabStop = true;
            this.radioButtonScore.Text = "Order by Score";
            this.radioButtonScore.UseVisualStyleBackColor = true;
            // 
            // radioButtonTitle
            // 
            this.radioButtonTitle.AutoSize = true;
            this.radioButtonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTitle.ForeColor = System.Drawing.Color.White;
            this.radioButtonTitle.Location = new System.Drawing.Point(16, 16);
            this.radioButtonTitle.Name = "radioButtonTitle";
            this.radioButtonTitle.Size = new System.Drawing.Size(120, 24);
            this.radioButtonTitle.TabIndex = 0;
            this.radioButtonTitle.TabStop = true;
            this.radioButtonTitle.Text = "Order by Ttile";
            this.radioButtonTitle.UseVisualStyleBackColor = true;
            // 
            // panelScreen
            // 
            this.panelScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.panelScreen.Controls.Add(this.panelMenuFilters);
            this.panelScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScreen.Location = new System.Drawing.Point(0, 57);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(1022, 544);
            this.panelScreen.TabIndex = 2;
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeColor.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonChangeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonChangeColor.FlatAppearance.BorderSize = 0;
            this.buttonChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChangeColor.Image = global::PersonalLibrary.Properties.Resources.ColorButtonIconSmall;
            this.buttonChangeColor.Location = new System.Drawing.Point(5, 2);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(45, 51);
            this.buttonChangeColor.TabIndex = 1;
            this.buttonChangeColor.UseVisualStyleBackColor = false;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // pictureBoxAnimesButton
            // 
            this.pictureBoxAnimesButton.BackColor = System.Drawing.Color.White;
            this.pictureBoxAnimesButton.Location = new System.Drawing.Point(508, 52);
            this.pictureBoxAnimesButton.Name = "pictureBoxAnimesButton";
            this.pictureBoxAnimesButton.Size = new System.Drawing.Size(166, 5);
            this.pictureBoxAnimesButton.TabIndex = 1;
            this.pictureBoxAnimesButton.TabStop = false;
            this.pictureBoxAnimesButton.Visible = false;
            // 
            // pictureBoxBooksButton
            // 
            this.pictureBoxBooksButton.BackColor = System.Drawing.Color.White;
            this.pictureBoxBooksButton.Location = new System.Drawing.Point(671, 52);
            this.pictureBoxBooksButton.Name = "pictureBoxBooksButton";
            this.pictureBoxBooksButton.Size = new System.Drawing.Size(166, 5);
            this.pictureBoxBooksButton.TabIndex = 3;
            this.pictureBoxBooksButton.TabStop = false;
            this.pictureBoxBooksButton.Visible = false;
            // 
            // pictureBoxMoviesButton
            // 
            this.pictureBoxMoviesButton.BackColor = System.Drawing.Color.White;
            this.pictureBoxMoviesButton.Location = new System.Drawing.Point(348, 52);
            this.pictureBoxMoviesButton.Name = "pictureBoxMoviesButton";
            this.pictureBoxMoviesButton.Size = new System.Drawing.Size(166, 5);
            this.pictureBoxMoviesButton.TabIndex = 3;
            this.pictureBoxMoviesButton.TabStop = false;
            this.pictureBoxMoviesButton.Visible = false;
            // 
            // pictureBoxSeriesButton
            // 
            this.pictureBoxSeriesButton.BackColor = System.Drawing.Color.White;
            this.pictureBoxSeriesButton.Location = new System.Drawing.Point(184, 52);
            this.pictureBoxSeriesButton.Name = "pictureBoxSeriesButton";
            this.pictureBoxSeriesButton.Size = new System.Drawing.Size(166, 5);
            this.pictureBoxSeriesButton.TabIndex = 3;
            this.pictureBoxSeriesButton.TabStop = false;
            this.pictureBoxSeriesButton.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::PersonalLibrary.Properties.Settings.Default.FormBackColor1;
            this.ClientSize = new System.Drawing.Size(1022, 658);
            this.Controls.Add(this.panelScreen);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::PersonalLibrary.Properties.Settings.Default, "FormBackColor1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelMenuFilters.ResumeLayout(false);
            this.panelMenuFilters.PerformLayout();
            this.panelScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooksButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoviesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeriesButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox pictureBoxAnimesButton;
        private System.Windows.Forms.Button buttonAnimes;
        private System.Windows.Forms.PictureBox pictureBoxBooksButton;
        private System.Windows.Forms.PictureBox pictureBoxMoviesButton;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.PictureBox pictureBoxSeriesButton;
        private System.Windows.Forms.Button buttonMovies;
        private System.Windows.Forms.Button buttonSeries;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFilters;
        private System.Windows.Forms.Panel panelMenuFilters;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.RadioButton radioButtonScore;
        private System.Windows.Forms.RadioButton radioButtonTitle;
        private System.Windows.Forms.Panel panelScreen;
        private System.Windows.Forms.Button buttonChangeColor;
    }
}

