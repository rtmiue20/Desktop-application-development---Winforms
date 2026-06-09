using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class WarrantyClaimsDAL
    {
        public int Insert(WarrantyClaimsDTO claim)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO WarrantyClaims
                                 (ClaimCode,SerialID,CustomerID,UserID,InvoiceID,ReceiveDate,DefectDescription,Status)
                                 VALUES (@ClaimCode,@SerialID,@CustomerID,@UserID,@InvoiceID,NOW(),@DefectDescription,@Status);
                                 SELECT LAST_INSERT_ID();";
                return db.ExecuteScalar<int>(query, claim);
            }
        }

        public bool UpdateStatus(int claimID, string status, string resolution = null)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Execute(
                    "UPDATE WarrantyClaims SET Status=@status, Resolution=@resolution WHERE ClaimID=@claimID",
                    new { status, resolution, claimID }) > 0;
            }
        }

        public List<WarrantyClaimsDTO> GetByCustomer(int customerID)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<WarrantyClaimsDTO>(
                    "SELECT * FROM WarrantyClaims WHERE CustomerID=@customerID", new { customerID }).AsList();
            }
        }
        // Mở file: DAL/WarrantyClaimsDAL.cs
        public List<WarrantyClaimsDTO> GetAll()
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<WarrantyClaimsDTO>("SELECT * FROM WarrantyClaims").AsList();
            }
        }

        public List<WarrantyClaimsDTO> GetByStatus(string status)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<WarrantyClaimsDTO>("SELECT * FROM WarrantyClaims WHERE Status = @status", new { status }).AsList();
            }
        }
    }
}