using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentation
{
    
    public partial class SellAndSends : Form
    {
        private Main main;
        
        public SellAndSends(Main main)
        {
            InitializeComponent();
            this.main = main;

            datedtp.MaxDate = DateTime.Now;

            if (UserCache.Position !="ADMIN")
            {
                ListSellsDetail(UserCache.IdUser,datedtp.Value);
                
            }
            else
            {
                ListSellsDetailAdmin(datedtp.Value);
                
            }

            

        }
        private void ListSellsDetail(int usercode,DateTime dt)
        {

            sellsdetaildgv.Columns.Clear();
            Console.WriteLine(usercode + " " + dt.ToString());
            sellsdetaildgv.DataSource = main.ListSellsDetail(usercode, dt);

           

            sellsdetaildgv.Columns[0].Visible = false;
        }
        private void ListSellsDetailAdmin(DateTime dt)
        {

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

        private void printsellbtn_Click(object sender, EventArgs e)
        {
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


            }


        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SearchInDGVReprint();

        }
        private void SearchInDGVReprint() {

            string searchValue = texttosearchtxt.Text;
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
        
        private void texttosearchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SearchInDGVReprint();


            }
        }

        private void openaspdfbtn_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in sellsdetaildgv.SelectedRows)
            {

                string date = Convert.ToString(row.Cells[11].Value).Replace("/","").Replace(":","").Replace(" ","");
                
                string path = "C:\\Users\\" + Main.actualuser + "\\Documents\\TPVFiles\\" +"Ticket " + date +".pdf";

                Console.WriteLine(path);

                if (File.Exists(path))
                {

                    Process.Start(path);
     
                }
                else
                {
                    MessageBox.Show("No se ubica el archivo PDF", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }



        }

        private void gmailsendbtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sellsdetaildgv.RowCount);
            if (sellsdetaildgv.RowCount>0)
            {
                foreach (DataGridViewRow row in sellsdetaildgv.SelectedRows)
                {

                    string date = Convert.ToString(row.Cells[11].Value).Replace("/", "").Replace(":", "").Replace(" ", "");



                    string path = "C:\\Users\\" + Main.actualuser + "\\Documents\\TPVFiles\\" + "Ticket " + date + ".pdf";

                    Console.WriteLine(path);

                    if (File.Exists(path))
                    {

                        GmailSend.clientname = Convert.ToString(row.Cells[1].Value);

                        GmailSend.pathfile = path;
                        GmailSend gmail = new GmailSend(this);
                        gmail.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("No se ubica el archivo PDF", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }


            

        }
        private void ClearClientClass()
        {

            ClientCache.ClientName = "";
            ClientCache.Movil = "";
            ClientCache.Email = "";
            ClientCache.Address = "";
            ClientCache.Fijo = "";
            ClientCache.CreateDate = "";

        }
        private void wasendbtn_Click(object sender, EventArgs e)
        {
            if (sellsdetaildgv.RowCount>0)
            {
                foreach (DataGridViewRow row in sellsdetaildgv.SelectedRows)
                {

                    string date = Convert.ToString(row.Cells[11].Value).Replace("/", "").Replace(":", "").Replace(" ", "");

                    string date2 = Convert.ToString(row.Cells[11].Value).Replace(" ", "_").Replace("/", "-").Replace(":", " ");

                    string clientname = Convert.ToString(row.Cells[1].Value);


                    string path = "C:\\Users\\" + Main.actualuser + "\\Documents\\TPVFiles\\" + "Ticket " + date + ".pdf";

              

          

                    Console.WriteLine(path);

                    if (File.Exists(path))
                    {
                        SaveFileDialog savepdf = new SaveFileDialog();
                        savepdf.FileName = clientname + " " + date2 + ".pdf";
                        savepdf.InitialDirectory = "C:\\Users\\" + Main.actualuser + "\\Documents";
                        savepdf.Filter = "PDF (*.pdf)|*.pdf";

                        if (savepdf.ShowDialog() == DialogResult.OK)
                        {
                            string newDirectory = savepdf.FileName;

                            File.Copy(path, newDirectory, true);

                            DialogResult a;

                            a = MessageBox.Show("El archivo PDF se guardó correctamente\nRecuerda la ubicación y el nombre\n " +
                                "Click en <OK> para abrir WhatsApp Web", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);




                            if (a == DialogResult.OK)
                            {
                                try
                                {

                                
                                ClientModel client = new ClientModel();

                                if (client.SearchClientByName(clientname))
                                {
                                    if (ClientCache.Movil != "")
                                    {
                                        string number = "51" + ClientCache.Movil;



                                        string formatedlink = "https://api.whatsapp.com/send?phone=" + number + "&text=" + Main.sendmsg1 + " " + clientname + " " + Main.sendmsg2;
                                        Process.Start(formatedlink);

                                    }
                                    else
                                    {
                                        MessageBox.Show("El cliente no cuenta con numero movil valido para realizar el envio" +
                                            ", modificar en la seccion clientes", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("No se hallaron datos de este cliente,el nombre podría haber sido modificado\nPuedes Colocar los datos" +
                                    "manualmente y enviar por email", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                ClearClientClass();

                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message, "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("No se ubica el archivo PDF", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
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

        private void excelexportsellbtn_Click(object sender, EventArgs e)
        {
            if (sellsdetaildgv.Rows.Count>0)
            {

                foreach (DataGridViewRow row in sellsdetaildgv.SelectedRows)
                {
                    main.ExportToExcelSell(sellproductsdgv, "Venta " + Convert.ToString(row.Cells[1].Value) +
                        " "+Convert.ToDateTime(row.Cells[11].Value).ToString("dd-MM-yyyy HH_mm_ss"), Convert.ToString(row.Cells[1].Value), sellsdetaildgv);
                }
                    
            }
            else
            {
                MessageBox.Show("No hay datos a exportar", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}





    