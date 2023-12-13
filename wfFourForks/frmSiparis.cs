using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfFourForks
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            grbMenuler.BackColor = Color.Transparent;
            gbMasaSiparis.BackColor = Color.Transparent;
          
                       grbAdet.BackColor = Color.Transparent;
         
        }

        
           
    }
}
