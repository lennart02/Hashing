using System;
using System.Diagnostics;

public class PerformanceTesting
{
  const int ITERATIONS = 1_000_000;
  public static void RunAllHashFunctions()
  {
    Stopwatch stopwatch = new Stopwatch();

    // Test the performance of Md5
    stopwatch.Start();
    for (int i = 0; i < ITERATIONS; i++)
    {
      CryptographicHashFunctions.GetMd5Hash("Hello, World!");
    }
    stopwatch.Stop();
    Console.WriteLine("Hashing Md5 Execution Time: " + stopwatch.Elapsed);


    // Test the performance of Sha1
    stopwatch.Reset();
    stopwatch.Start();
    for (int i = 0; i < ITERATIONS; i++)
    {
      CryptographicHashFunctions.GetSha1Hash("Hello, World!");
    }
    stopwatch.Stop();
    Console.WriteLine("Hashing Sha1 Execution Time: " + stopwatch.Elapsed);


    // Test the performance of Sha256
    stopwatch.Reset();
    stopwatch.Start();
    for (int i = 0; i < ITERATIONS; i++)
    {
      CryptographicHashFunctions.GetSha256Hash("Hello, World!");
    }
    stopwatch.Stop();
    Console.WriteLine("Hashing Sha256 Execution Time: " + stopwatch.Elapsed);


    // Test the performance of Sha512
    stopwatch.Reset();
    stopwatch.Start();
    for (int i = 0; i < ITERATIONS; i++)
    {
      CryptographicHashFunctions.GetSha512Hash("Hello, World!");
    }
    stopwatch.Stop();
    Console.WriteLine("Hashing Sha512 Execution Time: " + stopwatch.Elapsed);

    // Test the performance of our Simple Hash
    stopwatch.Reset();
    stopwatch.Start();
    for (int i = 0; i < ITERATIONS; i++)
    {
      CryptographicHashFunctions.GetSimpleHash("Hello, World!");
    }
    stopwatch.Stop();
    Console.WriteLine("Hashing Simple Execution Time: " + stopwatch.Elapsed);
  }
}