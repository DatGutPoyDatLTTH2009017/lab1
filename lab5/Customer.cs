﻿using System;

namespace Ex1
{
    public class Customer
    {
        public string Name { get; set; }

        public void getName()
        {
            Console.WriteLine("Enter you name.");
            Name = Console.ReadLine();
        }
    }
}
