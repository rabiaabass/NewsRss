using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsRss.Models
{
    public enum NewsPriorityLevels
    {
        Low = 1,
        Normal = 2,
        Important = 3,
        Critical = 4
    }
    public class News
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public string RSSUrl { get; set; }

        public NewsPriorityLevels NewsPriorityLevels { get; set; }


    }
}
