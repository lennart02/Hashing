namespace Hashing.Tests;

[TestClass]
public class HashCollisionTests
{

  const int MAX_VALUE = 1000;//Int32.MaxValue;

  [TestMethod]
  public void TestHashCollision()
  {
    int input1;
    int input2;
    string hash1;
    string hash2;
    do
    {
      // Arrange
      // Create two different inputs that are expected to collide
      Random random = new Random();

      //Get 2 different random numbers
      do
      {
        input1 = random.Next(1, MAX_VALUE);
        input2 = random.Next(1, MAX_VALUE);
      } while (input1 == input2);


      // Act
      // Apply the hashing algorithm to both inputs
      hash1 = CryptographicHashFunctions.GetSimpleHash(input1.ToString());
      hash2 = CryptographicHashFunctions.GetSimpleHash(input2.ToString());
      Console.WriteLine($"No Collision found: {hash1} != {hash2}");

    } while (hash1 != hash2);

    // Collision found
    Console.WriteLine($"Collision found: {input1} and {input2} hash to the same value: {hash1}");
  }
}

