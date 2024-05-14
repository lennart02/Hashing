public class DivisionHash
{
    private int tableSize;

    public DivisionHash(int size)
    {
        tableSize = size; 
    }

    public int Hash(int key)
    {
        return key % tableSize;
    }
}
