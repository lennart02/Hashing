public class HashTableDoubleHashing : HashTableBase
{
  public HashTableDoubleHashing(int size) : base(size) { }
  public override int ProbingFunction(int j, int k)
  {
    DivisionHash divisionHash = new DivisionHash(size - 2);
    int hash2 = 1 + divisionHash.Hash(k);
    return j * hash2;
  }
}