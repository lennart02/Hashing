using System;

class Program
{
  static void Main(string[] args)
  {
    // Size of the hash table
    int size = 79;

    DivisionHash divisionHash = new DivisionHash(size);
    MultiplicationHash multiplicationHash = new MultiplicationHash(size);

    int[] keys = { 1, 2, 3, 10, 43, 79, 255, 1986, 324, 1425, 509, 628, 777, 891, 101 };

    // Test Division Hashing
    Console.WriteLine("Division Hashing Results:");
    foreach (int key in keys)
    {
      Console.WriteLine($"Key: {key} -> Hash: {divisionHash.Hash(key)}");
    }

    Console.WriteLine("\n--------------------------------------------------\n");

    // Test Multiplication Hashing
    Console.WriteLine("Multiplication Hashing Results:");
    foreach (int key in keys)
    {
      Console.WriteLine($"Key: {key} -> Hash: {multiplicationHash.Hash(key)}");
    }
  }
}
