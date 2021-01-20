using System;
using System.Collections.Generic;
using Leopard.Models;

namespace Leopard.Services
{
    public interface IArticleDataService
    {
        List<Article> GetAll();
        void Add(Article entity);
        void Update(Article entity);
    }
}
