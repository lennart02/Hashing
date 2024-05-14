public class MultiplicationHash
{
  // const A, near the golden Ratio
  private readonly double A = (Math.Sqrt(5) - 1) / 2; 
  private int tableSize;

  public MultiplicationHash(int size)
  {
    tableSize = size;
  }

  public int Hash(int key)
  {
    double fractionalPart = key * A % 1; 
    return (int)(tableSize * fractionalPart);
  }
}
