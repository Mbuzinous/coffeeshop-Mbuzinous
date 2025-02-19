using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.Model
{
    public class User
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Dictionary<DateTime, Coffee> MyCoffees { get; set; }

        public User(string firstName, string lastName)
        {
            Id += 1;
            FirstName = firstName;
            LastName = lastName;
            MyCoffees = new Dictionary<DateTime, Coffee>();
        }
    }
}
