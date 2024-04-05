using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Design;
using System.Security.AccessControl;
public class DatabaseHandler
{
    private MyDBContext context;

    public DatabaseHandler()
    {
        context = new MyDBContext();
    }

    public void AddProduct(Product product)
    {
   
        context.Products.Add(product);
        context.SaveChanges();
    }

    //TODO:Plan and implement update function
    public void UpdateProductDescription()
    {
        var productToUpdate = context.Products.FirstOrDefault(p => p.Name == "Product A");
        if (productToUpdate != null)
        {
            productToUpdate.Description = "Updated description";
            context.SaveChanges();
        }
    }

    public void DeleteProduct(int productID)
    {
        var productToDelete = context.Products.FirstOrDefault(p => p.Id == productID);
        if (productToDelete != null)
        {
            context.Products.Remove(productToDelete);
            context.SaveChanges();
        }
    }

    public List<Product> GetProducts(QueryObject query)
    {

        //TODO: fix query
        //勘違いによって非効率なアルゴリズム
        List<Product> _products = context.Products.ToList();

        if (query.minPrice != null)
        {
            _products = _products.Where(p => p.Price >= query.minPrice).ToList();
        }
        if (query.maxPrice != null)
        {
            _products = _products.Where(p => p.Price <= query.maxPrice).ToList();
        }
        if (query.minStock != null)
        {
            _products = _products.Where(p => p.stock >= query.minStock).ToList();
        }
        if (query.maxStock != null)
        {
            _products = _products.Where(p => p.stock <= query.minStock).ToList();
        }
        if (query.nameQuery != null)
        {
            _products = _products.Where(p => p.Name.Contains(query.nameQuery)).ToList();
        }
        if (query.descriptionQuery != null)
        {
            _products = _products.Where(p => p.Description.Contains(query.descriptionQuery)).ToList();
        }

        ////TODO: Fix algolrythm
        //IQueryable<Product> products = context.Products.Where(p =>
        //        (query.minPrice == null || p.Price >= query.minPrice || p.Price == null) &&
        //        (query.maxPrice == null || p.Price <= query.maxPrice || p.Price == null) &&
        //        (query.minStock == null || p.stock >= query.minStock || p.stock == null) &&
        //        (query.maxStock == null || p.stock >= query.maxStock || p.stock == null) &&
        //        (query.nameQuery == null || p.Name == null || p.Name.Contains(query.nameQuery) &&
        //        (query.descriptionQuery == null || p.Description == null || p.Description.Contains(query.descriptionQuery));


        //List<Product> _products = (List<Product>)products;



        return _products;
    }

    //ChatGPT 
    public int GetFirstAvailableId()
    {
        
        
            // Get the maximum ID currently in use
            int maxIdInUse = context.Products.Any() ? context.Products.Max(p => p.Id) : 0;

            // Check for the first gap in the sequence of IDs
            for (int i = 1; i <= maxIdInUse + 1; i++)
            {
                if (!context.Products.Any(p => p.Id == i))
                {
                    return i;
                }
            }

            // If no gap is found, return the next ID after the maximum ID
            return maxIdInUse + 1;
        
    }

}

