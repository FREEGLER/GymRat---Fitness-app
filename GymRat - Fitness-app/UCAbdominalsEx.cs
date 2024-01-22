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
    public partial class UCAbdominalsEx : UserControl
    {
        public UCAbdominalsEx()
        {
            InitializeComponent();
        }

        public event EventHandler OpenAnotherUserControl;

        private void btnSpidermanPlankCrunch_Click(object sender, EventArgs e)
        {
            OpenAnotherUserControl?.Invoke(this, EventArgs.Empty);
        }

        private void btnModifiedVUps_Click(object sender, EventArgs e)
        {
            OpenAnotherUserControl?.Invoke(this, EventArgs.Empty);
        }
    }
}
