using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradePredictor
{
    public partial class frm_loading : Form
    {
        public frm_loading()
        {
            InitializeComponent();
        }

        //On loading...
        private void frm_loading_Load(object sender, EventArgs e)
        {
            this.timer_loading.Start();
        }

        //Increment the progress bar 
        private void timer_loading_Tick(object sender, EventArgs e)
        {
            this.pbar_loading.Increment(4);

            if(pbar_loading.Value == pbar_loading.Maximum) {
                timer_loading.Stop();
                this.Hide();
                frm_login nextScreen = new frm_login();
                nextScreen.Show();
            }  
        }
    }
}
