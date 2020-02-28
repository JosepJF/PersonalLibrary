using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibrary
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        private bool activeAnimeForm = false;
        private bool activeSeriesForm = false;
        private bool activeMoviesForm = false;
        private bool activesBooksForm = false;

        public MainForm()
        {
            InitializeComponent();
            setConfig();
            setColorConfig();
            Configuration.mainForm = this;
        }

        //Initialize ServerName and ConnectionString variables
        private void setConfig()
        {
            if ((File.Exists(Configuration.pathtxt)))
            {
                string[] lineas = File.ReadAllLines(Configuration.pathtxt);
                Configuration.ServerName = lineas[0];
                Configuration.ConnectionString = lineas[1];
            }
        }

        //Set the saved color in all necesary properties
        private void setColorConfig()
        {
            panelTop.BackColor = Properties.Settings.Default.FormBackColor1;
            panelBottom.BackColor = Properties.Settings.Default.FormBackColor1;
            buttonSeries.BackColor = Properties.Settings.Default.FormBackColor1;
            buttonMovies.BackColor = Properties.Settings.Default.FormBackColor1;
            buttonAnimes.BackColor = Properties.Settings.Default.FormBackColor1;
            buttonBooks.BackColor = Properties.Settings.Default.FormBackColor1;
            buttonChangeColor.BackColor = Properties.Settings.Default.FormBackColor1;
        }

        //Highlight the current session
        private void showButtonImage(PictureBox image)
        {
            //Hide all button images
            pictureBoxAnimesButton.Visible = false;
            pictureBoxSeriesButton.Visible = false;
            pictureBoxMoviesButton.Visible = false;
            pictureBoxBooksButton.Visible = false;
            image.Visible = true;

            //Show filter button
            buttonFilters.Visible = true;

            //Reset forms
            activeAnimeForm = false;
            activeMoviesForm = false;
            activeSeriesForm = false;
            activesBooksForm = false;
        }

        //Open new section Form
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelScreen.Controls.Add(childForm);
            panelScreen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Button Events

        public void buttonSeries_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            showButtonImage(pictureBoxSeriesButton);
            openChildForm(new SeriesForm());
            activeSeriesForm = true;
            if(panelMenuFilters.Visible == true) panelMenuFilters.Visible = false;
            Cursor.Current = Cursors.Default;
        }
        public void buttonMovies_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            showButtonImage(pictureBoxMoviesButton);
            openChildForm(new MovieForm());
            activeMoviesForm = true;
            if (panelMenuFilters.Visible == true) panelMenuFilters.Visible = false;
            Cursor.Current = Cursors.Default;
        }
        public void buttonAnimes_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            showButtonImage(pictureBoxAnimesButton);
            openChildForm(new AnimesForm());
            activeAnimeForm = true;
            if (panelMenuFilters.Visible == true) panelMenuFilters.Visible = false;
            Cursor.Current = Cursors.Default;
        }
        public void buttonBooks_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            showButtonImage(pictureBoxBooksButton);
            openChildForm(new BookForm());
            activesBooksForm = true;
            if (panelMenuFilters.Visible == true) panelMenuFilters.Visible = false;
            Cursor.Current = Cursors.Default;
        }

        //Show filters menu
        private void buttonFilters_Click(object sender, EventArgs e)
        {
            if (panelMenuFilters.Visible == true)
            {
                panelMenuFilters.Visible = false;
            }
            else
            {
                panelMenuFilters.Visible = true;
                panelMenuFilters.BringToFront();
            }
        }

        //Apply filters and reload the current section
        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            if (activeAnimeForm)
            {
                if (radioButtonTitle.Checked == true)
                {
                    openChildForm(new AnimesForm(" order by Title asc"));
                }
                if (radioButtonScore.Checked == true)
                {
                    openChildForm(new AnimesForm(" order by Score desc"));
                }
                if (radioButtonYear.Checked == true)
                {
                    openChildForm(new AnimesForm(" order by Year desc"));
                }
            }
            if (activeSeriesForm)
            {
                if (radioButtonTitle.Checked == true)
                {
                    openChildForm(new SeriesForm(" order by Title asc"));
                }
                if (radioButtonScore.Checked == true)
                {
                    openChildForm(new SeriesForm(" order by Score desc"));
                }
                if (radioButtonYear.Checked == true)
                {
                    openChildForm(new SeriesForm(" order by Year desc"));
                }
            }
            if (activeMoviesForm)
            {
                if (radioButtonTitle.Checked == true)
                {
                    openChildForm(new MovieForm(" order by Title asc"));
                }
                if (radioButtonScore.Checked == true)
                {
                    openChildForm(new MovieForm(" order by Score desc"));
                }
                if (radioButtonYear.Checked == true)
                {
                    openChildForm(new MovieForm(" order by Year desc"));
                }
            }
            if (activesBooksForm)
            {
                if (radioButtonTitle.Checked == true)
                {
                    openChildForm(new BookForm(" order by Title asc"));
                }
                if (radioButtonScore.Checked == true)
                {
                    openChildForm(new BookForm(" order by Score desc"));
                }
                if (radioButtonYear.Checked == true)
                {
                    openChildForm(new BookForm(" order by Year desc"));
                }
            }

            panelMenuFilters.Visible = false;
        }

        //Show the color palette and change it
        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            using (var color = new ColorDialog())
            {
                if (color.ShowDialog() == DialogResult.OK)
                {
                    panelTop.BackColor = Properties.Settings.Default.FormBackColor1 = color.Color;
                    panelBottom.BackColor = Properties.Settings.Default.FormBackColor1 = color.Color;
                    buttonSeries.BackColor = Properties.Settings.Default.FormBackColor1 = color.Color;
                    buttonMovies.BackColor = Properties.Settings.Default.FormBackColor1 = color.Color;
                    buttonAnimes.BackColor = Properties.Settings.Default.FormBackColor1 = color.Color;
                    buttonBooks.BackColor = Properties.Settings.Default.FormBackColor1 = color.Color;
                    buttonChangeColor.BackColor = Properties.Settings.Default.FormBackColor1 = color.Color;
                    Properties.Settings.Default.Save();
                }
            }
        }

        //Open add form
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.Show();
        }

        #endregion

        #region Other Events

        //Close the program
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Back in the main screen
        private void panelTop_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxAnimesButton.Visible = false;
            pictureBoxSeriesButton.Visible = false;
            pictureBoxMoviesButton.Visible = false;
            pictureBoxBooksButton.Visible = false;

            if (activeForm != null)
            {
                activeAnimeForm = false;
                activeMoviesForm = false;
                activeSeriesForm = false;
                activesBooksForm = false;

                buttonFilters.Visible = false;
                panelMenuFilters.Visible = false;
                activeForm.Close();
            }
        }

        #endregion
    }
}
