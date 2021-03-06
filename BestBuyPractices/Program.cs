﻿using System;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using BestBuyPractices.Factory.Categories;
using System.Collections.Generic;
using BestBuyPractices.Factory;
using Lamar;
using Microsoft.Extensions.DependencyInjection;
using BestBuyPractices.Factory.Products;
using BestBuyPractices.Models;
using BestBuyPractices.Factory.Reviews;

namespace BestBuyPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = GetConnection("appsettings.json", "DefaultConnection");

            var container = new Container(c =>
            {
                c.AddSingleton<IDbConnection>(x => 
                {
                    return new MySqlConnection(connection.ConnectionString);
                });
                c.AddTransient<ICategoryRepo, CategoryRepo>();
                c.AddTransient<IProductRepo, ProductRepo>();
                c.AddTransient<IReviewRepo, ReviewRepo>();
            });

            var categoryRepo = container.GetService<ICategoryRepo>();
            var prodRepo = container.GetService<IProductRepo>();
            var reviewRepo = container.GetService<IReviewRepo>();

            foreach (var item in reviewRepo.GetReviews())
            {
                Console.WriteLine($"Product Name: {item.Name}");
                Console.WriteLine($"Reviewer: {item.Reviewer}");
                Console.WriteLine($"Rating: {item.Rating}");
                Console.WriteLine($"Comment: {item.Comment}");
                Console.WriteLine();
            }

            //PrintBasicInfo(prodRepo.GetAllProducts(), "Products");
        }
        public static void PrintBasicInfo(IEnumerable<ICallable> list, string header)
        {
            Console.WriteLine($"{header}");
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine($"ID: {item.ID}");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine();
            }
        }
        public static IDbConnection GetConnection(string appJSONConfig, string connectionName)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(appJSONConfig)
                .Build();
            string connectionString = config.GetConnectionString(connectionName);
            IDbConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
