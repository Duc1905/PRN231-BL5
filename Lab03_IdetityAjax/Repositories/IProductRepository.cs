using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IProductRepository
{
    void SaveProduct(Product p);

    Product GetProductById(int id);

    void DeleteProduct(Product p);
    void DeleteProducts(Product[] ps);

    void UpdateProduct(Product p);

    List<Category> GetCategories();
    List<Product> GetProducts();

    List<Product> GetProducts(int[] ids);
    List<Product> GetProducts(decimal min, decimal max);
}
