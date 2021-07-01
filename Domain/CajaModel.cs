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
    public class CajaModel
    {

        CajaAccess caja = new CajaAccess();

        public DataTable ListCajas(DateTime date,int empid)
        {
            return caja.ListCajas(date,empid);
        }
        public DataTable ListDataCaja(DateTime date, int cajanumber,int empid)
        {
            return caja.ListDataCaja(date,cajanumber,empid);
        }
        public DataTable GetLastCierreCaja(int cajanumber)
        {
            return caja.GetLastCierreCaja(cajanumber);
            
        }
        
        public void InsertToCierreCaja(int cajanumber, decimal cierreactual, decimal saldoactual, decimal retirado, DateTime fechacierreactual, DateTime refdate, int state,int empid,int turn)
        {

            caja.InsertToCierreCaja(cajanumber, cierreactual, saldoactual, retirado, fechacierreactual, refdate, state,empid, turn);

        }
        public bool SearchCierreCaja(int cajanumber, DateTime refdate,int empid,int turn) {

           return  caja.SearchCierreCaja(cajanumber,refdate,empid,turn);

        }

        public DataTable SearchCierreCajaAndGetDGV(int cajanumber, DateTime refdate, int empid, int turn) {

            return caja.SearchCierreCajaAndGetDGV(cajanumber,refdate,  empid, turn);
        }

        public DataTable ListEmployCaja(string rol) {
            return caja.ListEmployCaja(rol);
        }

        public DataTable ListEmployCajaData(DateTime date, int empid)
        {
            return caja.ListEmployCajaData(date,empid);
        }

        public decimal ListTotalCajaEmploy(DateTime date, int empid) {

            return caja.ListTotalCajaEmploy(date,empid);
        }
        public decimal ListRefundCajaEmploy(DateTime date, int empid) {

            return caja.ListRefundCajaEmploy(date,empid);
        }
        public decimal ListDiscountCajaEmploy(DateTime date, int empid)
        {
            return caja.ListDiscountCajaEmploy(date,empid);
        }
        public DataTable ListEmpByCajas(DateTime date)
        {
            return caja.ListEmpByCajas(date);
        }
        public DataTable ListEmpByCajas2(DateTime date, int user)
        {
            return caja.ListEmpByCajas2(date,user);
        }
        public string ListTotalCaja(DateTime date, int cajax) {
            return caja.ListTotalCaja(date,cajax);
        }
        public decimal ListRetiredCaja(DateTime date, int cajax){
            return caja.ListRetiredCaja(date,cajax);
        }
        public string  ListSaldoCaja(DateTime date, int cajax) {
            return caja.ListSaldoCaja(date,cajax);
        }
        public decimal ListRefundCaja(DateTime date, int cajax) {
            return caja.ListRefundCaja(date,cajax);
        }
        public decimal ListDiscountCaja(DateTime date, int cajax) {
            return caja.ListDiscountCaja(date,cajax);
        }
        public decimal GetTotalByPayMethod(DateTime date, int cajax, string paymethod) {
            return caja.GetTotalByPayMethod(date,cajax,paymethod);
        }
        public string GetSaldAnt(DateTime date, int cajax)
        {
            return caja.GetSaldAnt(date, cajax);

        }
    }

}
