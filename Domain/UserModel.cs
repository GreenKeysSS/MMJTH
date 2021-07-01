using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Cache;
using System.Data;

namespace Domain
{
    public class UserModel
    {

        public bool hwidmatchfromdao;
        public bool checkexpdatefromdao;
        public DateTime expdate;

        UserDAO userDao = new UserDAO();
        public bool LoginUser(string usertype,string pwd) {

          
            return userDao.Login(usertype, pwd);
           
        }
        public void LogoutUser()
        {
            //userDao.Logout(0);

        }
        public DataTable ListUsers() {

            return userDao.ListUsers();
        }
        public void EndDateUser(int usercode, string state, string dt) {

            userDao.EndDateUser(usercode,state,dt);

        }
        public bool CheckHWID(string hwid) {

            return userDao.CheckHWID(hwid);
        }
        public string GetHWID() {

            return userDao.GetMachineGuid();
        }
        public void StartDateUser(int usercode, string state, string dt)
        {

            userDao.StartDateUser(usercode, state, dt);

        }
        public void UpdateUsersData(int usercode, string name, string lastname, string genre, string dni,
           string borndate, string movil, string fijo, string address, string district, string startdate,string enddate, int rol, string state, string obs,string pwd,int turn)
        {

            userDao.UpdateUsersData(usercode,name,lastname,genre,dni,borndate,movil,fijo,address,district,startdate,enddate,rol,state,obs,pwd,turn );


        }

        public void UsertNewUsersData(string name, string lastname, string genre, string dni,
           string borndate, string movil, string fijo, string address, string district, string startdate, int rol, string state, string obs,string pwd,int turn)
        {
            userDao.UsertNewUsersData(name,lastname,genre,dni,borndate,movil,fijo,address,district,startdate,rol,state,obs,pwd,turn);
        }

    }

}
