namespace Templates
{
    internal class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    internal class Customer : Person
    {
        public bool IsPrime { get; set; }
    }
}
