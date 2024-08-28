using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.entity
{
    public class ParceldetailsRepository:IParceldetailsRepository
    {
        string connectionString = string.Empty;//"server=DESKTOP-1U0BM0H\\SQLEXPRESS;database=Parcel;user Id =sa;password=Anaiyaan@123;";
        SqlConnection con = null;

        public ParceldetailsRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DbConnection");
            con = new SqlConnection(connectionString);
        }

        public void Details(Parceldetails reg)
        {
            try
            {
                var insertQuery = $" exec inserttable '{reg.FromAddress}','{reg.TOAddress}',{reg.NetWeight},{reg.Price},'{reg.Date}','{reg.ParcelServiceName}'";
                con.Open();
                con.Execute(insertQuery);
                con.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
        }


        public void UpdateDetails(Parceldetails reg)
        {
            try
            {
                var updateQuery = $"exec updatetable {reg.ParcelID},'{reg.FromAddress}','{reg.TOAddress}',{reg.NetWeight},{reg.Price},'{reg.Date}','{reg.ParcelServiceName}'";
                con.Open();
                con.Execute(updateQuery);
                con.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

      

        public void DeleteDetails(long ParcelID)
        {
            try
            {
                var DeleteQuery = $"exec deletetable {ParcelID}";
                con.Open();
                con.Execute(DeleteQuery);
                con.Close();


            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public List<Parceldetails> ShowAllParcel()
        {
            try
            {
                var Selectall = $"exec ShowAllParcel";
                con.Open();
                List<Parceldetails> result = con.Query<Parceldetails>(Selectall).ToList();
                return result;

            }
            catch(Exception ex)
            {
                throw;
            }

        }
        public Parceldetails ShowParcelbyName(long ParcelId)
        {
            try
            {
                var SelectbyName = $"exec showparcelbyname {ParcelId}";
                con.Open();
                Parceldetails result = con.QueryFirstOrDefault<Parceldetails>(SelectbyName);
                con.Close();
                return result;

            }
            catch (Exception ex)
            {
                throw;
            }
        }




    }    

    
}

