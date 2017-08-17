using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Lovejot singh
 * Date:17/08/2017
 * Student Id:300928227
 * desc:Adding a splash form
 * version 0.01
 */
namespace COMP123_S2017_FinalExam_300928227
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       /* private void Timer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();
            this.Hide();

            CardTimer.Enabled = false; // turn timer off
        }*/

        private void CardTimer_Tick(object sender, EventArgs e)
        {
            PickHighestCardForm pick = new PickHighestCardForm();
            pick.Show();
            this.Hide();
            CardTimer.Enabled = false;
        }
    }
}
