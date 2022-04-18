using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            var posts = context.PostWithTagsCount.ToList();
            foreach (var post in posts)
            {
                Console.WriteLine($"Title: {post.Name} - with {post.Count} categories");
            }


            //context.Users.Add(new User
            //{
            //    Bio = "Developer under updates",
            //    Email = "ricardo2@email.com",
            //    Image = "https://google.com",
            //    Name = "Ricardo Oliveira2",
            //    PasswordHash = "123456",
            //    Slug = "ricardo-oliveira2",
            //    Github = "stringao"
            //});
            //context.SaveChanges();

            //var user = context.Users.FirstOrDefault();
            //var post = new Post
            //{
            //    Author = user,
            //    Body = "Meu Artigo",
            //    Category = new Category
            //    {
            //        Name = "Artigos Pessoais",
            //        Slug = "artigos-pessoais"
            //    },
            //    CreateDate = DateTime.Now,
            //    //LastUpdateDate = DateTime.Now,
            //    Slug = "meu-artigo",
            //    Summary = "Neste artigo vamos conferir...",
            //    //Tags = null,
            //    Title = "Meu Artigo",
            //};
            //context.Posts.Add(post);
            //context.SaveChanges();

        }
    }
}
