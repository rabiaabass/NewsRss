using NewsRss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsRss.DomainEvents.Repositories
{
    public class NewsRepository
    {
        private readonly ApplicationDbContext _db;

        public NewsRepository()
        {
            _db = new ApplicationDbContext();
        }

        public void Add(News news)
        {
            _db.News.Add(news);
            _db.SaveChanges();
        }

        public List<News> List()
        {
            return _db.News.ToList();
        }
    }
}
