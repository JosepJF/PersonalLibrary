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
    public partial class AnimesForm : Form
    {
        public AnimesForm()
        {
            InitializeComponent();
            showAnimeLibrary("");
            OnlyVerticalScroll();
        }

        //Constructor Overloading for applicate filters
        public AnimesForm(string order)
        {
            InitializeComponent();
            showAnimeLibrary(order);
            OnlyVerticalScroll();
        }


        //Show animes registers
        private void showAnimeLibrary(string order)
        {

            int id = 0;
            TemplateHeadUC userControl1 = new TemplateHeadUC();
            flowLayoutPanel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Top;

            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Configuration.ConnectionString;
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM AnimesLibrary " + order, conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Image animeImage = Base64ToImage(reader.GetString(6));
                            AddAnimeUserControl(id, reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), animeImage, reader.GetInt32(0), reader.GetString(1));
                            id++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Change image format from base64 to image
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        //Create anime userControl
        private void AddAnimeUserControl(int id, string title, int score, string year, string state, Image image, int idDB, string type)
        {
            TemplateUC userControl = new TemplateUC();
            flowLayoutPanel2.Controls.Add(userControl);
            userControl.Dock = DockStyle.Top;
            userControl.SetID(id);
            userControl.SetTitle(title);
            userControl.SetScore(score);
            userControl.SetYear(year);
            userControl.SetState(state);
            userControl.SetImage(image);
            userControl.idDB = idDB;
            userControl.typeUC = type;
        }

        //Hide vertical scroll
        private void OnlyVerticalScroll()
        {
            flowLayoutPanel2.HorizontalScroll.Maximum = 0;
            flowLayoutPanel2.AutoScroll = false;
            flowLayoutPanel2.VerticalScroll.Visible = false;
            flowLayoutPanel2.AutoScroll = true;
        }
    }
}
