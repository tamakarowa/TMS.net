﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {   
            for (var a = 1; a < 10; a++)
            {
                Guid id = Guid.NewGuid();
                Console.WriteLine(id);
            }

            Console.ReadLine();
        }
    }
}
