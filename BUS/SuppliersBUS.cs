using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class SuppliersBUS
    {
        private readonly SuppliersDAL _dal = new SuppliersDAL();

        public List<SuppliersDTO> GetAll() => _dal.GetAll();

        public bool Add(SuppliersDTO supplier)
        {
            if (string.IsNullOrWhiteSpace(supplier.SupplierName)) return false;
            if (string.IsNullOrWhiteSpace(supplier.Phone)) return false;

            // Tạo mã NCC tự động nếu chưa có
            if (string.IsNullOrWhiteSpace(supplier.SupplierCode))
                supplier.SupplierCode = "NCC" + System.DateTime.Now.ToString("yyyyMMddHHmmss");

            int id = _dal.Insert(supplier);
            return id > 0;
        }

        public bool Update(SuppliersDTO supplier)
        {
            if (supplier.SupplierID <= 0) return false;
            if (string.IsNullOrWhiteSpace(supplier.SupplierName)) return false;

            return _dal.Update(supplier);
        }

        public bool Delete(int supplierId)
        {
            if (supplierId <= 0) return false;
            return _dal.Delete(supplierId);
        }
    }
}
