using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace lession2_231401
{
    public partial class testformSQL : Form
    {
        public testformSQL()
        {
            InitializeComponent();
        }

        private void bntConnection_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Global.GetConnection();
            if (conn.State != ConnectionState.Open)
            {

                MessageBox.Show("Kết nối bị đóng");
            }
            else
            {
                MessageBox.Show("Kết nối thành công");
            }

        }
    }
}
