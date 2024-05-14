public class HashTableQuadraticProbing : HashTableBase
{
  public HashTableQuadraticProbing(int size) : base(size) { }
  public override int ProbingFunction(int j, int k) => j * j;
}