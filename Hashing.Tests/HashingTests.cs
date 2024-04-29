namespace Hashing.Tests;

[TestClass]
public class HashingTests
{
  [TestMethod]
  public void TestMd5Hash()
  {
    // Arrange
    string input = "Hello, World!";
    string expectedHash = "65a8e27d8879283831b664bd8b7f0ad4";

    // Act
    string actualHash = HashFunctions.GetMd5Hash(input);

    // Assert
    Assert.AreEqual(expectedHash, actualHash);
  }

  [TestMethod]
  public void TestSha1Hash()
  {
    // Arrange
    string input = "Hello, World!";
    string expectedHash = "0a0a9f2a6772942557ab5355d76af442f8f65e01";

    // Act
    string actualHash = HashFunctions.GetSha1Hash(input);

    // Assert
    Assert.AreEqual(expectedHash, actualHash);
  }

  [TestMethod]
  public void TestSha256Hash()
  {
    // Arrange
    string input = "Hello, World!";
    string expectedHash = "dffd6021bb2bd5b0af676290809ec3a53191dd81c7f70a4b28688a362182986f";

    // Act
    string actualHash = HashFunctions.GetSha256Hash(input);

    // Assert
    Assert.AreEqual(expectedHash, actualHash);
  }

  [TestMethod]
  public void TestSha512Hash()
  {
    // Arrange
    string input = "Hello, World!";
    string expectedHash = "374d794a95cdcfd8b35993185fef9ba368f160d8daf432d08ba9f1ed1e5abe6cc69291e0fa2fe0006a52570ef18c19def4e617c33ce52ef0a6e5fbe318cb0387";

    // Act
    string actualHash = HashFunctions.GetSha512Hash(input);

    // Assert
    Assert.AreEqual(expectedHash, actualHash);
  }

  [TestMethod]
  public void TestSimpleHash()
  {
    // Arrange
    string input = "Hello, World!";
    string expectedHash = "69040000";

    // Act
    string actualHash = HashFunctions.GetSimpleHash(input);

    // Assert
    Assert.AreEqual(expectedHash, actualHash);
  }
}