public class HashTableLinearProbing : HashTableBase
{
  public HashTableLinearProbing(int size) : base(size) { }
  public override int ProbingFunction(int j, int k) => j;
}