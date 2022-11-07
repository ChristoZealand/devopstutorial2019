using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devopstutorial2019.Models;

namespace devopstutorial2019.Services
{
    public class StudiosService
    {
        private List<Studios> studios;

        public StudiosService()
        {
            studios = Studios.GetMockStudios();
        }

        public IEnumerable<Studios> GetStudios()
        {
            return studios;
        }
    }
}
