namespace PrettyDateTime.Units
{
    public class Hour : ITimeUnit
    {
        public string GetKey()
        {
            return "Hour";
        }

        public long GetMillisPerUnit()
        {
            return 3600000;
        }
    }
}