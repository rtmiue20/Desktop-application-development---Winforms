using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class ProductsBUS
    {
        private readonly ProductsDAL _dal = new ProductsDAL();

        public List<ProductsDTO> GetAll() => _dal.GetAll();

        public ProductsDTO GetByCode(string code) => _dal.GetByCode(code);

        public (bool success, string error) Insert(ProductsDTO product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductCode))
                return (false, "Mã sản phẩm không được để trống.");
            if (string.IsNullOrWhiteSpace(product.ProductName))
                return (false, "Tên sản phẩm không được để trống.");
            if (product.UnitPrice <= 0)
                return (false, "Giá bán phải lớn hơn 0.");
            if (_dal.GetByCode(product.ProductCode) != null)
                return (false, "Mã sản phẩm đã tồn tại.");

            _dal.Insert(product);
            return (true, null);
        }

        public (bool success, string error) Update(ProductsDTO product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName))
                return (false, "Tên sản phẩm không được để trống.");
            if (product.UnitPrice <= 0)
                return (false, "Giá bán phải lớn hơn 0.");

            return (_dal.Update(product), "Cập nhật thất bại.");
        }

        public (bool success, string error) Delete(int id)
        {
            // TODO: kiểm tra còn ProductItems trong kho không
            return (_dal.Delete(id), "Xóa thất bại.");
        }
        public ProductsDTO GetById(int id) => GetAll().Find(p => p.ProductID == id);
    }
}