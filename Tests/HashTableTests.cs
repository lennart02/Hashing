
namespace Hashing.Tests;

[TestClass]
public class HashTableTests
{
  [TestMethod]
  public void TestLinearProbing()
  {
    HashTableBase ht = new HashTableLinearProbing(10);

    TestHashTable(ht);
  }

  [TestMethod]
  public void TestQuadraticProbing()
  {
    HashTableBase ht = new HashTableLinearProbing(10);

    TestHashTable(ht);
  }

  [TestMethod]
  public void TestDoubleHashingProbing()
  {
    HashTableBase ht = new HashTableLinearProbing(10);

    TestHashTable(ht);
  }

  /// <summary>
  /// Test Insert, Search, and Delete methods of the HashTable
  /// </summary>
  /// <param name="ht"></param>
  private void TestHashTable(HashTableBase ht)
  {
    //Test Insert
    ht.Insert(10, "Hello");
    Assert.AreEqual(ht.Search(10), "Hello");

    ht.Insert(20, "World");
    Assert.AreEqual(ht.Search(20), "World");

    //Test Update

    ht.Insert(10, "Hello World");
    Assert.AreEqual(ht.Search(10), "Hello World");

    //Test Delete
    ht.Delete(10);
    Assert.AreEqual(ht.Search(10), null);

    //Test Collision
    ht.Insert(5, "Test");
    ht.Insert(15, "Kollision");
    ht.Insert(36, "Another Kollision");
    Assert.AreEqual(ht.Search(5), "Test");
    Assert.AreEqual(ht.Search(15), "Kollision");
    Assert.AreEqual(ht.Search(36), "Another Kollision");

    //Test Resize
    ht.Insert(120, "Hello");
    ht.Insert(230, "World");
    ht.Insert(53, "Test");
    ht.Insert(135, "Kollision");
    Assert.AreEqual(ht.Search(120), "Hello");
    Assert.AreEqual(ht.Search(230), "World");
    Assert.AreEqual(ht.Search(53), "Test");
    Assert.AreEqual(ht.Search(135), "Kollision");
  }
}