HashTable ht = new HashTable(10);
ht.Insert(10, "Hello");
ht.Insert(20, "World");
Console.WriteLine(ht.Search(10));  // Output: Hello
ht.Delete(10);
Console.WriteLine(ht.Search(10));  // Output: null