using AlugaJogos.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new ProductContext();

            context.LogSQLToConsole();

            
            Console.WriteLine("Hello World!");
        }
    }
}
