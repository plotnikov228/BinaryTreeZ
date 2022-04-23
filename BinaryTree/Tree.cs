using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Tree
    {
        int a;
        List<int> numbers = new List<int>();
        List<int> numbersF = new List<int>();


        public struct LeftEl
        {
            public int Value;
        }

        public struct RightEl
        {
            public int Value;
            
        }


        public struct Element
        {
            public int Value;
            public LeftEl Left;
            public RightEl Right;
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
            numbersF = numbers.GetRange(0, numbers.Count);

            Element Parent;
            Element Left;
            Element Right;

            Parent.Value = numbers[0];

            Right.Value = 899328798;
            Left.Value = 899328798;
            Parent.Right.Value = 899328798;
            Parent.Left.Value = 899328798;
            Right.Right.Value = 899328798;
            Right.Left.Value = 899328798;
            Left.Right.Value = 899328798;
            Left.Left.Value = 899328798;



            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbersF.Count == 0) break;

                if (i == 0)
                {
                    Parent.Value = numbersF[0];
                    Console.WriteLine("Parent = " + Parent.Value);
                    bool RightB = false;
                    bool LeftB = false;


                    for (int j = 0; j <= numbersF.Count - 1; j++)
                    {

                        

                        if (numbersF[j] == Parent.Value)
                        {
                            numbersF.RemoveAt(j);
                        }

                        if (numbersF.Count == 0) break;

                        if (numbersF[j] > Parent.Value)
                        {
                            Right.Value = numbersF[j];
                            numbersF.RemoveAt(j);
                            RightB = true;
                        }                      

                        if (numbersF.Count == 0) break;

                        if (numbersF[j] < Parent.Value)
                        {
                            Left.Value = numbersF[j];
                            numbersF.RemoveAt(j);
                            LeftB = true;
                        } 
                        
                        if (numbersF.Count == 0) break;
                        
                        if (RightB == false)
                        {
                            for (int k = j; k <= numbersF.Count; k++)
                            {
                                if (k == numbersF.Count) break;

                                if (numbersF[k] > Parent.Value)
                                {
                                    Right.Value = numbersF[k];
                                    numbersF.RemoveAt(k);
                                    RightB = true;
                                    break;

                                }

                                if (numbersF[k] < Parent.Value)
                                {

                                }


                            }

                        }
                       
                        if (LeftB == false)
                        {
                            for (int k = j; k <= numbersF.Count; k++)
                            {
                                if (k == numbersF.Count) break;

                                if (numbersF[k] > Parent.Value)
                                {

                                }

                                if (numbersF[k] < Parent.Value)
                                {
                                    Left.Value = numbersF[k];
                                    numbersF.RemoveAt(k);
                                    LeftB = true;
                                    break;
                                }
                            }


                        }

                        if (RightB == true)
                            if (LeftB ==true) break;

                        
                        
                    }

                    if(Right.Value != 899328798)
                    {
                        Console.WriteLine("Right = " + Right.Value);
                    }

                    if(Left.Value != 899328798)
                    {
                        Console.WriteLine("Left = " + Left.Value);
                    }

                    Parent.Right.Value = Right.Value;
                    Parent.Left.Value = Left.Value;
                }

                if (i == 1)
                {

                    Parent.Value = Parent.Right.Value;
                    Console.WriteLine("Parent = " + Parent.Value);
                    bool RightA = false;
                    bool RightB = false;
                    for (int j = 0; j <= numbersF.Count - 1; j++)
                    {

                        if (numbersF[j] == Parent.Value)
                        {
                            numbersF.RemoveAt(j);
                        }

                        if (numbersF[j] > Parent.Value)
                        {
                            for (int k = j; k < numbersF.Count; k++)
                            {
                                if (k == numbersF.Count) break;

                                if (numbersF[k] > Parent.Value)
                                {
                                    Right.Right.Value = numbersF[k];
                                    numbersF.RemoveAt(k);
                                    RightA = true;
                                    break;

                                }

                                if (numbersF[k] < Parent.Value)
                                {

                                }
                            }

                        }



                        if (numbersF[j] < Parent.Value)
                        {
                                for (int k = j; k < numbersF.Count; k++)
                                {
                                    if (k == numbersF.Count) break;

                                    if (numbersF[k] > Parent.Value)
                                    {

                                    }
                                    

                                    if (numbersF[k] < Parent.Value)
                                    {
                                        Right.Left.Value = numbersF[k];
                                        numbersF.RemoveAt(k);
                                        RightB = true;
                                        break;
                                    }
                                }
                            }

                       if (RightA == true)
                            if (RightB == true) break;

                    }


                    if (Right.Right.Value != 899328798)
                    {
                        Console.WriteLine("Right = " + Right.Right.Value);
                    }
                    if (Right.Left.Value != 899328798)
                    {
                        Console.WriteLine("Left = " + Right.Left.Value);
                    }




                    Parent.Value = Parent.Left.Value;
                    Console.WriteLine("Parent = " + Parent.Left.Value);
                    RightA = false;
                    RightB = false;
                    for (int j = 0; j <= numbersF.Count - 1; j++)
                    {


                        if (numbersF[j] == Parent.Value)
                        {
                            numbersF.RemoveAt(j);
                        }

                        if (numbersF[j] > Parent.Value)
                        {

                            if (numbersF[j] < Right.Left.Value)
                            {

                                Left.Right.Value = numbersF[j];
                                numbersF.RemoveAt(j);
                                RightA = true;

                            }

                            else
                            {
                                RightA = false;
                            }

                        }



                        if (numbersF.Count == 0) break;

                        if (numbersF[j] < Parent.Value)
                        {
                            if (numbersF[j] < Right.Left.Value)
                            {
                                Left.Left.Value = numbersF[j];
                                numbersF.RemoveAt(j);
                                RightB = true;
                            }


                            if (numbersF.Count == 0) break;


                        }



                        

                        if (RightA == true)
                            if (RightB == true) break;
                    }
                    
                    if (Left.Right.Value != 899328798)
                        {
                            Console.WriteLine("Right = " + Left.Right.Value);
                        }
                    if (Left.Left.Value != 899328798)
                        {
                            Console.WriteLine("Left = " + Left.Left.Value);
                        }

                }

                else
                {
                    int RightLeft = Right.Left.Value;
                    int LeftLeft = Left.Left.Value;
                    if (Right.Right.Value != 899328798)
                    {

                        Parent.Right.Value = Right.Right.Value;
                        Parent.Value = Parent.Right.Value;
                        Console.WriteLine("Parent = " + Parent.Right.Value);
                        bool RightA = false;
                        bool RightB = false;
                        for (int j = 0; j <= numbersF.Count - 1; j++)
                        {



                            if (numbersF[j] == Parent.Value)
                            {
                                numbersF.RemoveAt(j);
                            }

                            if (numbersF[j] > Parent.Value)
                            {
                                Right.Right.Value = numbersF[j];
                                numbersF.RemoveAt(j);
                                RightA = true;
                            }

                            if (RightA == false)
                            {
                                for (int k = j; k <= numbersF.Count; k++)
                                {
                                    if (k == numbersF.Count) break;

                                    if (numbersF[k] > Parent.Value)
                                    {
                                        Right.Right.Value = numbersF[k];
                                        numbersF.RemoveAt(k);
                                        RightA = true;
                                        break;

                                    }

                                    if (numbersF[k] < Parent.Value)
                                    {

                                    }


                                }

                            }

                            if (numbersF.Count == 0) break;

                            if (numbersF[j] < Parent.Value)
                            {
                                Right.Left.Value = numbersF[j];
                                numbersF.RemoveAt(j);
                                RightB = true;
                            }

                            if (RightB == false)
                            {
                                for (int k = j; k <= numbersF.Count; k++)
                                {
                                    if (k == numbersF.Count) break;

                                    if (numbersF[k] > Parent.Value)
                                    {

                                    }

                                    if (numbersF[k] < Parent.Value)
                                    {
                                        Right.Left.Value = numbersF[k];
                                        numbersF.RemoveAt(k);
                                        RightB = true;
                                        break;
                                    }
                                }


                            }

                            if (numbersF.Count == 0) break;


                        }


                        if (RightA == true)
                        {
                            Console.WriteLine("Right = " + Right.Right.Value);
                        }
                        if (RightB == true)
                        {
                            Console.WriteLine("Left = " + Right.Left.Value);
                        }

                        if (RightA == true)
                            if (RightB == true) break;

                        if (a == 1)
                        {/*Parent.Value = Parent.Right.Value;
                        Console.WriteLine("Parent = " + Parent.Value);
                        RightA = false;
                        RightB = false;

                        for (int j = 0; j <= numbersF.Count - 1; j++)
                        {



                            if (numbersF[j] == Parent.Value)
                            {
                                numbersF.RemoveAt(j);
                            }

                            if (numbersF[j] > Parent.Value)
                            {
                                Right.Right.Value = numbersF[j];
                                numbersF.RemoveAt(j);
                                RightA = true;
                            }

                            if (RightA == false)
                            {
                                for (int k = j; k <= numbersF.Count; k++)
                                {
                                    if (k == numbersF.Count) break;

                                    if (numbersF[k] > Parent.Value)
                                    {
                                        Right.Right.Value = numbersF[k];
                                        numbersF.RemoveAt(k);
                                        RightA = true;
                                        break;

                                    }

                                    if (numbersF[k] < Parent.Value)
                                    {

                                    }


                                }

                            }

                            if (numbersF.Count == 0) break;

                            if (numbersF[j] < Parent.Value)
                            {
                                Right.Left.Value = numbersF[j];
                                numbersF.RemoveAt(j);
                                RightB = true;
                            }

                            if (RightB == false)
                            {
                                for (int k = j; k <= numbersF.Count; k++)
                                {
                                    if (k == numbersF.Count) break;

                                    if (numbersF[k] > Parent.Value)
                                    {

                                    }

                                    if (numbersF[k] < Parent.Value)
                                    {
                                        Right.Left.Value = numbersF[k];
                                        numbersF.RemoveAt(k);
                                        RightB = true;
                                        break;
                                    }
                                }


                            }

                            if (numbersF.Count == 0) break;
                        }

                        if (RightA == true)
                        {
                            Console.WriteLine("Right = " + Right.Right.Value);
                        }
                        if (RightB == true)
                        {
                            Console.WriteLine("Left = " + Right.Left.Value);
                        }
*/
                        }

                    }
                    if (RightLeft != 899328798)
                    {

                        Parent.Right.Value = RightLeft;
                        Parent.Value = Parent.Right.Value;
                        Console.WriteLine("Parent = " + Parent.Right.Value);
                        bool RightA = false;
                        bool RightB = false;
                        for (int j = 0; j <= numbersF.Count - 1; j++)
                        {



                            if (numbersF[j] == Parent.Value)
                            {
                                numbersF.RemoveAt(j);
                            }

                            if (numbersF[j] > Parent.Value)
                            {

                                Right.Right.Value = numbersF[j];
                                numbersF.RemoveAt(j);
                                RightA = true;
                            }

                            if (RightA == false)
                            {
                                for (int k = j; k <= numbersF.Count; k++)
                                {
                                    if (k == numbersF.Count) break;

                                    if (numbersF[k] > Parent.Value)
                                    {
                                        Right.Right.Value = numbersF[k];
                                        numbersF.RemoveAt(k);
                                        RightA = true;
                                        break;

                                    }

                                    else;


                                }

                            }

                            if (numbersF.Count == 0) break;

                            if (numbersF[j] < Parent.Value)
                            {
                                Right.Left.Value = numbersF[j];
                                numbersF.RemoveAt(j);
                                RightB = true;
                            }

                            if (RightB == false)
                            {
                                for (int k = j; k <= numbersF.Count; k++)
                                {
                                    if (k == numbersF.Count) break;

                                    if (numbersF[k] > Parent.Value)
                                    {

                                    }

                                    if (numbersF[k] < Parent.Value)
                                    {
                                        Right.Left.Value = numbersF[k];
                                        numbersF.RemoveAt(k);
                                        RightB = true;
                                        break;
                                    }
                                }


                            }

                            if (numbersF.Count == 0) break;


                        }


                        if (RightA == true)
                        {
                            Console.WriteLine("Right = " + Right.Right.Value);
                        }
                        if (RightB == true)
                        {
                            Console.WriteLine("Left = " + Right.Left.Value);
                        }

                        if (RightA == true)
                            if (RightB == true) break;

                    }
                    if (Left.Right.Value != 899328798)
                    {

                        Parent.Left.Value = Left.Right.Value;
                        Parent.Value = Parent.Left.Value;
                        Console.WriteLine("Parent = " + Parent.Left.Value);
                        bool RightA = false;
                        bool RightB = false;
                        for (int j = 0; j <= numbersF.Count - 1; j++)
                        {


                            if (numbersF[j] == Parent.Value)
                            {
                                numbersF.RemoveAt(j);
                            }

                            if (numbersF[j] > Parent.Value)
                            {
                                for (int k = j; k <= numbersF.Count; k++)
                                {
                                    if (k == numbersF.Count) break;
                                    if (numbersF[j] < Right.Left.Value)
                                    {
                                        Left.Right.Value = numbersF[k];
                                        numbersF.RemoveAt(k);
                                        RightA = true;

                                    }

                                    else;

                                }

                            }



                            if (numbersF.Count == 0) break;

                            if (numbersF[j] < Parent.Value)
                            {
                                for (int k = j; k <= numbersF.Count; k++)
                                {
                                    if (k == numbersF.Count) break;
                                    if (numbersF[j] < Right.Left.Value)
                                    {
                                        Left.Left.Value = numbersF[k];
                                        numbersF.RemoveAt(k);
                                        RightA = true;

                                    }

                                    else;

                                }
                            }

                            if (numbersF.Count == 0) break;


                        }



                        if (RightA == true)
                        {
                            Console.WriteLine("Right = " + Left.Right.Value);
                        }
                        if (RightB == true)
                        {
                            Console.WriteLine("Left = " + Left.Left.Value);
                        }

                        if (RightA == true)
                            if (RightB == true) break;
                    }
                    if (LeftLeft != 899328798)
                    {

                        Parent.Left.Value = LeftLeft;
                        Parent.Value = Parent.Left.Value;
                        Console.WriteLine("Parent = " + Parent.Left.Value);
                        bool RightA = false;
                        bool RightB = false;
                        for (int j = 0; j <= numbersF.Count - 1; j++)
                        {


                            if (numbersF[j] == Parent.Value)
                            {
                                numbersF.RemoveAt(j);
                            }

                            if (numbersF[j] > Parent.Value)
                            {
                                for (int k = j; k <= numbersF.Count; k++)
                                {
                                    if (k == numbersF.Count) break;
                                    if (numbersF[j] < Right.Left.Value)
                                    {
                                        Left.Right.Value = numbersF[k];
                                        numbersF.RemoveAt(k);
                                        RightA = true;

                                    }

                                    else;

                                }

                            }



                            if (numbersF.Count == 0) break;

                            if (numbersF[j] < Parent.Value)
                            {
                                for (int k = j; k <= numbersF.Count; k++)
                                {
                                    if (k == numbersF.Count) break;
                                    if (numbersF[j] < Right.Left.Value)
                                    {
                                        Left.Left.Value = numbersF[k];
                                        numbersF.RemoveAt(k);
                                        RightA = true;

                                    }

                                    else;

                                }
                            }

                            

                            if (numbersF.Count == 0) break;


                        }



                        if (RightA == true)
                        {
                            Console.WriteLine("Right = " + Left.Right.Value);
                        }
                        if (RightB == true)
                        {
                            Console.WriteLine("Left = " + Left.Left.Value);
                        }

                        if (RightA == true)
                            if (RightB == true) break;
                    }
                }

            }
        }


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

