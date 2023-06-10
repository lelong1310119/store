using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALProduct
    {
        public DataTable getAllProduct()
        {

            string query = "Select * from SanPham";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }

        public int AddProductReturnID(DTOProduct product)
        {
            string query = "INSERT INTO SanPham(TenSP, Dongia, Anh) VALUES(N'" + product.Name + "','" + product.Price + "',N'" + product.Image + "'); SELECT SCOPE_IDENTITY();";
            return DataConnection.GetInstance().handleRecord(query);
        }

        public void AddProduct(DTOProduct product)
        {
            string query = "INSERT INTO SanPham(TenSP, Dongia, Anh) VALUES(N'" + product.Name + "','" + product.Price + "',N'" + product.Image + "');";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void EditProduct(DTOProduct product)
        {
            string query = "UPDATE SanPham SET TenSP=N'" + product.Name + "',Dongia=N'" + product.Price + "',Anh=N'" + product.Image +  "'" + "WHERE MaSP='" + product.ID + "'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void DeleteProduct(int ID)
        {

            string query = "DELETE SanPham Where MaSP = '" + ID + "'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public DataTable SearchProduct(string keyword)
        {
            string query = "SELECT * FROM SanPham WHERE TenSP LIKE '%" + keyword + "%'";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }
    }
}
