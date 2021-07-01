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
    public partial class CajaEmpleadoFrm : Form
    {
        private Main main;
        public CajaEmpleadoFrm(Main main)
        {
            InitializeComponent();
            this.main = main;
            datedtp.MaxDate = DateTime.Now;



            AddEmployes();
            

           

        }
        private void AddEmployes()
        {
            DataTable employ = ListEmployCaja("CAJA");



            foreach (DataRow row  in employ.Rows)
            {
                Console.WriteLine(row[0] +" "+ row[1]);

                ComboboxItem item = new ComboboxItem
                {
                    Text = Convert.ToString(row[1]) + " " + Convert.ToString(row[2]),
                    Value = Convert.ToInt32(row[0])
                };


                empcbo.Items.Add(item);
            }



            



            empcbo.SelectedIndex = 0;
           
        }
        private void ListEmployCajaData(DateTime date,int empid) {

            CajaModel caja = new CajaModel();

            cajadatadgv.DataSource = caja.ListEmployCajaData(date,empid);

        }
        public void ListTotalCajaEmploy(DateTime date, int empid) {

            CajaModel caja = new CajaModel();

            totaltxt.Text= Convert.ToString(caja.ListTotalCajaEmploy(date, empid));

        }
        public void ListDiscountCajaEmploy(DateTime date, int empid)
        {
            CajaModel caja = new CajaModel();

            dtotxt.Text =Convert.ToString( caja.ListDiscountCajaEmploy(date,empid));

        }
        private void ListRefundCajaEmploy(DateTime date, int empid) {

            CajaModel caja = new CajaModel();

            devtxt.Text = Convert.ToString(caja.ListRefundCajaEmploy(date,empid));
        }
        private DataTable ListEmployCaja(string rol) {
            CajaModel caja = new CajaModel();

            return caja.ListEmployCaja(rol); 
        }
        private int Empturn(int id)
        { ProductModel prod = new ProductModel();
            return prod.EmpTurn(id);
        }

        private void empcbo_SelectedIndexChanged(object sender, EventArgs e)
        {


            ComboboxItem selectedCar = (ComboboxItem)empcbo.SelectedItem;
            int selecteVal = Convert.ToInt32(selectedCar.Value);
            turncbo.SelectedIndex= Empturn(selecteVal);
            ListEmployCajaData(datedtp.Value, selecteVal);
           

            ListTotalCajaEmploy(datedtp.Value, selecteVal);
            ListRefundCajaEmploy(datedtp.Value, selecteVal);
            ListDiscountCajaEmploy(datedtp.Value, selecteVal);
        }

        private void datedtp_ValueChanged(object sender, EventArgs e)
        {
            ComboboxItem selectedCar = (ComboboxItem)empcbo.SelectedItem;
            int selecteVal = Convert.ToInt32(selectedCar.Value);
            turncbo.SelectedIndex = Empturn(selecteVal);

            ListEmployCajaData(datedtp.Value, selecteVal);

            ListTotalCajaEmploy(datedtp.Value, selecteVal);
            ListRefundCajaEmploy(datedtp.Value, selecteVal);
            ListDiscountCajaEmploy(datedtp.Value, selecteVal);
        }

        private void excelexportbtn_Click(object sender, EventArgs e)
        {
       
            main.ExportToExcel(cajadatadgv,titlelbl.Text +" "+ datedtp.Value.ToString("dd-MM-yyyy"), datedtp.Value.ToString("dd-MM-yyyy"));


        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
