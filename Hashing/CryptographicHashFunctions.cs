using System.Security.Cryptography;
using System.Text;

public class CryptographicHashFunctions
{
  private static string ComputeHash(string input, HashAlgorithm algorithm)
  {
    byte[] inputBytes = Encoding.UTF8.GetBytes(input);
    byte[] hashBytes = algorithm.ComputeHash(inputBytes);

    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < hashBytes.Length; i++)
    {
      sb.Append(hashBytes[i].ToString("x2"));
    }

    return sb.ToString();
  }

  public static string GetMd5Hash(string input)
  {
    using (MD5 md5 = MD5.Create())
    {
      return ComputeHash(input, md5);
    }
  }

  public static string GetSha1Hash(string input)
  {
    using (SHA1 sha1 = SHA1.Create())
    {
      return ComputeHash(input, sha1);
    }
  }

  public static string GetSha256Hash(string input)
  {
    using (SHA256 sha256 = SHA256.Create())
    {
      return ComputeHash(input, sha256);
    }
  }

  public static string GetSha512Hash(string input)
  {
    using (SHA512 sha512 = SHA512.Create())
    {
      return ComputeHash(input, sha512);
    }
  }

public static string GetHashByDivision(string input)
  {
    using (HashingByDivision simpleHash = new HashingByDivision())
    {
      return ComputeHash(input, simpleHash);
    }
  }

  public static string GetHashByMultiplication(string input)
  {
    using (HashingByMultiplication simpleHash = new HashingByMultiplication())
    {
      return ComputeHash(input, simpleHash);
    }
  }
}