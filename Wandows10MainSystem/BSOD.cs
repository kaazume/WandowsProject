using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wandows10MainSystem
{
    public partial class BSOD : Form
    {
        public BSOD()
        {
            InitializeComponent();
        }

        private void BSOD_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
       
     

        }
    }
}
