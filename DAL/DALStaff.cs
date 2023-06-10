using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALStaff
    {
        public DataTable getAllStaff()
        {
            
            string query = "Select * from NhanVien";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }

        public int AddStaffReturnID(DTOStaff staff)
        {
            string query = "INSERT INTO NhanVien(HoTen, NgayNV, DiaChi, DienThoai, GioiTinh) VALUES(N'" + staff.Name + "','" + staff.DateReceived + "',N'" + staff.Address + "','" + staff.Phone + "',N'" + staff.Gender + "'); SELECT SCOPE_IDENTITY();";
            return DataConnection.GetInstance().handleRecord(query);    
        }

        public void AddStaff(DTOStaff staff) 
        {
            string query = "INSERT INTO NhanVien(HoTen, NgayNV, DiaChi, DienThoai, GioiTinh) VALUES(N'" + staff.Name + "','" + staff.DateReceived + "',N'" + staff.Address + "','" + staff.Phone + "',N'" + staff.Gender + "')";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void EditStaff(DTOStaff staff)
        {
            string query = "UPDATE NhanVien SET HoTen=N'" + staff.Name + "',NgayNV='" + staff.DateReceived + "',DiaChi=N'" + staff.Address + "',DienThoai='" + staff.Phone + "',GioiTinh=N'" + staff.Gender + "',Anh='" + staff.Image + "'" + "WHERE MaNV='" + staff.ID + "'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void DeleteStaff(int ID)
        {

            string query = "DELETE NhanVien Where MaNV = '" + ID +"'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public DataTable SearchStaff(string keyword)
        {
            string query = "SELECT * FROM NhanVien WHERE HoTen LIKE '%" + keyword + "%'";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }
    }
}
