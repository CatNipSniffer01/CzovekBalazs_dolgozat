﻿using Database.Models;
using Database.Data;

namespace Database
{
    public class Program
    {
        static void Kiir(IEnumerable<object> szemelyek)
        {
            foreach (var item in szemelyek)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            AbContext db = new AbContext();

            if (!db.People.Any())
            {
                var sorok = File.ReadAllLines(@"C:\Users\CatNipSniffer\Desktop\2024-05-30\Doga\6.csv").Skip(1);
                foreach (var line in sorok)
                {
                    db.People.Add(new People(line));
                }
                db.SaveChanges();
            }
            Kiir(db.People);
        }
    }
}