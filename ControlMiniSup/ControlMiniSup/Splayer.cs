using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlMiniSup
{
    public partial class Splayer : Form
    {
        public Splayer()
        {
            InitializeComponent();
        }

        private void CargaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Splayer_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Width < 352)
            {
                panel1.Width = panel1.Width + 20;
            }
            else
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
