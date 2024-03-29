﻿using System;

namespace lab5
{
    public class AmountException: Exception
    {
        private string _personName;
        private string _message;

        public AmountException()
        {
        }

        public AmountException(string message, string personName)
        {
            this._message = message;
            this._personName = personName;
            PrintError();
        }

        private void PrintError()
        {
            Console.WriteLine($"Amount exception with person {_personName}, {_message}");
        }
    }
}