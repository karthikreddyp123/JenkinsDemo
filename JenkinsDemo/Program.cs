﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(createMessage());
        }

        public static string createMessage()
        {
            return "Jenkins";
        }
    }
}
