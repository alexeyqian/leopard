using System;
using System.Collections.Generic;
using Leopard.Models;

namespace Leopard.Services
{
    public class ArticleDataService : IArticleDataService
    {
        public List<Article> GetAll()
        {
            return ArticleRepository.Articles;
        }

        public void Add(Article entity)
        {
            ArticleRepository.Add(entity);
        }

        public void Update(Article entity)
        {
            ArticleRepository.Update(entity);
        }

    }
}
