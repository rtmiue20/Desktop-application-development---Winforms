using DAL;
using DTO;

namespace BUS
{
    public class CustomersBUS
    {
        private readonly CustomersDAL _dal = new CustomersDAL();

        public System.Collections.Generic.List<CustomersDTO> GetAll() => _dal.GetAll();

        public CustomersDTO GetByPhone(string phone) => _dal.GetByPhone(phone);

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

        public (bool success, string error) Update(CustomersDTO customer)
        {
            if (string.IsNullOrWhiteSpace(customer.Phone))
                return (false, "Số điện thoại không được để trống.");

            return (_dal.Update(customer), "Cập nhật thất bại.");
        }
        public CustomersDTO GetById(int id) => GetAll().Find(c => c.CustomerID == id);
    }
}