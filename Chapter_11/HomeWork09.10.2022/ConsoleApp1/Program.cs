using ConsoleApp1;



Random random = new Random();

Table[] tables = new Table[10];


for (int i = 0; i < tables.Length; i++)
{

    tables[i] = new Table(random.Next(50, 201), random.Next(50, 201));

    tables[i].ShowData();

}

CoffeTable[] cafe = new CoffeTable[5];
Console.WriteLine("----------------------------------------");
for (int i = 0; i < 5; i++)


{
    tables[i] = new Table(random.Next(50, 201), random.Next(50, 201));
    tables[i].ShowData();

    tables[i] = new CoffeTable(random.Next(40, 121), random.Next(40, 121));
    tables[i].ShowData();

}





