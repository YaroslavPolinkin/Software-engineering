
using SElab1;

Money apple = new Money(100,100);
Money chicken = new Money(160, 60);

apple.ChangeValue(50, 1000);


Console.WriteLine(apple.ShowBalance());


Product MyProduct = new Product(apple, "apple", "kg", 100);
Product MyProduct2 = new Product(chicken, "chicken", "kg", 200);




Warehouse MyWarehouse = new Warehouse(MyProduct);

Reporting MyReporting = new Reporting(MyWarehouse);

MyReporting.AddProduct(MyProduct2);


Console.WriteLine(MyReporting.GenerateInventoryReport());

Console.WriteLine(MyReporting.RegisterOutgoing(MyProduct2, 60));
Console.WriteLine(MyWarehouse.DisplayProductInfo());

MyProduct.Discount(10, 100);
Console.WriteLine($"Вартість продукту після знижки {MyProduct.NowProductPrice()}");
Console.WriteLine(MyWarehouse.DisplayProductInfo());




