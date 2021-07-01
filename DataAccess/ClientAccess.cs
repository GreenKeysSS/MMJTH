using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Management;
using Microsoft.Win32;
using System.Net.Sockets;
using System.IO;
using System.Globalization;
using Common.Cache;


namespace DataAccess
{
    public class ClientAccess : ConnectionMySQL
    {


        public DataTable ListClients()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                    select client.id,
                    client.clientname as 'Nombre Cliente', 
                    client.wanumber as Movil, 
                    client.email as 'Correo Electronico',
                    client.address as Direccion ,
                    client.fijo as 'Tlf. Fijo',
                    client.createdate as 'Fecha Alta',
                    max( sellsdetail.dt) as 'Ultima Visita' 
                    from client left join  sellsdetail on client.clientname = sellsdetail.client group by client.clientname 
                    order by client.id desc ;

                        ";


                    //command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar clientes ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }
        }

        public void DeleteClient(int clientcode)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                      delete from client where id = @clientcode ;

                        ";

                    command.Parameters.AddWithValue("@clientcode", clientcode);



                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a eliminar el cliente");


                }
            }
        }

        public void UpdateClientData(int clientcode, string clientname,string movil, string email, string address, string fijo) {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                        UPDATE client
                        SET clientname = @clientname, wanumber = @movil,email = @email,address = @address,fijo = @fijo
                        WHERE id = @clientcode;

                        ";
                    command.Parameters.AddWithValue("@clientcode", clientcode);
                    command.Parameters.AddWithValue("@clientname", clientname);
                    command.Parameters.AddWithValue("@movil", movil);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@fijo", fijo);


                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizar datos del cliente");


                }
            }
        }

        public void InsertNewClient(string clientname,string movil,string email,string address,string fijo,DateTime dt) {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     INSERT INTO client (clientname,wanumber,email,address,fijo,createdate) 
                       VALUES (@clientname,@wanumber,@email,@address,@fijo,@createdate)

                        ";

                    command.Parameters.AddWithValue("@clientname", clientname);
                    command.Parameters.AddWithValue("@wanumber", movil);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@fijo", fijo);
                    command.Parameters.AddWithValue("@createdate", dt);


                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a guardar datos del nuevo cliente");


                }
            }

        }
       
        public bool SearchClientByName(string clientname)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = @"

                         select * from client where clientname COLLATE UTF8_GENERAL_CI LIKE  @clientname ORDER BY id DESC LIMIT 1;


                        ";
                    command.Parameters.AddWithValue("@clientname", clientname);
               
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas");
                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("entre a ver la fila del  cliente");



                              
                                ClientCache.ClientName = reader.GetString(1);
                                ClientCache.Movil = reader.GetString(2);
                                ClientCache.Email = reader.GetString(3);
                                ClientCache.Address = reader.GetString(4);
                                ClientCache.Fijo = reader.GetString(5);
                                ClientCache.CreateDate = reader.GetString(6);

                                break;

                            }
                          

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }




                       
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                }
            }



        }


        public DataTable ListClientBySearch(string tosearch)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                      select client.id,
                    client.clientname as 'Nombre Cliente', 
                    client.wanumber as Movil, 
                    client.email as 'Correo Electronico',
                    client.address as Direccion ,
                    client.fijo as 'Tlf. Fijo',
                    client.createdate as 'Fecha Alta',
                    max( sellsdetail.dt) as 'Ultima Visita' 
                    from client left join  sellsdetail on client.clientname = sellsdetail.client  
                    where client.clientname COLLATE UTF8_GENERAL_CI LIKE  @tosearch  group by client.clientname ORDER BY client.id DESC;

                        ";

                    command.Parameters.AddWithValue("@tosearch", "%" + tosearch + "%");
                    //command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay el cliente en busqueda ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }
        }

    }
}
