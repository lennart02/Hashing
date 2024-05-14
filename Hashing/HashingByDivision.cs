using System.Security.Cryptography;

/// <summary>
/// This class is a simple additive hash algorithm that adds up all the bytes in the input.
/// It is not secure and only used as a bad example.
/// </summary>
public class HashingByDivision : HashAlgorithm
{
  private int _hash;

  public HashingByDivision()
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
      _hash += array[i] % int.MaxValue;// Math.Pow(2, 32);
    }
  }

  protected override byte[] HashFinal()
  {
    return BitConverter.GetBytes(_hash);
  }
}