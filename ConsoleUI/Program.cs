// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

Console.WriteLine("Hello, World!");


CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine(category.CategoryName);

}
//ProductTest();

//static void ProductTest()
//{
//    ProductManager productManager = new ProductManager(new EfProductDal());
//    foreach (var product in productManager.ProductDetails().Data)
//    {
//        Console.WriteLine(product.CategoryName);

//    }
//}