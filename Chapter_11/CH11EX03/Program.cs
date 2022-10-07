using CH11EX03;

Primes primesFrom2Tp1000 = new Primes(2, 1000);
foreach (long i in primesFrom2Tp1000)
{
    Console.WriteLine($"{i}");
    Console.ReadKey();

}