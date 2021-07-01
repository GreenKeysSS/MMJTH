using Common.Cache;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class ModifySellFrm : Form
    {
        private Main main;
       
        public ModifySellFrm(Main main)
        {
            InitializeComponent(); this.main = main;

            datedtp.MaxDate = DateTime.Now;


            if (UserCache.Position != "ADMIN")
            {
                deletesellbtn.Visible = false;
                ListSellsDetail(UserCache.IdUser, datedtp.Value);
                

            }
            else
            {
                deletesellbtn.Visible = true;
                ListSellsDetailAdmin(datedtp.Value);
               
            }
            



        }

        private void ListSellsDetail(int usercode, DateTime dt)
        {
            sellproductsdgv.Columns.Clear();
            sellsdetaildgv.Columns.Clear();

            sellsdetaildgv.DataSource = main.ListSellsDetail(usercode, dt);

            sellsdetaildgv.Columns[0].Visible = false;
        }
        private void ListSellsDetailAdmin(DateTime dt)
        {
            sellproductsdgv.Columns.Clear();
            sellsdetaildgv.Columns.Clear();
            sellsdetaildgv.DataSource = main.ListSellsDetailAdmin(dt);

            sellsdetaildgv.Columns[0].Visible = false;
        }
        private void ListSellsByIdVenta(int idventa)
        {

            sellproductsdgv.Columns.Clear();
            sellproductsdgv.DataSource = main.ListSellsByIdVenta(idventa);
            sellproductsdgv.Columns[0].Visible = false;


        }

        private void sellsdetaildgv_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in sellsdetaildgv.SelectedRows)
            {


                ListSellsByIdVenta(Convert.ToInt32(row.Cells[0].Value));



            }
        }

    
        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            SearchInDGVModify();
        }
        private void SearchInDGVModify()
        {

            string searchValue = tosearchtxt.Text;
            int rowIndex = 0;
            bool founded = false;
            if (searchValue != "")
            {
                if (sellsdetaildgv.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in sellsdetaildgv.Rows)
                    {
                        if (Convert.ToString(row.Cells[1].Value).Contains(searchValue) || 
                            Convert.ToString(row.Cells[2].Value).Contains(searchValue) ||
                           Convert.ToString(row.Cells[5].Value).Contains(searchValue) ||
                           Convert.ToString(row.Cells[8].Value).Contains(searchValue) ||
                           Convert.ToString(row.Cells[10].Value).Contains(searchValue) ||
                            Convert.ToString(row.Cells[11].Value).Contains(searchValue))
                        {
                            rowIndex = row.Index;
                            founded = true;
                            break;

                        }

                    }

                    if (founded == false)
                    {
                        MessageBox.Show("No hay resultados de su busqueda", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        sellsdetaildgv.Rows[rowIndex].Selected = true;
                    }


                }

            }

        }

        private void tosearchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SearchInDGVModify();


            }
        }

        private void datedtp_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(datedtp.Value);

            if (UserCache.Position != "ADMIN")
            {
                ListSellsDetail(UserCache.IdUser, datedtp.Value);

                if (sellsdetaildgv.Rows.Count < 1)
                {
                    sellproductsdgv.Columns.Clear();
                }

            }
            else
            {
                ListSellsDetailAdmin(datedtp.Value);

                if (sellsdetaildgv.Rows.Count < 1)
                {
                   sellproductsdgv.Columns.Clear();
                }
            }
        }
        private void PrintRefund() {

            foreach (DataGridViewRow row in sellsdetaildgv.SelectedRows)
            {

                main.PrintTicket2(sellproductsdgv,
                                        Main.storename,
                                        Main.address,
                                        Main.storetelf,
                                        Main.storeemail,
                                        Convert.ToDecimal(row.Cells[5].Value),
                                        Convert.ToDecimal(row.Cells[3].Value),
                                        Convert.ToDecimal(row.Cells[4].Value),
                                        Convert.ToDecimal(row.Cells[6].Value),
                                        Convert.ToDecimal(row.Cells[7].Value),
                                        Main.printer,
                                        main.GetActualDateTime().Replace(" ", "").Replace("_", "").Replace("-", ""),
                                        Main.cajanumber,
                                        Convert.ToString(row.Cells[1].Value),
                                        Convert.ToDecimal(row.Cells[8].Value),
                                        Convert.ToString(row.Cells[10].Value));
              
                main.PrintTickettoPDF2(sellproductsdgv,
                                      Main.storename,
                                      Main.address,
                                      Main.storetelf,
                                      Main.storeemail,
                                      Convert.ToDecimal(row.Cells[5].Value),
                                      Convert.ToDecimal(row.Cells[3].Value),
                                      Convert.ToDecimal(row.Cells[4].Value),
                                      Convert.ToDecimal(row.Cells[6].Value),
                                      Convert.ToDecimal(row.Cells[7].Value),
                                      Convert.ToString(row.Cells[11].Value).Replace(" ", "").Replace(":", "").Replace("/", ""),
                                      Convert.ToInt32(row.Cells[12].Value),
                                      Convert.ToString(row.Cells[1].Value),

                                      Convert.ToDecimal(row.Cells[8].Value), Convert.ToString(row.Cells[10].Value));
            }



        }
        private void refundbtn_Click(object sender, EventArgs e)
        {
            if (sellproductsdgv.Rows.Count > 0)
            {
                DialogResult a;

                a = MessageBox.Show("¿Estás seguro de devolver el producto al stock?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    ProductModel product = new ProductModel();


                   
              
                    foreach (DataGridViewRow row1 in sellsdetaildgv.SelectedRows)
                    {

                        int idventa = Convert.ToInt32(row1.Cells[0].Value);
                       string  client = Convert.ToString(row1.Cells[1].Value);
                        decimal subtotaldetail= Convert.ToDecimal(row1.Cells[3].Value); 
                        decimal payed = Convert.ToDecimal(row1.Cells[8].Value);
                        int index1 = row1.Index;
                        int index = 0;



                        foreach (DataGridViewRow row in sellproductsdgv.SelectedRows)
                            {
                            int idsell = Convert.ToInt32(row.Cells[0].Value);
                            string barcode = Convert.ToString(row.Cells[5].Value);
                            int user = UserCache.IdUser;
                             index = row.Index;


                            string productname = Convert.ToString(row.Cells[1].Value);
                            decimal price = Convert.ToDecimal(row.Cells[2].Value);
                            double cantidad = Convert.ToDouble(row.Cells[3].Value);
                            decimal subtotal = Convert.ToDecimal(row.Cells[4].Value);
                            DateTime actdt = datedtp.Value;
                            

                            decimal finalsbutotal = subtotaldetail - subtotal;
                            decimal newigv = 18 * finalsbutotal/100;
                            decimal newgravada = finalsbutotal - newigv;
                            decimal newvuelto = payed - finalsbutotal;


                            DateTime dt = DateTime.Now;
                            int caja = Main.cajanumber;



                            if (!product.CheckRefundIfRefunded(idsell))
                            {
                                InsertItemToRefunds(idventa, barcode, productname, price, cantidad, subtotal, user, dt, caja, client);
                                UpdateSellsFromRefund(idsell, "DEVUELTO");
                                product.UpdateSellsDetailsFromRefund(finalsbutotal, 0, finalsbutotal, newgravada, newigv, newvuelto, idventa);





                                if (barcode != "")
                                {
                                    product.UpdateProductDetails(barcode, product.GetActualUnids(barcode) + 1);
                                 

                                }

                                if (UserCache.Position != "ADMIN")
                                {
                                    ListSellsDetail(UserCache.IdUser, actdt);

                                }
                                else
                                {
                                    ListSellsDetailAdmin(actdt);

                                }
                                

                             
                               

                            }
                            else
                            {
                                
                                MessageBox.Show("El producto seleccionado ya fue devuelto, no puedes continuar con acción" , "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                goto End;

                            }




                        }
                        sellsdetaildgv.Rows[index1].Selected = true;
                        sellproductsdgv.Rows[index].Selected = true;
                        PrintRefund();
                        MessageBox.Show("¿Se cambió el estado del productos a devuelto? Puedes volver a imprimir el voucher en <VENTAS Y ENVIOS>", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                        End:;

                }
            }
            
        }

        private void InsertItemToRefunds(int idventa, string codebar, string productname, decimal price,
          double cantidad, decimal subtotal, int user, DateTime dt, int caja,string client)
        {

            ProductModel product = new ProductModel();
            product.InsertItemToRefunds(idventa,codebar,productname,price,cantidad,subtotal,user,dt,caja,client);
        }

        public void UpdateSellsFromRefund(int id,string state) {

            ProductModel product = new ProductModel();

            product.UpdateSellsFromRefund(id,state);
        }

        private void deletesellbtn_Click(object sender, EventArgs e)
        {
            if (sellproductsdgv.Rows.Count > 0)
            {
                DialogResult a;

                a = MessageBox.Show("¿Estás seguro de Anular la venta seleccionada?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {

                    DateTime actdt = datedtp.Value;
                    ProductModel product = new ProductModel();




                    foreach (DataGridViewRow row1 in sellsdetaildgv.SelectedRows)
                    {

                        int idventa = Convert.ToInt32(row1.Cells[0].Value);
                        string client = Convert.ToString(row1.Cells[1].Value);
                        decimal subtotaldetail = Convert.ToDecimal(row1.Cells[3].Value);
                        decimal payed = Convert.ToDecimal(row1.Cells[8].Value);
                        int index1 = row1.Index;
                        int index = 0;



                        foreach (DataGridViewRow row in sellproductsdgv.Rows)
                        {
                            int idsell = Convert.ToInt32(row.Cells[0].Value);
                            string barcode = Convert.ToString(row.Cells[5].Value);
                            int user = UserCache.IdUser;
                            index = row.Index;


                            string productname = Convert.ToString(row.Cells[1].Value);
                            decimal price = Convert.ToDecimal(row.Cells[2].Value);
                            double cantidad = Convert.ToDouble(row.Cells[3].Value);
                            decimal subtotal = Convert.ToDecimal(row.Cells[4].Value);
                        


                            decimal finalsbutotal = subtotaldetail - subtotal;
                            decimal newigv = 18 * finalsbutotal / 100;
                            decimal newgravada = finalsbutotal - newigv;
                            decimal newvuelto = payed - finalsbutotal;


                            DateTime dt = DateTime.Now;
                            int caja = Main.cajanumber;



                            if (!product.CheckRefundIfRefunded(idsell))
                            {
                                InsertItemToRefunds(idventa, barcode, productname, price, cantidad, subtotal, user, dt, caja, client);
                                UpdateSellsFromRefund(idsell, "DEVUELTO");
                                product.UpdateSellsDetailsFromRefund(finalsbutotal, 0, finalsbutotal, newgravada, newigv, newvuelto, idventa);

                                
                                if (barcode != "")
                                {
                                    product.UpdateProductDetails(barcode, product.GetActualUnids(barcode) + cantidad);
                                    

                                }
                                

                            }
                           



                        }
                      
                    }

                    

                    foreach (DataGridViewRow row1 in sellsdetaildgv.SelectedRows)
                    {

                        DeleteTotalSell(Convert.ToInt32(row1.Cells[0].Value));
                        Console.WriteLine(Convert.ToString(row1.Cells[0].Value));

                        if (UserCache.Position != "ADMIN")
                        {
                            ListSellsDetail(UserCache.IdUser, actdt);

                        }
                        else
                        {
                            ListSellsDetailAdmin(actdt);

                        }
                        MessageBox.Show("Venta Anulada", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                  

                }
            }
        }
        private void DeleteTotalSell(int idventa) {

            ProductModel prod = new ProductModel();
            prod.DeleteTotalSell(idventa);

        }
    }
}
