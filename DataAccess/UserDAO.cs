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
using System.Net;
using System.Text.RegularExpressions;

namespace DataAccess
{
    public class UserDAO:ConnectionMySQL
    {
        static string hwidres;
        static int iduser;
        static DateTime expdate;
        public DateTime publicexpdate;
        public bool hwidmatch = true;
        public bool checkedexpdate = true;
        static  readonly DateTime timenow = getTimeNow();
      

        public bool Login(string usertype, string pwd) {
  
            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    
                    command.CommandText = @"

                        select users.id,users.name,users.pwd,rol.name as rol,users.state,users.lastname from users INNER JOIN rol

                        ON users.rol = rol.id where rol.name = @rol and pwd = @pwd ORDER BY id DESC LIMIT 1


                        ";
                    command.Parameters.AddWithValue("@rol", usertype);
                    command.Parameters.AddWithValue("@pwd", pwd);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas");
                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("entre a ver la fila del  usuario");

                               
                                
                                UserCache.IdUser = reader.GetInt32(0);
                                UserCache.Name = reader.GetString(1);
                                UserCache.Position = reader.GetString(3);
                                UserCache.State = reader.GetString(4);
                                UserCache.LastName = reader.GetString(5);

                                break;

                            }
                            if (UserCache.State == "NO ACTIVO")
                            {
                                
                                return false;
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString()); 

                        }


                     

                        //LoginStateActive();
                        //Console.WriteLine("paso a insertar el estado active en la db y retorno true al login del usuario todo correcto");
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                }
            }



        }

        private bool AllowAccess() {

            return CheckHWID(GetMachineGuid());
        }
        public bool CheckHWID(string hwid)
        {
                var url = "https://raw.githubusercontent.com/GreenKeysSS/GeneralThings/master/tpvpcs.txt";

                var textFromFile = new WebClient().DownloadString(url);



                if (Regex.IsMatch(textFromFile, hwid))
                {
                    return true;
                }
                

            return false;



        }
        public string GetMachineGuid()
        {
            Console.WriteLine("consigo la hwid de este equipo");
            string location = @"SOFTWARE\Microsoft\Cryptography";
            string name = "MachineGuid";

            using (RegistryKey localMachineX64View =
                RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey rk = localMachineX64View.OpenSubKey(location))
                {
                    if (rk == null)
                        throw new KeyNotFoundException(
                            string.Format("Key Not Found: {0}", location));

                    object machineGuid = rk.GetValue(name);
                    if (machineGuid == null)
                        throw new IndexOutOfRangeException(
                            string.Format("Index Not Found: {0}", name));

                    return machineGuid.ToString();
                }
            }
        }
        public void Logout(int value)
        {

            try
            {

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;

                        command.CommandText = "UPDATE licenses SET State=@value WHERE id = @id ";
                        command.Parameters.AddWithValue("@id", iduser);
                        command.Parameters.AddWithValue("@value", value);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                       

                        Console.WriteLine("se deslogueo el usuario");

                    }
                }



            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            hwidres = "";
            iduser = 0;
                      
            Console.WriteLine("reseteo las variables de login del usuario");
        }
        private void LoginStateActive()
        {

            try
            {

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE licenses SET State=1 WHERE id = @id";
                        command.Parameters.AddWithValue("@id", iduser);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                       

                    }
                }



            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private static DateTime getTimeNow()
        {
            /*
                var client = new TcpClient("time.nist.gov", 13);
                using (var streamReader = new StreamReader(client.GetStream()))
                {



                    var response = streamReader.ReadToEnd();
                    var utcDateTimeString = response.Substring(7, 17);
                    var localDateTime = DateTime.ParseExact(utcDateTimeString, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);

                    return localDateTime;



                }
                */


    
                DateTime localDate = DateTime.Now;
                String cultureName = "es-PE";

             
                    var culture = new CultureInfo(cultureName);
                    string res = localDate.ToString(culture);
                    
                    return Convert.ToDateTime(res) ;
    

        }
        public DataTable ListUsers() {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                        select users.id,users.name as Nombre,
                        users.lastname as Apellido,
                        rol.name as Rol,
                        users.genre as Genero,users.dni as DNI,users.borndate as 'Fecha Nac.',
                        users.movil as Movil,users.fijo as Fijo, users.address as Direccion, 
                        users.district as Distrito,users.startdate as 'Fecha de Alta',
                        users.enddate as 'Fecha de Baja', users.state as Estado,
                        users.obs as Observaciones,users.pwd,users.turn from users inner join rol on users.rol = rol.id order by users.name;

                        ";



                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a listar users");

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
        public void EndDateUser(int usercode,string state,string dt) {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     UPDATE users SET state = @state,enddate = @enddate  WHERE id = @usercode ;

                        ";

                    command.Parameters.AddWithValue("@usercode", usercode);
                    command.Parameters.AddWithValue("@enddate", dt);
                    command.Parameters.AddWithValue("@state", state);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a dar de baja al usuario");


                }
            }

        }
        public void StartDateUser(int usercode, string state, string dt)
        {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     UPDATE users SET state = @state,startdate = @startdate  WHERE id = @usercode ;

                        ";

                    command.Parameters.AddWithValue("@usercode", usercode);
                    command.Parameters.AddWithValue("@startdate", dt);
                    command.Parameters.AddWithValue("@state", state);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a dar de alta al usuario");


                }
            }

        }

        public void UpdateUsersData(int usercode, string name, string lastname, string genre, string dni,
            string borndate, string movil, string fijo, string address, string district, string startdate, string enddate, int rol,string state,string obs,string pwd,int turn ) {



            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     UPDATE users SET name = @name ,rol = @rol, lastname =@lastname,genre = @genre,dni= @dni,borndate = @borndate,movil = @movil,fijo = @fijo,
                    address = @address,district = @district,startdate = @startdate,enddate = @enddate,state = @state, obs = @obs,pwd=@pwd ,turn  = @turn  WHERE id=@usercode ;

                        ";

                    command.Parameters.AddWithValue("@usercode", usercode);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastname",lastname );
                    command.Parameters.AddWithValue("@genre", genre);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@borndate", borndate);
                    command.Parameters.AddWithValue("@movil", movil);
                    command.Parameters.AddWithValue("@fijo", fijo);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@district", district);
                    command.Parameters.AddWithValue("@startdate", startdate);
                    command.Parameters.AddWithValue("@enddate", enddate);
                    command.Parameters.AddWithValue("@rol", rol);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@obs", obs);
                    command.Parameters.AddWithValue("@pwd", pwd);
                    command.Parameters.AddWithValue("@turn", turn );

                    command.CommandType = CommandType.Text;



                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizar el item del stock");


                }
            }








        }

        public void UsertNewUsersData(string name, string lastname, string genre, string dni,
            string borndate, string movil, string fijo, string address, string district, string startdate, int rol, string state, string obs,string pwd,int turn)
        {



            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     INSERT INTO users (name ,rol, lastname ,genre,dni,borndate ,movil  ,fijo ,
                    address ,district,startdate ,state , obs ,pwd,turn) VALUES(@name,@rol,@lastname, @genre,@dni,@borndate
                            ,@movil,@fijo,@address, @district,@startdate,@state,@obs,@pwd,@turn) ;

                        ";

                  
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@genre", genre);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@borndate", borndate);
                    command.Parameters.AddWithValue("@movil", movil);
                    command.Parameters.AddWithValue("@fijo", fijo);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@district", district);
                    command.Parameters.AddWithValue("@startdate", startdate);
                    command.Parameters.AddWithValue("@rol", rol);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@obs", obs);
                    command.Parameters.AddWithValue("@pwd", pwd);
                    command.Parameters.AddWithValue("@turn", turn);
                    command.CommandType = CommandType.Text;



                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizar el item del stock");


                }
            }








        }
    }
}
