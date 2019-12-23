using System.Diagnostics;

namespace External.Sdk
{
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

        public string DebuggerDisplay
            => $"Id: {Id}, Name: {Name}, Address assigned: {Address != null}";
    }

    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }
}