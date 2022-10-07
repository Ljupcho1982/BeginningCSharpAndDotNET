
Checker check = new Checker();
ClassA try1 = new ClassA();
ClassB try2 = new ClassB();
ClassC try3 = new ClassC();
ClassD try4 = new ClassD();
MyStruct try5 = new MyStruct();
object try6 = try5;
Console.WriteLine("Analizing ClassA type variable: ");
check.Check(try1);
Console.WriteLine("Analizing ClassB type variable: ");
check.Check(try2);
Console.WriteLine("Analizing ClassC type variable: ");
check.Check(try3);
Console.WriteLine("Analizing ClassD type variable: ");
check.Check(try4);
Console.WriteLine("Analizing MyStruct type variable: ");
check.Check(try5);
Console.WriteLine("Analizing  boxed MyStruct type variable: ");
check.Check(try6);
class Checker
{

    public void Check(object param1)
    {

        if (param1 is ClassA)
            Console.WriteLine("Variable can be convert to ClassA.");
        else
            Console.WriteLine("Variable can`t be convert to ClassA.");
        if (param1 is IMyInterface)
            Console.WriteLine("Variable can be converted to IMyInterface");
        else
            Console.WriteLine("Variable can`t be converted to IMyInterface");
        if (param1 is MyStruct)
            Console.WriteLine("Variable can be converted to MyStruct");
        else
            Console.WriteLine("Variable can`t be converted to MyStruct");

    }
}

interface IMyInterface { }
class ClassA : IMyInterface { }
class ClassB : IMyInterface { }
class ClassC { }
class ClassD : ClassA { }
struct MyStruct : IMyInterface { }


