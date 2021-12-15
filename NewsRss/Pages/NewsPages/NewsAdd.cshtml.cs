using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsRss.DomainEvents.Repositories;
using NewsRss.Models;

namespace NewsRss.Pages.NewsPages
{
    public class NewsAddModel : PageModel
    {
        private readonly NewsRepository nRepo;

        public NewsAddModel(NewsRepository newsRepository)
        {
            nRepo = newsRepository;
        }

        [BindProperty]
        public News NewsInput { get; set; }

        [BindProperty]
        public NewsPriorityLevels newsPriorityLevels { get; set; }


        public void OnGet()
        {
        }

        public void OnPostSave()
        {
            if (ModelState.IsValid)
            {
                NewsInput.NewsPriorityLevels = newsPriorityLevels;
                nRepo.Add(NewsInput); 
            }
        }
    }
}
