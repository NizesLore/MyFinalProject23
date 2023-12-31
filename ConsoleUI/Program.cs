﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


//ProductManager productManager = new ProductManager(new EfProductDal());
//foreach (var product in productManager.GetAllByCategoryId(2))
//{
//    Console.WriteLine(product.ProductName);
//}

//ProductTest();
//CategoryTest();



ProductManager productManager = new ProductManager(new EfProductDal());
var result = productManager.GetProductDetails();

if (result.Success == true)
{
    foreach (var product in result.Data)
    {
        Console.WriteLine(product.ProductName +"/" + product.CategoryName);
    }
}
else
{
    Console.WriteLine(result.Message);
}



static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetProductDetails().Data)
    {
        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}