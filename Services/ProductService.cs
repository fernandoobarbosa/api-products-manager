using Api.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _products;

        public ProductService(IProductsDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _products = database.GetCollection<Product>(settings.ProductsCollectionName);
        }

        public Product GetByName(string name) =>
            _products.Find<Product>(product => product.Name == name).FirstOrDefault();
        public List<Product> Get() =>
            _products.Find(product => true)
            .SortBy(e=>e.Tags)
            .ToList();

        public Product Get(string id) =>
            _products.Find<Product>(product => product.Id == id).FirstOrDefault();

        public Product Create(Product product)
        {
            _products.InsertOne(product);
            return product;
        }

        public void CreateBatch(List<Product> batch)
        {
            _products.InsertMany(batch);
        }

        public void Update(string id, Product productIn) =>
            _products.ReplaceOne(product => product.Id == id, productIn);

        public void Remove(Product product) =>
            _products.DeleteOne(product => product.Id == product.Id);

        public void Remove(string id) =>
            _products.DeleteOne(product => product.Id == id);
    }
}
