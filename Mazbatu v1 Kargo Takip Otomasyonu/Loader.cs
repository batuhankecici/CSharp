using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }
   
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Value= 100;
            timer1.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     

           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            GirisMenu GirisMenu = new GirisMenu();
            GirisMenu.Show();
            this.Hide();
            timer2.Enabled = false;
        }

       
    }
}
