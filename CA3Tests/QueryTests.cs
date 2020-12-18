using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CA3.Tests
{
    [TestClass()]
    public class QueryTests
    {
        [TestMethod()]
        public void AscendingDateTest()
        {
            {
                Article articleTest1 = new Article()
                {
                    publishedAt = new DateTime(2020, 12, 18)
                };
                Article articleTest2 = new Article()
                {
                    publishedAt = new DateTime(2020, 12, 16)
                };
                Article articleTest3 = new Article()
                {
                    publishedAt = new DateTime(2020, 12, 14)
                };

                Query queryData = new Query()
                {
                    rootData = new Root()
                    {
                        articles = new List<Article> { articleTest1, articleTest2, articleTest3 }
                    }
                };

                Article expectedArticle1 = articleTest3;

                Article actualArticle1 = queryData.rootData.articles.OrderBy(a => a.publishedAt).First();

                Assert.AreEqual(expectedArticle1, actualArticle1);
            }
        }
        [TestMethod()]
        public void DescendingDateTest()
        {
            {
                Article articleTest1 = new Article()
                {
                    publishedAt = new DateTime(2020, 12, 18)
                };
                Article articleTest2 = new Article()
                {
                    publishedAt = new DateTime(2020, 12, 16)
                };
                Article articleTest3 = new Article()
                {
                    publishedAt = new DateTime(2020, 12, 14)
                };

                Query queryData = new Query()
                {
                    rootData = new Root()
                    {
                        articles = new List<Article> { articleTest1, articleTest2, articleTest3}
                    }
                };

                Article expectedArticle1 = articleTest1;

                Article actualArticle1 = queryData.rootData.articles.OrderByDescending(a => a.publishedAt).First();

                Assert.AreEqual(expectedArticle1, actualArticle1);
            }
        }

        [TestMethod]
        public void TestSearchFilter()
        {
            Root query = new Root { articles = new List<Article>()};

            Article article1 = new Article { author = "David Murphy" };
            Article article2 = new Article { author = "Darrell Etherington" };
            Article article3 = new Article { author = "Steve Gillmor" };

            var authors = "";

            query.articles.AddRange(new List<Article> { article1, article2, article3 });

            foreach (var item in query.articles)
            {
                authors += $"{item.author}";
            }

            Query q = new Query();
            q.SearchValue = "David Murphy";
            var checkAuthor = authors.Contains(q.SearchValue);

            Assert.IsTrue(checkAuthor);
        }
    }
}
