

bool debug = true;

string newText = Encrypter.Encrypter.Encrypt("Hola");
Console.WriteLine("Text has been encripted: {0}", newText);
string textDecripted = Encrypter.Encrypter.Decrypt(newText);
Console.WriteLine("Text Decripted: {0}", textDecripted);

if (debug)
{
    Console.ReadLine();
}