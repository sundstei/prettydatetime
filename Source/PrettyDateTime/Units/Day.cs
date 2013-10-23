namespace PrettyDateTime.Units
{
    public class Day : ITimeUnit
    {
        public string GetKey()
        {
            return "Day";
        }

        public long GetMillisPerUnit()
        {
            return 86400000;
        }
    }
}