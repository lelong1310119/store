using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DALBill
    {
        public DataTable getAllBill()
        {

            string query = "Select * from HoaDon";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }

        public int AddBillReturnID(DTOBill bill)
        {
            string query = "INSERT INTO HoaDon(MaKH, MaNV, NgayLapHD, NgayNhanHang) VALUES('" + bill.IDCustomer + "','" + bill.IDStaff + "','" + bill.CreatedDate + "','" + bill.ReceivedDate + "'); SELECT SCOPE_IDENTITY();";
            return DataConnection.GetInstance().handleRecord(query);
        }

        public void AddBill(DTOBill bill)
        {
            string query = "INSERT INTO HoaDon(MaKH, MaNV, NgayLapHD, NgayNhanHang) VALUES('" + bill.IDCustomer + "','" + bill.IDStaff + "','" + bill.CreatedDate + "','" + bill.ReceivedDate + "');";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void EditBill(DTOBill bill)
        {
            string query = "UPDATE HoaDon SET MaKH='" + bill.IDCustomer + "',MaNV='" + bill.IDStaff + "',NgayLapHD='" + bill.CreatedDate + "',NgayNhanHang='" + bill.ReceivedDate + "'" + "WHERE MaHD='" + bill.ID + "'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void DeleteBill(int ID)
        {

            string query = "DELETE HoaDon Where MaHD = '" + ID + "'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }
    }
}
