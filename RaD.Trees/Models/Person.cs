using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaD.Trees.Models
{
    public class Person
    {
        public string FirstName { get; set; }

        public bool IsExpanded { get; set; }

        public List<Person> Children { get; set; }
    }
}
