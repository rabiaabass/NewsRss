using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewsRss.DomainEvents.Repositories;
using NewsRss.Models;

namespace NewsRss.Pages.NewsPages
{
    public class NewsFeedModel : PageModel
    {
        private readonly NewsRepository nRepo;

        public NewsFeedModel(NewsRepository newsRepository)
        {
            nRepo = newsRepository;
        }
        [BindProperty]
        public News NewsInput { get; set; }

        public List<News> NewsList { get; set; } = new List<News>();



    public void OnGet()
        {
            NewsList = nRepo.List();

            
        }
    }
}
