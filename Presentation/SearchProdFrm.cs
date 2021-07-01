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
    public partial class SearchProdFrm : Form
    {
        private Main main;
        public bool sway;
        public SearchProdFrm(Main main)
        {
            InitializeComponent();
            this.main = main;
            search();

           


        }

      

        private void selectprodbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in searchproddgv.SelectedRows)
            {
                if (sway)
                {
                    main.barcodetemptxt.Text = Convert.ToString(row.Cells[4].Value); this.Close();
                    SendKeys.Send("{Enter}");
                }
                else
                {
                    main.buyprodcodetxt.Text = Convert.ToString(row.Cells[4].Value); this.Close();
                    SendKeys.Send("{Enter}");
                }
               
                
            }
        }

        private void search()
        {
            ProductModel prod = new ProductModel();

            searchproddgv.DataSource = prod.ListSearchProd(tosearchtxt.Text);

            ActiveControl = tosearchtxt;

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            ProductModel prod = new ProductModel();

            searchproddgv.DataSource = prod.ListSearchProd(tosearchtxt.Text);
        }

        private void tosearchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                search();
            }
        }
    }
}
