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
using Common.Cache;

namespace Presentation
{
    public partial class ClientFrm : Form
    {
        private Main main;
        public ClientFrm(Main main)
        {
            InitializeComponent();
            this.main = main;

            clientdgv.DataSource =  ListClients();
            clientdgv.Columns[0].Visible = false;

            



        }

        private void clientdgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in clientdgv.SelectedRows)
            {

                ClientNametxt.Text = Convert.ToString(row.Cells[1].Value);
                moviltxt.Text = Convert.ToString(row.Cells[2].Value);
                emailtxt.Text= Convert.ToString(row.Cells[3].Value);
                addresstxt.Text= Convert.ToString(row.Cells[4].Value);
                fijotxt.Text = Convert.ToString(row.Cells[5].Value);
                creationdatetxt.Text= Convert.ToString(row.Cells[6].Value);
                lastvisittxt.Text =  Convert.ToString(row.Cells[7].Value);




            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            ClientNametxt.Clear();
            ClientNametxt.Focus();
            moviltxt.Clear(); 
            emailtxt.Clear(); 
            addresstxt.Clear();
            fijotxt.Clear();
            creationdatetxt.Clear(); 
            lastvisittxt.Clear();
            confirmpanel.Visible = true;
            clientdgv.Enabled = false;
            modifybtn.Enabled = false;
            deletebtn.Enabled = false;
            continuebtn.Enabled = false;
            
            

        }

        private bool ValidateData() {

            if (ClientNametxt.Text =="")
            {
                return false ;
            }
            if (moviltxt.Text == "")
            {
                return false;
            }
            return true;
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in clientdgv.SelectedRows)
            {

                int clientcode = Convert.ToInt32(row.Cells[0].Value);


                DialogResult a;
                a = MessageBox.Show("¿Está seguro de eliminar el cliente del sistema?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {
                    if (clientcode!=3)
                    {
                        DeleteClient(clientcode);
                        clientdgv.DataSource = ListClients();
                    }
                    



                }
                


            }

        }
        public DataTable ListClients()
        {
            ClientModel client = new ClientModel();

            return client.ListClients();
        }
        public void DeleteClient(int clientcode) {
            ClientModel client = new ClientModel();

            client.DeleteClient(clientcode);
        }

        private void modifybtn_Click(object sender, EventArgs e)
        {


            if (ValidateData())
            {
                DialogResult a;

                a = MessageBox.Show("¿Está seguro de modificar datos del cliente seleccionado?", "Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {




                    foreach (DataGridViewRow row in clientdgv.SelectedRows)
                    {

                        int clientcode = Convert.ToInt32(row.Cells[0].Value);
                        string clientname = ClientNametxt.Text;
                        string movil = moviltxt.Text;
                        string email = emailtxt.Text;
                        string address = addresstxt.Text;
                        string fijo = fijotxt.Text;
                        int index = row.Index;

                        if (clientcode!=3)
                        {
                            UpdateClientData(clientcode, clientname, movil, email, address, fijo);
                        }

                        clientdgv.Enabled = true;
                        clientdgv.DataSource = ListClients();
                        modifybtn.Enabled = true;
                        deletebtn.Enabled = true;
                        addbtn.Enabled = true;
                        continuebtn.Enabled = true;

                        clientdgv.Rows[index].Selected = true;


                    }



                   

                }

            }
            else
            {
                MessageBox.Show("Completar todos los campos necesarios para modificar datos del cliente", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateClientData(int clientcode, string clientname, string movil, string email, string address, string fijo) {

            ClientModel client = new ClientModel();

            client.UpdateClientData(clientcode,clientname,movil,email,address,fijo);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

            if (ValidateData())
            {
                

               
                string clientname = ClientNametxt.Text;
                string movil = moviltxt.Text;
                string email = emailtxt.Text;
                string address = addresstxt.Text;
                string fijo = fijotxt.Text;
                DateTime dt = DateTime.Now;

                InsertNewClient(clientname,movil,email,address,fijo,dt);

                confirmpanel.Visible = false;
                clientdgv.Enabled = true;
                clientdgv.DataSource = ListClients();
                addbtn.Enabled = true;
                deletebtn.Enabled = true;
                continuebtn.Enabled = true;
                modifybtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Completar todos los campos necesarios para guardar el producto", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InsertNewClient(string clientname, string movil, string email, string address, string fijo, DateTime dt) {
            ClientModel client = new ClientModel();

            client.InsertNewClient(clientname,movil,email,address,fijo,dt);
        }

        private void discardbtn_Click(object sender, EventArgs e)
        {



            clientdgv.Enabled = true;
            clientdgv.DataSource = ListClients();
            confirmpanel.Visible = false;

            deletebtn.Enabled = true;
            modifybtn.Enabled = true;
            addbtn.Enabled = true;
            continuebtn.Enabled = true;
            
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continuebtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in clientdgv.SelectedRows)
            {
                
                /*
                ClientCache.Id = Convert.ToInt32(row.Cells[0].Value);
                ClientCache.ClientName = Convert.ToString(row.Cells[1].Value);
                ClientCache.Movil = Convert.ToString(row.Cells[2].Value);
                ClientCache.Email = Convert.ToString(row.Cells[3].Value);
                ClientCache.Address = Convert.ToString(row.Cells[4].Value);
                ClientCache.Fijo = Convert.ToString(row.Cells[5].Value);
                ClientCache.CreateDate = Convert.ToString(row.Cells[6].Value);
                ClientCache.LastVisit = Convert.ToString(row.Cells[7].Value);
                */

                main.clientloadtxt.Text = Convert.ToString(row.Cells[1].Value);
            }
            this.Close();

        }

        private void clienttosearchbtn_Click(object sender, EventArgs e)
        {
            SearchInDGVClient(clienttosearchtxt.Text);
        }

        public void SearchInDGVClient(string tosearch)
        {

            ClientModel client = new ClientModel();
            clientdgv.DataSource =  client.ListClientBySearch(clienttosearchtxt.Text);

        }
    }
}
