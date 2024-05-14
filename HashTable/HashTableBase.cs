using System;
using System.Globalization;

public abstract class HashTableBase
{
  private KeyValuePair<int, string>?[] table;
  protected int size;

  public HashTableBase(int size)
  {
    this.size = size;
    this.table = new KeyValuePair<int, string>?[size];
  }

  public override string ToString()
  {
    string result = "";
    for (int i = 0; i < size; i++)
    {
      if (table[i] != null)
      {
        result += $"Hash: {i}, Key: {table[i]?.Key}, Value: {table[i]?.Value}\n";
      }
    }
    return result;
  }

  protected int Hash(int key)
  {
    // MultiplicationHash multiplicationHash = new MultiplicationHash(size);
    // return multiplicationHash.Hash(key);

    DivisionHash divisionHash = new DivisionHash(size);
    return divisionHash.Hash(key);
  }

  public void Insert(int key, string value)
  {
    int index = Hash(key);
    int counter = 0;

    while (table[index] != null)
    {
      counter++;
      if (table[index]?.Key == key)
      {
        table[index] = new KeyValuePair<int, string>(key, value);
        return;
      }
      index = (key + ProbingFunction(counter, index)) % size;
      if (counter == size) HandleTableFull();
    }

    table[index] = new KeyValuePair<int, string>(key, value);
  }

  //Efficient prime number check
  private bool IsPrime(int number)
  {
    if (number < 2) return false;
    if (number < 4) return true;
    if (number % 2 == 0) return false;
    for (int i = 3; i <= Math.Sqrt(number); i += 2)
    {
      if (number % i == 0) return false;
    }
    return true;
  }

  public void HandleTableFull()
  {
    Console.WriteLine("Table is full. Initializing rehashing...");
    //Rehashing with doubling and getting the next prime number
    size *= 2;
    while (!IsPrime(size))
    {
      size++;
    }

    KeyValuePair<int, string>?[] tempTable = table;
    table = new KeyValuePair<int, string>?[size];
    foreach (KeyValuePair<int, string>? item in tempTable)
    {
      if (item != null)
      {
        Insert(item.Value.Key, item.Value.Value);
      }
    }

    Console.WriteLine("Rehashing completed. New table size: " + size);
  }

  public abstract int ProbingFunction(int j, int k);


  public string? Search(int key)
  {
    int index = Hash(key);
    int startIndex = index;

    while (table[index] != null)
    {
      if (table[index]?.Key == key)
        return table[index]?.Value;
      index = (index + 1) % size;
      if (index == startIndex) return null;
    }
    return null;
  }

  public bool Delete(int key)
  {
    int index = Hash(key);
    int startIndex = index;

    while (table[index] != null)
    {
      if (table[index]?.Key == key)
      {
        table[index] = null;
        return true;
      }
      index = (index + 1) % size;
      if (index == startIndex) return false;
    }
    return false;
  }
}
