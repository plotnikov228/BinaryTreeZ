using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Tree
    {
        int Parent;
        int Left;
        int Right;

        List<int> numbers = new List<int>();
        List<int> sort = new List<int>();
        List<int> right = new List<int>();

        public Tree()
        {
            int left = 0;
            int right = 0;
            int value = 0;
            Parent = value;
            Left = left;
            Right = right;

        }

        public void Insert()
        {
            Console.WriteLine("Введите размер дерева: ");
            string s = Console.ReadLine();
            int l = int.Parse(s);
            for (int i = 0; i <= l; i++) numbers.Add(1);

            for (int i = 0; i <= l - 1; i++)
            {
                Console.WriteLine("Введите число: ");
                string num = Console.ReadLine();
                int num2 = int.Parse(num);
                numbers.Insert(i, num2);
                numbers.RemoveAt(i+1);
            }

            numbers.RemoveAt(numbers.Count - 1);

        }


        public void Sort()
        {
            numbers.AddRange(sort.ToArray());

            int len = 1;
            while (len <= numbers.Count) len = len + len;

            for (int i = 0; i == len; i++)
            {
                numbers.[i]
            }

        }

        /*public void Sort()
        {
            int True = 0;
            *//*int len = 1;
            while (len <= numbers.Count) len = len + len;*//*

            for (int i = 0; i <= numbers.Count; i++)
            {
                int index = i;
                numbers[i] = Parent;

                Console.WriteLine("Parent = ", Parent);

                if (numbers[i + 1] > Parent){
                    numbers[i + 1] = Right;
                    Console.WriteLine("Right = ", Right);
                    True = 1;
                }

                if (numbers[i + 1] < Parent)
                {
                    numbers[i + 1] = Left;
                    Console.WriteLine("Left = ", Left);
                    True = 0;
                }

                for ( int j = 0; j < numbers.Count; j++)
                {
                    if (True == 1)
                    {
                        i++;
                    }
                    if (True == 1)
                    {
                        i = index;
                    }

                }



            }
        }*/

        /*  public void Sort()
          {

              numbers.AddRange(sort.ToArray());

              int True = 1;


              for (int i = 0; i <= numbers.Count - 1; i++)
              {

                  int index = i;
                  int indexI = i;

                  indexI = indexI + 1;
                  numbers[i] = Parent;
                  Console.WriteLine("Parent = ", Left);



                  if (indexI == numbers.Count)
                  {
                      break;
                  }

                  if (numbers[indexI] > Parent) { 

                      numbers[indexI] = Right;
                      Console.WriteLine("Right = ", Right);                   
                      True = 1;

                  }

                  if (numbers[indexI] < Parent) { 


                      numbers[indexI] = Left;
                      Console.WriteLine("Left = ", Left);
                      True = 0;

                  }

                  if (True == 1)
                  {

                      for (int j = index; j <= numbers.Count; j++)
                      {   
                          int indexJ = j;
                          indexJ = j + 1;
                          if (j >= numbers.Count) break;

                          if (numbers[indexJ] > Parent) j++;
                          if (numbers[indexJ] < Parent)
                          {
                              numbers[indexJ] = Left;
                              break;
                          }


                      }
                  }

                  if (True == 0)
                  {
                      for (int j = index; j <= numbers.Count; j++)
                      {
                          int indexJ = j;
                          indexJ = j + 1;
                          if (j >= numbers.Count) break;

                          if (numbers[indexJ] > Parent)
                          {
                              numbers[indexJ] = Right;
                              break;
                          }
                          if (numbers[indexJ] < Parent) j++;


                      }
                  }


              }
          }
  */

        public void Print()
        {
            Console.WriteLine("Прямой обход дерева: ");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

