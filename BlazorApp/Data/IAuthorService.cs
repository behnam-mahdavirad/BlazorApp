using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public interface IAuthorService
    {
        public List<Author> GetAuthors();
        public Author GetAuthorById(string authorId);
        public DateTime GetCreateDate();
        public string GetVersion();
    }
}