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
using Common.Cache;
using Newtonsoft.Json;

namespace Presentation
{
    public partial class ViewActiveSellsFrm : Form
    {
        private Main main;
        public ViewActiveSellsFrm(Main main)
        {
            
            InitializeComponent();
            this.main = main;


            ListActiveSells();
        }
        private void ListActiveSells() {

            activesellsdgv.Columns.Clear();
            activesellsdgv.DataSource = main.ListActiveSells();
            activesellsdgv.Columns[0].Visible = false;
            

 
        }
        private void CloseWindows_Click(object sender, EventArgs e)
        {
           

            
           
        }
       
        private void activesellsdgv_SelectionChanged(object sender, EventArgs e)
        {

            Console.WriteLine(productsviewdgv.Rows.Count);

            if (productsviewdgv.Rows.Count==1)
            {
                errormessagelbl.Text = "No se encontraron datos de la venta";

                ClientNametxt.Clear();
                employnametxt.Clear();
                subtotaltxt.Clear();
                dtotxt.Clear();
                Totaltxt.Clear();
                igvtxt.Clear();
                gravadatxt.Clear();
                paymethodtxt.Clear();
                dtotypelbl.Text="Dto.";
                DateTimetxt.Clear();
                dtovaltxt.Clear();






                DataTable dat = new DataTable();
                productsviewdgv.DataSource = dat;
            }

            foreach (DataGridViewRow row in activesellsdgv.SelectedRows)
            {

                // SavedSellClientData 9-11-2020 15_06_23
                string datetime = row.Cells[1].Value.ToString();
                string id = row.Cells[0].Value.ToString();
                string path = "C:\\Users\\" + Main.actualuser + "\\Documents\\TPVFiles\\" + "SavedSellClientData " + datetime + ".txt";
                Console.WriteLine(path);
                string path1 = "C:\\Users\\" + Main.actualuser + "\\Documents\\TPVFiles\\" + "SavedSellProducts " + datetime + ".json";
                Console.WriteLine(path1);
                string jsonReadResult, jsonReadResult1;

                if (File.Exists(path))
                {
                    jsonReadResult = File.ReadAllText(path);


                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonReadResult, typeof(DataTable));

                    ClientNametxt.Text = Convert.ToString(dt.Rows[0][0]);
                    employnametxt.Text = Convert.ToString(dt.Rows[0][1]);
                    subtotaltxt.Text = Convert.ToString(dt.Rows[0][2]);
                    dtotxt.Text = Convert.ToString(dt.Rows[0][3]);
                    Totaltxt.Text = Convert.ToString(dt.Rows[0][4]);
                    igvtxt.Text = Convert.ToString(dt.Rows[0][5]);
                    gravadatxt.Text = Convert.ToString(dt.Rows[0][6]);
                    paymethodtxt.Text = Convert.ToString(dt.Rows[0][7]);
                    dtotypelbl.Text = Convert.ToString(dt.Rows[0][8]);
                    DateTimetxt.Text = Convert.ToString(dt.Rows[0][9]).Replace("-", "/").Replace("_", ":");
                    dtovaltxt.Text = Convert.ToString(dt.Rows[0][10]);

                    
                    errormessagelbl.Text = "";


                }
                else
                {
                   
                    errormessagelbl.Text = "No se encontraron datos de la venta";
                    ClientNametxt.Text = "";
                    Totaltxt.Text = "";
                    DateTimetxt.Text = "";
                    employnametxt.Text = "";
                }
                if (File.Exists(path1))
                {
                    jsonReadResult1 = File.ReadAllText(path1);
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonReadResult1, typeof(DataTable));

                    productsviewdgv.DataSource = dt;

                   productsviewdgv.Columns[4].Visible = false;
                  

                    errormessagelbl.Text = "";

                }
                else
                {
                    
                        DataTable dat = new DataTable();
                        productsviewdgv.DataSource =dat;
                 
                    errormessagelbl.Text = "No se encontraron datos de la venta";
                }

            }
        }

        private void RestoreSellbtn_Click(object sender, EventArgs e)
        {

            if (productsviewdgv.Rows.Count == 0)
            {
                MessageBox.Show("No existen datos de productos a restaurar", "Falta de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               
                if (main.Productsdgv.Rows.Count>0)
                {
                    DialogResult a;
                    a = MessageBox.Show("Existe una venta en curso, ¿Deseas guardarla?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (a == DialogResult.Yes)
                    {
                        main.SaveSell();
                        RestoreSell();
                    }
                    else
                    {
                        main.NewSellActions();
                        RestoreSell();
                    }
                }
                else
                {
                    RestoreSell();
                }

            }
            







        }
        private void ErrorHandling(string ex) {
            MessageBox.Show(ex, "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void RestoreSell() {

            main.dtotype = Convert.ToBoolean(dtovaltxt.Text);

            main.clientloadtxt.Text = ClientNametxt.Text;

            main.dtolbl.Text = dtotypelbl.Text;
            main.dtotxt.Text = dtotxt.Text;

            main.subtotalpricelbl.Text =  subtotaltxt.Text;

            main.totaltxt.Text= " ";
           
           
            main.paymethodcbo.SelectedItem = paymethodtxt.Text;
            
            


            foreach (DataGridViewRow row in productsviewdgv.Rows)
            {
                if (row.IsNewRow) continue;

                main.Productsdgv.Rows.Add(row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString()
                    );

            }




            string datetime = Convert.ToString(activesellsdgv.CurrentRow.Cells[1].Value);
            string id = Convert.ToString(activesellsdgv.CurrentRow.Cells[0].Value);


            string path = "C:\\Users\\" + Main.actualuser + "\\Documents\\TPVFiles\\" + "SavedSellClientData " + datetime + ".txt";
            string path1 = "C:\\Users\\" + Main.actualuser + "\\Documents\\TPVFiles\\" + "SavedSellProducts " + datetime + ".json";


            if (!main.DeleteSavedSell(id))
            {
                MessageBox.Show("No se pudo eliminar la venta", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                }
                catch (Exception ex)
                {

                    ErrorHandling(ex.ToString());
                }

            }

            if (File.Exists(path1))
            {
                try
                {
                    File.Delete(path1);
                }
                catch (Exception ex)
                {

                    ErrorHandling(ex.ToString());
                }


            }



            main.SortMainDGV();
            main.focusbarcodetemp();
            this.Close();
        }

        private void deletesellbtn_Click(object sender, EventArgs e)
        {

            if (activesellsdgv.Rows.Count>0)
            {
                string datetime = Convert.ToString(activesellsdgv.CurrentRow.Cells[1].Value);
                string id = Convert.ToString(activesellsdgv.CurrentRow.Cells[0].Value);


                string path = "C:\\Users\\" + Main.actualuser + "\\Documents\\TPVFiles\\" + "SavedSellClientData " + datetime + ".txt";
                string path1 = "C:\\Users\\" + Main.actualuser + "\\Documents\\TPVFiles\\" + "SavedSellProducts " + datetime + ".json";

                DialogResult a;
                a = MessageBox.Show("¿Desea eliminar la Venta Activa seleccionada?", "Autenticación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {
                    if (main.DeleteSavedSell(id))
                    {
                        try
                        {
                            ListActiveSells();
                            MessageBox.Show("¡Venta Activa Eliminada!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {

                            ErrorHandling(ex.ToString());
                        }



                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la venta", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (File.Exists(path))
                    {
                        try
                        {
                            File.Delete(path);
                        }
                        catch (Exception ex)
                        {

                            ErrorHandling(ex.ToString());
                        }

                    }

                    if (File.Exists(path1))
                    {
                        try
                        {
                            File.Delete(path1);
                        }
                        catch (Exception ex)
                        {

                            ErrorHandling(ex.ToString());
                        }


                    }
                }

            }




        }

        private void ViewActiveSells_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                main.focusbarcodetemp();
                this.Close();

            }
        }
    }

   
}
