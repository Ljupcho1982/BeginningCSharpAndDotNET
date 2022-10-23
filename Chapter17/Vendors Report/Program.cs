using Vendors_Report;





using (var db = new VendorContex())

{

    Vendors vendor1 = new Vendors { Vendor_Name = "Ljupcho", Product = "Mleko", Price = 10.5M, Code = 123, NumberOfSoldProducts = 10 };


    db.Vendor.Add(vendor1);

    Vendors vendor2 = new Vendors { Vendor_Name = "Trajche", Product = "Meso", Price = 20.5M, Code = 124, NumberOfSoldProducts = 15 };


    db.Vendor.Add(vendor2);



    db.SaveChanges();








    var querry = from v in db.Vendor orderby v.Vendor_Name select v;


    Console.WriteLine("Report on sales by Vendors name");
    foreach (var v in querry)
    {
        Console.WriteLine(v);
        // Console.WriteLine($"The vendor {v.Vendor_Name} who sales {v.Product} bring income of {v.NumberOfSoldProducts * v.Price}");
    }

}


