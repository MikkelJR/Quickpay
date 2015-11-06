using System;
using QuickPayApi.ApiCalls.Merchant;

namespace TestApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var qp = new Activity
            {
                PageSize = 30,
                Page = 2
            };

            Console.Out.WriteLine(qp.Execute());
        }
    }
}