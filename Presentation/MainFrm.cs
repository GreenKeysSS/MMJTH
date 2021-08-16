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
using Common.Cache;
using Newtonsoft.Json;
using System.Globalization;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using AutoUpdaterDotNET;
using System.Configuration;
using ClosedXML.Excel;

namespace Presentation
{

    public partial class Main : Form
    {
        public bool dtotype;
        public static string actualuser = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static bool buyway = false;
        public static int cajanumber;
        public static string storename; //"MINIMARKET JANETH";
        //public static string storeplace = "LOCAL PRINCIPAL";
        public static string address;//"DIRECCION DE LA TIENDA";
        public static string storetelf;//"123456789";
        public static string storeemail; //"email@gmail.com";
        public static string emailsender;//"tpvsendemailtest@gmail.com";
        public static string emailpwd;//"Kimberly16";
        public static string printer; //"Microsoft XPS Document Writer";
        public static string sendmsg1;//"Gracias por su compra estimado";
        public static string sendmsg2; //"No olvide encontrarnos en nuestras tiendas";
        
        public Main()
        {
            AutoUpdater.InstalledVersion = Version.Parse("1.0.0.8");
            UpdateStart();
            InitializeComponent();
            EnableTab(menutab, false);
         
        }
        
        private void UpdateStart()
        {

            try
            {
           
                AutoUpdater.Mandatory = true;
                AutoUpdater.UpdateMode = Mode.Forced;
                AutoUpdater.ShowSkipButton = false;
                AutoUpdater.ShowRemindLaterButton = false;
                AutoUpdater.DownloadPath = Environment.CurrentDirectory;
                AutoUpdater.Start("https://raw.githubusercontent.com/wabutt/itsmevsauce/master/TPVMinimarketAG/AutoUpdater.xml");
       
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message, "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool ValidateLocalData()
        {

            if (ReadSetting("cajanumber") == "") return false;
            if (ReadSetting("storename") == "") return false;
            if (ReadSetting("storeaddress") == "") return false;
            if (ReadSetting("storetelf") == "") return false;
            if (ReadSetting("storeemail") == "") return false;
            if (ReadSetting("senderemail") == "") return false;
            if (ReadSetting("senderpwd") == "") return false;
            if (ReadSetting("printername") == "") return false;
            if (ReadSetting("sendermsg1") == "") return false;
            //if (ReadSetting("sendermsg2") == "") return false;

            return true;
        }

        private bool CheckAvail() {



            if (ValidateLocalData())
            {
                try
                {
                    cajanumber = int.Parse(ReadSetting("cajanumber"));
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
              

                storename = ReadSetting("storename"); //"MINIMARKET JANETH";
                address = ReadSetting("storeaddress");//"DIRECCION DE LA TIENDA";
                storetelf = ReadSetting("storetelf");//"123456789";
                storeemail = ReadSetting("storeemail"); //"email@gmail.com";
                emailsender = ReadSetting("senderemail");//"tpvsendemailtest@gmail.com";
                emailpwd = ReadSetting("senderpwd");//"Kimberly16";
                printer = ReadSetting("printername"); //"Microsoft XPS Document Writer";
                sendmsg1 = ReadSetting("sendermsg1");//"Gracias por su compra estimado";
                sendmsg2 = ReadSetting("sendermsg2"); //"No olvide encontrarnos en nuestras tiendas";




                return true;
            }
            else
            {
                MessageBox.Show("Configurar datos necesarios en <Configuraciones>", "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        
        static string ReadSetting(string key)
        {


            string result = "";



            try
            {
                var appSettings = ConfigurationManager.AppSettings;


                result = appSettings[key] ?? "";



            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
                result = "";
            }
            return result;
        }

        

        static void AddUpdateAppSettings(string key, string value)
        {


            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        private void press1btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = pwdtxt.Text;
                pwdtxt.Text = pwd + "1";

            }
            catch (Exception)
            {

                throw;
            }


        }
        public DataTable ListSellsDetailAdmin(DateTime dt)
        {
            ProductModel product = new ProductModel();
            return product.ListSellsDetailAdmin(dt);
        }
        public DataTable ListSellsByIdVenta(int idventa)
        {
            ProductModel product = new ProductModel();
            return product.ListSellsProductsByIdVenta(idventa);
        }
        private void press2btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = pwdtxt.Text;
                pwdtxt.Text = pwd + "2";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void press3btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = pwdtxt.Text;
                pwdtxt.Text = pwd + "3";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void press4btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = pwdtxt.Text;
                pwdtxt.Text = pwd + "4";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void press5btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = pwdtxt.Text;
                pwdtxt.Text = pwd + "5";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void press6btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = pwdtxt.Text;
                pwdtxt.Text = pwd + "6";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void press7btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = pwdtxt.Text;
                pwdtxt.Text = pwd + "7";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void press8btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = pwdtxt.Text;
                pwdtxt.Text = pwd + "8";

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void press9btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = pwdtxt.Text;
                pwdtxt.Text = pwd + "9";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void press0btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = pwdtxt.Text;
                pwdtxt.Text = pwd + "0";

            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool DeleteSavedSell(string id)
        {

            ProductModel product = new ProductModel();

            if (product.DeleteSavedSell(id))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        private void pressgridbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string pwd = pwdtxt.Text;
                pwdtxt.Text = pwd + "*";

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void StateNumberButtonsLogin(bool state) {

            press1btn.Enabled = state;
            press2btn.Enabled = state;
            press3btn.Enabled = state;
            press4btn.Enabled = state;
            press5btn.Enabled = state;
            press6btn.Enabled = state;
            press7btn.Enabled = state;
            press8btn.Enabled = state;
            press9btn.Enabled = state;
            press0btn.Enabled = state;
            clearpwdbtn.Enabled = state;
            backspace1btn.Enabled = state;
            enterbtn.Enabled = state;
            pwdtxt.Enabled = state;

        }
        private async void enterbtn_Click(object sender, EventArgs e)
        {
            if (pwdtxt.Text != "")
            {
                try
                {

                    var validLogin = false;
                    UserModel user = new UserModel();

                    StateNumberButtonsLogin(false);
                    validateloginlbl.Visible = true;

                    await Task.Run(() =>
                    {
                        try
                        {
                            validLogin = user.LoginUser(usertypelbl.Text, pwdtxt.Text);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message + "\nIntente Otra vez", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                          

                        }
                      

                    });

                    validateloginlbl.Visible = false;


                    StateNumberButtonsLogin(true);



                    if (validLogin == true)
                    {


                        EnableTab(menutab, true);
                        if (UserCache.Position =="CAJA")
                        {
                            usermaintenancebtn.Visible = false;
                            listsbtn.Visible = false;
                            almacenbtn.Visible = false;
                            settingsbtn.Visible = false;
                            cajabtn.Visible = true;
                        }

                        if (UserCache.Position == "ADMIN")
                        {
                            usermaintenancebtn.Visible = true;
                            listsbtn.Visible = true;
                            almacenbtn.Visible = true;
                            settingsbtn.Visible = true;
                            cajabtn.Visible = true;
                            
                        }
                        if (UserCache.Position == "ALMACEN")
                        {
                            usermaintenancebtn.Visible = false;
                            listsbtn.Visible = false;
                            almacenbtn.Visible = true;
                            settingsbtn.Visible = false;
                            cajabtn.Visible = false;
                        }

                        DisableSafeMode();
                        maintab.SelectedTab = menutab;
                        FeaturedTab.SelectedTab = welcometab;
                        usernamelbl.Text = UserCache.Name+" "+UserCache.LastName;
                        rollbl.Text = UserCache.Position;
                        timeclock.Start();


                        //apptab.SelectedTab = bottab;
                        //EnableTab(logintab, false);


                    }
                    else
                    {

                        if (UserCache.State == "NO ACTIVO")
                        {
                            MessageBox.Show("El usuario ingresado no se encuentra activado.\nContactar al administrador.", "Observacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            pwdtxt.Clear();
                            pwdtxt.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Las credenciales ingresadas no coinciden con los registros.\nIntente otra vez.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pwdtxt.Clear();
                            pwdtxt.Focus();
                        }
                        





                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + "\nIntente Otra vez", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }




            }
            else
            {
                MessageBox.Show("Ingresar Clave de Seguridad", "Autenticación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pwdtxt.Focus();
            }
        }
        public static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }

        private void clearpwdbtn_Click(object sender, EventArgs e)
        {
            try
            {
                pwdtxt.Clear();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void focusbarcodetemp()
        {
            //this.ActiveControl = barcodetemptxt;
            barcodetemptxt.Focus();
            barcodetemptxt.SelectAll();
        }
        public void focusbarcodetemp2()
        {
            //this.ActiveControl = buyprodcodetxt;
            buyprodcodetxt.Focus();
            buyprodcodetxt.SelectAll();
        }

        private void timeclock_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToString("HH:mm");

            //lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblSecond.Location.Y);

        }



        private void backspace1btn_Click(object sender, EventArgs e)
        {
            if (pwdtxt.Text.Length != 0)
            {

                try
                {
                    pwdtxt.Text = pwdtxt.Text.Remove(pwdtxt.Text.Length - 1, 1);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }





        }
        public void SortMainDGV()
        {
            if (Productsdgv.Rows.Count > 0)
            {
                Productsdgv.Rows.OfType<DataGridViewRow>().Last().Selected = true;
                Productsdgv.FirstDisplayedScrollingRowIndex = Productsdgv.RowCount - 1;
            }

        }
        public void SortMainDGV2()
        {
            if (buynewdgv.Rows.Count > 0)
            {
                buynewdgv.Rows.OfType<DataGridViewRow>().Last().Selected = true;
                buynewdgv.FirstDisplayedScrollingRowIndex = buynewdgv.RowCount - 1;
            }

        }
        private void back1btn_Click(object sender, EventArgs e)
        {
            maintab.SelectedTab = starttab;
        }

        private void barcodetemptxt_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {

                ProductModel product = new ProductModel();



                if (product.SearchProductByBarCode(barcodetemptxt.Text))
                {

                   // subtotalpricelbl.Text = Convert.ToString(AddTotal(ProductCache.Preciov));




                    Productsdgv.Rows.Add(ProductCache.Name, ProductCache.Preciov, 1, ProductCache.Preciov, ProductCache.Barcode,ProductCache.Family);
                    SortMainDGV();






                    focusbarcodetemp();

                }
                else
                {
                    focusbarcodetemp();
                    MessageBox.Show("Producto no encontrado en el Inventario", "Obseervación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
          
                if (e.KeyCode == Keys.F5)
                {
                    Console.WriteLine("presione f5");
                    focusbarcodetemp();

                }
                if (e.KeyCode == Keys.F6)
                {
                    Console.WriteLine("presione f6");
                    focusbarcodetemp();
                    SearchProdFrm s = new SearchProdFrm(this)
                    {
                        sway = true
                    };
                   
                    s.ShowDialog();


                }
                if (e.KeyCode == Keys.F4)
                {
                    Console.WriteLine("presione f4");
                    FocusClientData();


                    ClientFrm client = new ClientFrm(this);

                    client.ShowDialog();


                }
                if (e.KeyCode == Keys.F3)
                {
                    ViewActiveSellsFrm view = new ViewActiveSellsFrm(this);
                    view.ShowDialog();



                }
                if (e.KeyCode == Keys.F1)
                {

                    if (Productsdgv.Rows.Count > 0)
                    {
                        DialogResult a;

                        a = MessageBox.Show("¿Estás seguro de crear una nueva venta?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (a == DialogResult.Yes)
                        {
                            NewSellActions();
                        }
                    }
                    else
                    {
                        NewSellActions();
                    }


                }
                if (e.KeyCode == Keys.F9)
                {
                    if (paymethodcbo.SelectedIndex != 0)
                    {
                        EndSellAction();
                    }
                    else
                    {
                        MessageBox.Show("Seleccionar forma de pago ", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }




                }

            
        }

        private void scancodebarbtn_Click(object sender, EventArgs e)
        {
            focusbarcodetemp();
        }
        private decimal AddTotal(decimal price)
        {



            decimal ActualValue = Convert.ToDecimal(subtotalpricelbl.Text);

            decimal NewValue = ActualValue + price;

            return NewValue;
        }
       


        private decimal LessTotal(decimal price)
        {



            decimal ActualValue = Convert.ToDecimal(subtotalpricelbl.Text);

            decimal ActualValueFromProduct = price;

            decimal NewValue = ActualValue - ActualValueFromProduct;

            return NewValue;
        }

        private void Productsdgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Productsdgv.SelectedRows)
            {
                
                focusbarcodetemp();

            }

        }

        private void Productsdgv_Click(object sender, EventArgs e)
        {
            
        }

        private void Productsdgv_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void deleteproductsbtn_Click(object sender, EventArgs e)
        {
            if (Productsdgv.RowCount > 0)
            {
                foreach (DataGridViewRow row in Productsdgv.SelectedRows)
                {




                    if (Productsdgv.Rows.Count >= 0)
                    {
                        decimal newValue = LessTotal(Convert.ToDecimal(Productsdgv.SelectedCells[3].Value));

                        subtotalpricelbl.Text = Convert.ToString(newValue);
                    }

                    Productsdgv.Rows.RemoveAt(row.Index);

                }
            }
            SortMainDGV();
            focusbarcodetemp();

        }

        private void exitfromcajabtn_Click(object sender, EventArgs e)
        {

            if (Productsdgv.Rows.Count > 0)
            {
                DialogResult a;
                a = MessageBox.Show("¡Tienes una venta en curso! ¿Deseas salir de todas formas?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    NewSellActions();
                    maintab.SelectedTab = starttab;
                    EnableTab(menutab,false);
                }

            }
            else
            {
                NewSellActions();
                maintab.SelectedTab = starttab;
                EnableTab(menutab, false);
            }

        }

        private void backtofamilybtn_Click(object sender, EventArgs e)
        {
            pickertab.SelectedTab = Familytab;
            focusbarcodetemp();
        }



        private DataTable ListProducts(string keyword)
        {

            ProductModel product = new ProductModel();

            return product.ListProducts(keyword);

        }

        private void productsbyfamilydgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            foreach (DataGridViewRow row in productsbyfamilydgv.SelectedRows)
            {
                actualproductselectedlbl.Text =Convert.ToString( row.Cells[0].Value);
                precventlbl.Text = Convert.ToString(row.Cells[1].Value);
                barcodelbl.Text = Convert.ToString(row.Cells[2].Value);
                //medlbl.Text = row.Cells[2].Value.ToString();



                //string value2 = row.Cells[1].Value.ToString();

                focusbarcodetemp();

            }

            pickertab.SelectedTab = Digitadortab;
            focusbarcodetemp();

        }

        private void backtosubfamilybtn_Click(object sender, EventArgs e)
        {
            actualproductselectedlbl.Text = "";
            precventlbl.Text = "0";
            cantlbl.Text = "0";
            medlbl.Text = "";
            barcodelbl.Text = "";
            totalprodlbl.Text = "0";
            pickertab.SelectedTab = Subfamilytab;
            displayerdigitadorlbl.Text = "";
            //dtolbl.Text = "";
            focusbarcodetemp();
        }

        private void pickernumber0btn_Click(object sender, EventArgs e)
        {
            try
            {
                string value = displayerdigitadorlbl.Text;
                displayerdigitadorlbl.Text = value + "0";

            }
            catch (Exception)
            {

                throw;
            }
            focusbarcodetemp();
        }

        private void pickercommabtn_Click(object sender, EventArgs e)
        {
            try
            {
                string value = displayerdigitadorlbl.Text;
                displayerdigitadorlbl.Text = value + ",";

            }
            catch (Exception)
            {

                throw;
            }
            focusbarcodetemp();
        }

        private void pickernumber1btn_Click(object sender, EventArgs e)
        {
            try
            {
                string value = displayerdigitadorlbl.Text;
                displayerdigitadorlbl.Text = value + "1";

            }
            catch (Exception)
            {

                throw;
            }
            focusbarcodetemp();
        }

        private void pickernumber2btn_Click(object sender, EventArgs e)
        {
            try
            {
                string value = displayerdigitadorlbl.Text;
                displayerdigitadorlbl.Text = value + "2";

            }
            catch (Exception)
            {

                throw;
            }
            focusbarcodetemp();
        }

        private void pickernumber3btn_Click(object sender, EventArgs e)
        {
            try
            {
                string value = displayerdigitadorlbl.Text;
                displayerdigitadorlbl.Text = value + "3";

            }
            catch (Exception)
            {

                throw;
            }
            focusbarcodetemp();
        }

        private void pickernumber4btn_Click(object sender, EventArgs e)
        {
            try
            {
                string value = displayerdigitadorlbl.Text;
                displayerdigitadorlbl.Text = value + "4";

            }
            catch (Exception)
            {

                throw;
            }
            focusbarcodetemp();
        }

        private void pickernumber5btn_Click(object sender, EventArgs e)
        {
            try
            {
                string value = displayerdigitadorlbl.Text;
                displayerdigitadorlbl.Text = value + "5";

            }
            catch (Exception)
            {

                throw;
            }
            focusbarcodetemp();
        }

        private void pickernumber6btn_Click(object sender, EventArgs e)
        {
            try
            {
                string value = displayerdigitadorlbl.Text;
                displayerdigitadorlbl.Text = value + "6";

            }
            catch (Exception)
            {

                throw;
            }
            focusbarcodetemp();
        }

        private void pickernumber7btn_Click(object sender, EventArgs e)
        {
            try
            {
                string value = displayerdigitadorlbl.Text;
                displayerdigitadorlbl.Text = value + "7";

            }
            catch (Exception)
            {

                throw;
            }

            focusbarcodetemp();
        }

        private void pickernumber8btn_Click(object sender, EventArgs e)
        {
            try
            {
                string value = displayerdigitadorlbl.Text;
                displayerdigitadorlbl.Text = value + "8";

            }
            catch (Exception)
            {

                throw;
            }
            focusbarcodetemp();
        }

        private void pickernumber9btn_Click(object sender, EventArgs e)
        {
            try
            {
                string value = displayerdigitadorlbl.Text;
                displayerdigitadorlbl.Text = value + "9";

            }
            catch (Exception)
            {

                throw;
            }
            focusbarcodetemp();
        }

        private void pickerdeletebtn_Click(object sender, EventArgs e)
        {
            if (displayerdigitadorlbl.Text.Length != 0)
            {

                try
                {
                    displayerdigitadorlbl.Text = displayerdigitadorlbl.Text.Remove(displayerdigitadorlbl.Text.Length - 1, 1);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            focusbarcodetemp();

        }

        private void pickercantbtn_Click(object sender, EventArgs e)
        {
            if (displayerdigitadorlbl.Text != "")
            {

                if (displayerdigitadorlbl.Text.Contains(","))
                {
                    if (!allCharactersSame(displayerdigitadorlbl.Text))
                    {
                        try
                        {
                            decimal cant = Convert.ToDecimal(displayerdigitadorlbl.Text);
                            decimal price = Convert.ToDecimal(precventlbl.Text);


                            totalprodlbl.Text = Convert.ToString(cant * price);

                            cantlbl.Text = Convert.ToString(cant);

                            displayerdigitadorlbl.Text = "";
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                }
                else
                {
                    decimal cant = Convert.ToDecimal(displayerdigitadorlbl.Text);
                    decimal price = Convert.ToDecimal(precventlbl.Text);

                    totalprodlbl.Text = Convert.ToString(cant * price);

                    cantlbl.Text = displayerdigitadorlbl.Text;

                    displayerdigitadorlbl.Text = "";
                }





            }
            else
            {
                MessageBox.Show("Digitar cantidad del producto", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            focusbarcodetemp();




        }
        private bool allCharactersSame(string s)
        {

            int n = s.Length;
            for (int i = 1; i < n; i++)
                if (s[i] != s[0])
                    return false;

            return true;
        }
        private void pickerprecbtn_Click(object sender, EventArgs e)
        {
            if (displayerdigitadorlbl.Text != "")
            {






                if (displayerdigitadorlbl.Text.Contains(","))
                {
                    if (!allCharactersSame(displayerdigitadorlbl.Text))
                    {
                        if (cantlbl.Text != "")
                        {
                            try
                            {
                                decimal cant = Convert.ToDecimal(cantlbl.Text);
                                decimal price = Convert.ToDecimal(displayerdigitadorlbl.Text);

                                totalprodlbl.Text = Convert.ToString(cant * price);

                                precventlbl.Text = Convert.ToString(price);
                                displayerdigitadorlbl.Text = "";
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
                    if (cantlbl.Text != "")
                    {
                        decimal cant = Convert.ToDecimal(cantlbl.Text);
                        decimal price = Convert.ToDecimal(displayerdigitadorlbl.Text);

                        totalprodlbl.Text = Convert.ToString(cant * price);


                    }
                    precventlbl.Text = displayerdigitadorlbl.Text;
                    displayerdigitadorlbl.Text = "";

                }




            }
            else
            {
                MessageBox.Show("Digitar precio del producto", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            focusbarcodetemp();

        }

        private void pickerdtobtn_Click(object sender, EventArgs e)
        {/*
            dtolbl.Text = displayerdigitadorlbl.Text;
            displayerdigitadorlbl.Text = "";*/
            focusbarcodetemp();
        }

        private void pickerclearbtn_Click(object sender, EventArgs e)
        {
            try
            {
                displayerdigitadorlbl.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
            focusbarcodetemp();
        }

        private void pickertab_Click(object sender, EventArgs e)
        {
            focusbarcodetemp();
        }

        private void pickerokbtn_Click(object sender, EventArgs e)
        {




            if (cantlbl.Text == "0")
            {
                DialogResult a;
                a = MessageBox.Show("NO SE INSERTÓ LA CANTIDAD A VENDER DEL PRODUCTO ¿DESEA CONTINUAR? ", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {
                    ProductModel prod = new ProductModel();
                    string family = prod.SearchFamilyByBarCode(barcodelbl.Text);
                    Console.WriteLine(family);

                    //subtotalpricelbl.Text = Convert.ToString(AddTotal(Convert.ToDecimal(totalprodlbl.Text)));

                    
                    Productsdgv.Rows.Add(actualproductselectedlbl.Text/* + "(por " + medlbl.Text + ")"*/, Convert.ToDecimal(precventlbl.Text).ToString("#,#.00"), cantlbl.Text, Convert.ToDecimal(totalprodlbl.Text).ToString("#,#.00"), barcodelbl.Text,family);


                    SortMainDGV();
                    focusbarcodetemp();


                }
            }

            else
            {
                ProductModel prod = new ProductModel();

                string family = prod.SearchFamilyByBarCode(barcodelbl.Text);
         


                //subtotalpricelbl.Text = Convert.ToString(AddTotal(Convert.ToDecimal(totalprodlbl.Text)));


               
                Productsdgv.Rows.Add(actualproductselectedlbl.Text/* + "(" + medlbl.Text + ")"*/, Convert.ToDecimal(precventlbl.Text).ToString("#,#.00"), cantlbl.Text, Convert.ToDecimal(totalprodlbl.Text).ToString("#,#.00"), barcodelbl.Text,family);



                SortMainDGV();
                focusbarcodetemp();

            }






        }

        private void endsellbtn_Click(object sender, EventArgs e)
        {
            focusbarcodetemp();
            if (paymethodcbo.SelectedIndex != 0)
            {
                EndSellAction();
            }
            else
            {
                MessageBox.Show("Seleccionar forma de pago ", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void EndSellAction()
        {


            if (Productsdgv.Rows.Count > 0)
            {
                MoneySellManageFrm money = new MoneySellManageFrm(this);
                money.ShowDialog();



            }
            else
            {
                MessageBox.Show("No existen datos a guardar, agregar productos a la venta", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                focusbarcodetemp();
            }

        }
        private void ErrorHandling(string ex)
        {
            MessageBox.Show(ex, "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void pwdtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                enterbtn.PerformClick();

            }


        }

        public void PrintTicket2(DataGridView dgv, string storename, string address,
            string storetelf, string storeemail, decimal total,
            decimal subtotal, decimal descuento, decimal igv, decimal gravada, string printer,
            string dt, int cajanumber, string clientname, decimal efectivo, string paymethod)
        {
            //Microsoft XPS Document Writer

            CreateTicket ticket = new CreateTicket();



            //ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro(storename);
            ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("EXPEDIDO EN: " + storeplace);
            ticket.TextoIzquierda("DIREC: " + address);
            ticket.TextoIzquierda("TELEF: " + storetelf);
            //ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
            ticket.TextoIzquierda("EMAIL: " + storeemail);//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Caja # " + Convert.ToString(cajanumber), "Ticket # " + Convert.ToString(cajanumber) + "-" + dt);
            ticket.LineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("MOZO: ");
            //ticket.TextoIzquierda("MESA: " + "1");
            //ticket.TextoIzquierda("SECCION: " + "CAJA");
            ticket.TextoIzquierda("CLIENTE: " + clientname);
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToLongTimeString());
            ticket.LineasAsteriscos();
            ticket.TextoIzquierda("");
            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.LineasAsteriscos();
            ticket.TextoIzquierda("");
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            foreach (DataGridViewRow fila in dgv.Rows)//dgvLista es el nombre del datagridview
            {
                if (fila.IsNewRow) continue;


                if (Convert.ToString(fila.Cells[6].Value) == "VENDIDO")
                {
                    ticket.AgregaArticulo("-" + Convert.ToString(fila.Cells[1].Value),


                   double.Parse(Convert.ToString(fila.Cells[3].Value)),


                   decimal.Parse(Convert.ToString(fila.Cells[2].Value)),



                   decimal.Parse(Convert.ToString(fila.Cells[4].Value)));
                }
               


            }/*
                    ticket.AgregaArticulo("Articulo A", 2, 20, 40);
                    ticket.AgregaArticulo("Articulo B", 1, 10, 10);
                    ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);*/
            ticket.TextoIzquierda("");

            ticket.LineasIgual();


            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("SUBTOTAL......S/.", subtotal);
            ticket.AgregarTotales("DTO...........S/.", descuento);
            //ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#


            ticket.TextoIzquierda("");
            ticket.AgregarTotales("GRAVADA.......S/.", gravada);
            ticket.AgregarTotales("IGV...........S/.", igv);


            ticket.AgregarTotales("TOTAL.........S/.", total);


            ticket.TextoIzquierda("");



            if (paymethod == "EFECTIVO")
            {
                ticket.TextoIzquierda("FORMA DE PAGO:" + " EFECTIVO");
                ticket.TextoIzquierda("");

                ticket.AgregarTotales("EFECTIVO...S/.", efectivo);
                ticket.AgregarTotales("CAMBIO.....S/.", efectivo - total);
            }
            else
            {
                ticket.TextoIzquierda("FORMA DE PAGO:" + " TARJETA");
                ticket.TextoIzquierda("");
                ticket.AgregarTotales(paymethod + "...S/.", efectivo);
                //ticket.AgregarTotales5("CAMBIO.....S/.", efectivo - total);
            }



            //Texto final del Ticket.

            //ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: 3");
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");



            ticket.CortaTicket();
            ticket.ImprimirTicket(printer);//Nombre de la impresora ticketera




        }
        public void PrintTicket(DataGridView dgv, string storename, string address,
            string storetelf, string storeemail, decimal total,
            decimal subtotal, decimal descuento, decimal igv, decimal gravada, string printer,
            string dt, int cajanumber, string clientname, decimal efectivo, string paymethod)
        {
            //Microsoft XPS Document Writer

            CreateTicket ticket = new CreateTicket();



            //ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro(storename);
            ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("EXPEDIDO EN: " + storeplace);
            ticket.TextoIzquierda("DIREC: " + address);
            ticket.TextoIzquierda("TELEF: " + storetelf);
            //ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
            ticket.TextoIzquierda("EMAIL: " + storeemail);//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Caja # " + Convert.ToString(cajanumber), "Ticket # " + Convert.ToString(cajanumber) + "-" + dt);
            ticket.LineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("MOZO: ");
            //ticket.TextoIzquierda("MESA: " + "1");
            //ticket.TextoIzquierda("SECCION: " + "CAJA");
            ticket.TextoIzquierda("CLIENTE: " + clientname);
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToLongTimeString());
            ticket.LineasAsteriscos();
            ticket.TextoIzquierda("");
            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.LineasAsteriscos();
            ticket.TextoIzquierda("");
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            foreach (DataGridViewRow fila in dgv.Rows)//dgvLista es el nombre del datagridview
            {
                if (fila.IsNewRow) continue;

                ticket.AgregaArticulo("-" + Convert.ToString(fila.Cells[0].Value), 
                    
                    
                    double.Parse(Convert.ToString( fila.Cells[2].Value)),


                    decimal.Parse(Convert.ToString( fila.Cells[1].Value)),
                    
                    
                    
                    decimal.Parse(Convert.ToString( fila.Cells[3].Value)));


            }/*
                    ticket.AgregaArticulo("Articulo A", 2, 20, 40);
                    ticket.AgregaArticulo("Articulo B", 1, 10, 10);
                    ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);*/
            ticket.TextoIzquierda("");

            ticket.LineasIgual();


            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("SUBTOTAL......S/.", subtotal);
            ticket.AgregarTotales("DTO...........S/.", descuento);
            //ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#


            ticket.TextoIzquierda("");
            ticket.AgregarTotales("GRAVADA.......S/.", gravada);
            ticket.AgregarTotales("IGV...........S/.", igv);


            ticket.AgregarTotales("TOTAL.........S/.", total);


            ticket.TextoIzquierda("");



            if (paymethod == "EFECTIVO")
            {
                ticket.TextoIzquierda("FORMA DE PAGO:" + " EFECTIVO");
                ticket.TextoIzquierda("");

                ticket.AgregarTotales("EFECTIVO...S/.", efectivo);
                ticket.AgregarTotales("CAMBIO.....S/.", efectivo - total);
            }
            else
            {
                ticket.TextoIzquierda("FORMA DE PAGO:" + " TARJETA");
                ticket.TextoIzquierda("");
                ticket.AgregarTotales(paymethod + "...S/.", efectivo);
                //ticket.AgregarTotales5("CAMBIO.....S/.", efectivo - total);
            }



            //Texto final del Ticket.

            //ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: 3");
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");



            ticket.CortaTicket();
            ticket.ImprimirTicket(printer);//Nombre de la impresora ticketera




        }



        public async void PrintTickettoPDF(DataGridView dgv, string storename, string storeaddress, string storetelf, string storeemail, decimal total,
           decimal subtotal, decimal descuento, decimal igv, decimal gravada,
           string dt, int cajanumber, string clientname, decimal efectivo, string paymethod)
        {
            //Microsoft XPS Document Writer

            CreateTicket ticket = new CreateTicket();



            //ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro2(storename);

            ticket.TextoIzquierda("");
           // ticket.TextoIzquierda("EXPEDIDO EN: " + storeplace);
            ticket.TextoIzquierda("DIREC: " + storeaddress);
            ticket.TextoIzquierda("TELEF: " + storetelf);
            //ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
            ticket.TextoIzquierda("EMAIL: " + storeemail);//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Caja # " + Convert.ToString(cajanumber), "Ticket # " + Convert.ToString(cajanumber) + "-" + dt);
            ticket.LineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("MOZO: ");
            //ticket.TextoIzquierda("MESA: " + "1");
            //ticket.TextoIzquierda("SECCION: " + "CAJA");
            ticket.TextoIzquierda("CLIENTE: " + clientname);
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToLongTimeString());
            ticket.LineasAsteriscos();
            ticket.TextoIzquierda("");
            //Articulos a vender.
            ticket.EncabezadoVenta2();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.LineasAsteriscos();
            ticket.TextoIzquierda("");
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            foreach (DataGridViewRow fila in dgv.Rows)//dgvLista es el nombre del datagridview
            {
                if (fila.IsNewRow) continue;

                ticket.AgregaArticulo2("-" +
                    fila.Cells[0].Value.ToString(),
                    double.Parse(fila.Cells[2].Value.ToString()),
                    decimal.Parse(fila.Cells[1].Value.ToString()),
                    decimal.Parse(fila.Cells[3].Value.ToString()));
            }/*
                    ticket.AgregaArticulo("Articulo A", 2, 20, 40);
                    ticket.AgregaArticulo("Articulo B", 1, 10, 10);
                    ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);*/
            ticket.TextoIzquierda("");

            ticket.LineasIgual2();

            //Resumen de la venta. Sólo son ejemplos









            ticket.AgregarTotales2("SUBTOTAL...S/.", subtotal, 2);
            //ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#
            ticket.AgregarTotales2("DTO........S/.", descuento, -1);


            //ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#

            ticket.TextoIzquierda("");



            ticket.AgregarTotales2("GRAVADA.......S/.", gravada, 1);
            ticket.AgregarTotales2("IGV...........S/.", igv, -3);
            ticket.TextoIzquierda("");

            ticket.AgregarTotales2("TOTAL.........S/.", total, -1);

            ticket.TextoIzquierda("");

            if (paymethod == "EFECTIVO")
            {
                ticket.TextoIzquierda("FORMA DE PAGO:" + " EFECTIVO");
                ticket.TextoIzquierda("");



                ticket.AgregarTotales2("EFECTIVO..S/.", efectivo, 2);
                ticket.AgregarTotales2("CAMBIO....S/.", efectivo - total, 1);
            }
            else
            {
                ticket.TextoIzquierda("FORMA DE PAGO:" + " TARJETA");
                ticket.TextoIzquierda("");



                ticket.AgregarTotales2(paymethod + "...S/.", efectivo, 2);
                //ticket.AgregarTotales5("CAMBIO.....S/.", efectivo - total);
            }




            //Texto final del Ticket.

            //ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: 3");
            ticket.TextoIzquierda("");
            ticket.TextoCentro2("¡GRACIAS POR SU COMPRA!");

            await Task.Run(() =>
            {
                GetPDF(ticket.linea, dt);
            });
            


        }
        public async void PrintTickettoPDF2(DataGridView dgv, string storename, string storeaddress, string storetelf, string storeemail, decimal total,
          decimal subtotal, decimal descuento, decimal igv, decimal gravada,
          string dt, int cajanumber, string clientname, decimal efectivo, string paymethod)
        {
            //Microsoft XPS Document Writer

            CreateTicket ticket = new CreateTicket();



            //ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro2(storename);

            ticket.TextoIzquierda("");
            // ticket.TextoIzquierda("EXPEDIDO EN: " + storeplace);
            ticket.TextoIzquierda("DIREC: " + storeaddress);
            ticket.TextoIzquierda("TELEF: " + storetelf);
            //ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
            ticket.TextoIzquierda("EMAIL: " + storeemail);//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Caja # " + Convert.ToString(cajanumber), "Ticket # " + Convert.ToString(cajanumber) + "-" + dt);
            ticket.LineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("MOZO: ");
            //ticket.TextoIzquierda("MESA: " + "1");
            //ticket.TextoIzquierda("SECCION: " + "CAJA");
            ticket.TextoIzquierda("CLIENTE: " + clientname);
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToLongTimeString());
            ticket.LineasAsteriscos();
            ticket.TextoIzquierda("");
            //Articulos a vender.
            ticket.EncabezadoVenta2();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.LineasAsteriscos();
            ticket.TextoIzquierda("");
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            foreach (DataGridViewRow fila in dgv.Rows)//dgvLista es el nombre del datagridview
            {
                if (fila.IsNewRow) continue;


                if (Convert.ToString(fila.Cells[6].Value) == "VENDIDO")
                {
                    ticket.AgregaArticulo("-" + Convert.ToString(fila.Cells[1].Value),


                   double.Parse(Convert.ToString(fila.Cells[3].Value)),


                   decimal.Parse(Convert.ToString(fila.Cells[2].Value)),



                   decimal.Parse(Convert.ToString(fila.Cells[4].Value)));
                }



            }/*
                    ticket.AgregaArticulo("Articulo A", 2, 20, 40);
                    ticket.AgregaArticulo("Articulo B", 1, 10, 10);
                    ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);*/
            ticket.TextoIzquierda("");

            ticket.LineasIgual2();

            //Resumen de la venta. Sólo son ejemplos









            ticket.AgregarTotales2("SUBTOTAL...S/.", subtotal, 2);
            //ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#
            ticket.AgregarTotales2("DTO........S/.", descuento, -1);


            //ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#

            ticket.TextoIzquierda("");



            ticket.AgregarTotales2("GRAVADA.......S/.", gravada, 1);
            ticket.AgregarTotales2("IGV...........S/.", igv, -3);
            ticket.TextoIzquierda("");

            ticket.AgregarTotales2("TOTAL.........S/.", total, -1);

            ticket.TextoIzquierda("");

            if (paymethod == "EFECTIVO")
            {
                ticket.TextoIzquierda("FORMA DE PAGO:" + " EFECTIVO");
                ticket.TextoIzquierda("");



                ticket.AgregarTotales2("EFECTIVO..S/.", efectivo, 2);
                ticket.AgregarTotales2("CAMBIO....S/.", efectivo - total, 1);
            }
            else
            {
                ticket.TextoIzquierda("FORMA DE PAGO:" + " TARJETA");
                ticket.TextoIzquierda("");



                ticket.AgregarTotales2(paymethod + "...S/.", efectivo, 2);
                //ticket.AgregarTotales5("CAMBIO.....S/.", efectivo - total);
            }




            //Texto final del Ticket.

            //ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: 3");
            ticket.TextoIzquierda("");
            ticket.TextoCentro2("¡GRACIAS POR SU COMPRA!");

            await Task.Run(() =>
            {
                GetPDF(ticket.linea, dt);
            });



        }


        private bool GetPDF(StringBuilder data, string dt)
        {




            try
            {
                string path =  actualuser + "\\TPVFiles";

                DirectoryInfo di = Directory.CreateDirectory(path);


                Document doc = new Document(PageSize.Halfletter);
                //doc.SetMargins(4,4,4,4);
                FileStream file = new FileStream(path + "\\Ticket " + dt + ".pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                PdfWriter writer = PdfWriter.GetInstance(doc, file);
                //doc.AddAuthor("");
                doc.AddTitle("Ticket " + dt);
                doc.Open();

                doc.Add(new Phrase(data.ToString()));




                writer.Close();
                doc.Close();
                file.Dispose();
                //  var pdf = new FileStream("hola_mundo.pdf", FileMode.Open, FileAccess.Read);


                return true;
            }
            catch (Exception)
            {

                return false;
            }



        }
        private void datedtp_ValueChanged(object sender, EventArgs e)
        {
            focusbarcodetemp();
        }

        private void usertypecajabtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel user = new UserModel();

                if (!user.CheckHWID(user.GetHWID()))
                {
                    MessageBox.Show("Not Registered, contact creator trevorcalfan2@gmail.com", "<3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Application.Exit();

                }
              


            }
            catch (Exception)
            {

                MessageBox.Show("No podrá enviar emails o mensajes, no tiene conexión", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                

            }


            almacenimg.Visible = false;
            adminimg.Visible = false;
            cajaimg.Visible = true;


            usertypelbl.Text = "CAJA";


            pwdtxt.Text = "";
            maintab.SelectedTab = logintab;
            pwdtxt.Focus();

        }

        private void cajabtn_Click_1(object sender, EventArgs e)
        {
           
            if (CheckAvail())
            {
                FeaturedTab.SelectedTab = cajatab;

                focusbarcodetemp();
                dtotxt.Enabled = false;
                paymethodcbo.SelectedIndex = 1;
                calccaja.Start();
            }
            
        }

        private void datedtp_CloseUp(object sender, EventArgs e)
        {
            focusbarcodetemp();
        }


        private void datedtp_MouseDown_1(object sender, MouseEventArgs e)
        {
            datedtp.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void newsellbtn_Click(object sender, EventArgs e)
        {
            if (Productsdgv.Rows.Count > 0)
            {
                DialogResult a;

                a = MessageBox.Show("¿Estás seguro de crear una nueva venta?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    NewSellActions();
                }
            }
            else
            {
                NewSellActions();
            }
        }
        public void NewSellActions()
        {
            


            dtoclear();
            subtotalpricelbl.Text = "0";
            
            




            datedtp.Value = DateTime.Today;
            precventlbl.Text = "0";
            medlbl.Text = "";
            totalprodlbl.Text = "0";
            cantlbl.Text = "0";
            actualproductselectedlbl.Text = "";
            barcodetemptxt.Clear();
            clientloadtxt.Text = "Cliente Generico";
            pickertab.SelectedTab = Familytab;
            displayerdigitadorlbl.Text = "";                            
            paymethodcbo.SelectedIndex = 1;
            Productsdgv.Rows.Clear();
            focusbarcodetemp();


        }
        private void savesellbtn_Click(object sender, EventArgs e)
        {
            SaveSell();
        }
        private void dtoclear()
        {


            dtolbl.Text = "dto.";
            dtotxt.Enabled = false;
            dtotxt.Clear();
        }
        public void SaveSell()
        {

            if (Productsdgv.RowCount > 0)
            {
                string actualdate = GetActualDateTime();



                ProductModel productmodel = new ProductModel();

                if (productmodel.SaveSell(actualdate))
                {
                    SaveSellDGV(actualdate);
                    SaveSellClientData(actualdate);

                    MessageBox.Show("Venta Activa Guardada, puede revisar presionando el botón <VENTAS ACTIVAS>", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewSellActions();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la venta", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            else
            {
                MessageBox.Show("No agregó productos a la venta, NO SE PUEDE GUARDAR UNA VENTA VACIA ", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


            focusbarcodetemp();
        }
        public string GetActualDateTime()
        {

            DateTime localDate = DateTime.Now;



            string actualdate = Convert.ToString(localDate).Replace(":", "_").Replace("/", "-");


            return actualdate;
        }
        public void InputNumbers(object sender, KeyPressEventArgs e)
        {
            // Get the decimal symbol format defined in your regional settings.
            char decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.
                        NumberFormat.NumberDecimalSeparator);
            // Check if pressed key is not a control key, digit key and decimal separator key.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                      && (e.KeyChar != decimalSeparator))
            {
                // Convert the sender to TextBox.
                TextBox toolTippedControl = sender as TextBox;
                // Create ToolTip parameters.
                string toolTipText = "La casilla solo puede contener los siguientes caracteres:"
                        + "\n\t- Numeros: 0123456789"
                        + "\n\t- Separador Decimal";
                int toolTipPosX = toolTippedControl.Width;
                int toolTipPosY = 0;
                int toolTipDuration = 4000;
                // Create a ToolTip object.
                ToolTip toolTip = new ToolTip
                {
                    // Set ToolTip icon.
                    ToolTipIcon = ToolTipIcon.Warning
                };
                // Pass the created ToolTip parameters and show it.
                toolTip.Show(toolTipText, toolTippedControl, toolTipPosX, toolTipPosY, toolTipDuration);
                // Set Handled method to true to cancel the button press.
                e.Handled = true;
            }
            // Decimal separator symbol must be only one, so:
            // Check if the decimal separator key is pressed.
            // And check if the TextBox already have entered symbol for decimal separator.
            if ((e.KeyChar == decimalSeparator) &&
                    ((sender as TextBox).Text.IndexOf(decimalSeparator) > -1))
            {
                // Set Handled method to true to cancel the button press.
                e.Handled = true;
            }
        }

        private void SaveSellDGV(string datetime)
        {


            DataTable dt = new DataTable();




            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Precio", typeof(string));
            dt.Columns.Add("Cantidad", typeof(string));
            dt.Columns.Add("Subtotal", typeof(string));
            dt.Columns.Add("Codebar", typeof(string));



            foreach (DataGridViewRow rowGrid in Productsdgv.Rows)
            {
                DataRow row = dt.NewRow();

                row["Producto"] = Convert.ToString(rowGrid.Cells[0].Value);
                row["Precio"] = Convert.ToString(rowGrid.Cells[1].Value);
                row["Cantidad"] = Convert.ToString(rowGrid.Cells[2].Value);
                row["Subtotal"] = Convert.ToString(rowGrid.Cells[3].Value);
                row["Codebar"] = Convert.ToString(rowGrid.Cells[4].Value);

                dt.Rows.Add(row);
            }

            string JSONDataTable;
            JSONDataTable = JsonConvert.SerializeObject(dt);


            WriteJSONToFile(JSONDataTable, "SavedSellProducts " + datetime + ".json");

        }

        private void SaveSellClientData(string datetime)
        {

            DataTable dt1 = new DataTable();

            dt1.Columns.Add("ClientName", typeof(string));

            dt1.Columns.Add("Employ", typeof(string));

            dt1.Columns.Add("SubTotal", typeof(string));

            dt1.Columns.Add("Dto", typeof(string));

            dt1.Columns.Add("Total", typeof(string));

            dt1.Columns.Add("IGV", typeof(string));

            dt1.Columns.Add("Gravada", typeof(string));

            dt1.Columns.Add("PayMethod", typeof(string));

            dt1.Columns.Add("DtoType", typeof(string));

            dt1.Columns.Add("DateTime", typeof(string));

            dt1.Columns.Add("DtoValidate", typeof(string));

            DataRow row1 = dt1.NewRow();

            row1["ClientName"] = clientloadtxt.Text;

            row1["Employ"] = usernamelbl.Text;

            row1["SubTotal"] = subtotalpricelbl.Text;

            row1["Dto"] = dtotxt.Text;

            row1["Total"] = totaltxt.Text;

            row1["IGV"] = igvtxt.Text;

            row1["Gravada"] = gravadatxt.Text;

            row1["PayMethod"] = Convert.ToString(paymethodcbo.SelectedItem);

            row1["DtoType"] = dtolbl.Text;

            row1["DateTime"] = datetime;
            
            row1["DtoValidate"] = Convert.ToString(dtotype);

            dt1.Rows.Add(row1);

            string JSONClientData;
            JSONClientData = JsonConvert.SerializeObject(dt1);

            WriteJSONToFile(JSONClientData, "SavedSellClientData " + datetime + ".txt");


        }
        private void WriteJSONToFile(string data, string filename)
        {

            string path =  actualuser + "\\TPVFiles";

            DirectoryInfo di = Directory.CreateDirectory(path);

            File.WriteAllText(path + "\\" + filename, data);

        }

        private void activesellsbtn_Click(object sender, EventArgs e)
        {
            ViewActiveSellsFrm view = new ViewActiveSellsFrm(this);
            view.ShowDialog();




        }
        public DataTable ListActiveSells()
        {

            ProductModel product = new ProductModel();

            return product.ListSavedSells();

        }
        public DataTable ListSellsDetail(int usercode,DateTime dt)
        {

            ProductModel product = new ProductModel();

            return product.ListSellsDetail(usercode,dt);

        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {




        }
        
        private void FocusClientData()
        {


            clientloadtxt.Focus();
            clientloadtxt.SelectAll();
        }
        FormWindowState LastWindowState = FormWindowState.Minimized;
        private void Main_Resize(object sender, EventArgs e)
        {
            DataGridViewColumn col1 = Productsdgv.Columns[4];

            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;


                if (WindowState == FormWindowState.Maximized)
                {


                    col1.Visible = true;
                }
                if (WindowState == FormWindowState.Normal)
                {


                    col1.Visible = false;
                }
            }
        }

        private void importdtobtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Digitar el descuento en <IMPORTE> (solo ENTEROS o DECIMALES)", "Consejo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtotype = true;
            dtotxt.Clear();
            dtotxt.Enabled = true;
            dtotxt.Focus();
            dtotxt.SelectAll();
            dtolbl.Text = "dto. S/.";



        }

        private void dtotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbers(sender, e);

        }

        private void percendtobtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitar el descuento en <PORCENTAJE> (solo ENTEROS o DECIMALES <SIN SIMNOLOS DE PORCENTAJE>)", "Consejo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtotype = false;
            dtotxt.Clear();
            dtotxt.Enabled = true;
            dtotxt.Focus();
            dtotxt.SelectAll();
            dtolbl.Text = "dto. %";

        }





        private void settingsbtn_Click(object sender, EventArgs e)
        {
            FeaturedTab.SelectedTab = configtab;


            configcajanumbertxt.Text = Convert.ToString(ReadSetting("cajanumber"));
            confignametxt.Text = ReadSetting("storename"); //"MINIMARKET JANETH";
            configaddresstxt.Text = ReadSetting("storeaddress");//"DIRECCION DE LA TIENDA";
            confignumbertxt.Text = ReadSetting("storetelf");//"123456789";
            configemailtxt.Text = ReadSetting("storeemail"); //"email@gmail.com";
            configsendgmailtxt.Text = ReadSetting("senderemail");//"tpvsendemailtest@gmail.com";
            configpwdgmailtxt.Text = ReadSetting("senderpwd");//"Kimberly16";
            configprinternametxt.Text = ReadSetting("printername"); //"Microsoft XPS Document Writer";
            configsendmsg1txt.Text = ReadSetting("sendermsg1");//"Gracias por su compra estimado";
            configsendmsg2txt.Text = ReadSetting("sendermsg2"); //"No olvide encontrarnos en nuestras tiendas";



        }

        private void printersbtn_Click(object sender, EventArgs e)
        {

        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            

            inventorydec.Visible = true;
            stockdec.Visible = false;
            providerdec.Visible = false;
            topsellsdec.Visible = false;
            lowstockdec.Visible = false;
            buysdec.Visible = false;
            almaccontenttab.SelectedTab = InventoryTab;
            inventorydgv.DataSource = ListProductsInvent("");
            inventorydgv.Columns[0].Visible = false;
        }


        private void providersbtn_Click(object sender, EventArgs e)
        {
            inventorydec.Visible = false;
            stockdec.Visible = false;
            providerdec.Visible = true;
            topsellsdec.Visible = false;
            lowstockdec.Visible = false;
            buysdec.Visible = false;
            almaccontenttab.SelectedTab = ProvidersTab;
            StartProvidersDGV();
        }

        private void lowstockbtn_Click(object sender, EventArgs e)
        {
            inventorydec.Visible = false;
            stockdec.Visible = false;
            providerdec.Visible = false;
            topsellsdec.Visible = false;
            lowstockdec.Visible = true;
            buysdec.Visible = false;
            almaccontenttab.SelectedTab = LowStockTab;
            lowstockdgv.DataSource = ListProductsLowStock();



        }

        private void usertypealmacenbtn_Click(object sender, EventArgs e)
        {
            try { 
                UserModel user = new UserModel();

                if (!user.CheckHWID(user.GetHWID()))
                {
                    MessageBox.Show("Not Registered, contact creator trevorcalfan2@gmail.com", "<3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Application.Exit();

                }




            }
            catch (Exception)
            {

                MessageBox.Show("No podrá enviar emails o mensajes, no tiene conexión", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                


            }







            almacenimg.Visible = true;
            adminimg.Visible = false;
            cajaimg.Visible = false;

            usertypelbl.Text = "ALMACEN";

            pwdtxt.Text = "";
            maintab.SelectedTab = logintab;
            pwdtxt.Focus();



        }

        private void usertypeaminbtn_Click(object sender, EventArgs e)
        {
            try { 

                UserModel user = new UserModel();


                if (!user.CheckHWID(user.GetHWID()))
                {
                    MessageBox.Show("Not Registered, contact creator trevorcalfan2@gmail.com", "<3", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Application.Exit();

                }


            }
                catch (Exception)
            {

                MessageBox.Show("No podrá enviar emails o mensajes, no tiene conexión", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                

            }


            usertypelbl.Text = "ADMIN";

            almacenimg.Visible = false;
            adminimg.Visible = true;
            cajaimg.Visible = false;

            pwdtxt.Text = "";
            maintab.SelectedTab = logintab;
            pwdtxt.Focus();



        }

        private void almacenbtn_Click(object sender, EventArgs e)
        {
           
            FeaturedTab.SelectedTab = almacentab;
            almaccontenttab.SelectedTab = StockTab;
            StartStockDGV();
            inventorydec.Visible = false;
            stockdec.Visible = true;
            providerdec.Visible = false;
            topsellsdec.Visible = false;
            lowstockdec.Visible = false;
            buysdec.Visible = false;
        }

        private void cleardtobtn_Click(object sender, EventArgs e)
        {
            dtotxt.Text = "";
            dtotxt.Enabled = false;
            totaltxt.Text = subtotalpricelbl.Text;
            focusbarcodetemp();
        }

        private void reprintbtn_Click(object sender, EventArgs e)
        {
            focusbarcodetemp();
            SellAndSends reprint = new SellAndSends(this);
            reprint.ShowDialog();


        }

        private void modifysellbtn_Click(object sender, EventArgs e)
        {
            focusbarcodetemp();
            

                ModifySellFrm modify = new ModifySellFrm(this);
                modify.ShowDialog();
          
        }

        private void okdtbtn_Click(object sender, EventArgs e)
        {
            dtotxt.Enabled = false;
            focusbarcodetemp();
            totaltxt.Text = " ";



        }

        private void dtotxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                dtotxt.Enabled = false;
                focusbarcodetemp();


            }
        }

        private void clientloadtxt_KeyDown(object sender, KeyEventArgs e)
        {

            
        }

        private void drinksbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void cajapanel_Click(object sender, EventArgs e)
        {
            
        }

        private void paymethodcbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            focusbarcodetemp();
        }

        private void totalpricelbl_TextChanged(object sender, EventArgs e)
        {
            totaltxt.Text = subtotalpricelbl.Text;


        }

        private void totaltxt_TextChanged(object sender, EventArgs e)
        {

            if (subtotalpricelbl.Text != "0")
            {
                if (dtotxt.Text != "")
                {
                    if (dtotype == true)
                    {
                        decimal subtotal = Convert.ToDecimal(subtotalpricelbl.Text);

                        decimal dto = Convert.ToDecimal(dtotxt.Text);
                        decimal total = subtotal - dto;

                        decimal igv = total * 18 / 100;
                        decimal gravada = total - igv;



                        igvtxt.Text = Convert.ToString(igv);
                        gravadatxt.Text = Convert.ToString(gravada);
                        totaltxt.Text = Convert.ToString(total);

                    }
                    else
                    {
                        decimal subtotal = Convert.ToDecimal(subtotalpricelbl.Text);

                        decimal dto = Convert.ToDecimal(dtotxt.Text) * subtotal / 100;
                        decimal total = subtotal - dto;

                        decimal igv = total * 18 / 100;
                        decimal gravada = total - igv;



                        igvtxt.Text = Convert.ToString(igv);
                        gravadatxt.Text = Convert.ToString(gravada);
                        totaltxt.Text = Convert.ToString(total);
                    }
                }
                else
                {
                    decimal subtotal = Convert.ToDecimal(subtotalpricelbl.Text);
                    decimal igv = subtotal * 18 / 100;
                    decimal gravada = subtotal - igv;

                    igvtxt.Text = Convert.ToString(igv);
                    gravadatxt.Text = Convert.ToString(gravada);
                    totaltxt.Text = Convert.ToString(subtotal);
                }

            }
            else
            {
                totaltxt.Text = "0";
                igvtxt.Text = "0";
                gravadatxt.Text = "0";
            }




        }

        private DataTable ListProductsInvent(string tosearch)
        {

            ProductModel product = new ProductModel();


            return product.ListProductsInvent(tosearch);
        }
        private DataTable ListProviders()
        {

            ProductModel product = new ProductModel();


            return product.ListProviders();
        }
        private DataTable ListBuys(string buytype,DateTime dt, string keyword)
        {

            ProductModel product = new ProductModel();


            return product.ListBuys(buytype,dt,keyword);
        }

        private DataTable ListProductsLowStock()
        {

            ProductModel product = new ProductModel();


            return product.LowStockListProducts();
        }

        private void topsellsbtn_Click(object sender, EventArgs e)
        {
            inventorydec.Visible = false;
            stockdec.Visible = false;
            providerdec.Visible = false;
            topsellsdec.Visible = true;
            lowstockdec.Visible = false;
            buysdec.Visible = false;
            almaccontenttab.SelectedTab = TopSellsTab;
            topsellsproductsdgv.DataSource = TopSellsListProducts(topsellsdtp.Value);

        }

        private void inventorydgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in inventorydgv.SelectedRows)
            {

                inventbarcodetxt.Text = Convert.ToString(row.Cells[7].Value);
                inventproductnametxt.Text = Convert.ToString(row.Cells[1].Value);
                inventfamilycbo.SelectedItem = Convert.ToString(row.Cells[8].Value);
                inventpctxt.Text = Convert.ToString(row.Cells[2].Value);
                inventpvtxt.Text = Convert.ToString(row.Cells[3].Value);
                inventstocktxt.Text = Convert.ToString(row.Cells[4].Value);
                inventstockmintxt.Text = Convert.ToString(row.Cells[6].Value);
                inventstockmaxtxt.Text = Convert.ToString(row.Cells[5].Value);
            }
        }

        private void Inventnewprodbtn_Click(object sender, EventArgs e)
        {
            inventorydgv.Enabled = false;
            inventbarcodetxt.Clear();
            inventbarcodetxt.Focus();
            inventproductnametxt.Clear();
            inventfamilycbo.SelectedIndex = 0;
            inventpctxt.Clear();
            inventpvtxt.Clear();
            inventstocktxt.Clear();
            inventstockmintxt.Clear();
            inventstockmaxtxt.Clear();
            almacconfirmpanel.Visible = true;
            inventdeletebtn.Enabled = false;
            inventeditbtn.Enabled = false;
            inventstocktxt.Text = "0";
            inventstockmintxt.Text = "0";
            inventstockmaxtxt.Text = "0";

        }

        private bool InventCheckInformation()
        {
          
            if (inventbarcodetxt.Text == "")
            {
                return false;
            }
            if (inventproductnametxt.Text == "")
            {
                return false;
            }
            if (inventpctxt.Text == "")
            {
                return false;
            }
            if (inventpvtxt.Text == "")
            {
                return false;
            }

            return true;
        }
        private bool NewBuyCheckInformation()
        {
            if (buyprovcbo.Text =="")
            {
                return false;
            }

            if (buyprovcbo.Text == "")
            {
                return false;
            }
           
            if (buytypecbo.SelectedIndex ==0)
            {
                return false;
            }
            if (buycompcbo.SelectedIndex == 0)
            {
                return false;
            }
            if (buycompnumbertxt.Text =="")
            {
                return false;
            }
            if (buynewdgv.Rows.Count<1)
            {
                return false;
            }

            return true;
        }
        private bool ProvCheckInformation()
        {

            if (provnametxt.Text == "")
            {
                return false;
            }
            if (provrstxt.Text == "")
            {
                return false;
            }
            if (provructxt.Text == "")
            {
                return false;
            }
            if (provmoviltxt.Text == "")
            {
                return false;
            }

            return true;
        }
        private bool StockCheckInformation()
        {

            if (stockcanttxt.Text == "")
            {
                return false;
            }
            if (stockmaxtxt.Text == "")
            {
                return false;
            }
            if (stockmintxt.Text == "")
            {
                return false;
            }


            return true;
        }

        private void Inventsavebtn_Click(object sender, EventArgs e)
        {
            if (InventCheckInformation())
            {
                string barcode = inventbarcodetxt.Text;
                string prodname = inventproductnametxt.Text;
                string family = Convert.ToString(inventfamilycbo.SelectedItem);
                decimal pc = Convert.ToDecimal(inventpctxt.Text);
                decimal pv = Convert.ToDecimal(inventpvtxt.Text);
                double stock = Convert.ToDouble( inventstocktxt.Text);
                double stockmax = Convert.ToDouble(inventstockmaxtxt.Text);
                double stockmin= Convert.ToDouble(inventstockmintxt.Text);
               

                InsertAsNewProductInvent(prodname, pc, pv, barcode, family,stock,stockmin,stockmax);

                almacconfirmpanel.Visible = false;
                inventorydgv.Enabled = true;
                inventorydgv.DataSource = ListProductsInvent("");
                inventdeletebtn.Enabled = true;
                inventeditbtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Completar todos los campos necesarios para guardar el producto", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InsertAsNewProductInvent(string productname, decimal precioc, decimal preciov, string barcode, string family,double stock,double stockmin,double stockmax)
        {

            ProductModel product = new ProductModel();

            product.InsertAsNewProductInvent(productname, precioc, preciov, barcode, family,stock,stockmin,stockmax);

        }
        private void InsertNewProvider(string name, string rs, string ruc, string dni, string direc,string fijo,string movil)
        {

            ProductModel product = new ProductModel();

            product.InsertNewProvider(name, rs, ruc, dni, direc,fijo,movil);

        }

        private void Inventdiscardbtn_Click(object sender, EventArgs e)
        {
           
            inventorydgv.Enabled = true;
            inventorydgv.DataSource = ListProductsInvent("");
            almacconfirmpanel.Visible = false;

            inventdeletebtn.Enabled = true;
            inventeditbtn.Enabled = true;
            inventnewprodbtn.Enabled = true;
        }

        private void Inventdeletebtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in inventorydgv.SelectedRows)
            {

                int prodcode = Convert.ToInt32(row.Cells[0].Value);


                DialogResult a;
                a = MessageBox.Show("¿Está seguro de eliminar el producto seleccionado, del sistema?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {
                    DeleteProductInvent(prodcode);
                    inventorydgv.DataSource = ListProductsInvent("");
                }







            }
        }

        private void DeleteProductInvent(int prodcode)
        {


            ProductModel product = new ProductModel();
            product.DeleteProductInvent(prodcode);

        }
        private void DeleteProvider(int provid)
        {


            ProductModel product = new ProductModel();
            product.DeleteProvider(provid);

        }
        private void Inventeditbtn_Click(object sender, EventArgs e)
        {


            if (InventCheckInformation())
            {
                DialogResult a;

                a = MessageBox.Show("¿Está seguro de modificar el producto seleccionado?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {




                    foreach (DataGridViewRow row in inventorydgv.SelectedRows)
                    {

                        int prodcode = Convert.ToInt32(row.Cells[0].Value);
                        string barcode = inventbarcodetxt.Text;
                        string prodname = inventproductnametxt.Text;
                        string family = Convert.ToString(inventfamilycbo.SelectedItem);
                        decimal pc = Convert.ToDecimal(inventpctxt.Text);
                        decimal pv = Convert.ToDecimal(inventpvtxt.Text);
                        int index = row.Index;

                        UpdateProductAlmacInvent(prodcode, prodname, pc, pv, barcode, family);

                        inventorydgv.Enabled = true;
                        inventorydgv.DataSource = ListProductsInvent("");
                        inventdeletebtn.Enabled = true;
                        inventnewprodbtn.Enabled = true;

                        inventorydgv.Rows[index].Selected = true;

                        MessageBox.Show("Datos actualizados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                    
                }

            }
            else
            {
                MessageBox.Show("Completar todos los campos necesarios para modificar el producto", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateProductAlmacInvent(int prodcode, string productname, decimal precioc, decimal preciov, string barcode, string family)
        {

            ProductModel product = new ProductModel();

            product.UpdateProductInvent(prodcode, productname, precioc, preciov, barcode, family);

        }
        private void UpdateProvider(int provcode, string name, string rs, string ruc, string dni, string direc,string fijo,string movil)
        {

            ProductModel product = new ProductModel();

            product.UpdateProvider(provcode, name, rs, ruc, dni, direc,fijo,movil);

        }

        private DataTable ListProductsStock()
        {
            ProductModel product = new ProductModel();
            return product.ListProductsStock();
        }

        private void Stockbtn_Click(object sender, EventArgs e)
        {
            inventorydec.Visible = false;
            stockdec.Visible = true;
            providerdec.Visible = false;
            topsellsdec.Visible = false;
            lowstockdec.Visible = false;
            buysdec.Visible = false;


            almaccontenttab.SelectedTab = StockTab;

            StartStockDGV();




        }

        private void StartStockDGV()
        {

            stockproddgv.DataSource = ListProductsStock();
            stockproddgv.Columns[0].Visible = false;
        }
        private void StartInventDGV() {
            inventorydgv.DataSource = ListProductsInvent(inventtosearchtxt.Text);
            inventorydgv.Columns[0].Visible = false;
        }
        private void StartProvidersDGV()
        {
            providersdgv.DataSource = ListProviders();
            providersdgv.Columns[0].Visible = false;
            providersdgv.Columns[7].Visible = false;
            providersdgv.Columns[6].Visible = false;
            providersdgv.Columns[5].Visible = false;
            providersdgv.Columns[4].Visible = false;
        }

        private void StartBuysDGV(string buytype,DateTime dt,string keyword)
        {
            buysdgv.DataSource = ListBuys(buytype,dt,keyword);

            buysdgv.Columns[0].Visible = false;
            buysdgv.Columns[3].Visible = false;
            buysdgv.Columns[7].Visible = false;
            buysdgv.Columns[9].Visible = false;
            buysdgv.Columns[11].Visible = false;
            buysdgv.Columns[12].Visible = false;
            buysdgv.Columns[13].Visible = false;
            buysdgv.Columns[14].Visible = false;

        }





        /*
        private DataTable ListStockByIdProduct(string prodcode) {

            ProductModel product = new ProductModel();

            return product.ListStockByIdProduct(prodcode);
        }
        */

        private void Stockproddgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in stockproddgv.SelectedRows)
            {
                //stockdetaildgv.DataSource = ListStockByIdProduct(Convert.ToString(row.Cells[3].Value));
                //stockdetaildgv.Columns[0].Visible = false;

                stockcanttxt.Text = Convert.ToString(row.Cells[2].Value);
                stockmaxtxt.Text = Convert.ToString(row.Cells[3].Value);
                stockmintxt.Text = Convert.ToString(row.Cells[4].Value);

            }

        }

        private  void stockedittbtn_Click(object sender, EventArgs e)
        {
            if (StockCheckInformation())
            {
                DialogResult a;

                a = MessageBox.Show("¿Está seguro de modificar el stock del producto seleccionado?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {




                    foreach (DataGridViewRow row in stockproddgv.SelectedRows)
                    {

                        int prodcode = Convert.ToInt32(row.Cells[0].Value);
                        int unid = Convert.ToInt32(stockcanttxt.Text);
                        double maxunid = Convert.ToDouble(stockmaxtxt.Text);
                        double minunid = Convert.ToDouble(stockmintxt.Text);
                        string barcode = Convert.ToString(row.Cells[5].Value);
                        int index = row.Index;



                        UpdateProductStock(prodcode, unid, maxunid, minunid);

                        stockproddgv.DataSource = ListProductsStock();

                        stockproddgv.Rows[index].Selected = true;

                        MessageBox.Show("Datos actualizados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                    }
                    



                }

            }
            else
            {
                MessageBox.Show("Completar todos los campos necesarios para modificar el producto", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateProductStock(int prodcode, int unidades, double maxunidades, double minunidades)
        {

            ProductModel product = new ProductModel();

            product.UpdateProductStock(prodcode, unidades, maxunidades, minunidades);
        }
       
       

       
        private void paymethodcbo_DropDownClosed(object sender, EventArgs e)
        {
            focusbarcodetemp();
        }

        private DataTable TopSellsListProducts(DateTime dt)
        {
            ProductModel product = new ProductModel();

           return product.TopSellsListProducts(dt);
        }

        private void SearchInDGVTopSells()
        {

            string searchValue = topsellstosearchtxt.Text;
            int rowIndex = 0;
            bool founded = false;
            if (searchValue != "")
            {
                if (topsellsproductsdgv.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in topsellsproductsdgv.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value).Contains(searchValue)
                           )
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
                        topsellsproductsdgv.Rows[rowIndex].Selected = true;
                    }


                }

            }

        }
        private void SearchInDGVUserM()
        {

            string searchValue = usermtosearchtxt.Text;
            int rowIndex = 0;
            bool founded = false;
            if (searchValue != "")
            {
                if (usermdgv.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in usermdgv.Rows)
                    {
                        if (Convert.ToString(row.Cells[1].Value).Contains(searchValue) || Convert.ToString(row.Cells[2].Value).Contains(searchValue)|| Convert.ToString(row.Cells[3].Value).Contains(searchValue)
                           )
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
                        usermdgv.Rows[rowIndex].Selected = true;
                    }


                }

            }

        }
        private void SearchInDGVLowStock()
        {

            string searchValue = lowstocktosearchtxt.Text;
            int rowIndex = 0;
            bool founded = false;
            if (searchValue != "")
            {
                if (lowstockdgv.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in lowstockdgv.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value).Contains(searchValue)
                           )
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
                        lowstockdgv.Rows[rowIndex].Selected = true;
                    }


                }

            }

        }

        private void SearchInDGVStock()
        {

            string searchValue = stocktosearchtxt.Text;
            int rowIndex = 0;
            bool founded = false;
            if (searchValue != "")
            {
                if (stockproddgv.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in stockproddgv.Rows)
                    {
                        if (Convert.ToString(row.Cells[1].Value).Contains(searchValue) || Convert.ToString(row.Cells[6].Value).Contains(searchValue)
                           )
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
                        stockproddgv.Rows[rowIndex].Selected = true;
                    }


                }

            }

        }
        private void SearchInDGVInventory()
        {

            string searchValue = inventtosearchtxt.Text;
            int rowIndex = 0;
            bool founded = false;
            if (searchValue != "")
            {
                if (inventorydgv.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in inventorydgv.Rows)
                    {
                        if (Convert.ToString(row.Cells[1].Value).Contains(searchValue) || Convert.ToString(row.Cells[8].Value).Contains(searchValue)
                           )
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
                        inventorydgv.Rows[rowIndex].Selected = true;
                    }


                }

            }

        }
        private void SearchInDGVProviders()
        {

            string searchValue = provtosearchtxt.Text;
            int rowIndex = 0;
            bool founded = false;
            if (searchValue != "")
            {
                if (providersdgv.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in providersdgv.Rows)
                    {
                        if (Convert.ToString(row.Cells[1].Value).Contains(searchValue) || Convert.ToString(row.Cells[2].Value).Contains(searchValue) ||
                            Convert.ToString(row.Cells[3].Value).Contains(searchValue)
                           )
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
                        providersdgv.Rows[rowIndex].Selected = true;
                    }


                }

            }

        }
        private void topsellstosearchbtn_Click(object sender, EventArgs e)
        {
            SearchInDGVTopSells();
        }

        private void stocktosearchbtn_Click(object sender, EventArgs e)
        {
            SearchInDGVStock();
        }

        private void inventtosearchbtn_Click(object sender, EventArgs e)
        {
             StartInventDGV();
        }

        private void lowstocktosearchbtn_Click(object sender, EventArgs e)
        {
            SearchInDGVLowStock();
        }

        private void clientbtn_Click(object sender, EventArgs e)
        {
            focusbarcodetemp();


            ClientFrm client = new ClientFrm(this);

            client.ShowDialog();

            
        }

        private void usermaintenancebtn_Click(object sender, EventArgs e)
        {
            FeaturedTab.SelectedTab = UserMaintenanceTab;
            usermdgv.DataSource = ListUsers();
          
            usermdgv.Columns[0].Visible = false;
            usermdgv.Columns[6].Visible = false;
            usermdgv.Columns[8].Visible = false;
            usermdgv.Columns[9].Visible = false;
            usermdgv.Columns[10].Visible = false;
            usermdgv.Columns[11].Visible = false;
            usermdgv.Columns[12].Visible = false;
            usermdgv.Columns[13].Visible = false;
            usermdgv.Columns[14].Visible = false;
            usermdgv.Columns[15].Visible = false;
            usermdgv.Columns[16].Visible = false;

        }
        private DataTable ListUsers() {
            UserModel users = new UserModel();
            return users.ListUsers();
        }

        private void usermdgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in usermdgv.SelectedRows)
            {
               

                usermnametxt.Text = Convert.ToString(row.Cells[1].Value);
                usermlastnametxt.Text = Convert.ToString(row.Cells[2].Value);
                usermrolcbo.SelectedItem = Convert.ToString(row.Cells[3].Value);
                usermgenrecbo.SelectedItem = Convert.ToString(row.Cells[4].Value);
                usermdnitxt.Text = Convert.ToString(row.Cells[5].Value);

                if (string.IsNullOrEmpty(Convert.ToString(row.Cells[6].Value))) usermborndatetxt.Text = "";
                else  usermborndatetxt.Text = Convert.ToString(Convert.ToDateTime(row.Cells[6].Value).ToString("dd-MM-yyyy"));

                usermmoviltxt.Text = Convert.ToString(row.Cells[7].Value);
                usermfijotxt.Text = Convert.ToString(row.Cells[8].Value);
                usermaddresstxt.Text = Convert.ToString(row.Cells[9].Value);
                usermdistricttxt.Text = Convert.ToString(row.Cells[10].Value);

                if (string.IsNullOrEmpty(Convert.ToString(row.Cells[11].Value))) usermstartdatetxt.Text = "";
                else usermstartdatetxt.Text = Convert.ToString(Convert.ToDateTime(row.Cells[11].Value).ToString("dd-MM-yyyy"));

                if (string.IsNullOrEmpty(Convert.ToString(row.Cells[12].Value)))  usermenddatetxt.Text = ""; 
                else usermenddatetxt.Text = Convert.ToString(Convert.ToDateTime(row.Cells[12].Value).ToString("dd-MM-yyyy"));

                //Console.WriteLine(Convert.ToString(row.Cells[12].Value));

                usermstatecbo.SelectedItem= Convert.ToString(row.Cells[13].Value);
                usermobstxt.Text = Convert.ToString(row.Cells[14].Value);
                usermpwdtxt.Text = Convert.ToString(row.Cells[15].Value);
                turncbo.SelectedIndex = Convert.ToInt32(row.Cells[16].Value);
               

            }
        }

        private void usermadduserbtn_Click(object sender, EventArgs e)
        {
            usermdgv.Enabled = false;
            usermnametxt.Clear();
            usermnametxt.Focus();
            usermlastnametxt.Clear();
            usermgenrecbo.SelectedIndex = 0;
            usermdnitxt.Clear();
            usermborndatetxt.Clear();
            usermmoviltxt.Clear();
            usermfijotxt.Clear();
            usermaddresstxt.Clear();
            usermdistricttxt.Clear();
            usermstartdatetxt.Text = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy"));
            usermenddatetxt.Clear();
            usermrolcbo.SelectedIndex = 0;
            usermstatecbo.SelectedIndex = 0;
            usermobstxt.Clear();
            usermpwdtxt.Clear();
            usermvalidatepanel.Visible = true;
            usermenddatebtn.Enabled = false;
            usermstartdatebtn.Enabled = false; 
            usermmodifyuserbtn.Enabled = false;
            turncbo.SelectedIndex = 0;


        }

        private void usermenddatebtn_Click(object sender, EventArgs e)
        {



            foreach (DataGridViewRow row in usermdgv.SelectedRows)
            {

                int usercode = Convert.ToInt32(row.Cells[0].Value);
                int index = row.Index; 

                DialogResult a;
                a = MessageBox.Show("¿Estás seguro de dar de baja el usuario seleccionado? podrás activarlo cuando desees", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {

                    EndDateUser(usercode,"NO ACTIVO", DateTime.Now.ToString("dd-MM-yyyy "));
                    usermdgv.DataSource = ListUsers();
                    usermdgv.Rows[index].Selected = true;
                    MessageBox.Show("Usuario dado de baja", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                

            }


        }
        private void EndDateUser(int usercode, string state, string dt) {

            UserModel users = new UserModel();
            users.EndDateUser(usercode,state,dt);
        }
        private void StartDateUser(int usercode, string state, string dt)
        {

            UserModel users = new UserModel();
            users.StartDateUser(usercode, state, dt);
        }

        private void usermstartdatebtn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in usermdgv.SelectedRows)
            {

                int usercode = Convert.ToInt32(row.Cells[0].Value);
                int index = row.Index;

                DialogResult a;
                a = MessageBox.Show("¿Estás seguro de dar de alta el usuario seleccionado? ", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {

                    StartDateUser(usercode, "ACTIVO", DateTime.Now.ToString("dd-MM-yyyy "));
                    usermdgv.DataSource = ListUsers();

                    usermdgv.Rows[index].Selected = true; MessageBox.Show("Usuario dado de alta", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
        }

        private void usermmodifyuserbtn_Click(object sender, EventArgs e)
        {


            if (ValidateUserM())
            {
                DialogResult a;

                a = MessageBox.Show("¿Está seguro de modificar el usuario seleccionado?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {




                    foreach (DataGridViewRow row in usermdgv.SelectedRows)
                    {
                        int usercode = Convert.ToInt32(row.Cells[0].Value);
                        string name = usermnametxt.Text;
                        string lastname = usermlastnametxt.Text;
                        string genre = Convert.ToString( usermgenrecbo.SelectedItem);
                        string dni = usermdnitxt.Text;
                        string borndate = usermborndatetxt.Text;
                        string movil = usermmoviltxt.Text;
                        string fijo = usermfijotxt.Text;
                        string address = usermaddresstxt.Text;
                        string district = usermdistricttxt.Text;
                        string startdate = DateTime.Now.ToString("dd-MM-yyyy ");
                        string enddate = usermenddatetxt.Text;
                        int rol = usermrolcbo.SelectedIndex;
                        string state = Convert.ToString(usermstatecbo.SelectedItem);
                        string obs = usermobstxt.Text;
                        string pwd = usermpwdtxt.Text;
                        int turn = turncbo.SelectedIndex;

                        int index = row.Index;

                        UpdateUsersData(usercode,name,lastname,genre,dni,borndate,movil,fijo,address,district,startdate,enddate,rol,state,obs,pwd,turn );

                        usermdgv.Enabled = true;
                        usermdgv.DataSource = ListUsers();
                        usermenddatebtn.Enabled = true;
                        usermstartdatebtn.Enabled = true;
                        usermmodifyuserbtn.Enabled = true;
                        usermadduserbtn.Enabled = true;


                        usermdgv.Rows[index].Selected = true; MessageBox.Show("Datos actualizados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                    
                }

            }
            else
            {
                MessageBox.Show("Completar todos los campos necesarios para modificar el usuario", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private bool ValidateUserM() {

            if (usermnametxt.Text =="") return false;
            if (usermlastnametxt.Text == "") return false;
            if (usermgenrecbo.SelectedIndex==0) return false;
            if (usermdnitxt.Text=="") return false;
            if (usermborndatetxt.Text=="") return false;
            if (usermmoviltxt.Text=="") return false;
            if (usermaddresstxt.Text=="") return false;
            if (usermdistricttxt.Text=="") return false;
            if (usermrolcbo.SelectedIndex==0) return false;
            if (usermstatecbo.SelectedIndex==0) return false;
            if (usermpwdtxt.Text == "") return false;
            if (turncbo.SelectedIndex == 0) return false;
            return true;
        }

        public void UpdateUsersData(int usercode, string name, string lastname, string genre, string dni,
             string borndate, string movil, string fijo, string address, string district, string startdate,string  enddate, int rol, string state, string obs,string pwd,int turn)
        {


            UserModel users = new UserModel();
            users.UpdateUsersData(usercode,name,lastname,genre,dni,borndate,movil,fijo,address,district,startdate,enddate,rol,state,obs,pwd,turn );
        }

        private void usermsave_Click(object sender, EventArgs e)
        {

            if (ValidateUserM())
            {
                
                string name = usermnametxt.Text;
                string lastname = usermlastnametxt.Text;
                string genre = Convert.ToString(usermgenrecbo.SelectedItem);
                string dni = usermdnitxt.Text;
                string borndate = usermborndatetxt.Text;
                string movil = usermmoviltxt.Text;
                string fijo = usermfijotxt.Text;
                string address = usermaddresstxt.Text;
                string district = usermdistricttxt.Text;
                string startdate = DateTime.Now.ToString("dd-MM-yyyy ");
                int rol = usermrolcbo.SelectedIndex;
                string state = Convert.ToString(usermstatecbo.SelectedItem);
                string obs = usermobstxt.Text;
                string pwd = usermpwdtxt.Text;
                int turn = turncbo.SelectedIndex;

                UsertNewUsersData(name,lastname,genre,dni,borndate,movil,fijo,address,district,startdate,rol,state,obs,pwd,turn);

                usermvalidatepanel.Visible = false;
                usermdgv.Enabled = true;
                usermdgv.DataSource = ListUsers();

                usermadduserbtn.Enabled = true;
                usermstartdatebtn.Enabled = true;
                usermenddatebtn.Enabled = true;
                usermmodifyuserbtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Completar todos los campos necesarios para guardar los datos", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public void UsertNewUsersData(string name, string lastname, string genre, string dni,
         string borndate, string movil, string fijo, string address, string district, string startdate, int rol, string state, string obs,string pwd,int turn )
        {
            UserModel users = new UserModel();

            users.UsertNewUsersData(name, lastname, genre, dni, borndate, movil, fijo, address, district, startdate, rol, state, obs,pwd,turn );
        }

        private void usermdiscard_Click(object sender, EventArgs e)
        {



            usermdgv.Enabled = true;
            usermdgv.DataSource = ListUsers();
            usermvalidatepanel.Visible = false;

            usermadduserbtn.Enabled = true;
            usermmodifyuserbtn.Enabled = true;
            usermstartdatebtn.Enabled = true;
            usermenddatebtn.Enabled = true;

        }
        public void copyAlltoClipboard(DataGridView data)
        {
            data.SelectAll();
            DataObject dataObj = data.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        public void ExportToExcel(DataGridView data,string filetitle,string sheetname)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento de Excel (*.xlsx)|*.xlsx";
            sfd.FileName = filetitle;
            sfd.InitialDirectory =  Main.actualuser ;


            if (sfd.ShowDialog() == DialogResult.OK)
            {



                DataTable dt = (DataTable)data.DataSource;


                string folderPath = sfd.FileName;

               
                using (XLWorkbook xlfile = new XLWorkbook())
                {
                    var worksheet = xlfile.Worksheets.Add(dt, sheetname);
                    
                    worksheet.Columns().AdjustToContents();

                    try
                    {
                        xlfile.SaveAs(folderPath);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


                DialogResult a;
                a = MessageBox.Show("¿Deseas abrir el documento exportado?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (a == DialogResult.Yes)
                {
                    if (File.Exists(sfd.FileName))
                        System.Diagnostics.Process.Start(sfd.FileName);
                }
                

            }
                  

           
        

        }
        
        public void ExportToExcelBuyDetail(DataGridView data, string filetitle, string sheetname)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento de Excel (*.xlsx)|*.xlsx";
            sfd.FileName = filetitle;
            sfd.InitialDirectory = Main.actualuser ;


            if (sfd.ShowDialog() == DialogResult.OK)
            {

                DataTable dt = new DataTable();



                dt.Columns.Add("Codigo (Barras)", typeof(string));
                dt.Columns.Add("Producto", typeof(string));
                dt.Columns.Add("Unidad/Med", typeof(string));
                dt.Columns.Add("Cantidad", typeof(string));
                dt.Columns.Add("Precio S/.", typeof(string));
                dt.Columns.Add("Precio IGV S/.", typeof(string));
                dt.Columns.Add("Importe S/.", typeof(string));
                dt.Columns.Add("Importe IGV S/.", typeof(string));
                dt.Columns.Add("PVenta S/.", typeof(string));

                foreach (DataGridViewRow rowGrid in data.Rows)
                {
                    DataRow row = dt.NewRow();

                    row["Codigo (Barras)"] = Convert.ToString(rowGrid.Cells[0].Value);
                    row["Producto"] = Convert.ToString(rowGrid.Cells[1].Value);
                    row["Unidad/Med"] = Convert.ToString(rowGrid.Cells[2].Value);
                    row["Cantidad"] = Convert.ToString(rowGrid.Cells[3].Value);
                    row["Precio S/."] = Convert.ToString(rowGrid.Cells[4].Value);
                    row["Precio IGV S/."] = Convert.ToString(rowGrid.Cells[5].Value);
                    row["Importe S/."] = Convert.ToString(rowGrid.Cells[6].Value);
                    row["Importe IGV S/."] = Convert.ToString(rowGrid.Cells[7].Value);
                    row["PVenta S/."] = Convert.ToString(rowGrid.Cells[8].Value);
                  

                    dt.Rows.Add(row);
                }


                    string folderPath = sfd.FileName;


                using (XLWorkbook xlfile = new XLWorkbook())
                {
                    var worksheet = xlfile.Worksheets.Add(dt, sheetname);


                    ProductModel prod = new ProductModel();

                    ComboboxItem selectedCar = (ComboboxItem)buyprovcbo.SelectedItem;
                    string timetype;

                    int provid = Convert.ToInt32(selectedCar.Value);

                    string ruc = prod.GetRUCOfProvider(provid);
                    string provname = buyprovcbo.Text;
                    if (buycompra1btn.Checked == true) timetype = "ACTUAL"; else timetype = "ANTICIPADA";
                    string buytype = Convert.ToString(buytypecbo.SelectedItem);
                    string comp = Convert.ToString(buycompcbo.SelectedItem);
                    string ncomp = buycompnumbertxt.Text;
                    string nguiar = buynguiatxt.Text;
                    decimal dto = 0;
                    if (buydtotxt.Text != "") dto = Convert.ToDecimal(buydtotxt.Text);
                    decimal total = Convert.ToDecimal(buytotaltxt.Text);
                    decimal igv = Convert.ToDecimal(buyigvtxt.Text);
                    string state = Convert.ToString(buystatecbo.SelectedItem);
                    DateTime date = buydtp.Value;
                    string obs = buyobstxt.Text;




                    worksheet.Cell(1, 11).Value = "Proveedor:";
                    worksheet.Cell(1, 12).Value = provname;
                    worksheet.Cell(2, 11).Value = "RUC:";
                    worksheet.Cell(2, 12).Value = ruc;
                    worksheet.Cell(3, 11).Value = "Modo Compra:";
                    worksheet.Cell(3, 12).Value = timetype;
                    worksheet.Cell(4, 11).Value = "Tipo de Compra:";
                    worksheet.Cell(4, 12).Value = buytype;
                    worksheet.Cell(5, 11).Value = "Comprobante:";
                    worksheet.Cell(5, 12).Value = comp;
                    worksheet.Cell(6, 11).Value = "Nº Comprobante:";
                    worksheet.Cell(6, 12).Value = ncomp;
                    worksheet.Cell(7, 11).Value = "Nº Guia R.:";
                    worksheet.Cell(7, 12).Value = nguiar;
                    worksheet.Cell(8, 11).Value = "Estado de Compra:";
                    worksheet.Cell(8, 12).Value = state;
                    worksheet.Cell(9, 11).Value = "Observación:";
                    worksheet.Cell(9, 12).Value = obs;
                    worksheet.Cell(10, 11).Value = "Fecha:";
                    worksheet.Cell(10, 12).Value = date;
                    worksheet.Cell(11, 11).Value = "Subtotal:";
                    worksheet.Cell(11, 12).Value = buysubtotaltxt.Text;
                    worksheet.Cell(12, 11).Value = "Descuento:";
                    worksheet.Cell(12, 12).Value = dto;
                    worksheet.Cell(13, 11).Value = "IGV:";
                    worksheet.Cell(13, 12).Value = igv;
                    worksheet.Cell(14, 11).Value = "Total:";
                    worksheet.Cell(14, 12).Value = total;

                    worksheet.Columns().AdjustToContents();


                    IXLRange range = worksheet.Range(worksheet.Cell(1, 11).Address, worksheet.Cell(14, 12).Address);
                    IXLRange range2 = worksheet.Range(worksheet.Cell(1, 11).Address, worksheet.Cell(14, 11).Address);

                    range.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
                    range2.Style.Fill.SetBackgroundColor(XLColor.WhiteSmoke);
                  


                    try
                    {
                        xlfile.SaveAs(folderPath);
                    }
                    catch (Exception ex )
                    {

                        MessageBox.Show(ex.Message, "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }


                DialogResult a;
                a = MessageBox.Show("¿Deseas abrir el documento exportado?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (a == DialogResult.Yes)
                {
                    if (File.Exists(sfd.FileName))
                        System.Diagnostics.Process.Start(sfd.FileName);
                }


            }





        }

        public void ExportToExcelSell(DataGridView data, string filetitle, string sheetname,DataGridView detaildata)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento de Excel (*.xlsx)|*.xlsx";
            sfd.FileName = filetitle;
            sfd.InitialDirectory =  Main.actualuser;


            if (sfd.ShowDialog() == DialogResult.OK)
            {

                DataTable dt = (DataTable)data.DataSource;




                string folderPath = sfd.FileName;


                using (XLWorkbook xlfile = new XLWorkbook())
                {
                    var worksheet = xlfile.Worksheets.Add(dt, sheetname);


                    ProductModel prod = new ProductModel();


                    foreach (DataGridViewRow row in detaildata.SelectedRows)
                    {
                        string clientname = Convert.ToString(row.Cells[1].Value);
                        string cajero = Convert.ToString(row.Cells[2].Value);
                        decimal subtotal = Convert.ToDecimal(row.Cells[3].Value);
                        decimal dto = Convert.ToDecimal(row.Cells[4].Value);
                        decimal total = Convert.ToDecimal(row.Cells[5].Value);
                        decimal igv = Convert.ToDecimal(row.Cells[6].Value);
                        decimal gravada = Convert.ToDecimal(row.Cells[7].Value);
                        decimal payed = Convert.ToDecimal(row.Cells[8].Value);
                        decimal vuelto = Convert.ToDecimal(row.Cells[9].Value);
                        string paymethod = Convert.ToString(row.Cells[10].Value);
                        string fecha = Convert.ToString(row.Cells[11].Value);
                        int caja = Convert.ToInt32(row.Cells[12].Value);

                        worksheet.Cell(1, 9).Value = "Cliente:";
                        worksheet.Cell(1, 10).Value = clientname;
                        worksheet.Cell(2, 9).Value = "Cajero:";
                        worksheet.Cell(2, 10).Value = cajero;
                        worksheet.Cell(3, 9).Value = "Subtotal S/.:";
                        worksheet.Cell(3, 10).Value = subtotal;
                        worksheet.Cell(4, 9).Value = "Descuento S/.:";
                        worksheet.Cell(4, 10).Value = dto;
                        worksheet.Cell(5, 9).Value = "Total S/.:";
                        worksheet.Cell(5, 10).Value = total;
                        worksheet.Cell(6, 9).Value = "IGV S/.:";
                        worksheet.Cell(6, 10).Value = igv;
                        worksheet.Cell(7, 9).Value = "Gravada S/.:";
                        worksheet.Cell(7, 10).Value = gravada;
                        worksheet.Cell(8, 9).Value = "Pagado S/.:";
                        worksheet.Cell(8, 10).Value = payed;
                        worksheet.Cell(9, 9).Value = "Vuelto S/.:";
                        worksheet.Cell(9, 10).Value = vuelto;
                        worksheet.Cell(10, 9).Value = "Forma de Pago:";
                        worksheet.Cell(10, 10).Value = paymethod;
                        worksheet.Cell(11, 9).Value = "Fecha & Hora:";
                        worksheet.Cell(11, 10).Value = fecha;
                        worksheet.Cell(12, 9).Value = "Caja:";
                        worksheet.Cell(12, 10).Value = caja;
                    }

                    



                    IXLRange range = worksheet.Range(worksheet.Cell(1, 9).Address, worksheet.Cell(12, 10).Address);
                    IXLRange range2 = worksheet.Range(worksheet.Cell(1, 9).Address, worksheet.Cell(12, 9).Address);

                    range.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
                    range2.Style.Fill.SetBackgroundColor(XLColor.WhiteSmoke);
             
                    worksheet.Columns().AdjustToContents();

                    try
                    {
                        xlfile.SaveAs(folderPath);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }


                DialogResult a;
                a = MessageBox.Show("¿Deseas abrir el documento exportado?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (a == DialogResult.Yes)
                {
                    if (File.Exists(sfd.FileName))
                        System.Diagnostics.Process.Start(sfd.FileName);
                }


            }





        }

        private void listsbtn_Click(object sender, EventArgs e)
        {
            if (CheckAvail())
            {
                FeaturedTab.SelectedTab = ListadosTab;
            }
           
        }

        private void configupdate1_Click(object sender, EventArgs e)
        {

            try
            {
                AddUpdateAppSettings("storename", confignametxt.Text);
                AddUpdateAppSettings("storeaddress", configaddresstxt.Text);
                AddUpdateAppSettings("storetelf", confignumbertxt.Text);
                AddUpdateAppSettings("storeemail", configemailtxt.Text);

                MessageBox.Show("Datos actualizados correctamente", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Observación", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            

        }

        private void configupdate2_Click(object sender, EventArgs e)
        {
            try
            {
                AddUpdateAppSettings("cajanumber", configcajanumbertxt.Text);
                AddUpdateAppSettings("printername", configprinternametxt.Text);


                MessageBox.Show("Datos actualizados correctamente", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Observación",MessageBoxButtons.OK,MessageBoxIcon.Warning); 
            }
            
        }

        private void configupdate3_Click(object sender, EventArgs e)
        {
            try
            {
                AddUpdateAppSettings("senderemail", configsendgmailtxt.Text);
                AddUpdateAppSettings("senderpwd", configpwdgmailtxt.Text);
                AddUpdateAppSettings("sendermsg1", configsendmsg1txt.Text);
                AddUpdateAppSettings("sendermsg2", configsendmsg2txt.Text);
              





                MessageBox.Show("Datos actualizados correctamente", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Observación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void topsellsdtp_ValueChanged(object sender, EventArgs e)
        {
            topsellsproductsdgv.DataSource = TopSellsListProducts(topsellsdtp.Value);
        }

        private void usermtosearchbtn_Click(object sender, EventArgs e)
        {
            SearchInDGVUserM();
        }

        private void bebidasbtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("BEBIDAS");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void licoresbtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("BEBIDAS ALCOHOLICAS");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void libreriabtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("LIBRERIA");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void embutidosbtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("CARNES Y EMBUTIDOS");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void abarrotesbtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("ABARROTES");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void medicbtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("AUTOMEDICACION");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void snacksbtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("SNACKS");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void confbtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("CONFITERIA");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void higbtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("HIGIENE PERSONAL");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void lacteosbtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("LACTEOS");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void limpbtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("PRODUCTOS DE LIMPIEZA");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void otrosbtn_Click(object sender, EventArgs e)
        {
            productsbyfamilydgv.Columns.Clear();
            productsbyfamilydgv.DataSource = ListProducts("OTROS");
            productsbyfamilydgv.Columns[2].Visible = false;



            pickertab.SelectedTab = Subfamilytab;


            focusbarcodetemp();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Productsdgv.Rows.Count > 0)
            {

                var result = MessageBox.Show("Tienes una venta en curso ¿Estás seguro de salir?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                e.Cancel = result == DialogResult.No;


            }
           


            


        }

        private void caja1_Click(object sender, EventArgs e)
        {
            CierreCajaFrm cierre = new CierreCajaFrm(this);
            cierre.isadmin = true;

            if (cierre.isadmin)
            {
                cierre.ListEmpByCaja(cierre.datedtp.Value);

            }
            else
            {
                cierre.ListEmpByCaja2(cierre.datedtp.Value, UserCache.IdUser);

            }

            cierre.ShowDialog();
        }

        private void caja2_Click(object sender, EventArgs e)
        {
            CajaEmpleadoFrm emp = new CajaEmpleadoFrm(this);

            emp.ShowDialog();
        }

        private void general1_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.ListClients();
            gen.titlelbl.Text = "Clientes";
            gen.ShowDialog();
            
        }

        private void general2_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.ListProducts();
            gen.titlelbl.Text = "Productos";
            gen.ShowDialog();

        }

        private void general3_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.ListEmploy();
            gen.titlelbl.Text = "Empleados";
            gen.ShowDialog();
        }

        private void general7_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.ListLowStock();
            gen.titlelbl.Text = "Bajo Stock";
            gen.ShowDialog();
        }

        private void mov1btn_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.actuallist = "byrefund";
            gen.ListRefunds(gen.datedtp.Value);
            gen.titlelbl.Text = "Devoluciones";
            gen.datedtp.Visible = true;

            gen.ShowDialog();
        }

        private void sells1btn_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.actuallist = "byprod";
            gen.ListSells(gen.datedtp.Value);
            gen.titlelbl.Text = "Ventas por prod.";
            gen.datedtp.Visible = true;
            
            gen.ShowDialog();
        }

        private void sells2btn_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.actuallist = "byfam";

            gen.ListSellsByFamily(gen.datedtp.Value);
            gen.titlelbl.Text = "Ventas por Cat.";
            gen.datedtp.Visible = true;
            gen.ShowDialog();
        }

        private void sells3btn_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.actuallist = "bycli";
            gen.datedtp.Visible = true;
            gen.ListSellsByClient(gen.datedtp.Value);
            gen.titlelbl.Text = "Ventas por Cliente";
      
            gen.ShowDialog();
        }

        private void sells4btn_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.actuallist = "bypm";
            gen.datedtp.Visible = true;
            gen.ListSellsByPayMethod(gen.datedtp.Value);
            gen.titlelbl.Text = "Ventas por F. Pago";

            gen.ShowDialog();
        }

        private void sells5btn_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.actuallist = "byuser";
            gen.datedtp.Visible = true;
            gen.ListSellsByUser(gen.datedtp.Value);
            gen.titlelbl.Text = "Ventas por Cajero";

            gen.ShowDialog();
        }

        private void sells6btn_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.actuallist = "bycaja";
            gen.datedtp.Visible = true;
            gen.ListSellsByCaja(gen.datedtp.Value);
            gen.titlelbl.Text = "Ventas por Caja";

            gen.ShowDialog();
        }

        private void sells7btn_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.actuallist = "bycierre";
            gen.datedtp.Visible = true;
            gen.ListCierreCaja(gen.datedtp.Value);
            gen.titlelbl.Text = "Cajas Tot.Dia";

            gen.ShowDialog();
        }

        private void sells8btn_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.actuallist = "allprod";
            gen.datedtp.Visible = true;
            gen.ListSellsProducts(gen.datedtp.Value);
            gen.titlelbl.Text = "Prod. Vendidos";

            gen.ShowDialog();
        }

        private void sells9btn_Click(object sender, EventArgs e)
        {
            GeneralLists gen = new GeneralLists(this);
            gen.actuallist = "bysells";
            gen.datedtp.Visible = true;
            gen.ListSellsGeneral(gen.datedtp.Value);
            gen.titlelbl.Text = "Ventas";

            gen.ShowDialog();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            click++;
            if (click == 10)
            {
                authtxt.Visible = true;
                authtxt.Focus();
                authtxt.SelectAll();
            }
           

        }
        private int click=0;
        private void authtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (authtxt.Text=="Kimberly16")
                {
                    UserModel user = new UserModel();
                    Clipboard.SetText(user.GetHWID());
                    MessageBox.Show("Done: "+user.GetHWID());
                    

                    authtxt.Visible = false;
                    click = 0;
                    authtxt.Clear();
                }


            }
        }

        private void stockcanttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // InputNumbers(sender, e);
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 )
            {
                e.Handled = true;
            }
        }

        private void stockmintxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbers(sender, e);
        }

        private void stockmaxtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbers(sender, e);
        }

        private void inventbarcodetxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void inventpctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbers(sender, e);
        }

        private void inventpvtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbers(sender, e);
        }

        private void inventstocktxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void inventstockmintxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbers(sender, e);
        }

        private void inventstockmaxtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbers(sender, e);
        }

        private void configcajanumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void DisableSafeMode() {

            ProductModel prod = new ProductModel();
            prod.DisableSafeMode();
        }

        private void providersdgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in providersdgv.SelectedRows)
            {

                provnametxt.Text = Convert.ToString(row.Cells[1].Value);
                provrstxt.Text = Convert.ToString(row.Cells[2].Value);
                provructxt.Text = Convert.ToString(row.Cells[3].Value);
                provdnitxt.Text = Convert.ToString(row.Cells[4].Value);
                provdirectxt.Text = Convert.ToString(row.Cells[5].Value);
                provfijotxt.Text = Convert.ToString(row.Cells[6].Value);
                provmoviltxt.Text = Convert.ToString(row.Cells[7].Value);


            }
        }

        private void addprovbtn_Click(object sender, EventArgs e)
        {

            providersdgv.Enabled = false;
            provnametxt.Clear();
            provnametxt.Focus();
            provrstxt.Clear();
 
            provructxt.Clear();
            provdnitxt.Clear();
            provdirectxt.Clear();
            provfijotxt.Clear();
            provmoviltxt.Clear();

            provpanel.Visible = true;
            deleteprovbtn.Enabled = false;
            modifyprovbtn.Enabled = false;

        }

        private void deleteprovbtn_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow row in providersdgv.SelectedRows)
            {

                int provcode = Convert.ToInt32(row.Cells[0].Value);


                DialogResult a;
                a = MessageBox.Show("¿Está seguro de eliminar el proveedor seleccionado, del sistema?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {
                    DeleteProvider(provcode);
                    providersdgv.DataSource = ListProviders();
                }







            }

        }

        private void modifyprovbtn_Click(object sender, EventArgs e)
        {

            if (ProvCheckInformation())
            {
                DialogResult a;

                a = MessageBox.Show("¿Está seguro de modificar datos del proveedor seleccionado?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {




                    foreach (DataGridViewRow row in providersdgv.SelectedRows)
                    {

                        int provcode = Convert.ToInt32(row.Cells[0].Value);
                        string provname = provnametxt.Text;

                        string provrs = provrstxt.Text;
                        string provruc = provructxt.Text;
                        string provdni = provdnitxt.Text;
                        string provdirec = provdirectxt.Text;
                        string provfijo = provfijotxt.Text;
                        string provmovil = provmoviltxt.Text;

                       

                        int index = row.Index;

                        UpdateProvider(provcode, provname,provrs,provruc, provdni, provdirec,provfijo,provmovil);
                        providersdgv.Enabled = true;
                        providersdgv.DataSource = ListProviders();
                        deleteprovbtn.Enabled = true;
                        addprovbtn.Enabled = true;



                        providersdgv.Rows[index].Selected = true;

                        MessageBox.Show("Datos actualizados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }




                }

            }
            else
            {
                MessageBox.Show("Completar todos los campos necesarios para los datos", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void provsavebtn_Click(object sender, EventArgs e)
        {
            if (ProvCheckInformation())
            {
               
                    string provname = provnametxt.Text;
                    string provrs = provrstxt.Text;
                    string provruc = provructxt.Text;
                    string provdni = provdnitxt.Text;
                    string provdirec = provdirectxt.Text;
                    string provfijo = provfijotxt.Text;
                    string provmovil = provmoviltxt.Text;

                    InsertNewProvider(provname,provrs, provruc, provdni, provdirec,provfijo,provmovil);

          
                    provpanel.Visible = false;
                    providersdgv.Enabled = true;
                    providersdgv.DataSource = ListProviders();
                    deleteprovbtn.Enabled = true;

                    modifyprovbtn.Enabled = true;


            }
            else
            {
                MessageBox.Show("Completar todos los campos necesarios para guardar los datos", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void provdiscardbtn_Click(object sender, EventArgs e)
        {

            providersdgv.Enabled = true;
            providersdgv.DataSource = ListProviders();
            provpanel.Visible = false;

            deleteprovbtn.Enabled = true;
            modifyprovbtn.Enabled = true;
            addprovbtn.Enabled = true;
        }

        private void provsearchbtn_Click(object sender, EventArgs e)
        {
            SearchInDGVProviders();
        }

        private void buysbtn_Click(object sender, EventArgs e)
        {
            inventorydec.Visible = false;
            stockdec.Visible = false;
            providerdec.Visible = false;
            topsellsdec.Visible = false;
            lowstockdec.Visible = false;
            buysdec.Visible = true;
            buysallactivebtn.Checked = true;
            buylistdtp.MaxDate = DateTime.Now;
            buystosearchtxt.Clear();

            almaccontenttab.SelectedTab = BuysTab;

            StartBuysDGV(GetBuyType(), buylistdtp.Value,"");


           
        }
        private string GetBuyType() {

            string buytype = "";

            
            if (buysallactivebtn.Checked == true)
            {
                buytype = "ALL";
            }
            if (buyscashbtn.Checked == true)
            {
                buytype = "CONTADO";
            }
            if (buyscreditbtn.Checked ==true)
            {
                buytype = "CREDITO";

            }
            if (buysdeletedbtn.Checked == true)
            {
                buytype = "ANULADO";

            }
           

            return buytype;
        }
        private void newbuybtn_Click(object sender, EventArgs e)
        {


            ClearNewBuyData();


            newbuypanel.Visible = true;
            newbuybtn.Visible = false;
            buymodifybtn.Visible = false;
            deletebuybtn.Visible = false;
            buyway = true;

            buysavebtn.ButtonText = "Guardar Cambios";
            buystatecbo.Visible = false;
            buystatelbl.Visible = false;
            Buys.SelectedTab = NewBuy;
            focusbarcodetemp2();
          
            AddProvidersToCBO();
            calcbuy.Start();


        }
        private void AddProvidersToCBO()
        {
            DataTable providers = ListProviders();



            foreach (DataRow row in providers.Rows)
            {
            

                ComboboxItem item = new ComboboxItem
                {
                    Text = Convert.ToString(row[1]) ,
                    Value = Convert.ToInt32(row[0])
                };


                buyprovcbo.Items.Add(item);
            }



        }
        private void buyprodcodetxt_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {

                ProductModel product = new ProductModel();



                if (product.SearchProductByBarCode(buyprodcodetxt.Text))
                {

                    subtotalpricelbl.Text = Convert.ToString(AddTotal(ProductCache.Preciov));

                    decimal prec = ProductCache.Precioc - (ProductCache.Precioc * 18 / 100);


                    buynewdgv.Rows.Add(ProductCache.Barcode,ProductCache.Name,"UNIDAD", 1,  prec, ProductCache.Precioc, prec * 1, ProductCache.Precioc * 1, ProductCache.Preciov);
                    SortMainDGV2();
                    focusbarcodetemp2(); 

                }
                else
                {
                    focusbarcodetemp2();
                    MessageBox.Show("Producto no encontrado en el Inventario", "Obseervación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }

        private void buynewdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in buynewdgv.SelectedRows)
            {

                decimal sub = Convert.ToDecimal(row.Cells[3].Value) * Convert.ToDecimal(row.Cells[4].Value);
                decimal subigv = Convert.ToDecimal(row.Cells[3].Value) * Convert.ToDecimal(row.Cells[5].Value);



                row.Cells[6].Value = sub;
                row.Cells[7].Value = subigv;


            }
        }

        private void calcbuy_Tick(object sender, EventArgs e)
        {
            if (buynewdgv.Rows.Count>0)
            {
                decimal sub = 0;
                decimal dto = 0;
                decimal total =0;
                if (buydtotxt.Text !="")
                {
                    dto = Convert.ToDecimal(buydtotxt.Text);
                }


                try
                {

               
                foreach (DataGridViewRow row in buynewdgv.Rows)
                {

                   sub  = sub+ Convert.ToDecimal(row.Cells[7].Value);

                }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                buysubtotaltxt.Text = Convert.ToString(sub);
                total = sub - dto;
                buyigvtxt.Text = Convert.ToString(total * 18 / 100);
                buytotaltxt.Text = Convert.ToString(total);
            }
            else
            {
                buysubtotaltxt.Text = "0";
                buyigvtxt.Text = "0";
                buytotaltxt.Text = "0";
            }
            
        }
        private void ClearNewBuyData() {
            buyprodcodetxt.Clear();
            buyprovcbo.Text = "";
            buycompra1btn.Checked = true;
            buytypecbo.SelectedIndex = 0;
            buycompcbo.SelectedIndex = 0;
            buycompnumbertxt.Clear();
            buynguiatxt.Clear();
            buyobstxt.Clear();
            buynewdgv.Rows.Clear();
            buysubtotaltxt.Clear();
            buydtotxt.Clear();
            buyigvtxt.Clear();
            buytotaltxt.Clear();
        }
        private void buydiscbtn_Click(object sender, EventArgs e)
        {

            newbuypanel.Visible = false;
            newbuybtn.Visible = true;
            buymodifybtn.Visible = true;
            deletebuybtn.Visible = true;
            ClearNewBuyData();
            buyprovcbo.Items.Clear();
            Buys.SelectedTab = BuyList;
            StartBuysDGV(GetBuyType(), buylistdtp.Value,"");
            calcbuy.Stop();
            buystatecbo.Visible = false;
            buystatelbl.Visible = false;
        }

        private void buyprodcodetxt_Click(object sender, EventArgs e)
        {
            focusbarcodetemp2();
        }

        private void buydtotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbers(sender, e); 
        }

        private void buysavebtn_Click(object sender, EventArgs e)
        {
            if (buyway)
            {
                if (NewBuyCheckInformation())
                {
                    DialogResult a;
                    a = MessageBox.Show("¿Deseas guardar esta compra?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (a == DialogResult.Yes)
                    {
                        ProductModel prod = new ProductModel();

                        ComboboxItem selectedCar = (ComboboxItem)buyprovcbo.SelectedItem;
                    
                        prod.GetLastBuy();
                        BuyDetails.LastBuyId = BuyDetails.LastBuyId + 1;
                        string timetype;
                        int provid = Convert.ToInt32(selectedCar.Value); 
                        string ruc = prod.GetRUCOfProvider(provid);
                        string provname = buyprovcbo.Text;
                        if (buycompra1btn.Checked == true) timetype = "ACTUAL"; else timetype = "ANTICIPADA";
                        string buytype = Convert.ToString(buytypecbo.SelectedItem);
                        string comp = Convert.ToString(buycompcbo.SelectedItem);
                        string compnumber = buycompnumbertxt.Text;
                        string nguiar = buynguiatxt.Text;
                        decimal dto = 0;
                        if (buydtotxt.Text!="") dto= Convert.ToDecimal(buydtotxt.Text);

                        decimal total = Convert.ToDecimal(buytotaltxt.Text);
                        decimal igv = Convert.ToDecimal(buyigvtxt.Text);
                        string state = "ACTIVO";
                        DateTime dt = DateTime.Now;
                        string obs = buyobstxt.Text;

                        prod.InsertNewBuy(comp, compnumber, provid, provname, ruc, dt, dto, total, igv, buytype, timetype, nguiar, state,obs);
              


                        foreach (DataGridViewRow row in buynewdgv.Rows)
                        {
                            if (row.IsNewRow) continue;

                            try
                            {
               
                                ////product by product variables
                                ///
                                string codebar = Convert.ToString(row.Cells[0].Value);
                                string prodname = Convert.ToString(row.Cells[1].Value);
                                string med = Convert.ToString(row.Cells[2].Value);
                                double newcant = Convert.ToDouble(row.Cells[3].Value);
                                decimal prec = Convert.ToDecimal(row.Cells[4].Value);
                                decimal precigv = Convert.ToDecimal(row.Cells[5].Value);
                                decimal importe = Convert.ToDecimal(row.Cells[6].Value);
                                decimal importeigv = Convert.ToDecimal(row.Cells[7].Value);
                          

                                double prodcant = prod.GetActualUnids(codebar);
                              


                                prod.InsertProductsNewBuy(BuyDetails.LastBuyId, codebar, prodname, med, newcant, prec, precigv, importe, importeigv, dt,provid, prodcant + newcant);

                                prod.UpdateProductStockByBuy(codebar, prodcant + newcant);



                            }
                            catch (Exception)
                            {

                                throw;
                            }


                        }
                        MessageBox.Show("Datos guardados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        newbuypanel.Visible = false;
                        newbuybtn.Visible = true;
                        buymodifybtn.Visible = true;
                        deletebuybtn.Visible = true;
                        ClearNewBuyData();
                        buyprovcbo.Items.Clear();
                        Buys.SelectedTab = BuyList;
                        StartBuysDGV(GetBuyType(), buylistdtp.Value,"");
                        calcbuy.Stop();


                    }


                }
                else
                {
                    MessageBox.Show("Completar todos los campos necesarios para guardar la compra", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {



                if (NewBuyCheckInformation())
                {
                    DialogResult a;
                    a = MessageBox.Show("¿Deseas actualizar esta compra?", "Obseervación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (a == DialogResult.Yes)
                    {

                        

                        foreach (DataGridViewRow row in buysdgv.SelectedRows)
                        {


                                ////product by product variables
                                ///
                                ProductModel prod = new ProductModel();


                                int buyid = Convert.ToInt32(row.Cells[0].Value);

                                ComboboxItem selectedCar = (ComboboxItem)buyprovcbo.SelectedItem;
                                string timetype;

                                int provid = Convert.ToInt32(selectedCar.Value);

                                string ruc = prod.GetRUCOfProvider(provid);
                                string provname = buyprovcbo.Text;
                                if (buycompra1btn.Checked == true) timetype = "ACTUAL"; else timetype = "ANTICIPADA";
                                string buytype = Convert.ToString(buytypecbo.SelectedItem);
                                string comp = Convert.ToString(buycompcbo.SelectedItem);
                                string ncomp = buycompnumbertxt.Text;
                                string nguiar = buynguiatxt.Text;
                                decimal dto = 0;
                                if (buydtotxt.Text != "") dto = Convert.ToDecimal(buydtotxt.Text);
                                decimal total = Convert.ToDecimal(buytotaltxt.Text);
                                decimal igv = Convert.ToDecimal(buyigvtxt.Text);
                                string state = Convert.ToString(buystatecbo.SelectedItem);
                                DateTime dt = buydtp.Value; 
                                string obs = buyobstxt.Text;
                                DataTable oldbuyprods = prod.ListOldBuysPropd(buyid);

                            




                            prod.UpdateDataBuy(buyid, comp, ncomp, provid, provname, ruc, dt, dto, total, igv, buytype, timetype, nguiar, state,obs);


                            foreach (DataRow item in oldbuyprods.Rows)
                            {
                                int idprod = Convert.ToInt32(item[0]);
                                prod.UpdateProductStockByBuy(Convert.ToString(item[2]), prod.GetActualUnids(Convert.ToString(item[2])) - Convert.ToDouble(item[5]));

                                

                            }

                            prod.DeleteProdBuy(buyid);

                            foreach (DataGridViewRow row1 in buynewdgv.Rows)
                                {
                                    if (row1.IsNewRow) continue;

                                    try
                                    {

                                       

                                        ////product by product variables
                                        ///
                                        string codebar = Convert.ToString(row1.Cells[0].Value);
                                            string prodname = Convert.ToString(row1.Cells[1].Value);
                                            string med = Convert.ToString(row1.Cells[2].Value);
                                            double cant = Convert.ToDouble(row1.Cells[3].Value);
                                            decimal prec = Convert.ToDecimal(row1.Cells[4].Value);
                                            decimal precigv = Convert.ToDecimal(row1.Cells[5].Value);
                                            decimal importe = Convert.ToDecimal(row1.Cells[6].Value);
                                            decimal importeigv = Convert.ToDecimal(row1.Cells[7].Value);
                                       


                                        prod.UpdateProductStockByBuy(codebar, prod.GetActualUnids(codebar)+ cant);


                                        prod.InsertProductsNewBuy(buyid, codebar, prodname, med, cant, prec, precigv, importe, importeigv, dt, provid, prod.GetActualUnids(codebar));

                                    }
                                    catch (Exception ex)
                                    {

                                    MessageBox.Show(ex.Message,"Observacion");
                                    }


                            }
                            

                            MessageBox.Show("Datos actualizados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                newbuypanel.Visible = false;
                                newbuybtn.Visible = true;
                                buymodifybtn.Visible = true;
                                deletebuybtn.Visible = true;
                                ClearNewBuyData();
                                buyprovcbo.Items.Clear();
                                Buys.SelectedTab = BuyList;
                                StartBuysDGV(GetBuyType(), buylistdtp.Value,"");
                                calcbuy.Stop();
                                buystatecbo.Visible = false;
                                buystatelbl.Visible = false;

                           


                        }
                        

                    }
                    
                   




                }

                else
                {
                    MessageBox.Show("Completar todos los campos necesarios para guardar la compra", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }






            }



        }

        private void buysallactivebtn_CheckedChanged(object sender, EventArgs e)
        {
            StartBuysDGV(GetBuyType(),buylistdtp.Value,"");
        }

        private void buyscashbtn_CheckedChanged(object sender, EventArgs e)
        {
            StartBuysDGV(GetBuyType(),buylistdtp.Value,"");
        }

        private void buyscreditbtn_CheckedChanged(object sender, EventArgs e)
        {
            StartBuysDGV(GetBuyType(),buylistdtp.Value,"");
        }

        private void buysdeletedbtn_CheckedChanged(object sender, EventArgs e)
        {
            StartBuysDGV(GetBuyType(),buylistdtp.Value,"");
        }

        private void buylistdtp_ValueChanged(object sender, EventArgs e)
        {
            StartBuysDGV(GetBuyType(), buylistdtp.Value,"");
        }

        private void buyssearchbtn_Click(object sender, EventArgs e)
        {
            buysallactivebtn.Checked = false;
            buyscashbtn.Checked = false;
            buyscreditbtn.Checked = false;
            buysdeletedbtn.Checked = false;


            StartBuysDGV("SEARCH", buylistdtp.Value, buystosearchtxt.Text);
        }
       

        private void deletebuybtn_Click(object sender, EventArgs e)
        {


            if (buysdgv.Rows.Count > 0)
            {
                DialogResult a;

                a = MessageBox.Show("¿Estás seguro de Anular la compra seleccionada?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {


                    foreach (DataGridViewRow row1 in buysdgv.SelectedRows)
                    {

                        int buyid = Convert.ToInt32(row1.Cells[0].Value);
                        ProductModel prod = new ProductModel();
                        

                       

                       


                        DataTable data = prod.ListBuysProd(buyid);
                        

                        foreach (DataRow row in data.Rows)
                        {
                      

                            int idprod = Convert.ToInt32(row[0]);
                            string codebar = Convert.ToString(row[2]);


                            prod.UpdateProductStockByBuy(codebar, prod.GetActualUnids(codebar) - prod.GetActualUnidsFromBuysProd(idprod));



                        }
                        prod.UpdateBuyToNulled(buyid);
                      








                        StartBuysDGV(GetBuyType(), buylistdtp.Value,"");
                        MessageBox.Show("Compra Anulada", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                }
             
            }

        }

        private void buydetailbtn_Click(object sender, EventArgs e)
        {

            if (buysdgv.Rows.Count>0)
            {
                ClearNewBuyData();

                newbuypanel.Visible = true;
                buyway = false;
                newbuybtn.Visible = false;
                buymodifybtn.Visible = false;
                deletebuybtn.Visible = false;
                buysavebtn.ButtonText = "Modificar";
                Buys.SelectedTab = NewBuy;
                focusbarcodetemp2();
                AddProvidersToCBO();
                buystatecbo.Visible = true;
                buystatelbl.Visible = true;

                foreach (DataGridViewRow row in buysdgv.SelectedRows)
                {

                    try
                    {

                        ////product by product variables
                        ///
                        ProductModel prod = new ProductModel();


                        int buyid = Convert.ToInt32(row.Cells[0].Value);
                        buycompcbo.SelectedItem = Convert.ToString(row.Cells[1].Value);
                        buycompnumbertxt.Text = Convert.ToString(row.Cells[2].Value);

                        buyprovcbo.Text = Convert.ToString(row.Cells[4].Value);


                        buydtp.Value = Convert.ToDateTime(row.Cells[6].Value);
                        buydtotxt.Text = Convert.ToString(row.Cells[7].Value);
                        buytypecbo.SelectedItem = Convert.ToString(row.Cells[10].Value);
                        
                        string timetype = Convert.ToString(row.Cells[11].Value);
                        if (timetype == "ACTUAL") buycompra1btn.Checked = true; else buycompra2btn.Checked = true;

                        buynguiatxt.Text = Convert.ToString(row.Cells[12].Value);
                        buyobstxt.Text = Convert.ToString(row.Cells[14].Value);
                        DataTable data = prod.ListBuysProd(buyid);

                        buystatecbo.SelectedItem = Convert.ToString(row.Cells[13].Value);


                        foreach (DataRow row1 in data.Rows)
                        {
                            decimal pventa = prod.GetPVenta(Convert.ToString(row1[2]));

                            buynewdgv.Rows.Add(

                                Convert.ToString(row1[2]),
                                Convert.ToString(row1[3]),
                                Convert.ToString(row1[4]),
                                Convert.ToString(row1[5]),
                                Convert.ToString(row1[6]),
                                Convert.ToString(row1[7]),
                                Convert.ToString(row1[8]),
                                Convert.ToString(row1[9]),
                                Convert.ToString(pventa));

                                Convert.ToString(row1[0]);
                            Console.WriteLine(row1[0]);


                        }


                        //prod.InsertProductsNewBuy(BuyDetails.LastBuyId, codebar, prodname, med, cant, prec, precigv, importe, importeigv);


                    }
                    catch (Exception)
                    {

                        throw;
                    }


                }


                calcbuy.Start();
            }
           
        }

        private void buyexcelexportbtn_Click(object sender, EventArgs e)
        {
            if (buysdgv.Rows.Count > 0)
            { ExportToExcel(buysdgv, "Listado Compras" + " " + buylistdtp.Value.ToString("dd-MM-yyyy"), buylistdtp.Value.ToString("dd-MM-yyyy")); }
                
        }

        private void buydetailexportbtn_Click(object sender, EventArgs e)
        {
            if (buyprovcbo.Text !="")
            {
                ExportToExcelBuyDetail(buynewdgv, "Detalles Compra" + " " + buyprovcbo.Text + " " + buydtp.Value.ToString("dd-MM-yyyy "), buydtp.Value.ToString("dd-MM-yyyy"));
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor antes de exportar", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void general4btn_Click(object sender, EventArgs e)
        {
            Kardex k = new Kardex(this);
            k.ShowDialog();
        }

        private void newbuysearchbtn_Click(object sender, EventArgs e)
        {
            buyprodcodetxt.SelectAll();
            buyprodcodetxt.Focus();
            SearchProdFrm s = new SearchProdFrm(this);

            s.ShowDialog();
        }

        private void gencodebarbtn_Click(object sender, EventArgs e)
        {
            inventbarcodetxt.SelectAll();
            inventbarcodetxt.Text = Convert.ToString(LongRandom(1000000000000, 9999999999999, new Random()));
     

        }
        

        long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

        private void searchprodcajabtn_Click(object sender, EventArgs e)
        {
            focusbarcodetemp();
            SearchProdFrm s = new SearchProdFrm(this);
                s.sway = true;
              
        

            s.ShowDialog();

        }

        private void calccaja_Tick(object sender, EventArgs e)
        {
            if (Productsdgv.Rows.Count > 0)
            {
                decimal sub = 0;
               
                foreach (DataGridViewRow row in Productsdgv.Rows)
                {

                    sub = sub + Convert.ToDecimal(row.Cells[3].Value);

                }


                subtotalpricelbl.Text = Convert.ToString(sub);
                
            }
            else
            {
                subtotalpricelbl .Text= "0";
              
            }
        }

        private void Productsdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

           
            foreach (DataGridViewRow row in Productsdgv.SelectedRows)
            {

                decimal cant = Convert.ToDecimal(row.Cells[2].Value) * Convert.ToDecimal(row.Cells[1].Value);

               



                row.Cells[3].Value = cant;
             


            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void Productsdgv_MouseLeave(object sender, EventArgs e)
        {
            focusbarcodetemp();
        }

        private void inventtosearchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartInventDGV();

            }
        }

        private void stocktosearchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SearchInDGVStock();
            }
          
        }

        private void topsellstosearchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SearchInDGVTopSells();
            }
           
        }

        private void lowstocktosearchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SearchInDGVLowStock();
            }
          
        }

        private void provtosearchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                          SearchInDGVProviders();

            }
        }

        private void usermtosearchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SearchInDGVUserM();

            }
         
        }

        private void ccbtn_Click(object sender, EventArgs e)
        {
            CierreCajaFrm cc = new CierreCajaFrm(this);

            cc.isadmin = false;

            if (cc.isadmin)
            {
                cc.ListEmpByCaja(cc.datedtp.Value);

            }
            else
            {
                cc.ListEmpByCaja2(cc.datedtp.Value, UserCache.IdUser);

            }

            cc.ShowDialog();
        }
    }


}
