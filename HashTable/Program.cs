HashTableBase ht = new HashTableLinearProbing(2);
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

HashTableBase ht2 = new HashTableLinearProbing(2);

for (int i = 0; i < 10_000_000; i++)
{
  ht2.Insert(i, "");
}

