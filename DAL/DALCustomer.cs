using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCustomer
    {
        public DataTable getAllCustomer()
        {

            string query = "Select * from KhachHang";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }

        public int AddCustomerReturnID(DTOCustomer customer)
        {
            string query = "INSERT INTO KhachHang(TenKH, DiaChi, DienThoai, MaTP) VALUES(N'" + customer.Name + "',N'" + customer.Address + "','" + customer.Phone + "','" + customer.ID_City + "'); SELECT SCOPE_IDENTITY();";
            return DataConnection.GetInstance().handleRecord(query);
        }

        public void AddCustomer(DTOCustomer customer)
        {
            string query = "INSERT INTO KhachHang(TenKH, DiaChi, DienThoai, MaTP) VALUES(N'" + customer.Name + "',N'" + customer.Address + "','" + customer.Phone + "','" + customer.ID_City + "')";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void EditCustomer(DTOCustomer customer)
        {
            string query = "UPDATE KhachHang SET TenKH=N'" + customer.Name + "',DiaChi=N'" + customer.Address + "',DienThoai='" + customer.Phone + "',MaTP='" + customer.ID_City + "'" + "WHERE MaKH='" + customer.ID + "'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void DeleteCustomer(int ID)
        {

            string query = "DELETE KhachHang Where MaKH = '" + ID + "'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public DataTable SearchCustomer(string keyword)
        {
            string query = "SELECT * FROM KhachHang WHERE TenKH LIKE '%" + keyword + "%'";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }

        public DataTable getCustomerfromPhone(string phone)
        {
            string query = $"select * from KhachHang where DienThoai = {phone}";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }
    }
}
