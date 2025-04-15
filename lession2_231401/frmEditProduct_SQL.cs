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
        public delegate void Sukienthaydoi_Style(Object obj);
        public Sukienthaydoi_Style thaydoidulieu_event;


        int ProductID = 0;
        String FLAG = "UPDATE";
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
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@thamso", SqlDbType.Int).Value = ProductID;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
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

        void Editable(bool dk)
        {

            btnAdd.Enabled = !dk;
            btnExit.Enabled = !dk;
            btnDel.Enabled = !dk;
            btnSave.Enabled = dk;
            btnCancel.Enabled = dk;

            txtProductID.Enabled = dk;
            txtProductName.Enabled = dk;
            txtQuantityPerUnit.Enabled = dk;
            txtUnitPrice.Enabled = dk;
            cboCategoryID.Enabled = dk;
            cboSupplierID.Enabled = dk;
        }



        private void frmEditProduct_SQL_Load(object sender, EventArgs e)
        {
            Editable(false);
            FillCBOCategory();
            FillCBOSupplier();
            LoadProductByID(ProductID);
        }

        private void bntEdit_Click(object sender, EventArgs e)
        {
            FLAG = "UPDATE";
            Editable(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FLAG = "INSERT";
            Editable(true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Editable(false);
        }

        void CapnhatProduct()
        {
            SqlConnection conn = Global.GetConnection();
            String sql = @"UPDATE Products SET ProductName=@ProductName, 
                    UnitPrice=@UnitPrice, QuantityPerUnit=@QuantityPerUnit, 
                    SupplierID=@SupplierID, CategoryID=@CategoryID
                    WHERE ProductID=@ProductID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = ProductID;
            cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = txtProductName.Text;
            cmd.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = Global.ToDouble(txtUnitPrice.Text);
            cmd.Parameters.Add("@QuantityPerUnit", SqlDbType.NVarChar).Value = txtQuantityPerUnit.Text;
            cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = Global.ToInt(cboSupplierID.SelectedValue);
            cmd.Parameters.Add("@CategoryID", SqlDbType.Int).Value = Global.ToInt(cboCategoryID.SelectedValue);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã cập nhật Product thành công");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FLAG == "UPDATE")
            {
                CapnhatProduct();
                if (thaydoidulieu_event != null)
                    thaydoidulieu_event("Em vừa cập nhật xong Product:" + ProductID);
            }
        }

        private void bntTestDelegate_Click(object sender, EventArgs e)
        {
            frmTestDelegate frm1 = new frmTestDelegate();
            frm1.thaydoitext_event += Thaydoi_dulieudoFormTesttrave;
            frm1.Show();

        }

        private void Thaydoi_dulieudoFormTesttrave(object data)
        {
            //MessageBox.Show(data.ToString());
            txtProductName.Text = data.ToString();
            
        }
    }
}
