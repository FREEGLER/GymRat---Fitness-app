using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymRat___Fitness_app
{
    public partial class Form1 : Form
    {
        bool sidebarExpand = true;


        public Form1()
        {
            InitializeComponent();
            ucExercises1.OpenAnotherUserControl += OpenUCAbdominalsEX;
            ucAbdominalsEx1.OpenAnotherUserControl += OpenUCWorkOutEX;
        }


        private void OpenUCAbdominalsEX(object sender, EventArgs e)
        {
            UCCloseAll();
            CloseCurtain();
            this.ucAbdominalsEx1.Show();
        }

        private void OpenUCWorkOutEX(object sender, EventArgs e)
        {
            UCCloseAll();
            CloseCurtain();
            this.ucWorkOut1.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        
        //Animatie voor de menu
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) 
            {
                flypSidebar.Width -= 10;
                if (flypSidebar.Width == flypSidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                flypSidebar.Width += 10;
                if (flypSidebar.Width == flypSidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }

        }

        public  void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        public static void CuritainClose(object selectedItem)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void flypSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UCCloseAll()
        {
            ucExercises1.Hide();
            ucWorkOut1.Hide();
            ucAbdominalsEx1.Hide();
        }

        private void CloseCurtain() 
        {
            if (sidebarExpand == true)
            {
                sidebarTimer.Start();
            }
        }

        private void btnEXERCISES_Click(object sender, EventArgs e)
        {
            UCCloseAll();
            CloseCurtain();
            ucExercises1.Show();
        }

        private void btnWORKOUT_Click(object sender, EventArgs e)
        {
            UCCloseAll();
            CloseCurtain();
            ucWorkOut1.Show();
        }


    }
}
