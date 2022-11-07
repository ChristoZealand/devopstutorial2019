using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devopstutorial2019.Models
{
    public class Studios
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HQCity { get; set; }
        public int NoOfEmployees { get; set; }

        public Studios()
        {

        }
        private static List<Studios> studios = new List<Studios>()
        {
            new Studios { Id = 1, Name = "DIsney", HQCity = "Florida", NoOfEmployees = 2},
            new Studios { Id = 2, Name = "SUii", HQCity = "Texas", NoOfEmployees = 1},
        };

        public static List<Studios> GetMockStudios()
        {
            return studios;
        }
    }
}
