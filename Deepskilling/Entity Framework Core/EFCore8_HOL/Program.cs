using EFCore8_HOL.Data;
using EFCore8_HOL.Models;

using var db = new AppDbContext();

var cat = new Category
{
    Name = "Electronics"
};

db.Categories.Add(cat);

db.Products.Add(
new Product
{
    Name = "Laptop",
    Price = 75000,
    Category = cat
});

db.SaveChanges();

Console.WriteLine("Data Inserted");


