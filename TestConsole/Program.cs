﻿using AlugaJogos.Persistence;
using Microsoft.EntityFrameworkCore;
using System;

namespace TestConsole
{
    public class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var context = new ProductContext();

            context.LogSQLToConsole();

            var products = await context.Products.ToListAsync();
            
            Console.WriteLine("Hello World!");
        }
    }
}
