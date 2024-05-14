using System.Security.Cryptography;

/// <summary>
/// This class is a simple additive hash algorithm that adds up all the bytes in the input.
/// It is not secure and only used as a bad example.
/// </summary>
public class HashingByMultiplication : HashAlgorithm
{
  private int _hash;
   
  //change output bit size
  private new const int HashSize = 256;

  public HashingByMultiplication()
  {
    _hash = 0;
  }

  public override void Initialize()
  {
    _hash = 0;
  }

  protected override void HashCore(byte[] array, int ibStart, int cbSize)
  {
    for (int i = ibStart; i < ibStart + cbSize; i++)
    {
      //Fibonacci Hashing 
      double A = 0.6180339887;
      _hash += (int)(HashSize * (array[i] * A % 1));
    }
  }

  protected override byte[] HashFinal()
  {
    return BitConverter.GetBytes(_hash);
  }
}