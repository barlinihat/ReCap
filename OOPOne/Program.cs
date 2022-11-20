using OOPOne;

Console.WriteLine("Hello, World!");

Product productOne = new Product();
productOne.Id = 1;
productOne.CategoryId = 2;
productOne.ProductName = "table";
productOne.UnitPrice = 500;
productOne.UnitsInStock = 3;

ProductManager productManager = new ProductManager();
productManager.Add(productOne);
