PerformanceTesting.RunAllHashFunctions();

while (true)
{
  Console.WriteLine("Enter the string to hash:");
  string? input = Console.ReadLine();
  if (string.IsNullOrEmpty(input))
  {
    break;
  }


  // MD5 Hashing
  string md5Hash = CryptographicHashFunctions.GetMd5Hash(input);
  Console.WriteLine($"MD5 Hash:    {md5Hash}");

  // SHA1 Hashing
  string sha1Hash = CryptographicHashFunctions.GetSha1Hash(input);
  Console.WriteLine($"SHA1 Hash:   {sha1Hash}");

  // SHA256 Hashing
  string sha256Hash = CryptographicHashFunctions.GetSha256Hash(input);
  Console.WriteLine($"SHA256 Hash: {sha256Hash}");

  // SHA512 Hashing
  string sha512Hash = CryptographicHashFunctions.GetSha512Hash(input);
  Console.WriteLine($"SHA512 Hash: {sha512Hash}");

  // Hashing By Division
  string divisionHash = CryptographicHashFunctions.GetHashByDivision(input);
  Console.WriteLine($"Hash By Division: {divisionHash}");

  // Hashing By Multiplication
  string multiplicationHash = CryptographicHashFunctions.GetHashByMultiplication(input);
  Console.WriteLine($"Hash By Multiplication: {multiplicationHash}");
}