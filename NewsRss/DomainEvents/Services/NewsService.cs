using NewsRss.DomainEvents.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsRss.DomainEvents.Services
{
    public class NewsService
    {
        NewsRepository _newsRepository;

        public NewsService(NewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        
    }
}
