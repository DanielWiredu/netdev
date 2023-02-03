using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netdev.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name {get; set;} = "Daniel";
        public int MyProperty { get; set; }
    }
}