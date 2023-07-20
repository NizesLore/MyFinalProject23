using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

ProductManager productManager = new ProductManager( new EfProductDal());

foreach (var product in productManager.GetByUnitPrice(80,100))
{
    Console.WriteLine(product.ProductName);
}
