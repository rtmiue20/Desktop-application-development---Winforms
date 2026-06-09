using System.Data;
using Dapper;
using DTO;
using System.Linq;
using System.Collections.Generic;
namespace DAL
{
    public class PromotionsDAL
    {
        public PromotionsDTO GetActiveByCode(string promoCode)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT * FROM Promotions
                                 WHERE PromoCode=@promoCode AND IsActive=1
                                 AND NOW() BETWEEN StartDate AND EndDate";
                return db.QueryFirstOrDefault<PromotionsDTO>(query, new { promoCode });
            }
        }
        public List<PromotionsDTO> GetAll()
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Promotions";
                return db.Query<PromotionsDTO>(sql).ToList();
            }
        }

        public bool Insert(PromotionsDTO promo)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO Promotions
                                 (PromoCode,Description,DiscountPercent,DiscountAmount,StartDate,EndDate,IsActive)
                                 VALUES (@PromoCode,@Description,@DiscountPercent,@DiscountAmount,@StartDate,@EndDate,@IsActive)";
                return db.Execute(query, promo) > 0;
            }
        }

        public bool SetActive(int id, bool isActive)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Execute(
                    "UPDATE Promotions SET IsActive=@isActive WHERE PromotionID=@id",
                    new { isActive, id }) > 0;
            }
        }
    }
}