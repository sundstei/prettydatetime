namespace PrettyDateTime.Units
{
    public interface ITimeUnit
    {
        string GetKey();
        long GetMillisPerUnit();
    }
}