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
    public partial class UCWorkOut : UserControl
    {
        public UCWorkOut()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }


        private void UCWorkOut_Load(object sender, EventArgs e)
        {

        }

        private void pnlMondayPlan_Click(object sender, EventArgs e)
        {
            UCCloseAll();
            flwlpMondayPlan.Show();
        }
        public void UCCloseAll()
        {
            flowLayoutPanel1.Hide();
            flwlpMondayPlan.Hide();
            flowLayoutPanel2.Hide();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //metahScrollBar1.Value
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            UCCloseAll();
            flowLayoutPanel2.Show();
            timer1.Start();

        }

        private int CalculateEXPPerTraining()
        {
            int expPerSecond = 5; // Set this to your desired EXP per second value
            int trainingTimeInSeconds = (int)timer1.Interval / 1000; // Convert the timer interval to seconds
            int totalCountOfReps = 10; // Set this to your desired total count of reps

            int expPerTraining = expPerSecond * trainingTimeInSeconds * totalCountOfReps;
            return expPerTraining;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pnlExercises.Hide();
            pnlEnd.Show();
            progressBar1.Value = 100;

        }

        private void tbxNumberOfReps_TextChanged(object sender, EventArgs e)
        {
            if (tbxNumberOfReps.Text != null)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCCloseAll();
            flowLayoutPanel1.Show();
        }

        
    }
}
    