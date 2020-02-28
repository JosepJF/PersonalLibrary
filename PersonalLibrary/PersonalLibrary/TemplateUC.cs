using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibrary
{
    public partial class TemplateUC : UserControl
    {
        public int idDB;
        public string typeUC;

        public TemplateUC()
        {
            InitializeComponent();
        }

        #region Set Properties

        public void SetID(int id)
        {
            labelID.Text = id.ToString();
        }
        public void SetTitle(string title)
        {
            labelAnimeTitle.Text = title;
        }
        public void SetScore(int score)
        {
            labelScore.Text = score.ToString();
        }
        public void SetYear(string year)
        {
            labelYear.Text = year;
        }
        public void SetState(string state)
        {
            labelState.Text = state;
        }
        public void SetImage(Image image)
        {
            pictureBoxImage.Image = image;
        }

        #endregion

        //Open edit menu
        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.inEdit = true;
            addForm.SetID(idDB);
            addForm.SetType(typeUC);
            addForm.SetTitle(labelAnimeTitle.Text);
            addForm.SetScore(Convert.ToInt32(labelScore.Text));
            addForm.SetImage(pictureBoxImage.Image);
            addForm.SetYear(labelYear.Text);
            addForm.SetState(labelState.Text);
            addForm.Show();

            Configuration.mainForm.Enabled = false;
        }
    }
}
