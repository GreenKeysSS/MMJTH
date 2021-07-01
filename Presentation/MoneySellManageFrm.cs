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
 
    public partial class MoneySellManageFrm : Form
    {
        private Main main;
       
        public MoneySellManageFrm(Main main)
        {
            InitializeComponent();
            focuscashtext();

            this.main = main;

            

            subtotallbl.Text = main.subtotalpricelbl.Text;
            igvlbl.Text = main.igvtxt.Text;
            gravadalbl.Text = main.gravadatxt.Text;
            paymethodlbl.Text = Convert.ToString(main.paymethodcbo.SelectedItem);

            if (main.dtotxt.Text == "")
            {
                
                dtofinallbl.Text = "0";
                totallbl.Text = main.subtotalpricelbl.Text;
                dtotaglbl.Text = "Descuento:";
            }
            else
            {
                

                if (main.dtotype ==true)
                {
                    dtofinallbl.Text = main.dtotxt.Text;
                    decimal dto = Convert.ToDecimal(dtofinallbl.Text);

                    decimal total = Convert.ToDecimal(subtotallbl.Text) - dto;
                    totallbl.Text = Convert.ToString(total);
                    dtotaglbl.Text = "Descuento S/.:";
                }
                else
                {
                    
                    decimal dto = Convert.ToDecimal(main.dtotxt.Text);
                    decimal todto = dto * Convert.ToDecimal(subtotallbl.Text) / 100;

                    dtofinallbl.Text = Convert.ToString(todto);

                    decimal total = Convert.ToDecimal(subtotallbl.Text) - todto;
                    totallbl.Text = Convert.ToString(total);
                    dtotaglbl.Text = "Descuento "+main.dtotxt.Text+"%:";

                }
               
            }

            

        }

        private void CloseWindowbtn_Click(object sender, EventArgs e)
        {
        }
        private void focuscashtext() {

            cashtxt.Focus();
            cashtxt.SelectAll();
        }
        private  void finishsellbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cashtxt.Text!="")
                {
                ProductModel product = new ProductModel();
                product.GetLastSell();
                SellsDetail.LastIdSell = SellsDetail.LastIdSell + 1;

                ////detalles de la venta variables

                int user = UserCache.IdUser;
                string client = main.clientloadtxt.Text;
                decimal subtotal1 = Convert.ToDecimal(subtotallbl.Text);
                decimal total = Convert.ToDecimal(totallbl.Text);
                decimal dto = Convert.ToDecimal(dtofinallbl.Text);
                decimal cash = Convert.ToDecimal(cashtxt.Text);
                decimal vuelto = cash - total;
                decimal igv = Convert.ToDecimal(igvlbl.Text);
                decimal gravada = Convert.ToDecimal(gravadalbl.Text);
                DateTime dt = DateTime.Now;
                string dtcustom = Convert.ToString(dt).Replace(" ", "").Replace(":", "").Replace("/", ""); 
                string paymethod = paymethodlbl.Text;
                string nboleta = Convert.ToString(Main.cajanumber) + "-" + dtcustom;
               






                product.InsertAsSellDetail(SellsDetail.LastIdSell, client, user, subtotal1, dto, total,gravada,igv, cash, vuelto, dt,paymethod,Main.cajanumber,nboleta);




                foreach (DataGridViewRow row in main.Productsdgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    try
                    {
                        ////product by product variables
                        string barcode = Convert.ToString(row.Cells[4].Value);
                        string prodname = Convert.ToString(row.Cells[0].Value);
                        double cant = Convert.ToDouble(row.Cells[2].Value);
                        decimal prec = Convert.ToDecimal(row.Cells[1].Value);
                        decimal subtotal = Convert.ToDecimal(row.Cells[3].Value);
                        string family = Convert.ToString(row.Cells[5].Value);
                        double newunids = product.GetActualUnids(barcode) - cant;

                        product.InsertAsSell(
                          SellsDetail.LastIdSell,
                          prodname,
                          barcode,
                          prec,
                          cant,
                          subtotal,
                          user,
                          dt,Main.cajanumber,"VENDIDO",
                          family,newunids);

                       


                        if (barcode != "")
                        {
                            product.UpdateProductDetails(barcode, newunids);
                           
                        


                        }
                        
                        
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                }
                



                main.PrintTicket(main.Productsdgv, 
                                        Main.storename,
                                        Main.address,
                                        Main.storetelf,
                                        Main.storeemail,
                                        total ,
                                        subtotal1,
                                        Convert.ToDecimal(dto),igv,gravada,
                                        Main.printer,
                                        dtcustom,
                                        Main.cajanumber,
                                        client,
                                        Convert.ToDecimal(cashtxt.Text),paymethod);


               

                main.PrintTickettoPDF(main.Productsdgv,
                                       Main.storename,
                                       Main.address,
                                       Main.storetelf,
                                       Main.storeemail,
                                       total,
                                       subtotal1,
                                       Convert.ToDecimal(dto), igv, gravada,
                                       dtcustom,
                                       Main.cajanumber,
                                       client,
                                       Convert.ToDecimal(cashtxt.Text), paymethod);

                
               


                //main.NewSellActions();
                this.Close();
            }
            else
            {
                MessageBox.Show("Digitar efectivo pagado", 
                    "Observación",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Question);
                focuscashtext();
            }



           

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message+"\nVolver a insertar la venta", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }








        }

        private void cashtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            main.InputNumbers(sender, e);
        }

        private void cashtxt_TextChanged(object sender, EventArgs e)
        {
            if (cashtxt.Text!="")
            {
                decimal total = Convert.ToDecimal(totallbl.Text);
                decimal payed = Convert.ToDecimal(cashtxt.Text);

                vueltolbl.Text = Convert.ToString( payed-total);
            }
            else
            {
                vueltolbl.Text = "";
            }


        }

        private void cashtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                finishsellbtn.PerformClick();
            }
        }
    }
}
