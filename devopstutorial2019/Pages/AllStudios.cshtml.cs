using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devopstutorial2019.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace devopstutorial2019.Pages
{
    public class AllStudiosModel : PageModel
    {
        private StudiosService studiosService;
        public List<Models.Studios> Studios { get; private set; }

        public AllStudiosModel(StudiosService studiosService)
        {
            this.studiosService = studiosService;
        }

        public IActionResult OnGet()
        {
            Studios = studiosService.GetStudios().ToList();
            return Page();
        }
    }
}
