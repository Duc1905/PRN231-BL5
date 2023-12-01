using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProductRepository :IProductRepository
{
    public void DeleteProduct(Product p) => ProductDAO.DeleteProduct(p);
    public void DeleteProducts(Product[] ps) => ProductDAO.DeleteProducts(ps);
    public void SaveProduct(Product p) => ProductDAO.SaveProduct(p);
    public void UpdateProduct(Product p) => ProductDAO.UpdateProduct(p);

    public List<Product> GetProducts() => ProductDAO.GetProducts();
    public List<Product> GetProducts(int[] ids) => ProductDAO.GetProducts(ids);

    public List<Product> GetProducts(decimal min, decimal max) => ProductDAO.GetProducts(min, max);

    public List<Category> GetCategories() => CategoryDAO.GetCategories();

    public Product GetProductById(int Id) => ProductDAO.FindProductById(Id);

}
