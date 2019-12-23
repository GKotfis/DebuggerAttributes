using System;

namespace External.Sdk {
    public class Person {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }

    public class Address {
        public string City { get; set; }
        public string Street { get; set; }
    }
}