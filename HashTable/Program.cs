using System.Diagnostics;
using System.Runtime.CompilerServices;

//Example usage of the HashTable
HashTableBase ht = new HashTableLinearProbing(10);
ht.Insert(10, "Hello");
ht.Insert(20, "World");
ht.Insert(5, "Test");
ht.Insert(15, "Kollision");
ht.Insert(36, "Another Kollision");

ht.Insert(120, "Hello");
ht.Insert(230, "World");
ht.Insert(53, "Test");
ht.Insert(135, "Kollision");

Console.WriteLine(ht);


//Benchmarking the HashTable implementations
HashTableBase linear = new HashTableLinearProbing(11);
HashTableBase quadratic = new HashTableQuadraticProbing(11);
HashTableBase doubleHashing = new HashTableDoubleHashing(11);

TimeSpan BenchmarkTime(HashTableBase hashTable)
{
  Stopwatch stopwatch = new Stopwatch();
  stopwatch.Start();
  for (int i = 0; i < 1_000_000; i++)
  {
    Random random = new Random();
    hashTable.Insert(random.Next(), i.ToString());
  }

  stopwatch.Stop();
  return stopwatch.Elapsed;
}

TimeSpan linearTime = BenchmarkTime(linear);
TimeSpan quadraticTime = BenchmarkTime(quadratic);
TimeSpan doubleHashingTime = BenchmarkTime(doubleHashing);

Console.WriteLine("Linear Probing Execution Time: " + linearTime);
Console.WriteLine("Quadratic Probing Execution Time: " + quadraticTime);
Console.WriteLine("Double Hashing Execution Time: " + doubleHashingTime);