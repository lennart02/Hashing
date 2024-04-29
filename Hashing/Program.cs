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
  string md5Hash = HashFunctions.GetMd5Hash(input);
  Console.WriteLine($"MD5 Hash:    {md5Hash}");

  // SHA1 Hashing
  string sha1Hash = HashFunctions.GetSha1Hash(input);
  Console.WriteLine($"SHA1 Hash:   {sha1Hash}");

  // SHA256 Hashing
  string sha256Hash = HashFunctions.GetSha256Hash(input);
  Console.WriteLine($"SHA256 Hash: {sha256Hash}");

  // SHA512 Hashing
  string sha512Hash = HashFunctions.GetSha512Hash(input);
  Console.WriteLine($"SHA512 Hash: {sha512Hash}");

  // Simple Hashing
  string simpleHash = HashFunctions.GetSimpleHash(input);
  Console.WriteLine($"Simple Hash: {simpleHash}");
}