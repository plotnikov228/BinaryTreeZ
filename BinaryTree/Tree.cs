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
       

        public Tree()
        {
            int left = 0;
            
            int value = 1;
            Parent = value;


        }

        public void Insert()
        {
            Console.WriteLine("Введите размер дерева: ");           
            string s = Console.ReadLine();
            Console.WriteLine(" ");

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
            int True = 1;
            int index = 1;

            /*
                        int len = 1;
                        while (len <= numbers.Count) len = len + len;*/


            for (int k = 0; k <= numbers.Count - 1; k++)
            {
                Parent = numbers[k];
                Console.WriteLine($"Parent = {Parent}");


                for (int i = 0; i <= numbers.Count; i++)
                {


                    int indexx = i;
                    indexx = index + indexx;

                    


                    if (numbers[index] > Parent)
                    {
                        Right = numbers[index];
                        Console.WriteLine($"Right = {Right}");
                        numbers.RemoveAt(index);
                        True = 1;
                    }

                    if (numbers[index] < Parent)
                    {
                        Left = numbers[index];
                        Console.WriteLine($"Left = {Left}");
                        True = 0;
                        numbers.RemoveAt(index);
                    }


                    if (Left == null)
                    {
                        for (int j = index; j <= numbers.Count; j++)
                        {

                            if (numbers[j] > Parent)
                            {
                                j++;
                            }

                            if (numbers[j] < Parent)
                            {
                                Left = numbers[j];
                                Console.WriteLine($"Left = {Left}");
                                numbers.RemoveAt(index);
                                break;
                            }
                            if (numbers[j] == numbers[numbers.Count]) break;
                        }


                    }

                    if (Right == null)
                    {
                        for (int j = index; j <= numbers.Count; j++)
                        {


                            if (numbers[j] < Parent)
                            {
                                j++;
                            }

                            if (numbers[j] > Parent)
                            {
                                Right = numbers[j];
                                Console.WriteLine($"Right = {Right}");
                                numbers.RemoveAt(index);
                                break;
                            }

                            if (numbers[j] == numbers[numbers.Count -1 ]) break;
                        }
                    }

                        if (index == numbers[numbers.Count - 1]) break;
                    i = i -2;
                    Console.WriteLine(" ");
                }

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
                  int  i + 1 = i;

                   i + 1 =  i + 1 + 1;
                  numbers[i] = Parent;
                  Console.WriteLine("Parent = ", Left);



                  if ( i + 1 == numbers.Count)
                  {
                      break;
                  }

                  if (numbers[ i + 1] > Parent) { 

                      numbers[ i + 1] = Right;
                      Console.WriteLine("Right = ", Right);                   
                      True = 1;

                  }

                  if (numbers[ i + 1] < Parent) { 


                      numbers[ i + 1] = Left;
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

