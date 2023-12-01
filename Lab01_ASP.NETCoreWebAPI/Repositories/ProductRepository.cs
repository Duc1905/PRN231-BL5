using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProductRepository :IProductRepository
{
    public void DeleteProduct(Product p) => ProductDAO.DeleteProduct(p);
    public void SaveProduct(Product p) => ProductDAO.SaveProduct(p);
    public void UpdateProduct(Product p) => ProductDAO.UpdateProduct(p);

    public List<Product> GetProducts() => ProductDAO.GetProducts();

    public List<Category> GetCategories() => CategoryDAO.GetCategories();

    public Product GetProductById(int Id) => ProductDAO.FindProductById(Id);

}
