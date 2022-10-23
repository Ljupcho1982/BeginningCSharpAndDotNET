using Vendors1;

using (var db = new Vendors1Context())
{

    Vendors vendor1 = new Vendors { Name = "Ljupcho", Id = 1, Code = 123, number_Sales = 2, Product = "milk", Price = 10 };

    Vendors vendor2 = new Vendors { Name = "Ljupcho1", Id = 2, Code = 1234, number_Sales = 2, Product = "Chocolate", Price = 10 };


    db.vendors1s.Add(vendor1);

    db.vendors1s.Add(vendor2);

    db.SaveChanges();

    var querry = from v in db.vendors1s orderby v.Name select v;

    foreach (var b in querry)
    {
        Console.WriteLine(b.Name);
    }

}