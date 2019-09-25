using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_DatabaseFirst.ViewModels
{
    public class Search_VM
    {
        public SearchByName_VM SearchByName_VM { get; set; }
        public SearchByLocation_VM SearchByLocation_VM { get; set; }
    }
}
