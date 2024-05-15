public class HashTableQuadraticProbing : HashTableBase
{
  public HashTableQuadraticProbing(int size) : base(size) { }
  public override int ProbingFunction(int j, int k) => (j/2) * (j/2) * (int)Math.Pow(-1, j);
}