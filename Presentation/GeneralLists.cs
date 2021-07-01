using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
namespace Presentation
{
    
    public partial class GeneralLists : Form
    {
        private Main main; public string actuallist;
        public GeneralLists(Main main)
        {
            InitializeComponent();
            this.main = main;
            

            datedtp.MaxDate = DateTime.Now;




        }

        public void ListClients() {
            Console.WriteLine("tewtwetwet");
            ClientModel client = new ClientModel();

            generallistdgv.DataSource = client.ListClients();
            generallistdgv.Columns[0].Visible = false;
        }

        public void ListProducts() {

            ProductModel product = new ProductModel();

            generallistdgv.DataSource= product.ListProductsInvent(tosearchtxt.Text) ;
            generallistdgv.Columns[0].Visible = false;

        }
        public void ListEmploy()
        {

            UserModel user = new UserModel();

            generallistdgv.DataSource = user.ListUsers();
            generallistdgv.Columns[0].Visible = false;
        }
        public void ListLowStock() {

            ProductModel product = new ProductModel();

            generallistdgv.DataSource=product.LowStockListProducts();
        }
        public void ListRefunds(DateTime date)
        {

            ProductModel product = new ProductModel();

            generallistdgv.DataSource = product.ListRefunds(date);
        }

        public void ListSellsByFamily(DateTime dt) {

            ProductModel prod = new ProductModel();

            generallistdgv.DataSource =  prod.ListSellsByFamily(dt);
        }

        public void ListSells(DateTime date) {

            ProductModel product = new ProductModel();

          generallistdgv.DataSource = product.ListSells(date);
        }
        public void ListSellsByClient(DateTime date)
        {

            ProductModel product = new ProductModel();

            generallistdgv.DataSource = product.ListSellsByClient(date);

        }
        public void ListSellsByPayMethod(DateTime date)
        {

            ProductModel product = new ProductModel();

            generallistdgv.DataSource = product.ListSellsByPayMethod(date);
        }
        public void ListSellsByUser(DateTime date)
        {

            ProductModel product = new ProductModel();

            generallistdgv.DataSource = product.ListSellsByUser(date);
        }
        public void ListSellsByCaja(DateTime date)
        {

            ProductModel product = new ProductModel();

            generallistdgv.DataSource = product.ListSellsByCaja(date);
        }
        public void ListCierreCaja(DateTime dt)
        {ProductModel product= new ProductModel();

            generallistdgv.DataSource =product.ListCierreCaja(dt);
        }

        public void ListSellsProducts(DateTime dt)
        {
            ProductModel product = new ProductModel();

            generallistdgv.DataSource = product.ListSellsProducts(dt);
        }
        public void ListSellsGeneral(DateTime dt)
        {
            ProductModel product = new ProductModel();

            generallistdgv.DataSource = product.ListSellsGeneral(dt);
            generallistdgv.Columns[0].Visible = false;
        }
        private void datedtp_ValueChanged(object sender, EventArgs e)
        {
           

            if (actuallist == "bysells")
            {
                ListSellsGeneral(datedtp.Value);
            }
            if (actuallist == "byrefund")
            {
                ListRefunds(datedtp.Value);
            }
            if (actuallist =="byprod")
            {
                ListSells(datedtp.Value);
            }
            if (actuallist=="byfam")
            {
                ListSellsByFamily(datedtp.Value);
            }
            if (actuallist == "bycli")
            {
                ListSellsByClient(datedtp.Value);
            }
            if (actuallist == "bypm")
            {
                ListSellsByPayMethod(datedtp.Value);
            }
            if (actuallist == "byuser")
            {
                ListSellsByUser(datedtp.Value);
            }
            if (actuallist == "bycaja")
            {
                ListSellsByCaja(datedtp.Value);
            }
            if (actuallist == "bycierre")
            {
                ListCierreCaja(datedtp.Value);
            }
            if (actuallist == "allprod")
            {
                ListSellsProducts(datedtp.Value);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SearchInDGVGeneralList();
        }
        private void SearchInDGVGeneralList()
        {

            string searchValue = tosearchtxt.Text;
            int rowIndex = 0;
            bool founded = false;

            if (searchValue != "")
            {
                if (generallistdgv.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in generallistdgv.Rows)
                    {
                        for (int i = 0; i < generallistdgv.ColumnCount; i++)
                        {
                            if (Convert.ToString(row.Cells[i].Value).Contains(searchValue))
                            {
                                rowIndex = row.Index;
                                founded = true;

                                goto end;

                            }

                        }
                       


                    }end:

                    if (founded == false)
                    {
                        MessageBox.Show("No hay resultados de su busqueda", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        generallistdgv.Rows[rowIndex].Selected = true;
                    }


                }

            }

        }

        private void tosearchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SearchInDGVGeneralList();


            }
        }

        private void excelexportbtn_Click(object sender, EventArgs e)
        {
            if (generallistdgv.Rows.Count>0)
            {
                main.ExportToExcel(generallistdgv, titlelbl.Text + " " + datedtp.Value.ToString("MM-yyyy"), datedtp.Value.ToString("MM-yyyy"));
            }
            
        }
    }
}
