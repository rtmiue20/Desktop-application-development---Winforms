using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class CustomersBUS
    {
        private readonly CustomersDAL _dal = new CustomersDAL();

        public List<CustomersDTO> GetAll() => _dal.GetAll();

        public CustomersDTO? GetByPhone(string phone) => _dal.GetByPhone(phone);

        /// <summary>
        /// Tìm hoặc tạo mới khách theo SĐT (dùng khi bán hàng).
        /// </summary>
        public CustomersDTO GetOrCreate(string phone, string fullName = "Khách lẻ")
        {
            var existing = _dal.GetByPhone(phone);
            if (existing != null) return existing;

            var newCustomer = new CustomersDTO
            {
                Phone = phone,
                FullName = fullName,
                CustomerType = "Thường"
            };
            int id = _dal.Insert(newCustomer);
            newCustomer.CustomerID = id;
            return newCustomer;
        }

        /// <summary>
        /// Thêm khách hàng mới, trả true nếu thành công.
        /// </summary>
        public bool Add(CustomersDTO customer)
        {
            if (customer == null) return false;
            if (string.IsNullOrWhiteSpace(customer.Phone) || string.IsNullOrWhiteSpace(customer.FullName))
                return false;

            try
            {
                int id = _dal.Insert(customer);
                if (id > 0)
                {
                    customer.CustomerID = id;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Cập nhật khách hàng, trả (success, errorMessage)
        /// </summary>
        public (bool success, string error) Update(CustomersDTO customer)
        {
            if (customer == null) return (false, "Dữ liệu rỗng.");
            if (string.IsNullOrWhiteSpace(customer.Phone))
                return (false, "Số điện thoại không được để trống.");

            try
            {
                bool ok = _dal.Update(customer);
                return ok ? (true, string.Empty) : (false, "Cập nhật thất bại.");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        /// <summary>
        /// Tìm khách hàng theo từ khóa (SĐT hoặc họ tên). Trả list (có thể rỗng).
        /// </summary>
        public List<CustomersDTO> Search(string keyword)
        {
            var all = GetAll() ?? new List<CustomersDTO>();
            if (string.IsNullOrWhiteSpace(keyword)) return all;

            keyword = keyword.Trim();
            var lower = keyword.ToLowerInvariant();
            var result = all.FindAll(c =>
                (!string.IsNullOrEmpty(c.Phone) && c.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                (!string.IsNullOrEmpty(c.FullName) && c.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            );
            return result;
        }

        public CustomersDTO? GetById(int id) => GetAll().Find(c => c.CustomerID == id);
    }
}
