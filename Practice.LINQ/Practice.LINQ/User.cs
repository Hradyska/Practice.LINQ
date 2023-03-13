namespace Practice.LINQ
{
    internal class User
    {
        public User()
        {
            Name = string.Empty;
            PhoneNumber = string.Empty;
        }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return Name + " " + PhoneNumber;
        }
    }
}
