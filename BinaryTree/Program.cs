﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{


    internal class Program
    {       
            
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.InsertRand();
            tree.Print();
            tree.Sort();

            


            Console.ReadKey();
        }

        
    }
}
