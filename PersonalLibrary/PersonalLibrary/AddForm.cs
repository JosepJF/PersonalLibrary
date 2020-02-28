using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibrary
{
    public partial class AddForm : Form
    {
        private string path64base;
        private Image image;

        public Image imageRef = null;
        public bool inEdit = false;
        public int id = 0;
        public int score = 0;
        public string year = "";

        public AddForm()
        {
            InitializeComponent();
        }

        #region Set Properties

        public void SetID(int id)
        {
            labelID.Text = id.ToString();
        }

        public void SetType(string type)
        {
            if (type == "SERIE") comboBoxType.SelectedIndex = 0;
            if (type == "MOVIE") comboBoxType.SelectedIndex = 1;
            if (type == "ANIME") comboBoxType.SelectedIndex = 2;
            if (type == "BOOK") comboBoxType.SelectedIndex = 3;
            comboBoxType.Enabled = false;
        }
        public void SetTitle(string title)
        {
            textBoxTitle.Text = title;
        }
        public void SetScore(int score)
        {
            numericUpDownScore.Value = score;
        }
        public void SetYear(string year)
        {
            textBoxYear.Text = year;
        }
        public void SetState(string state)
        {
            comboBoxState.Text = state;
        }
        public void SetImage(Image image)
        {
            pictureBoxImage.Image = image;
        }

        #endregion

        #region Button Events

        //Choose and upload an image
        private void button_ChangeImage(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImage = new OpenFileDialog();
            openFileDialogImage.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";

            try
            {
                if (openFileDialogImage.ShowDialog() == DialogResult.OK)
                {
                    path64base = openFileDialogImage.FileName;
                    pictureBoxImage.Image = Image.FromFile(path64base);
                    image = pictureBoxImage.Image;
                    openFileDialogImage.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid format");
            }
        }

        //Insert new registry or update/edit current registry
        private void buttonApply_Click(object sender, EventArgs e)
        {
            //------------------------------------------------- NEW REGISTRY -----------------------------------------------------//
            if (inEdit == false)
            {
                //Mandatory requirements
                if (pictureBoxImage.Image != null && textBoxTitle.Text != "" && comboBoxType.Text != "")
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection())
                        {
                            conn.ConnectionString = Configuration.ConnectionString;
                            conn.Open();
                            SqlCommand insertCommand;
                            string image64 = ImageToBase64(path64base);

                            if (comboBoxType.Text == "SERIE")
                            {
                                insertCommand = new SqlCommand("INSERT INTO SeriesLibrary (Type, Title, Score, Year, State, Image) " +
                                                                "VALUES (@Type, @Title, @Score, @Year, @State, @Image)", conn);
                                insertCommand.Parameters.Add(new SqlParameter("Type", comboBoxType.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Title", textBoxTitle.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Score", (int)numericUpDownScore.Value));
                                insertCommand.Parameters.Add(new SqlParameter("Year", textBoxYear.Text));
                                insertCommand.Parameters.Add(new SqlParameter("State", comboBoxState.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Image", image64));
                                insertCommand.ExecuteNonQuery();
                                this.Close();
                                Configuration.mainForm.buttonSeries_Click(sender, e);
                            }
                            else if (comboBoxType.Text == "MOVIE")
                            {
                                insertCommand = new SqlCommand("INSERT INTO MoviesLibrary (Type, Title, Score, Year, State, Image) " +
                                "VALUES (@Type, @Title, @Score, @Year, @State, @Image)", conn);
                                insertCommand.Parameters.Add(new SqlParameter("Type", comboBoxType.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Title", textBoxTitle.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Score", (int)numericUpDownScore.Value));
                                insertCommand.Parameters.Add(new SqlParameter("Year", textBoxYear.Text));
                                insertCommand.Parameters.Add(new SqlParameter("State", comboBoxState.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Image", image64));
                                insertCommand.ExecuteNonQuery();
                                this.Close();
                                Configuration.mainForm.buttonMovies_Click(sender, e);
                            }
                            else if (comboBoxType.Text == "ANIME")
                            {
                                insertCommand = new SqlCommand("INSERT INTO AnimesLibrary (Type, Title, Score, Year, State, Image) " +
                                "VALUES (@Type, @Title, @Score, @Year, @State, @Image)", conn);
                                insertCommand.Parameters.Add(new SqlParameter("Type", comboBoxType.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Title", textBoxTitle.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Score", (int)numericUpDownScore.Value));
                                insertCommand.Parameters.Add(new SqlParameter("Year", textBoxYear.Text));
                                insertCommand.Parameters.Add(new SqlParameter("State", comboBoxState.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Image", image64));
                                insertCommand.ExecuteNonQuery();
                                this.Close();
                                Configuration.mainForm.buttonAnimes_Click(sender, e);
                            }
                            else
                            {
                                //comboBoxType.Text == "BOOK"
                                insertCommand = new SqlCommand("INSERT INTO BooksLibrary (Type, Title, Score, Year, State, Image) " +
                                "VALUES (@Type, @Title, @Score, @Year, @State, @Image)", conn);
                                insertCommand.Parameters.Add(new SqlParameter("Type", comboBoxType.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Title", textBoxTitle.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Score", (int)numericUpDownScore.Value));
                                insertCommand.Parameters.Add(new SqlParameter("Year", textBoxYear.Text));
                                insertCommand.Parameters.Add(new SqlParameter("State", comboBoxState.Text));
                                insertCommand.Parameters.Add(new SqlParameter("Image", image64));
                                insertCommand.ExecuteNonQuery();
                                this.Close();
                                Configuration.mainForm.buttonBooks_Click(sender, e);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (pictureBoxImage.Image == null)
                    {
                        MessageBox.Show("Select image please");
                    }
                    else if (textBoxTitle.Text == "")
                    {
                        MessageBox.Show("Write title please");
                    }
                    else
                    {
                        MessageBox.Show("Select type please");
                    }
                }
            }
            //------------------------------------------------- EDIT REGISTRY -----------------------------------------------------//
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = Configuration.ConnectionString;
                        conn.Open();

                        if (comboBoxType.Text == "SERIE")
                        {
                            string comand = "UPDATE SeriesLibrary SET Title = @title, Score = @score, Year = @year, State = @state";
                            if (path64base != null)
                            {
                                comand += ", Image = @image Where ID = @id";
                            }
                            else
                            {
                                comand += " Where ID = @id";
                            }
                            SqlCommand updateCommand = new SqlCommand(comand, conn);
                            updateCommand.Parameters.AddWithValue("@id", labelID.Text);
                            updateCommand.Parameters.AddWithValue("@title", textBoxTitle.Text);
                            updateCommand.Parameters.AddWithValue("@score", numericUpDownScore.Value);
                            updateCommand.Parameters.AddWithValue("@year", textBoxYear.Text);
                            updateCommand.Parameters.AddWithValue("@state", comboBoxState.Text);
                            if (path64base != null)
                            {
                                string newImage64base = ImageToBase64(path64base);
                                updateCommand.Parameters.AddWithValue("@image", newImage64base);
                            }
                            updateCommand.ExecuteNonQuery();
                            this.Close();
                            Configuration.mainForm.buttonSeries_Click(sender, e);
                        }
                        else if (comboBoxType.Text == "MOVIE")
                        {
                            string comand = "UPDATE MoviesLibrary SET Title = @title, Score = @score, Year = @year, State = @state";
                            if (path64base != null)
                            {
                                comand += ", Image = @image Where ID = @id";
                            }
                            else
                            {
                                comand += " Where ID = @id";
                            }
                            SqlCommand updateCommand = new SqlCommand(comand, conn);
                            updateCommand.Parameters.AddWithValue("@id", labelID.Text);
                            updateCommand.Parameters.AddWithValue("@title", textBoxTitle.Text);
                            updateCommand.Parameters.AddWithValue("@score", numericUpDownScore.Value);
                            updateCommand.Parameters.AddWithValue("@year", textBoxYear.Text);
                            updateCommand.Parameters.AddWithValue("@state", comboBoxState.Text);
                            if (path64base != null)
                            {
                                string newImage64base = ImageToBase64(path64base);
                                updateCommand.Parameters.AddWithValue("@image", newImage64base);
                            }
                            updateCommand.ExecuteNonQuery();
                            this.Close();
                            Configuration.mainForm.buttonMovies_Click(sender, e);
                        }
                        else if (comboBoxType.Text == "ANIME")
                        {
                            string comand = "UPDATE AnimesLibrary SET Title = @title, Score = @score, Year = @year, State = @state";
                            if (path64base != null)
                            {
                                comand += ", Image = @image Where ID = @id";
                            }
                            else
                            {
                                comand += " Where ID = @id";
                            }
                            SqlCommand updateCommand = new SqlCommand(comand, conn);
                            updateCommand.Parameters.AddWithValue("@id", labelID.Text);
                            updateCommand.Parameters.AddWithValue("@title", textBoxTitle.Text);
                            updateCommand.Parameters.AddWithValue("@score", numericUpDownScore.Value);
                            updateCommand.Parameters.AddWithValue("@year", textBoxYear.Text);
                            updateCommand.Parameters.AddWithValue("@state", comboBoxState.Text);
                            if (path64base != null)
                            {
                                string newImage64base = ImageToBase64(path64base);
                                updateCommand.Parameters.AddWithValue("@image", newImage64base);
                            }
                            updateCommand.ExecuteNonQuery();
                            this.Close();
                            Configuration.mainForm.buttonAnimes_Click(sender, e);
                        }
                        else // "BOOK"
                        {
                            string comand = "UPDATE BooksLibrary SET Title = @title, Score = @score, Year = @year, State = @state";
                            if (path64base != null)
                            {
                                comand += ", Image = @image Where ID = @id";
                            }
                            else
                            {
                                comand += " Where ID = @id";
                            }
                            SqlCommand updateCommand = new SqlCommand(comand, conn);
                            updateCommand.Parameters.AddWithValue("@id", labelID.Text);
                            updateCommand.Parameters.AddWithValue("@title", textBoxTitle.Text);
                            updateCommand.Parameters.AddWithValue("@score", numericUpDownScore.Value);
                            updateCommand.Parameters.AddWithValue("@year", textBoxYear.Text);
                            updateCommand.Parameters.AddWithValue("@state", comboBoxState.Text);
                            if (path64base != null)
                            {
                                string newImage64base = ImageToBase64(path64base);
                                updateCommand.Parameters.AddWithValue("@image", newImage64base);
                            }
                            updateCommand.ExecuteNonQuery();
                            this.Close();
                            Configuration.mainForm.buttonBooks_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Close Add Form
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Delete a current registry
        private void buttonRemove_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "DELETE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = Configuration.ConnectionString;
                        conn.Open();
                        SqlCommand deleteCommnad = new SqlCommand("", conn);

                        if (comboBoxType.Text == "SERIE")
                        {
                            deleteCommnad.CommandText = "DELETE from SeriesLibrary where ID = @id";
                            deleteCommnad.Parameters.AddWithValue("@id", labelID.Text);
                            deleteCommnad.ExecuteNonQuery();
                            MessageBox.Show("Deleted correctly");
                            this.Close();
                            Configuration.mainForm.buttonSeries_Click(sender, e);
                        }
                        if (comboBoxType.Text == "MOVIE")
                        {
                            deleteCommnad.CommandText = "DELETE from MoviesLibrary where ID = @id";
                            deleteCommnad.Parameters.AddWithValue("@id", labelID.Text);
                            deleteCommnad.ExecuteNonQuery();
                            MessageBox.Show("Deleted correctly");
                            this.Close();
                            Configuration.mainForm.buttonMovies_Click(sender, e);
                        }
                        if (comboBoxType.Text == "ANIME")
                        {
                            deleteCommnad.CommandText = "DELETE from AnimesLibrary where ID = @id";
                            deleteCommnad.Parameters.AddWithValue("@id", labelID.Text);
                            deleteCommnad.ExecuteNonQuery();
                            MessageBox.Show("Deleted correctly");
                            this.Close();
                            Configuration.mainForm.buttonAnimes_Click(sender, e);
                        }
                        if (comboBoxType.Text == "BOOK")
                        {
                            deleteCommnad.CommandText = "DELETE from BooksLibrary where ID = @id";
                            deleteCommnad.Parameters.AddWithValue("@id", labelID.Text);
                            deleteCommnad.ExecuteNonQuery();
                            MessageBox.Show("Deleted correctly");
                            this.Close();
                            Configuration.mainForm.buttonBooks_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        #region Other Events

        //Show delete button if user editing registry
        private void AddForm_Shown(object sender, EventArgs e)
        {
            if (inEdit == true)
            {
                buttonRemove.Visible = true;
            }
        }

        //Enable main form when close add form
        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inEdit) Configuration.mainForm.Enabled = true;
        }

        //Change the comboBoxState depending on the current section (Book, Movie or Serie/Anime)
        private void comboBoxType_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "BOOK")
            {
                comboBoxState.Items.Clear();
                comboBoxState.Items.Add("Read");
                comboBoxState.Items.Add("Reading");
                comboBoxState.Items.Add("Plan to read");
            }
            else if (comboBoxType.Text == "MOVIE")
            {
                comboBoxState.Items.Clear();
                comboBoxState.Items.Add("Watching");
                comboBoxState.Items.Add("Watched");
                comboBoxState.Items.Add("Plan to watch");
            }
            else
            {
                //Serir or Anime section
                comboBoxState.Items.Clear();
                comboBoxState.Items.Add("Watching");
                comboBoxState.Items.Add("Completed");
                comboBoxState.Items.Add("Plan to watch");
            }
        }

        #endregion

        //Convert image in base64 format
        public string ImageToBase64(string path)
        {
            string imagePath = path;
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }
    }
}
