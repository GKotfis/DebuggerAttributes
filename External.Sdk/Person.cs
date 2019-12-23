using System.Diagnostics;

namespace External.Sdk
{
    [DebuggerDisplay("Id: {Id, nq}, Name: {Name, nq}, Address assigned: {Address != null}")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }
}