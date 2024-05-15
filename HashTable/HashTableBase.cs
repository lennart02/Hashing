using System;
using System.Globalization;

public abstract class HashTableBase
{
  private KeyValuePair<int, string>?[] table;
  protected int size;
  protected int count;

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

  /// <summary>
  /// Probing function to calculate the next index. Can be overridden by subclasses
  /// </summary>
  public abstract int ProbingFunction(int j, int k);

  /// <summary>
  /// Hash function to calculate the index
  /// </summary>
  protected int Hash(int key)
  {
    DivisionHash divisionHash = new DivisionHash(size);
    return divisionHash.Hash(key);

    // MultiplicationHash multiplicationHash = new MultiplicationHash(size);
    // return multiplicationHash.Hash(key);
  }

  /// <summary>
  /// Inserts the key and value into the hash table
  /// </summary>
  public void Insert(int key, string value)
  {
    CheckLoadFactor();

    int index = Hash(key);
    int counter = 0;

    while (table[index] != null)
    {
      counter++;
      // If the key already exists, update the value
      if (table[index]?.Key == key)
      {
        table[index] = new KeyValuePair<int, string>(key, value);
        return;
      }
      index = (int)((key + (long)ProbingFunction(counter, index)) % size);
      if (counter == size)
      {
        Console.Write("Table is full. Initializing rehashing... ");
        HandleTableFull();
      }
    }
    // Insert the key-value pair at the hashed index
    count++;
    table[index] = new KeyValuePair<int, string>(key, value);
  }

  private void CheckLoadFactor()
  {
    double loadFactor = (double)count / size;
    // If the load factor is greater than this specific value, rehash the table
    if (loadFactor > 0.75)
    {
      HandleTableFull();
    }
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


  /// <summary>
  /// This triggers to rehash the table
  /// </summary>
  private void HandleTableFull()
  {
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


  /// <summary>
  /// Searches for the key in the hash table
  /// </summary>
  public string? Search(int key)
  {
    int index = Hash(key);
    int counter = 0;

    while (table[index] != null)
    {
      counter++;
      if (table[index]?.Key == key)
        return table[index]?.Value;
      index = (int)((key + (long)ProbingFunction(counter, index)) % size);

      if (counter == size) return null;
    }
    return null;
  }

  /// <summary>
  /// Deletes the key from the hash table
  /// </summary>
  public bool Delete(int key)
  {
    int index = Hash(key);
    int counter = 0;

    while (table[index] != null)
    {
      counter++;
      if (table[index]?.Key == key)
      {
        table[index] = null;
        count--;
        return true;
      }
      index = (int)((key + (long)ProbingFunction(counter, index)) % size);

      if (counter == size) return false;
    }
    return false;
  }
}
