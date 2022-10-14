
Console.WriteLine("Enter the height of an rectangle: ");
double height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the width of an rectangle: ");
double width = Convert.ToDouble(Console.ReadLine());

double diagonale = Math.Sqrt(width * width + height * height);
Console.WriteLine(diagonale);
