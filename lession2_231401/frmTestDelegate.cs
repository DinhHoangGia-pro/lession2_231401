using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lession2_231401
{
    public partial class frmTestDelegate : Form
    {
        public delegate void Sukienthaydoi_Style1(Object obj);
        public Sukienthaydoi_Style1 thaydoitext_event;
        public frmTestDelegate()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (thaydoitext_event!=null) 
            {
                thaydoitext_event(textBox1.Text);
            }
        }
    }
}
