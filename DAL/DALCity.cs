using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALcity
    {
        public DataTable getAllcity()
        {
            string query = "Select * from ThanhPho";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }
        public void AddCity(DTOCity city)
        {
            string query = "INSERT INTO ThanhPho(TenThanhPHo) VALUES(N'" + city.Name + "')";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void EditCity(DTOCity city)
        {
            string query = "UPDATE ThanhPho SET TenThanhPho=N'" + city.Name + "'" + "WHERE MaTP='" + city.ID + "'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public void DeleteCity(int ID)
        {

            string query = "DELETE ThanhPho Where MaTP = '" + ID + "'";
            DataConnection.GetInstance().ExecuteNonQuery(query);
        }

        public DataTable SearchCity(string keyword)
        {
            string query = "SELECT * FROM ThanhPho WHERE TenThanhPho LIKE '%" + keyword + "%'";
            DataTable result = DataConnection.GetInstance().GetRecords(query);
            return result;
        }
    }
}
