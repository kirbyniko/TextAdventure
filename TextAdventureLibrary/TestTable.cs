using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class TestTable
    {
        [Key]
        public int MyProperty { get; set; }

        public string test { get; set; }
    }
}
