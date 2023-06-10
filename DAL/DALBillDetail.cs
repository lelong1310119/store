using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBillDetail
    {
        public DataTable getAllBillDetail()
        {

            string query = "Select * from ChiTietHD";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }

        public DataTable getBillDtail(int idBill)
        {
            string query = $"Select * from ChiTietHD where MaHD = {idBill}";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }

        public void AddBillDetail(DTODetailBill bill, int id)
        {
            string query = "INSERT INTO ChiTietHD(MaHD, MaSP, SoLuong) VALUES('" + id + "','" + bill.IDProduct + "','" + bill.Quantity + "');";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void EditBill(DTODetailBill bill, int id)
        {
            string query = "UPDATE ChiTietHD SET SoLuong='" + bill.Quantity + "'" + "WHERE MaHD='" + id + "'" + "AND MaSP= '" + bill.IDProduct + "'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void DeleteBill(DTODetailBill bill, int id)
        {

            string query = "DELETE ChiTietHD Where MaHD='" + id + "'" + "AND MaSP= '" + bill.IDProduct + "'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }
    }
}