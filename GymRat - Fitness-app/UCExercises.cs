using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymRat___Fitness_app
{
    public partial class UCExercises : UserControl
    {
        public UCExercises()
        {
            InitializeComponent();
            picbxFrontBonesImage.Controls.Add(picbxTibialisAnteriorFrontImage);
            picbxTibialisAnteriorFrontImage.Location = new Point(91, 385);
            picbxTibialisAnteriorFrontImage.BackColor = Color.Transparent;
            picbxFrontBonesImage.Controls.Add(picbxQuadricepsFrontImage);
            picbxQuadricepsFrontImage.Location = new Point(85, 240);
            picbxQuadricepsFrontImage.BackColor = Color.Transparent;
            picbxFrontBonesImage.Controls.Add(picbxAbdominalsFrontImage);
            picbxAbdominalsFrontImage.Location = new Point(101, 125);
            picbxAbdominalsFrontImage.BackColor = Color.Transparent;
            //86; 328
            //97; 75


        }
        public event EventHandler OpenAnotherUserControl;


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picbxQuadricepsFrontImage_Click(object sender, EventArgs e)
        {
            label1.Text = "Dat werkt";
        }

        private void picbxTibialisAnteriorFrontImage_Click(object sender, EventArgs e)
        {
            label1.Text = "Dat werkt ook!";
        }

        private void UCExercises_Load(object sender, EventArgs e)
        {

        }

        private void picbxAbdominalsFrontImage_Click(object sender, EventArgs e)
        {
            OpenAnotherUserControl?.Invoke(this, EventArgs.Empty);
        }
    }
}
