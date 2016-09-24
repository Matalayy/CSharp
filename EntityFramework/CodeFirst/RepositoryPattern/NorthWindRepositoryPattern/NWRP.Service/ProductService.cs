using NorthWindRepositoryPatern.ORM.Models;
using NWRP.DTO.Product;
using NWRP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWRP.Service
{
    public class ProductService
    {
        ProductRepository repository = new ProductRepository();
        public IList<ProductListDTO> Listed()
        {
            return repository.Listed().Select(
                x => new ProductListDTO
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    SupplierID = x.SupplierID,
                    CategoryID = x.CategoryID,
                    QuantityPerUnit = x.QuantityPerUnit,
                    UnitPrice = x.UnitPrice,
                    UnitsInStock = x.UnitsInStock,
                    UnitsOnOrder = x.UnitsOnOrder,
                    ReorderLevel = x.ReorderLevel,
                    Discontinued = x.Discontinued                    
                }).ToList();
        }

        public void Add(ProductAddDTO entity)
        {
            Product product = new Product{
                ProductName = entity.ProductName,
                UnitPrice = entity.UnitPrice,
                UnitsInStock = entity.UnitsInStock,
                CategoryID = entity.CategoryId,
                SupplierID = entity.SupplierId };

            repository.Add(product);
        }
    }
}