using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lession2_231401
{
    public partial class frmDanhsachSP_SQL : Form
    {
        public frmDanhsachSP_SQL()
        {
            InitializeComponent();
        }

        void LoadSanpham()
        {

            SqlConnection conn = Global.GetConnection();
            String sql = @"select P.ProductID,P.ProductName, P.QuantityPerUnit, P.UnitPrice,
                        S.CompanyName TenCongty, C.CategoryName Loaihanghoa 
                        from Products P 
                        join Suppliers S on P.SupplierID=S.SupplierID
                        join Categories C on P.CategoryID=C.CategoryID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        void TimSanpham()
        {
            SqlConnection conn = Global.GetConnection();
            String sql = @"select P.ProductID,P.ProductName, P.QuantityPerUnit, P.UnitPrice,
                        S.CompanyName TenCongty, C.CategoryName Loaihanghoa 
                        from Products P 
                        join Suppliers S on P.SupplierID=S.SupplierID
                        join Categories C on P.CategoryID=C.CategoryID 
                        where P.ProductName like @thamso
                        OR C.CategoryName like @thamso
                        OR S.CompanyName like @thamso
                         ";


            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@thamso", SqlDbType.NVarChar).Value = "%" + txtSearch.Text + "%";
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void TimSanphambyCategory()
        {
            SqlConnection conn = Global.GetConnection();
            String sql = @"select P.ProductID,P.ProductName, P.QuantityPerUnit, P.UnitPrice,
                        S.CompanyName TenCongty, C.CategoryName Loaihanghoa 
                        from Products P 
                        join Suppliers S on P.SupplierID=S.SupplierID
                        join Categories C on P.CategoryID=C.CategoryID 
                        where P.CategoryID =@CategoryID";

            int CategoryID = Global.ToInt(cboCategory.SelectedValue);


            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void TimSanphambySupplier()
        {
            SqlConnection conn = Global.GetConnection();
            String sql = @"select P.ProductID,P.ProductName, P.QuantityPerUnit, P.UnitPrice,
                        S.CompanyName TenCongty, C.CategoryName Loaihanghoa 
                        from Products P 
                        join Suppliers S on P.SupplierID=S.SupplierID
                        join Categories C on P.CategoryID=C.CategoryID 
                        where P.SupplierID =@SupplierID";

            int SupplierID = Global.ToInt(cboSupplier.SelectedValue);


            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = SupplierID;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void FillCBOCategory()
        {
            SqlConnection conn = Global.GetConnection();
            String sql = "select * from Categories";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";

        }

        private void FillCBOSupplier()
        {
            SqlConnection conn = Global.GetConnection();
            String sql = "select * from Suppliers";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cboSupplier.DataSource = dt;
            cboSupplier.DisplayMember = "CompanyName";
            cboSupplier.ValueMember = "SupplierID";

        }

        private void frmDanhsachSP_SQL_Load(object sender, EventArgs e)
        {
            LoadSanpham();
            FillCBOCategory();
            FillCBOSupplier();
        }



        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            TimSanpham();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimSanphambyCategory();
        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimSanphambySupplier();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            //dgvGrid.Rows[index].Selected = true;


            //DataRow dr = ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem).Row;

            DataRow dr = ((DataRowView)dataGridView1.Rows[index].DataBoundItem).Row;
            int ProductID = Global.ToInt(dr["ProductID"]);
            //MessageBox.Show(ProductID.ToString());

            frmEditProduct_SQL frm= new frmEditProduct_SQL(ProductID);

            frm.thaydoidulieu_event += Reload_dulieu;
            frm.ShowDialog();

            

           
        }

        private void Reload_dulieu(object data)
        {
            MessageBox.Show(data.ToString());
            TimSanpham();
        }
    }
}
