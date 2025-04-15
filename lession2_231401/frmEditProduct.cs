using Newtonsoft.Json;
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
    public partial class frmEditProduct : Form
    {
        private Product product = new Product();

        public frmEditProduct()
        {
            InitializeComponent();
        }

        private void LoadCBOCategory()
        {



            String categories_json = ProductsUtils.category_json;
            List<Category> data = JsonConvert.DeserializeObject<List<Category>>(categories_json);
            var categories = data.ToList();

            Category category1 = new Category();
            category1.CategoryID = 0;
            category1.CategoryName = "------Chọn tất cả----";
            //categories.Add(category1);

            categories.Insert(0, category1);


            cboCategoryID.DataSource = categories;
            cboCategoryID.DisplayMember = "CategoryName";
            cboCategoryID.ValueMember = "CategoryID";
        }

        private void LoadCBOSupplier()
        {
            String supplier_json = ProductsUtils.supplier_json;
            var data = JsonConvert.DeserializeObject<List<Supplier>>(supplier_json);
            var suppliers = data;


            Supplier s1 = new Supplier();
            s1.SupplierID = 0;
            s1.CompanyName = "-----Chọn tất cả-------";
            suppliers.Insert(0, s1);

            cboSupplierID.DataSource = suppliers;
            cboSupplierID.DisplayMember = "CompanyName";
            cboSupplierID.ValueMember = "SupplierID";
        }

        internal Product Product { get => product; set => product = value; }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            LoadCBOCategory();
            LoadCBOSupplier();
            txtProductID.Text = product.ProductID.ToString();
            txtProductName.Text = product.ProductName.ToString();
            txtQuantityPerUnit.Text = product.QuantityPerUnit.ToString();
            txtUnitPrice.Text = product.UnitPrice.ToString();
            cboCategoryID.SelectedValue = product.CategoryID;
            cboSupplierID.SelectedValue = product.SupplierID;
            Editable(false);


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void bntEdit_Click(object sender, EventArgs e)
        {
            Editable(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Editable(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GhiDL();
        }

        public void GhiDL()
        {
            product.ProductName = txtProductName.Text;
            product.QuantityPerUnit = txtQuantityPerUnit.Text;
            product.SupplierID = ToInt(cboSupplierID.SelectedValue);
            product.CategoryID = ToInt(cboCategoryID.SelectedValue);
            product.UnitPrice = ToDecimal(txtUnitPrice.Text);
            MessageBox.Show("Đã ghi dữ liệu vào item");
            Editable(false);


        }

        public static int ToInt(object obj)
        {
            int i = 0;
            if (obj == null)
                return 0;
            int.TryParse(obj.ToString(), out i);
            return i;
        }

        public static decimal ToDecimal(object obj)
        {
            decimal i = 0;
            if (obj == null)
                return 0;
            decimal.TryParse(obj.ToString(), out i);
            return i;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                product = null;
            }
            else if (result == DialogResult.No)
            {
                //...
            }
        }


        //public frmEditProduct(Product p)
        //{
        //    InitializeComponent();
        //    this.product = p;
        //}
    }
}
