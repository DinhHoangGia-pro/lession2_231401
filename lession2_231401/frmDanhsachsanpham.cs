using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace lession2_231401
{
    public partial class frmDanhsachsanpham : Form
    {

        List<Product> products = new List<Product>();
        List<Category> categories = new List<Category>();
        List<Supplier> suppliers = new List<Supplier>();

        int pagesize = 0;
        int pagenumber = 1;/*Trang 1, 2...*/
        int count = 0;


        public static int ToInt(object obj)
        {
            int i = 0;
            if (obj == null)
                return 0;
            int.TryParse(obj.ToString(), out i);
            return i;
        }


        private void LoadCBOPageSize()
        {
            List<object> list = new List<object>();
            //list.Add(new { pagevalue = 5, pagename = "5 bản ghi" });
            list.Add(new { pagevalue = 10, pagename = "10 bản ghi" });
            list.Add(new { pagevalue = 15, pagename = "15 bản ghi" });
            list.Add(new { pagevalue = 20, pagename = "20 bản ghi" });
            cboPageSize.DataSource = list;
            cboPageSize.ValueMember = "pagevalue";
            cboPageSize.DisplayMember = "pagename";
        }
        public frmDanhsachsanpham()
        {
            InitializeComponent();
            LoadCBOPageSize();

        }


        private void TinhSotrang()
        {
            pagesize = ToInt(cboPageSize.SelectedValue);
            if (pagesize == 0)
                pagesize = 10;
            int PageCount = (this.count % pagesize == 0) ? this.count / pagesize : (this.count / pagesize) + 1;
            List<object> lstpages = new List<object>();
            for (int i = 0; i < PageCount; i++)
            {

                var item = new { pagevalue = (i + 1), pagename = "Trang " + (i + 1).ToString() };

                /* chữ var này là kiểu động, lấy bất kỳ dữ liệu loại nào cũng được*/
                lstpages.Add(item);
            }
            if (PageCount > 0)
            {
                cboPage.DataSource = lstpages;
                cboPage.DisplayMember = "pagename";
                cboPage.ValueMember = "pagevalue";
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //LoadProduct();

            //dataGridView1.DataSource = products;

            Timkiemsanpham();
            TinhSotrang();



        }

        void Timkiemsanpham()
        {
            String chuoitim = txtSearch.Text;


            var lst = (from x in products where x.ProductName.Contains(chuoitim) select x).ToList();


            pagenumber = (cboPage.SelectedValue != null) ? ToInt(cboPage.SelectedValue) : 1;
            //Xử lý phân trang
            int begin = (pagenumber - 1) * pagesize;
            lst = lst.Skip(begin).Take(pagesize).ToList();
            dataGridView1.DataSource = lst;


        }

        private void LoadCBOCategory()
        {



            String categories_json = ProductsUtils.category_json;
            List<Category> data = JsonConvert.DeserializeObject<List<Category>>(categories_json);
            categories = data.ToList();

            Category category1 = new Category();
            category1.CategoryID = 0;
            category1.CategoryName = "------Chọn tất cả----";
            //categories.Add(category1);

            categories.Insert(0, category1);


            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";
        }

        private void LoadCBOSupplier()
        {
            String supplier_json = ProductsUtils.supplier_json;
            var data = JsonConvert.DeserializeObject<List<Supplier>>(supplier_json);
            suppliers = data;


            Supplier s1 = new Supplier();
            s1.SupplierID = 0;
            s1.CompanyName = "-----Chọn tất cả-------";
            suppliers.Insert(0, s1);

            cboSupplier.DataSource = suppliers;
            cboSupplier.DisplayMember = "CompanyName";
            cboSupplier.ValueMember = "SupplierID";
        }


        void LoadProduct()
        {
            String products_json = ProductsUtils.product_json;
            var lstproducts = JsonConvert.DeserializeObject<List<Product>>(products_json);
            //products = lstproducts.ToList();

            //Thực hiện join danh mục
            products = (from product in lstproducts
                        join category in categories on product.CategoryID equals category.CategoryID
                        join supplier in suppliers on product.SupplierID equals supplier.SupplierID
                        select new Product
                        {
                            ProductID = product.ProductID,
                            ProductName = product.ProductName,
                            SupplierID = product.SupplierID,
                            CompanyName = supplier.CompanyName,
                            CategoryID = product.CategoryID,
                            CategoryName = category.CategoryName,
                            QuantityPerUnit = product.QuantityPerUnit,
                            UnitPrice = product.UnitPrice,
                            UnitsInStock = product.UnitsInStock,
                            UnitsOnOrder = product.UnitsOnOrder,
                            ReorderLevel = product.ReorderLevel,
                            Discontinued = product.Discontinued

                        }).ToList();

            this.count = products.Count;


            //dataGridView1.DataSource = products;

        }

        private void frmDanhsachsanpham_Load(object sender, EventArgs e)
        {
            LoadCBOCategory();
            LoadCBOSupplier();
            LoadProduct();

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocSPtheoCategory();
        }

        void LocSPtheoCategory()
        {

            int CategoryID = 0;

            if (cboCategory.SelectedValue != null)
            {

                int.TryParse(cboCategory.SelectedValue.ToString(), out CategoryID);
            }
            if (CategoryID > 0)
            {
                var lst = (from x in products where x.CategoryID == CategoryID select x).ToList();
                dataGridView1.DataSource = lst;
            }
            else
            {
                dataGridView1.DataSource = products;

            }
        }


        void LocSPtheoSupplier()
        {

            int SupplierID = 0;

            if (cboSupplier.SelectedValue != null)
            {

                int.TryParse(cboSupplier.SelectedValue.ToString(), out SupplierID);
            }
            if (SupplierID > 0)
            {
                var lst = (from x in products where x.SupplierID == SupplierID select x).ToList();
                dataGridView1.DataSource = lst;
            }
            else
            {
                dataGridView1.DataSource = products;

            }
        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocSPtheoSupplier();
        }

        private void cboPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            pagesize = ToInt(cboPageSize.SelectedValue);
            if (pagesize == 0)
                pagesize = 10;
        }

        private void cboPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPage.SelectedValue != null)
                Timkiemsanpham();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            //dgvGrid.Rows[index].Selected = true;
            Product product = products[index];
            frmEditProduct frm = new frmEditProduct();
            frm.Product = product;
            frm.ShowDialog();

        }
    }
}
