﻿using vendor123;

using (var db = new VendorContex())
{
    Vendor vendor1 = new Vendor { Name = "Ljupcho", Product = "chip", Price = 10, Number_product = 5 };

    Vendor vendor2 = new Vendor { Name = "Petko", Product = "memory", Price = 100, Number_product = 60 };

    db.Vendors.Add(vendor1);
    db.Vendors.Add(vendor2);
    db.SaveChanges();
    // decimal revenue = 0;
    var querry = from b in db.Vendors orderby b.Name select b;

    Console.WriteLine("--------Report on Sale:-----");
    foreach (var b in querry)
    {

        //  revenue += b.Price * b.Number_product;
        Console.WriteLine($"The Vendor {b.Name} made sale revenue of {b.Number_product * b.Price} of the {b.Product} and the total is {b.Sum}");


    }
    Console.WriteLine($"_________Total revenue is: {revenue}_____________");

    Console.WriteLine($"______________________END OF THE REPORT____________________________");
}
