using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Domain;

namespace Presentation
{
    public partial class Kardex : Form
    {
        private Main main;

        public Kardex(Main main)
        {
            InitializeComponent();
            this.main = main;



            try
            {
                ListProductsToCBO();
            }
            catch (Exception)
            {

                MessageBox.Show("Agregar un producto al inventario", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            

            ComboboxItem selectedCar = (ComboboxItem)productscbo.SelectedItem;



            ListSalidas(Convert.ToString(selectedCar.Value),kardexmc.SelectionStart,kardexmc.SelectionEnd);
            ListEntradas(Convert.ToString(selectedCar.Value), kardexmc.SelectionStart, kardexmc.SelectionEnd);

        }

        private void  ListProductsToCBO() {

            ProductModel product = new ProductModel();

            DataTable products = product.ListProductsToCBO();


            foreach (DataRow row in products.Rows)
            {


                ComboboxItem item = new ComboboxItem
                {
                    Text = Convert.ToString(row[0]),
                    Value = Convert.ToString(row[1])
                };


                productscbo.Items.Add(item);


            }
            productscbo.SelectedIndex = 0;


        }

        public void ListSalidas(string barcode, DateTime startdate, DateTime enddate)
        {
            ProductModel product= new ProductModel();

            salidasdgv.DataSource = product.ListSalidas(barcode,startdate,enddate);
            salidasdgv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }
        public void ListEntradas(string barcode, DateTime startdate, DateTime enddate)
        {
            ProductModel product = new ProductModel();

            entradasdgv.DataSource = product.ListEntradas(barcode, startdate, enddate);
            entradasdgv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void kardexmc_DateChanged(object sender, DateRangeEventArgs e)
        {
            ComboboxItem selectedCar = (ComboboxItem)productscbo.SelectedItem;

            ListSalidas(Convert.ToString(selectedCar.Value), kardexmc.SelectionStart, kardexmc.SelectionEnd);
            ListEntradas(Convert.ToString(selectedCar.Value), kardexmc.SelectionStart, kardexmc.SelectionEnd);
            

        }

        private void productscbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem selectedCar = (ComboboxItem)productscbo.SelectedItem;

            prodcodetxt.Text = Convert.ToString(selectedCar.Value);

            ListSalidas(Convert.ToString(selectedCar.Value), kardexmc.SelectionStart, kardexmc.SelectionEnd);
            ListEntradas(Convert.ToString(selectedCar.Value), kardexmc.SelectionStart, kardexmc.SelectionEnd);
        }
        private double GetLastStockSellsProduct (string codebar,DateTime dt){
            ProductModel product = new ProductModel();

            return product.GetLastStock(codebar,dt);
        }
        public decimal GetLastSellPrice(string barcode, DateTime dt)
        { ProductModel product = new ProductModel();
            return product.GetLastSellPrice(barcode,dt); 
        }

        public DateTime GetLastSellDT(string barcode, DateTime dt)
        {
            ProductModel product = new ProductModel();
            return product.GetLastSellDT(barcode, dt);
        }
        private void excelexportbtn_Click(object sender, EventArgs e)
        {
            var selectedDates = new List<DateTime?>();



            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            ComboboxItem selectedCar = (ComboboxItem)productscbo.SelectedItem;
       

            string prodbarcode = Convert.ToString(selectedCar.Value);


            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("Cliente/Proveedor", typeof(string));
            dt.Columns.Add("Comprobante", typeof(string));
            dt.Columns.Add("N Comp.", typeof(string));
            dt.Columns.Add("Operacion", typeof(string));

            dt.Columns.Add("Ent/Cantidad", typeof(string));
            dt.Columns.Add("Ent/Precio", typeof(string));
            dt.Columns.Add("Ent/Total", typeof(string));

            dt.Columns.Add("Sal/Cantidad", typeof(string));
            dt.Columns.Add("Sal/Precio", typeof(string));
            dt.Columns.Add("Sal/Total", typeof(string));

            dt.Columns.Add("SaldFin/Cantidad", typeof(string));
            dt.Columns.Add("SaldFin/Precio", typeof(string));
            dt.Columns.Add("SaldFin/Total", typeof(string));


            dt2.Columns.Add("Fecha", typeof(string));
            dt2.Columns.Add("Cliente/Proveedor", typeof(string));
            dt2.Columns.Add("Comprobante", typeof(string));
            dt2.Columns.Add("N Comp.", typeof(string));
            dt2.Columns.Add("Operacion", typeof(string));

            dt2.Columns.Add("Ent/Cantidad", typeof(string));
            dt2.Columns.Add("Ent/Precio", typeof(string));
            dt2.Columns.Add("Ent/Total", typeof(string));

            dt2.Columns.Add("Sal/Cantidad", typeof(string));
            dt2.Columns.Add("Sal/Precio", typeof(string));
            dt2.Columns.Add("Sal/Total", typeof(string));

            dt2.Columns.Add("SaldFin/Cantidad", typeof(string));
            dt2.Columns.Add("SaldFin/Precio", typeof(string));
            dt2.Columns.Add("SaldFin/Total", typeof(string));


            for (var date = kardexmc.SelectionStart; date <= kardexmc.SelectionEnd; date = date.AddDays(1))
            {
                selectedDates.Add(date);
            }

            foreach (DateTime item in selectedDates)
            {
                double finalstocksal = 0;
                double finalstockent = 0;
                double finalstock = 0;

                double salcantidad = 0;
                decimal saltotal = 0;
                decimal salprecio = 0;
                decimal entprecio = 0;
              
             
                double entcantidad = 0;
                decimal enttotal = 0;
                


                foreach (DataGridViewRow row  in salidasdgv.Rows)
                {
                    if (item.Date.ToShortDateString() ==  Convert.ToDateTime(row.Cells[0].Value).ToShortDateString())
                    {

                        DataRow rows1 = dt.NewRow();


                        rows1["Fecha"] = Convert.ToDateTime(row.Cells[0].Value);
                        rows1["Cliente/Proveedor"] = Convert.ToString(row.Cells[1].Value);
                        rows1["Comprobante"] = Convert.ToString(row.Cells[2].Value);
                        rows1["N Comp."] = Convert.ToString(row.Cells[3].Value);
                        rows1["Operacion"] = Convert.ToString(row.Cells[4].Value);

                       

                        //salida

                        rows1["Sal/Cantidad"] = Convert.ToString(row.Cells[5].Value);

                        rows1["Sal/Precio"] = Convert.ToString(row.Cells[6].Value);

                        rows1["Sal/Total"] = Convert.ToString(row.Cells[7].Value);

                        //entradas EN BLANCO

                        rows1["Ent/Cantidad"] = "";

                        rows1["Ent/Precio"] = "";

                        rows1["Ent/Total"] = "";

                        //stock

                        rows1["SaldFin/Cantidad"] = Convert.ToString(row.Cells[8].Value);

                        rows1["SaldFin/Precio"] = Convert.ToString(row.Cells[9].Value);

                        rows1["SaldFin/Total"] = Convert.ToString(row.Cells[10].Value);


                        dt.Rows.Add(rows1);


                        salcantidad = salcantidad + Convert.ToDouble(row.Cells[5].Value);
                        saltotal = saltotal  + Convert.ToDecimal(row.Cells[7].Value);
                       


                        

                        salprecio = GetLastSellPrice(prodbarcode, Convert.ToDateTime(row.Cells[0].Value));

                      

                        finalstocksal = Convert.ToDouble(row.Cells[8].Value);

                    }
                }

                foreach (DataGridViewRow row1 in entradasdgv.Rows)
                {
                    if (item.Date.ToShortDateString() == Convert.ToDateTime(row1.Cells[0].Value).ToShortDateString())
                    {


                        DataRow rows2 = dt.NewRow();



                        rows2["Fecha"] = Convert.ToDateTime(row1.Cells[0].Value);
                        rows2["Cliente/Proveedor"] =Convert.ToString(row1.Cells[1].Value);
                        rows2["Comprobante"] = Convert.ToString(row1.Cells[2].Value);
                        rows2["N Comp."] = Convert.ToString(row1.Cells[3].Value);
                        rows2["Operacion"] = Convert.ToString(row1.Cells[4].Value);





                        //entrada

                        rows2["Ent/Cantidad"] = Convert.ToString(row1.Cells[5].Value);

                        rows2["Ent/Precio"] = Convert.ToString(row1.Cells[6].Value);

                        rows2["Ent/Total"] = Convert.ToString(row1.Cells[7].Value);


                        //salidas en blanco
                        rows2["Sal/Cantidad"] = "";

                        rows2["Sal/Precio"] = "";

                        rows2["Sal/Total"] = "";


                        //stock

                        
                       

                        salprecio = GetLastSellPrice(prodbarcode, Convert.ToDateTime(row1.Cells[0].Value));

                       // minstock = GetLastStockMins(prodbarcode, Convert.ToDateTime(row1.Cells[0].Value));


                        rows2["SaldFin/Cantidad"] = Convert.ToString(Convert.ToDouble(row1.Cells[8].Value));
                        
                        

                        rows2["SaldFin/Precio"] = Convert.ToString(row1.Cells[6].Value);

                        rows2["SaldFin/Total"] = Convert.ToString(Convert.ToDecimal(Convert.ToDouble(row1.Cells[8].Value)) * Convert.ToDecimal(row1.Cells[6].Value));



                        dt.Rows.Add(rows2);



                        entcantidad = entcantidad + Convert.ToDouble(row1.Cells[5].Value);

                        enttotal = enttotal + Convert.ToDecimal(row1.Cells[7].Value);

                        entprecio = Convert.ToDecimal(row1.Cells[6].Value);


                        finalstockent = Convert.ToDouble(row1.Cells[8].Value);









                        //finaltotal = Convert.ToDecimal(stock) * salprecio;

                    }
                }


                


                dt.DefaultView.Sort = "Fecha asc";
                dt = dt.DefaultView.ToTable();



                if (dt.Rows.Count>0)
                {
                    DataRow lastrow = dt.Rows[dt.Rows.Count - 1];

                    if (Convert.ToString(lastrow[4]) == "COMPRA")
                    {
                        finalstock = finalstockent;
                    }
                    else
                    {
                        finalstock = finalstocksal;
                    }
                }





                DataRow rows = dt.NewRow();



                rows["Fecha"] = Convert.ToString(item.ToShortDateString());
                rows["Cliente/Proveedor"] = Convert.ToString("SALDOS Y TOTALES AL CIERRE DEL DIA");
                rows["Comprobante"] = "";
                rows["N Comp."] = "";
                rows["Operacion"] = "";


                

                //ENTRADA
          

                rows["Ent/Cantidad"] = Convert.ToString(entcantidad);

                rows["Ent/Precio"] = Convert.ToString(entprecio);

                rows["Ent/Total"] = Convert.ToString(enttotal);


                //SALIDA
                rows["Sal/Cantidad"] = Convert.ToString(salcantidad);

                rows["Sal/Precio"] = Convert.ToString(salprecio);

                rows["Sal/Total"] = Convert.ToString(saltotal);

                //stock


                rows["SaldFin/Cantidad"] = Convert.ToString(finalstock);

                rows["SaldFin/Precio"] = Convert.ToString(salprecio);

                rows["SaldFin/Total"] = Convert.ToString(Convert.ToDecimal(finalstock)*salprecio);


                dt.Rows.Add(rows);




























                foreach (DataRow dr in dt.Rows)
                {
                        dt2.Rows.Add(dr.ItemArray);
                }
                dt.Rows.Clear();



            }






            ExportToExcelKardex(dt2, "Informe_operaciones_detallado_" + kardexmc.SelectionStart.ToString("dd MM yyyy") + "-" + kardexmc.SelectionEnd.ToString("dd MM yyyy"), "Reporte");
        }


        public void ExportToExcelKardex(DataTable data, string filetitle, string sheetname)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento de Excel (*.xlsx)|*.xlsx";
            sfd.FileName = filetitle;
            sfd.InitialDirectory = "C:\\Users\\" + Main.actualuser + "\\Documents";


            if (sfd.ShowDialog() == DialogResult.OK)
            {



                DataTable dt = data;


                string folderPath = sfd.FileName;


                using (XLWorkbook xlfile = new XLWorkbook())
                {
                    var worksheet = xlfile.Worksheets.Add(sheetname);
                    int r = 7;

                    worksheet.Cell(1, 2).Value = "REPORTE DE KARDEX FÍSICO VALORIZADO POR FECHA";

                    worksheet.Cell(2, 2).Value = "Productos:";
                    worksheet.Cell(2, 3).Value = productscbo.Text;
                    worksheet.Cell(3, 2).Value = "Fecha DESDE/HASTA:";
                    worksheet.Cell(3, 3).Value = kardexmc.SelectionStart.ToString("dd/MM/yyyy") + " - " + kardexmc.SelectionEnd.ToString("dd/MM/yyyy");


                    IXLRange range = worksheet.Range(worksheet.Cell(1, 2).Address, worksheet.Cell(3, 3).Address);
                    IXLRange range2 = worksheet.Range(worksheet.Cell(2, 2).Address, worksheet.Cell(3, 2).Address);
                    IXLRange range3 = worksheet.Range(worksheet.Cell(1, 2).Address, worksheet.Cell(1, 3).Address);


                    range.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
                    range2.Style.Fill.SetBackgroundColor(XLColor.WhiteSmoke);
                    range3.Style.Fill.SetBackgroundColor(XLColor.Yellow);




                    
                        worksheet.Cell(6, 1).Value = "Fecha"; worksheet.Cell(6, 1).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        worksheet.Cell(6, 2).Value = "Cliente/Proveedor"; worksheet.Cell(6, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        worksheet.Cell(6, 3).Value = "Comprobante"; worksheet.Cell(6, 3).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        worksheet.Cell(6, 4).Value = "N Comp."; worksheet.Cell(6, 4).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        worksheet.Cell(6, 5).Value = "Operacion"; worksheet.Cell(6, 5).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;

                        worksheet.Cell(5, 7).Value = "Entrada";
                        IXLRange rang = worksheet.Range(worksheet.Cell(5, 6).Address, worksheet.Cell(5, 8).Address);
                        rang.Style.Fill.SetBackgroundColor(XLColor.Yellow); rang.Style.Border.OutsideBorder = XLBorderStyleValues.Hair;

                        worksheet.Cell(6, 6).Value = "Cantidad"; worksheet.Cell(6, 6).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        worksheet.Cell(6, 7).Value = "Precio"; worksheet.Cell(6, 7).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        worksheet.Cell(6, 8).Value = "Total"; worksheet.Cell(6, 8).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;

                        worksheet.Cell(5, 10).Value = "Salida";
                        IXLRange rang1 = worksheet.Range(worksheet.Cell(5, 9).Address, worksheet.Cell(5, 11).Address);
                        rang1.Style.Fill.SetBackgroundColor(XLColor.Yellow); rang1.Style.Border.OutsideBorder = XLBorderStyleValues.Hair;

                        worksheet.Cell(6, 9).Value = "Cantidad"; worksheet.Cell(6,9).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        worksheet.Cell(6, 10).Value = "Precio"; worksheet.Cell(6, 10).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        worksheet.Cell(6, 11).Value = "Total"; worksheet.Cell(6, 11).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;

                        worksheet.Cell(5, 13).Value = "Saldo Final";
                        IXLRange rang2 = worksheet.Range(worksheet.Cell(5, 12).Address, worksheet.Cell(5, 14).Address);
                        rang2.Style.Fill.SetBackgroundColor(XLColor.Yellow); rang2.Style.Border.OutsideBorder = XLBorderStyleValues.Hair;

                        worksheet.Cell(6, 12).Value = "Cantidad"; worksheet.Cell(6, 12).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        worksheet.Cell(6, 13).Value = "Precio"; worksheet.Cell(6, 13).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        worksheet.Cell(6, 14).Value = "Total"; worksheet.Cell(6, 14).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;






                    foreach (DataRow item in dt.Rows)
                    {
                        worksheet.Cell(r, 1).Value = item[0];
                        worksheet.Cell(r, 2).Value = item[1];
                        worksheet.Cell(r, 3).Value = item[2];
                        worksheet.Cell(r, 4).Value = item[3];
                        worksheet.Cell(r, 5).Value = item[4];
                        worksheet.Cell(r, 6).Value = item[5];
                        worksheet.Cell(r, 7).Value = item[6];
                        worksheet.Cell(r, 8).Value = item[7];
                        worksheet.Cell(r, 9).Value = item[8];
                        worksheet.Cell(r, 10).Value = item[9];
                        worksheet.Cell(r, 11).Value = item[10];
                        worksheet.Cell(r, 12).Value = item[11];
                        worksheet.Cell(r, 13).Value = item[12];
                        worksheet.Cell(r, 14).Value = item[13];

                        for (int i = 1; i < 15; i++)
                        {
                            worksheet.Cell(r,i).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        }
                       

                        if (Convert.ToString(item[1]) == "SALDOS Y TOTALES AL CIERRE DEL DIA")
                        {
                            IXLRange ran = worksheet.Range(worksheet.Cell(r, 1).Address, worksheet.Cell(r, 14).Address);
                            ran.Style.Fill.SetBackgroundColor(XLColor.Yellow);
                        }
                        if (Convert.ToString(item[4]) == "COMPRA")
                        {
                            IXLRange ran = worksheet.Range(worksheet.Cell(r, 1).Address, worksheet.Cell(r, 14).Address);
                            ran.Style.Fill.SetBackgroundColor(XLColor.SkyBlue);
                        }





                        r++;


                    }


                    


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
        private double GetLastStockMins(string codebar, DateTime dt) {
            ProductModel prod = new ProductModel();
            return prod.GetLastStockMin(codebar,dt);
        }
        private void prodcodetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductModel prod = new ProductModel();

                Console.WriteLine("wqwrqwrqwrr"+prod.GetPorductNameByBarcode(prodcodetxt.Text));

                
                productscbo.Text = prod.GetPorductNameByBarcode(prodcodetxt.Text); 

                ListSalidas(prodcodetxt.Text, kardexmc.SelectionStart, kardexmc.SelectionEnd);
                ListEntradas(prodcodetxt.Text, kardexmc.SelectionStart, kardexmc.SelectionEnd);
            }
        }

        private void prodcodetxt_Click(object sender, EventArgs e)
        {
            prodcodetxt.SelectAll();
            prodcodetxt.Focus();
        }
    }
}
