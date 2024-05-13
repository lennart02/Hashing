using System;

public class HashTable
{
  private KeyValuePair<int, string>?[] table;
  private int size;

  public HashTable(int size)
  {
    this.size = size;
    this.table = new KeyValuePair<int, string>?[size];
  }

  private int HashFunction(int key)
  {
    return key % size;
  }

  public void Insert(int key, string value)
  {
    int index = HashFunction(key);
    int startIndex = index;

    while (table[index] != null)
    {
      if (table[index].Value.Key == key)  // Update existing key
      {
        table[index] = new KeyValuePair<int, string>(key, value);
        return;
      }
      index = (index + 1) % size;
      if (index == startIndex) throw new Exception("HashTable is full");
    }

    table[index] = new KeyValuePair<int, string>(key, value);
  }

  public string Search(int key)
  {
    int index = HashFunction(key);
    int startIndex = index;

    while (table[index] != null)
    {
      if (table[index].Value.Key == key)
        return table[index].Value.Value;
      index = (index + 1) % size;
      if (index == startIndex) return null; // Element not found
    }
    return null; // Element not found
  }

  public bool Delete(int key)
  {
    int index = HashFunction(key);
    int startIndex = index;

    while (table[index] != null)
    {
      if (table[index].Value.Key == key)
      {
        table[index] = null;
        return true; // Element deleted
      }
      index = (index + 1) % size;
      if (index == startIndex) return false; // Element not found
    }
    return false; // Element not found
  }
}
