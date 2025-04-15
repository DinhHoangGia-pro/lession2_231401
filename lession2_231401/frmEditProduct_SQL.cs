using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lession2_231401
{
    public partial class frmEditProduct_SQL : Form
    {

        int ProductID = 0;
        public frmEditProduct_SQL()
        {
            InitializeComponent();
        }

        private void FillCBOCategory()
        {
            SqlConnection conn = Global.GetConnection();
            String sql = "select * from Categories";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cboCategoryID.DataSource = dt;
            cboCategoryID.DisplayMember = "CategoryName";
            cboCategoryID.ValueMember = "CategoryID";

        }

        private void FillCBOSupplier()
        {
            SqlConnection conn = Global.GetConnection();
            String sql = "select * from Suppliers";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cboSupplierID.DataSource = dt;
            cboSupplierID.DisplayMember = "CompanyName";
            cboSupplierID.ValueMember = "SupplierID";

        }

        public frmEditProduct_SQL(int ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;
        }

        void LoadProductByID(int ProductID) 
        {
            if (ProductID == 0)
                return;

            SqlConnection con = Global.GetConnection();
            String sql = "Select * from Products where ProductID=@thamso";
            SqlCommand cmd= new SqlCommand(sql, con);
            cmd.Parameters.Add("@thamso", SqlDbType.Int).Value = ProductID;
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                txtProductID.Text = dr["ProductID"].ToString();
                txtProductName.Text = dr["ProductName"].ToString();
                txtUnitPrice.Text = dr["UnitPrice"].ToString() + "$";
                txtQuantityPerUnit.Text = dr["QuantityPerUnit"].ToString();
                cboCategoryID.SelectedValue = Global.ToInt(dr["CategoryID"]);
                cboSupplierID.SelectedValue = Global.ToInt(dr["SupplierID"]);

            }    

        }



        private void frmEditProduct_SQL_Load(object sender, EventArgs e)
        {
            FillCBOCategory();
            FillCBOSupplier();
            LoadProductByID(ProductID);
        }
    }
}
