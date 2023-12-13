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
    public partial class frmMasalar : Form
    {
        public frmMasalar()
        {
            InitializeComponent();
        }

        private void frmMasalar_Load(object sender, EventArgs e)
        {
            cMasalar m = new cMasalar();
            
        }
    }
}
