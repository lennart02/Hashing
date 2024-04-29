using System.Security.Cryptography;

/// <summary>
/// This class is a additive hash algorithm that adds up all numbers in the input.
/// It is not secure and only used as a bad example.
/// </summary>
public class AdditiveHash : HashAlgorithm
{
  private int _hash;

  public AdditiveHash()
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
      _hash += GetDigitSum(array[i]);
    }
  }

  private int GetDigitSum(byte number)
  {
    int sum = 0;
    while (number != 0)
    {
      sum += number % 10;
      number /= 10;
    }
    return sum;
  }

  protected override byte[] HashFinal()
  {
    return BitConverter.GetBytes(_hash);
  }
}