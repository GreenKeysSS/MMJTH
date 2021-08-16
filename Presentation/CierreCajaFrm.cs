using System;

using System.Data;

using System.Text;
using System.Windows.Forms;
using Domain;
using Common.Cache;

using System.Globalization;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Presentation
{
    public partial class CierreCajaFrm : Form
    {
        private Main main;
        decimal retiro;
        public bool isadmin;
        public CierreCajaFrm(Main main)
        {
            InitializeComponent();
            this.main = main;
            timer1.Start();

            datedtp.MaxDate = DateTime.Now;


           

            ExecuteData();

            


        }
       
        private void ExecuteData() {

            noretireradiobtn.Checked = true;
            saldoactualtxt.Text = cierreactualtxt.Text;

        }
        public DataTable ListCajasDGV(DateTime date,int empid)
        {
            CajaModel caja = new CajaModel();
            return caja.ListCajas(date,empid);
        }



        public DataTable ListDataCaja(DateTime date, int cajanumber,int empid)
        {
            CajaModel caja = new CajaModel();

            return caja.ListDataCaja(date, cajanumber,empid);
        }

        

        public void ListCajas(DateTime dt, int empid) {

            cierrecajadgv.Columns.Clear();
            cierrecajadgv.DataSource = ListCajasDGV(dt,empid);

        }

        private void datedtp_ValueChanged(object sender, EventArgs e)
        {
            if (isadmin)
            {
                ListEmpByCaja(datedtp.Value);
              
            }
            else
            {
                ListEmpByCaja2(datedtp.Value, UserCache.IdUser);
              
            }

            Default();
         
            

            if (cierrecajadgv.Rows.Count<1)
            {
                cajadatadgv.Columns.Clear();
                cajatxt.Clear();
                cierreactualtxt.Clear();
                saldoactualtxt.Clear();
                saldocierreanttxt.Clear();
                cierreanttxt.Clear();
                fechacierreanttxt.Clear();
            }
        }

        private void Default() {
            noretireradiobtn.Checked = true;
            importtxt.Clear();
            leavetxt.Clear();
        }
        private void FillLastCierreCaja(int cajanumber) {

            CajaModel caja = new CajaModel();

            DataTable LastCierre = caja.GetLastCierreCaja(cajanumber);


            if (LastCierre.Rows.Count > 0)
            {
                if (Convert.ToString(LastCierre.Rows[0][3])!="")
                    saldocierreanttxt.Text = Convert.ToString(LastCierre.Rows[0][3]);
                else
                    saldocierreanttxt.Text = "0";

                if (Convert.ToString(LastCierre.Rows[0][2])!="")
                    cierreanttxt.Text = Convert.ToString(LastCierre.Rows[0][2]);
                else
                    cierreanttxt.Text = "0";

                if (Convert.ToString(LastCierre.Rows[0][5]) != "")
                    fechacierreanttxt.Text = Convert.ToString(LastCierre.Rows[0][5]);
                else
                    fechacierreanttxt.Text = "0";


            }
            else
            {
                saldocierreanttxt.Text = "0";
                cierreanttxt.Text = "0";
                fechacierreanttxt.Text = "";
            }



        }
      

        private void ListByIdCaja(DateTime dt, int cajanumber,int empid) {
            cajadatadgv.Columns.Clear();
            cajadatadgv.DataSource = ListDataCaja(dt, cajanumber,empid);
            cajadatadgv.Columns[0].Visible = false;
        }

        private void cierrecajadgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in cierrecajadgv.SelectedRows)
            {
                CajaModel caja = new CajaModel();
                

                cajatxt.Text = Convert.ToString(row.Cells[0].Value);

                //cierreactualtxt.Text = Convert.ToString(Convert.ToDecimal( row.Cells[1].Value) + Convert.ToDecimal(saldocierreanttxt.Text));

                Default();

                foreach (DataGridViewRow row1 in empcajadgv.SelectedRows)
                {

                    ListByIdCaja(datedtp.Value, Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row1.Cells[0].Value));





                    FillLastCierreCaja(Convert.ToInt32(row.Cells[0].Value));






                    if (caja.SearchCierreCaja(Convert.ToInt32(row.Cells[0].Value), datedtp.Value, Convert.ToInt32(row1.Cells[0].Value ), Convert.ToInt32(row1.Cells[4].Value)))
                    {
                        decimal totalventa = Convert.ToDecimal(Convert.ToString(row.Cells[1].Value));

                        decimal saldocierreant = Convert.ToDecimal(saldocierreanttxt.Text.Replace(".", CultureInfo.CurrentCulture.
                        NumberFormat.NumberDecimalSeparator));

                        decimal total = totalventa + saldocierreant;
                        cierreactualtxt.Text = Convert.ToString(total);

                        saldoactualtxt.Text = "-";
                    }
                    else
                    {
                        
                        decimal totalventa = Convert.ToDecimal(Convert.ToString(row.Cells[1].Value));
                
                        decimal saldocierreant = Convert.ToDecimal(saldocierreanttxt.Text.Replace(".", CultureInfo.CurrentCulture.
                        NumberFormat.NumberDecimalSeparator));

                        decimal total = totalventa + saldocierreant;

                        cierreactualtxt.Text = Convert.ToString(total);

                        saldoactualtxt.Text = cierreactualtxt.Text;
                    }
                }

                

               
            }
            
           
        }
        public DataTable ListEmpByCajas(DateTime date)
        { CajaModel caja = new CajaModel();

            return caja.ListEmpByCajas(date);

        }
        public DataTable ListEmpByCajas2(DateTime date,int user)
        {
            CajaModel caja = new CajaModel();

            return caja.ListEmpByCajas2(date,user);

        }
        public void ListEmpByCaja(DateTime dt)
        {
            empcajadgv.Columns.Clear();
            empcajadgv.DataSource = ListEmpByCajas(dt);
            empcajadgv.Columns[0].Visible = false;
            empcajadgv.Columns[4].Visible = false;

        }
        public void ListEmpByCaja2(DateTime dt,int user)
        {
            empcajadgv.Columns.Clear();
            empcajadgv.DataSource = ListEmpByCajas2(dt,user);
            empcajadgv.Columns[0].Visible = false;
            empcajadgv.Columns[4].Visible = false;

        }
        private void noretireradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (noretireradiobtn.Checked ==true)
            {
              
                saldoactualtxt.Text =  cierreactualtxt.Text;
                importtxt.Clear();importtxt.Enabled = false;
                leavetxt.Clear();leavetxt.Enabled = false;

            }


        }

        private void importradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (importradiobtn.Checked==true)
            {
                
                importtxt.Enabled = true;
                leavetxt.Enabled = false;
                saldoactualtxt.Clear();
                leavetxt.Clear();
            }
            
        }

        private void leaveradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (leaveradiobtn.Checked == true)
            {
                leavetxt.Enabled = true;
                importtxt.Enabled = false;
                saldoactualtxt.Clear();
                importtxt.Clear();
            }
        }

        private void retireallradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (retireallradiobtn.Checked == true)
            {
                saldoactualtxt.Text = "0";
                importtxt.Clear(); importtxt.Enabled = false;
                leavetxt.Clear(); leavetxt.Enabled = false;

            }
        }

        private void importtxt_TextChanged(object sender, EventArgs e)
        {
            if (importradiobtn.Checked == true)
            {
                if (cierreactualtxt.Text!="")
                {
                    if (importtxt.Text != "")
                    {
                        saldoactualtxt.Text = Convert.ToString(Convert.ToDecimal(cierreactualtxt.Text) - Convert.ToDecimal(importtxt.Text));
                    }
                    else
                    {
                        saldoactualtxt.Text = cierreactualtxt.Text;
                    }
                }
                
            }
            
        }

        private void importtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            main.InputNumbers(sender, e);
        }

        private void leavetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            main.InputNumbers(sender, e);
        }

        private void leavetxt_TextChanged(object sender, EventArgs e)
        {
            if (leaveradiobtn.Checked ==true)
            {
                if (cierreactualtxt.Text != "")
                {
                    if (leavetxt.Text != "")
                    {
                        saldoactualtxt.Text = leavetxt.Text;
                    }
                    else
                    {
                        saldoactualtxt.Text = cierreactualtxt.Text;
                    }
                }
                   
            }
            
        }

        private void cerrarcajabtn_Click(object sender, EventArgs e)
        {

            cierrecajacms.Show(Cursor.Position.X, Cursor.Position.Y);

            
           
            
        }
        private decimal GetRetiro() {

                retiro = 0;

            if (noretireradiobtn.Checked ==true)
            {
                retiro = 0;
            }
            if (importradiobtn.Checked == true)
            {
                retiro = Convert.ToDecimal(importtxt.Text);
            }
            if (leaveradiobtn.Checked ==true)
            {
                decimal cierre = Convert.ToDecimal(cierreactualtxt.Text);
                decimal leave = Convert.ToDecimal(leavetxt.Text);

                retiro = cierre-leave ;
            }
            if (retireallradiobtn.Checked ==true)
            {
                retiro = Convert.ToDecimal(cierreactualtxt.Text);
            }


            return retiro;
        }

        private bool ValidateData() {

            if (cajatxt.Text=="")
            {
                return false;
            }
            if (importradiobtn.Checked == true && importtxt.Text == "")
            {
                return false;
            }
            if (leaveradiobtn.Checked == true && leavetxt.Text == "")
            {
                return false;

            }
            if (cierrecajadgv.Rows.Count<1)
            {
                return false;
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fechacierreactualtxt.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public async void PrintTicket( string storename, string printer, int cajanumber,decimal dev,decimal desc,
            decimal subtotal,decimal retire, decimal actualsaldo,decimal total,string username,string turno, decimal saldant,DateTime refdt)
        {
            //Microsoft XPS Document Writer

            CreateTicket ticket = new CreateTicket();



            //ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro(" "+storename);
            ticket.TextoCentro("CIERRE DE CAJA DE TURNO");
            ticket.TextoIzquierda("");

            //ticket.TextoIzquierda("EXPEDIDO EN: " + storeplace);
            //ticket.TextoIzquierda("DIREC: " + address);
            //ticket.TextoIzquierda("TELEF: " + storetelf);
            //ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
           // ticket.TextoIzquierda("EMAIL: " + storeemail);//Es el mio por si me quieren contactar ...
            //ticket.TextoIzquierda("");
            ticket.TextoExtremos("Caja # " + Convert.ToString(cajanumber), "DIA:" + refdt.ToString("dd/MM/yyyy"));
            ticket.TextoExtremos("Usuario: " + Convert.ToString(username), "");
            ticket.TextoExtremos("Turno: " + Convert.ToString(turno), "");

            ticket.LineasAsteriscos();

            //Sub cabecera.
            //ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("MOZO: ");
            //ticket.TextoIzquierda("MESA: " + "1");
            //ticket.TextoIzquierda("SECCION: " + "CAJA");
            //ticket.TextoIzquierda("CLIENTE: " + clientname);
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA DE CIERRE: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToLongTimeString());


            ticket.LineasAsteriscos();
            ticket.TextoIzquierda("");
           
           
                   
            ticket.TextoIzquierda("");

            //ticket.LineasIgual();


        
            foreach ( DataGridViewRow  row in cajadatadgv.Rows) {

                if (row.IsNewRow) continue;

                ticket.AgregarTotales(Convert.ToString(row.Cells[2].Value)+" . . . . S/.", Convert.ToDecimal(row.Cells[1].Value));

            }

                ticket.TextoIzquierda("");
                ticket.AgregarTotales("DEVOLUCIONES . . . S/.", dev);
                ticket.AgregarTotales("DESCUENTOS . . . . S/.", desc);
                ticket.TextoIzquierda("");
                ticket.AgregarTotales("SALDO ANTERIOR . . . S/.", saldant);
                ticket.TextoIzquierda("");
                ticket.AgregarTotales("SUBTOTAL . . . . . S/.", subtotal);
                ticket.LineasAsteriscos();
                ticket.AgregarTotales("RETIRO . . . . . . S/.", retire);
                ticket.LineasAsteriscos();
                ticket.AgregarTotales("SALDO ACTUAL . . . S/.", actualsaldo);
                ticket.LineasAsteriscos();
                ticket.AgregarTotales("TOTAL . . . . . . .S/.", total);
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("*Las devoluciones(si hay) ya estan restados del ");
                ticket.TextoIzquierda("subtotal ");
            
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");

            await Task.Run(() =>
            {
                GetPDF(ticket.linea, refdt.ToString("yyyyMMdd"), username, turno);
                GetCierreTurnoText(ticket.linea, refdt.ToString("yyyyMMdd"), username, turno);

            });



            ticket.CortaTicket();
            ticket.ImprimirTicket(printer);//Nombre de la impresora ticketera

            


        }
        public void PrintTicket2(string storename, string printer, int cajanumber, decimal dev, decimal desc,
           decimal subtotal, decimal retire, decimal actualsaldo, decimal total, DataTable sellsdetaildgv,decimal ef,decimal tv,
           decimal tm,decimal td,decimal ta,decimal saldant,DateTime refdt)
        {
            //Microsoft XPS Document Writer

            CreateTicket ticket = new CreateTicket();



            //ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro(" " + storename);
            ticket.TextoCentro("CIERRE DE CAJA TOTAL");
            ticket.TextoIzquierda("");

            //ticket.TextoIzquierda("EXPEDIDO EN: " + storeplace);
            //ticket.TextoIzquierda("DIREC: " + address);
            //ticket.TextoIzquierda("TELEF: " + storetelf);
            //ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
            // ticket.TextoIzquierda("EMAIL: " + storeemail);//Es el mio por si me quieren contactar ...
            //ticket.TextoIzquierda("");
            ticket.TextoExtremos("Caja # " + Convert.ToString(cajanumber), "DIA:" +refdt.ToString("dd/MM/yyyy"));
  
            ticket.LineasAsteriscos();

            //Sub cabecera.
            //ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("MOZO: ");
            //ticket.TextoIzquierda("MESA: " + "1");
            //ticket.TextoIzquierda("MESA: " + "1");
            //ticket.TextoIzquierda("SECCION: " + "CAJA");
            //ticket.TextoIzquierda("CLIENTE: " + clientname);
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA DE CIERRE: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToLongTimeString());


            ticket.LineasAsteriscos();
            ticket.TextoIzquierda("");



            ticket.TextoIzquierda("");

            //ticket.LineasIgual();

            ticket.TextoIzquierda("");
            ticket.AgregarTotales("EFECTIVO . . . S/.", ef);
            ticket.AgregarTotales("TARJETA VISA . . . S/.", tv);
            ticket.AgregarTotales("TARJETA MASTER . . . S/.", tm);
            ticket.AgregarTotales("TARJETA DINERS . . . S/.", td);
            ticket.AgregarTotales("TARJETA AMERICAN EXPRESS . . . S/.", ta);

            ticket.TextoIzquierda("");
            ticket.AgregarTotales("DEVOLUCIONES . . . S/.", dev);
            ticket.AgregarTotales("DESCUENTOS . . . . S/.", desc);
           
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("SALDO ANTERIOR . . . . . S/.", saldant);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("SUBTOTAL . . . . . S/.", subtotal);
            ticket.LineasAsteriscos();
            ticket.AgregarTotales("RETIRO . . . . . . S/.", retire);
            ticket.LineasAsteriscos();
            ticket.AgregarTotales("SALDO ACTUAL . . . S/.", actualsaldo);
            ticket.LineasAsteriscos();
            ticket.AgregarTotales("TOTAL . . . . . . .S/.", total);
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("*Las devoluciones(si hay) ya estan restados del ");
            ticket.TextoIzquierda("subtotal ");

            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("VENTAS------------------------------------------");
            ticket.TextoIzquierda("");
            ticket.EncabezadoSellsDetail();
            ticket.TextoIzquierda("");
            foreach (DataRow row in sellsdetaildgv.Rows)
            {



                ticket.AgregaArticulo3("_" + Convert.ToString(row[0]),


                     decimal.Parse(Convert.ToString(row[1])),


                     decimal.Parse(Convert.ToString(row[2])),



                     decimal.Parse(Convert.ToString(row[3])));

            }


            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");


            ticket.CortaTicket();
            ticket.ImprimirTicket(printer);//Nombre de la impresora ticketera




        }
        private bool GetPDF(StringBuilder data, string dt,string user,string turn)
        {

            
            try
            {
                string path = Main.actualuser + "\\TPVFiles";

                DirectoryInfo di = Directory.CreateDirectory(path);


                Document doc = new Document(PageSize.Halfletter);
                //doc.SetMargins(4,4,4,4);
                FileStream file = new FileStream(path + "\\CierreCaja" + dt +user+turn+".pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                PdfWriter writer = PdfWriter.GetInstance(doc, file);
                //doc.AddAuthor("");
                doc.AddTitle("CierreCaja " + dt + user + turn);
                doc.Open();

                doc.Add(new Phrase(data.ToString()));


                Console.WriteLine(path + "\\CierreCaja" + dt + user + turn + ".pdf");

                writer.Close();
                doc.Close();
                file.Dispose();
          


                return true;
            }
            catch (Exception)
            {

                return false;
            }



        }
        private bool GetCierreTurnoText(StringBuilder data, string dt, string user, string turn)
        {


            try
            {
                string path = Main.actualuser + "\\TPVFiles";

                DirectoryInfo di = Directory.CreateDirectory(path);


                File.WriteAllText(path + "\\CierreCaja" + dt + user + turn + ".txt", Convert.ToString(data)); 
               


                return true;
            }
            catch (Exception)
            {

                return false;
            }



        }
        private void printbtn_Click(object sender, EventArgs e)
        {
            printcierrecajacms.Show(Cursor.Position.X, Cursor.Position.Y);




        }

        private void empcajadgv_SelectionChanged(object sender, EventArgs e)
        {
             if (empcajadgv.Rows.Count>0)
            {
                foreach (DataGridViewRow row1 in empcajadgv.SelectedRows)
                {
                    ListCajas(datedtp.Value, Convert.ToInt32(row1.Cells[0].Value));
                }
            }
            else
            {
                cierrecajadgv.Columns.Clear();
                cajadatadgv.Columns.Clear();
            }
               

        }

        private void cierreDeTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CajaModel caja = new CajaModel();
            //state camp is useless i think

            if (ValidateData())
            {
                DialogResult a;
                a = MessageBox.Show("¿Estás seguro de cerrar la caja?", "Observacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (a == DialogResult.Yes)
                {
                    int cajanumber = Convert.ToInt32(cajatxt.Text);
                    DateTime refactual = datedtp.Value;




                    foreach (DataGridViewRow row1 in empcajadgv.SelectedRows)
                    {

                        if (!caja.SearchCierreCaja(cajanumber, refactual, Convert.ToInt32(row1.Cells[0].Value), Convert.ToInt32(row1.Cells[4].Value)))
                        {

                            decimal cierreactual = Convert.ToDecimal(cierreactualtxt.Text);
                            decimal saldoactual = Convert.ToDecimal(saldoactualtxt.Text);
                            decimal retired = GetRetiro();
                            DateTime fechacierreact = Convert.ToDateTime(fechacierreactualtxt.Text);
                            int empid = Convert.ToInt32(row1.Cells[0].Value);
                            string empname = Convert.ToString(row1.Cells[1].Value);
                            string emplastname = Convert.ToString(row1.Cells[2].Value);

                            int turn = Convert.ToInt32(row1.Cells[4].Value);
                            string turname = Convert.ToString(row1.Cells[3].Value);
                           

                            foreach (DataGridViewRow row in cierrecajadgv.SelectedRows)
                            {
                                string dev = Convert.ToString(row.Cells[3].Value), desc = Convert.ToString(row.Cells[4].Value);
                                if (dev == "") dev = "0";
                                if (desc == "") desc = "0";

                                decimal saldant = Convert.ToDecimal(saldocierreanttxt.Text.Replace(".", CultureInfo.CurrentCulture.
                        NumberFormat.NumberDecimalSeparator));

                   PrintTicket(Main.storename, Main.printer, cajanumber, Convert.ToDecimal(dev), Convert.ToDecimal(desc), Convert.ToDecimal(cierreactualtxt.Text), retiro,
                    Convert.ToDecimal(cierreactualtxt.Text) - retiro, Convert.ToDecimal(cierreactualtxt.Text) - retiro, empname + " " + emplastname, turname,saldant,refactual);
                               
                            }




                            caja.InsertToCierreCaja(cajanumber, cierreactual, saldoactual, retired, fechacierreact, refactual, 1, empid, turn);

                            foreach (DataGridViewRow row in cierrecajadgv.SelectedRows)
                            {
                                FillLastCierreCaja(Convert.ToInt32(cajanumber));
                            }

                            if (isadmin)
                            {
                                ListEmpByCaja(datedtp.Value);
                            }
                            else
                            {
                                ListEmpByCaja2(datedtp.Value, UserCache.IdUser);

                            }

                            Default();
                            saldoactualtxt.Text = "-";

                        }
                        else
                        {
                            MessageBox.Show("La caja ya fue cerrada anteriormente, si deseas solo imprimir presiona <Imprimir>", "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Default();

                            if (isadmin)
                            {
                                ListEmpByCaja(datedtp.Value);
                            }
                            else
                            {
                                ListEmpByCaja2(datedtp.Value, UserCache.IdUser);
                                
                            }
                        }



                    }








                }





            }
            else
            {
                MessageBox.Show("Completar los datos necesarios antes de cerrar la caja", "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void cierreGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cierreCajaTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cierreTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                CajaModel caja = new CajaModel();
                ProductModel product= new ProductModel();



               















                int cajanumber = Convert.ToInt32(cajatxt.Text);
                DateTime refactual = datedtp.Value;


                foreach (DataGridViewRow row1 in empcajadgv.Rows)
                {

                    if (!caja.SearchCierreCaja(cajanumber, refactual, Convert.ToInt32(row1.Cells[0].Value), Convert.ToInt32(row1.Cells[4].Value)))
                    {

                        MessageBox.Show("Hay turnos donde no se cerraron cajas, cerrar todos los turnos para continuar", "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        goto End;
                    }
                    

                }

               
                decimal saldant = Convert.ToDecimal(caja.GetSaldAnt(refactual, Main.cajanumber).Replace(".", CultureInfo.CurrentCulture.
                       NumberFormat.NumberDecimalSeparator));

                decimal cierremonto = Convert.ToDecimal(caja.ListTotalCaja(refactual,Main.cajanumber).Replace(".", CultureInfo.CurrentCulture.
                       NumberFormat.NumberDecimalSeparator)) ;

             
                decimal retire = caja.ListRetiredCaja(refactual, Main.cajanumber);

                decimal saldo = Convert.ToDecimal(caja.ListSaldoCaja(refactual,Main.cajanumber).Replace(".", CultureInfo.CurrentCulture.
                       NumberFormat.NumberDecimalSeparator));

                decimal ef = caja.GetTotalByPayMethod(refactual,Main.cajanumber,"EFECTIVO") ;
                decimal tv = caja.GetTotalByPayMethod(refactual, Main.cajanumber, "TARJETA VISA");
                decimal tm = caja.GetTotalByPayMethod(refactual, Main.cajanumber, "TARJETA MASTER");
                decimal td = caja.GetTotalByPayMethod(refactual, Main.cajanumber, "TARJETA DINERS");
                decimal ta = caja.GetTotalByPayMethod(refactual, Main.cajanumber, "TARJETA AMERICAN EXPRESS");


                decimal dev = caja.ListRefundCaja(refactual, Main.cajanumber),
                desc = caja.ListDiscountCaja(refactual,Main.cajanumber) ;



                DataTable SellsDetail = product.GetSellsDetailToDT(cajanumber, refactual);

                
                
                           
                PrintTicket2(Main.storename, Main.printer, Main.cajanumber, dev, desc, cierremonto, retire,
                saldo, saldo, SellsDetail,  ef,  tv,  tm,  td, ta, saldant,refactual);



                End:Console.WriteLine("Todas los turnos no fueron cerrados");
                        


            }
            else
            {
                MessageBox.Show("Selección invalida", "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Default();
            }
        }

        private void cierreactualtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void verPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void verPDFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void saldoactualtxt_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void saldoactualtxt_Click(object sender, EventArgs e)
        {
            
        }

        private void verPDFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in empcajadgv.SelectedRows)
            {

                string user = Convert.ToString(row.Cells[1].Value) + " " + Convert.ToString(row.Cells[2].Value);
                string turn = Convert.ToString(row.Cells[3].Value);

                string path =  Main.actualuser + "\\TPVFiles\\" + "CierreCaja" + datedtp.Value.ToString("yyyyMMdd") + user + turn + ".pdf";

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

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in empcajadgv.SelectedRows)
            {

                string user = Convert.ToString(row.Cells[1].Value) + " " + Convert.ToString(row.Cells[2].Value);
                string turn = Convert.ToString(row.Cells[3].Value);

                string path =  Main.actualuser + "\\TPVFiles\\" + "CierreCaja" + datedtp.Value.ToString("yyyyMMdd") + user + turn + ".txt";

                Console.WriteLine(path);

                if (File.Exists(path))
                {
                    string cc = File.ReadAllText(Main.actualuser + "\\TPVFiles\\" + "CierreCaja" + datedtp.Value.ToString("yyyyMMdd") + user + turn + ".txt");

                    CreateTicket ticket = new CreateTicket();

                    ticket.linea.Append(cc) ;
                    ticket.CortaTicket();
                    ticket.ImprimirTicket(Main.printer);//Nombre de la impresora ticketera

                }
                else
                {
                    MessageBox.Show("No se ubica el archivo PDF", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }
    }
}
