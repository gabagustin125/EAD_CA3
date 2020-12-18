using System;
using System.Collections.Generic;
using System.Linq;


namespace CA3
{
    public class Query
    {
        
        public Root rootData;
        public string SearchValue { get; set; }
        public void AscendingDate()
        {
            rootData.articles = rootData.articles.OrderBy(e => e.publishedAt).ToList();
        }

        public void DescendingDate()
        {
            rootData.articles = rootData.articles.OrderByDescending(e => e.publishedAt).ToList();
        }

        public bool SearchData(Article article)
        {
            if (string.IsNullOrEmpty(SearchValue))
                return true;

            if (article.author.Contains(SearchValue, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        }
    }
}
