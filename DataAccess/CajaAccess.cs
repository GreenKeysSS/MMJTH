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
    public class CajaAccess : ConnectionMySQL
    {

        
        public DataTable ListCajas(DateTime date,int empid)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                           SELECT sellsdetail.caja as Caja,sum(sellsdetail.total) as 'Total S/.' ,
                            date(sellsdetail.dt) as Fecha,sum(refunds.subtotal) as 
                'Devoluc. S/. ',sum(sellsdetail.discount) as 'Desc.'
                         from sellsdetail left join refunds on sellsdetail.idventa = refunds.idventa
                          where date(sellsdetail.dt)= @date and sellsdetail.user = @empid group by sellsdetail.caja  ;

                        ";


                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@empid", empid);

                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar las cajas con los totales");

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
        public DataTable ListEmpByCajas(DateTime date)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                           select 
                            users.id,
                            users.name as Nombre, 
                            users.lastname as Apellido,
                            turn.name as Turno,
                            users.turn
                            from users inner join sellsdetail on users.id = sellsdetail.user
                            inner join turn  on users.turn = turn.id  
                            and date(sellsdetail.dt) = @date group by users.id

                        ";


                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                 

                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar las cajas con los totales");

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
        public DataTable ListEmpByCajas2(DateTime date,int user)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                          select users.id, users.name as Nombre, users.lastname as Apellido,turn.name as Turno,users.turn
                            from users inner join sellsdetail on users.id = sellsdetail.user
                            inner join turn  on users.turn = turn.id  where users.id = @user
                            and date(sellsdetail.dt) = @date group by users.id 

                        ";


                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@user", user);

                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar las cajas con los totales");

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
        public DataTable ListDataCaja(DateTime date, int caja,int empid)
        {
            

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                           SELECT sellsdetail.caja,sum(sellsdetail.total) as 'Total S/.' ,sellsdetail.paymethod as 'Metodo de pago',
                    date(sellsdetail.dt) as Fecha,sum(refunds.subtotal) as 
                'Devoluciones S/. '
                 from sellsdetail left join refunds on sellsdetail.idventa = refunds.idventa
                  where date(sellsdetail.dt)= @date and sellsdetail.caja = @caja and sellsdetail.user = @empid group by sellsdetail.paymethod  ;

                        ";


                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@caja", caja);
                    command.Parameters.AddWithValue("@empid", empid);

                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar caja by idcaja");

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
        public DataTable GetLastCierreCaja(int cajanumber)
        {
            

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                           SELECT * FROM cierrecaja where caja = @caja ORDER BY id DESC LIMIT 1;

                        ";


                    command.Parameters.AddWithValue("@caja", cajanumber);
                   

                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar datos del ultimo cierre de caja");

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
        public void InsertToCierreCaja(int caja, decimal cierreactual,decimal saldoactual,decimal retirado, DateTime fechacierreactual, DateTime refdate, int state,int empid, int turn)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {



                    command.Connection = connection;
                    command.CommandText = @"

                        INSERT INTO cierrecaja (caja,cierremonto,saldomonto,retirado,dt,refdt,state,emp,turn) VALUES 
                    (@caja,@cierreactual,@saldoactual,@retirado,@datecierre,@dateref,@state,@emp,@turn)

                        ";

                    command.Parameters.AddWithValue("@caja", caja);
                    command.Parameters.AddWithValue("@cierreactual", cierreactual);
                    command.Parameters.AddWithValue("@saldoactual", saldoactual);
                    command.Parameters.AddWithValue("@retirado", retirado);
                    command.Parameters.AddWithValue("@datecierre", fechacierreactual.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@dateref", refdate.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@emp", empid);
                    command.Parameters.AddWithValue("@turn", turn);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a insertar en cierrecaja");


                }
            }




        }
        public bool SearchCierreCaja(int cajanumber,DateTime refdate,int empid,int turn)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT * FROM cierrecaja where caja = @cajanumber and DATE(refdt) = @refdate and emp = @empid and turn = @turn 

                        ";
                    command.Parameters.AddWithValue("@cajanumber", cajanumber);
                    command.Parameters.AddWithValue("@refdate", refdate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@turn", turn);
                    command.Parameters.AddWithValue("@empid", empid);



                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en cierrecaja");



                    if (reader.HasRows)
                    {
                        

                        return true;

                    }
                    else
                    {
                        return false;
                    }





                }
            }



        }
        public DataTable SearchCierreCajaAndGetDGV(int cajanumber, DateTime refdate,int empid, int turn )
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT * FROM cierrecaja where caja = @cajanumber and date(refdt) = @refdate and emp =@empid and turn = @turn 

                        ";
                    command.Parameters.AddWithValue("@cajanumber", cajanumber);
                    command.Parameters.AddWithValue("@refdate", refdate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@empid", empid);
                    command.Parameters.AddWithValue("@turn", turn );
                    
                    command.CommandType = CommandType.Text;

                   // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en cierrecaja si hay devolverdatatable");


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
        public DataTable ListEmployCaja(string rol)
        {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                          SELECT users.id,users.name,users.lastname FROM users inner join rol on users.rol = rol.id 

                        ";


                
                    command.Parameters.AddWithValue("@rol", rol);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar emoleados de caja");

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
        public DataTable ListEmployCajaData(DateTime date,int  empid)
        {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                             SELECT sum(sellsdetail.total) as 'Total S/.' ,sellsdetail.paymethod as 'Metod de Pago',
                        date(sellsdetail.dt) as Fecha,sum(sellsdetail.discount) as 'Descuentos S/.',
                        sum(refunds.subtotal) as 
                                'Devoluciones S/. '
                                 from sellsdetail   left join refunds on sellsdetail.idventa = refunds.idventa inner join users on sellsdetail.user = users.id
                                  where date(sellsdetail.dt)= @date and sellsdetail.user = @empid   group by paymethod ;

                        ";



                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@empid", empid);

                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar emoleados de caja");

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
        public decimal ListTotalCajaEmploy(DateTime date, int empid)
        {

            

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    decimal total = 0;

                    command.Connection = connection;
                    command.CommandText = @"

                               SELECT sum(sellsdetail.total) as 'Total S/.' 
                                 from sellsdetail 
                                  where date(sellsdetail.dt)= @date and sellsdetail.user = @empid    ;

                        ";



                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@empid", empid);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    

                    if (reader.HasRows)
                    {
                        
                        try
                        {
                            while (reader.Read())
                            {
                              



                                total = reader.GetDecimal(0);
                                
                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                    }

                    return total; 
                }



            }

        }
        public decimal ListRefundCajaEmploy(DateTime date, int empid)
        {



            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    decimal refund = 0;

                    command.Connection = connection;
                    command.CommandText = @"

                                 SELECT sum(refunds.subtotal) as 
                                'Devoluciones S/. '
                                 from refunds  
                                  where date(refunds.dt)= @date and refunds.user = @empid    ;

                        ";



                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@empid", empid);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {

                        try
                        {
                            while (reader.Read())
                            {




                                refund = reader.GetDecimal(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                    }

                    return refund;
                }



            }

        }
        public decimal ListDiscountCajaEmploy(DateTime date, int empid)
        {



            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    decimal discount = 0;

                    command.Connection = connection;
                    command.CommandText = @"

                                 SELECT sum(sellsdetail.discount) 
                                 from sellsdetail 
                                  where date(sellsdetail.dt)= @date and sellsdetail.user = @empid    ;

                        ";



                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@empid", empid);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {

                        try
                        {
                            while (reader.Read())
                            {




                                discount = reader.GetDecimal(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                    }

                    return discount;
                }



            }

        }
        public string ListTotalCaja(DateTime date, int caja)
        {



            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    string total = "0";

                    command.Connection = connection;
                    command.CommandText = @"

                              SELECT cierrecaja.cierremonto 
                                 from cierrecaja 
                                  where date(cierrecaja.refdt) = @date and caja = @caja order by id desc limit 1    ;
                        ";
                   


                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@caja", caja);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {

                        try
                        {
                            while (reader.Read())
                            {




                                total = reader.GetString(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                    }

                    return total;
                }



            }

        }
        public decimal ListRetiredCaja(DateTime date, int caja)
        {



            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    decimal total = 0;

                    command.Connection = connection;
                    command.CommandText = @"

                               SELECT sum(cierrecaja.retirado)  
                                 from cierrecaja 
                                  where date(cierrecaja.refdt)= @date and caja = @caja    ;

                        ";



                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@caja", caja);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {

                        try
                        {
                            while (reader.Read())
                            {




                                total = reader.GetDecimal(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                    }

                    return total;
                }



            }

        }
        public string  ListSaldoCaja(DateTime date, int caja)
        {



            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    string  total = "0";

                    command.Connection = connection;
                    command.CommandText = @"

                               SELECT cierrecaja.saldomonto  
                                 from cierrecaja 
                                  where date(cierrecaja.refdt) <= @date and caja = @caja order by id desc limit 1  ;

                        ";



                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@caja", caja);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {

                        try
                        {
                            while (reader.Read())
                            {




                                total = reader.GetString(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                    }

                    return total;
                }



            }

        }
        public decimal ListRefundCaja(DateTime date, int caja)
        {



            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    decimal refund = 0;

                    command.Connection = connection;
                    command.CommandText = @"

                                 SELECT sum(refunds.subtotal) 
                                 from refunds  

                                    where date(refunds.dt)= @date and caja = @caja    ;

                        ";



                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@caja", caja);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {

                        try
                        {
                            while (reader.Read())
                            {




                                refund = reader.GetDecimal(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                    }

                    return refund;
                }



            }

        }
        public decimal ListDiscountCaja(DateTime date, int caja)
        {



            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    decimal discount = 0;

                    command.Connection = connection;
                    command.CommandText = @"

                                 SELECT sum(sellsdetail.discount) 
                                 from sellsdetail 
                                  where date(sellsdetail.dt)= @date  and caja = @caja   ;

                        ";



                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@caja", caja);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {

                        try
                        {
                            while (reader.Read())
                            {




                                discount = reader.GetDecimal(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                    }

                    return discount;
                }



            }

        }

        public decimal GetTotalByPayMethod(DateTime date, int caja,string paymethod)
        {



            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    decimal total = 0;

                    command.Connection = connection;
                    command.CommandText = @"

                              SELECT sum(sellsdetail.total)  
                                 from sellsdetail 
                                  where date(sellsdetail.dt) = @date and caja = @caja and sellsdetail.paymethod = @paymethod;
                        ";



                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@caja", caja);
                    command.Parameters.AddWithValue("@paymethod", paymethod);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {

                        try
                        {
                            while (reader.Read())
                            {




                                total = reader.GetDecimal(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                    }

                    return total;
                }



            }

        }

        public string GetSaldAnt(DateTime date, int caja)
        {



            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {
                    string discount = "0";

                    command.Connection = connection;
                    command.CommandText = @"

                                 SELECT saldomonto 
                                 from cierrecaja 
                                  where    date(refdt) = @date - interval 1 DAY and caja = @caja order by id desc limit 1   ;  

                        ";



                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@caja", caja);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {

                        try
                        {
                            while (reader.Read())
                            {




                                discount = reader.GetString(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                    }

                    return discount;
                }



            }

        }
    }
}
