using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Tree // создать ещё один список, для 4 строки, сделать высоту дерева
    {
        int ICenter;
        int IRight;
        int ILeft;
        List<int> numbers = new List<int>();
        List<int> OrigNumbers = new List<int>();
        List<int> numbersF = new List<int>();
        List<int> ForSort = new List<int>();
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

            for (int i = 0; i <= l; i++)
            {
                Console.WriteLine("Введите число: ");
                string num = Console.ReadLine();
                int num2 = int.Parse(num);
                numbers.Insert(i, num2);
                numbers.RemoveAt(i+1);
            }

            numbers.RemoveAt(numbers.Count - 1);

        }
        public void CRL()
        {
            int IndexCenter = numbers.Count / 2;
            ICenter = IndexCenter;

            int IndexLeft = IndexCenter / 2;
            ILeft = IndexLeft;

            int IndexRight = IndexCenter + IndexLeft;
            IRight = IndexRight;

            Console.WriteLine(" ");
        }
        public void InsertRand()
        {
            Console.WriteLine("Вывод 16 рандомных элементов, без повторений: ");
            Console.WriteLine(" ");

            Random rnd = new Random();

            int l = 16;
            for (int i = 0; i <= l; i++) OrigNumbers.Add(1);

            for (int i = 0; i <= l - 1; i++)
            {

                OrigNumbers.Insert(i, rnd.Next(1, 25));
                OrigNumbers.RemoveAt(i+1);
            }

            OrigNumbers.RemoveAt(OrigNumbers.Count - 1);
            OrigNumbers.Sort();
            numbers = OrigNumbers.Distinct().ToList();
        }
        public void Remove()
        {
            bool Complete = false;
            Console.WriteLine("Введите элемент который хотите удалить: ");
            string s = Console.ReadLine();
            int l = int.Parse(s);
            Console.WriteLine(" ");

            for (int i = 0; i <= numbers.Count; i++)
            {
                if (i == numbers.Count) break;
                if (numbers[i] == l)
                {
                    numbers.RemoveAt(i);
                    Complete = true;
                    break;
                }
            }

            if (Complete == true)
            {
                Console.WriteLine($"Элемент {l} был удалён");
                Console.WriteLine(" ");
                Print();
                Console.WriteLine(" ");
                Sort();
            }
            if (Complete == false) Console.WriteLine($"Элемент {l} не был найден");
        }
        public void Find()
        {
            bool Complete = false;
            Console.WriteLine("Введите элемент который хотите найти: ");
            string s = Console.ReadLine();
            int l = int.Parse(s);
            Console.WriteLine(" ");

            for (int i = 0; i <= numbers.Count; i++)
            {
                if (i == numbers.Count) break;
                if (numbers[i] == l)
                {

                    Complete = true;
                    break;
                }
            }

            if (Complete == true) Console.WriteLine($"Элемент {l} был найден");

            if (Complete == false) Console.WriteLine($"Элемент {l} не был найден");
        }
        public void Sort()
        {
            CRL();
            numbersF = numbers.GetRange(0, numbers.Count);
            int TreeHigh = 0;
            int TreeHighElement = 8;
            Element Parent;
            Element Left;
            Element Right;

            Parent.Value = numbers[0];

            int Center = 0;

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
                    TreeHigh++;
                    Parent.Value = numbersF[ICenter - 1];
                    Center = Parent.Value;
                    Right.Value = numbersF[IRight - 1];
                    Left.Value = numbersF[ILeft - 1];
                    if (numbersF.Count == 0) break;
                    Console.WriteLine("Parent = " + Parent.Value);
                    Console.WriteLine("Right = " + Right.Value);
                    Console.WriteLine("Left = " + Left.Value);
                    numbersF.RemoveAt(IRight - 1);
                    if (numbersF.Count == 0) break;
                    numbersF.RemoveAt(ICenter - 1);
                    if (numbersF.Count == 0) break;
                    numbersF.RemoveAt(ILeft - 1);
                    if (numbersF.Count == 0) break;


                    Console.WriteLine("");
                }

                if (i == 1)
                {
                    TreeHigh++;
                    if (Right.Value != 899328798)
                    {
                        int RightChek = Parent.Value;
                        Parent.Value = Right.Value;
                        Console.WriteLine("Parent = " + Parent.Value);
                        bool RightA = false;
                        bool RightB = false;
                        for (int j = 0; j <= numbersF.Count; j++)
                        {
                            if (j >= (numbersF.Count / 2) - 1)
                            {
                                if (j == numbersF.Count) break;

                                if (numbersF.Count == 0) break;
                                if (RightA == false)
                                {
                                    if (numbersF[j] > Parent.Value)
                                    {
                                        Right.Right.Value = numbersF[j];
                                        numbersF.RemoveAt(j);
                                        RightA = true;
                                    }

                                }


                                if (numbersF.Count == 0) break;

                                if (j == numbersF.Count) break;

                                if (RightB == false)
                                {
                                    if (numbersF[j] < Parent.Value)
                                    {
                                        if (numbersF[j] > RightChek)
                                        {
                                            Right.Left.Value = numbersF[j];
                                            numbersF.RemoveAt(j);
                                            RightB = true;

                                        }


                                    }
                                }

                                if (numbersF.Count == 0) break;
                                if (RightA == true)
                                {
                                    if (RightB == true) break;
                                }



                            }


                        }


                        if (RightA == true)
                        {
                            Console.WriteLine("Right = " + Right.Right.Value);
                        }
                        if (RightB == true)
                        {
                            Console.WriteLine("Left = " + Right.Left.Value);
                        }
                        Console.WriteLine("");
                    }
                    if (Left.Value != 899328798)
                    {
                        Parent.Value = Left.Value;
                        Console.WriteLine("Parent = " + Parent.Value);
                        bool RightA = false;
                        bool RightB = false;
                        for (int j = 0; j <= numbersF.Count; j++)
                        {
                            if (j < (numbersF.Count / 2))
                            {
                                if (j == numbersF.Count) break;

                                if (numbersF.Count == 0) break;

                                if (numbersF[j] == Parent.Value)
                                {
                                    j = j++;
                                }

                                if (j == numbersF.Count) break;

                                if (numbersF[j] > Parent.Value)
                                {

                                    if (numbersF[j] < Right.Left.Value)
                                    {

                                        Left.Right.Value = numbersF[j];
                                        numbersF.RemoveAt(j);
                                        RightA = true;

                                    }

                                }

                                if (numbersF.Count == 0) break;

                                if (j == numbersF.Count) break;

                                if (numbersF[j] < Parent.Value)
                                {
                                    if (numbersF[j] < Left.Right.Value)
                                    {
                                        Left.Left.Value = numbersF[j];
                                        numbersF.RemoveAt(j);
                                        RightB = true;
                                    }


                                    if (numbersF.Count == 0) break;


                                }
                            }

                            if (RightA == true)
                                if (RightB == true) break;
                        }

                        if (RightA == true)
                        {
                            Console.WriteLine("Right = " + Left.Right.Value);
                        }
                        if (RightB == true)
                        {
                            Console.WriteLine("Left = " + Left.Left.Value);
                        }
                    }
                    Console.WriteLine("");
                }

                if (i == 2)
                {
                    TreeHigh++;
                    for (int p = 0; p <= TreeHighElement; p++) ForSort.Add(0);
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
                            if (numbersF.Count == 0) break;
                            if (numbersF[j] >= Center)
                            {

                                if (numbersF.Count == 0) break;

                                if (numbersF[j] > Parent.Value)
                                {
                                    Right.Right.Value = numbersF[j];
                                    numbersF.RemoveAt(j);
                                    RightA = true;

                                }


                                if (numbersF.Count == 0) break;

                                if (j == numbersF.Count) break;

                                if (numbersF[j] < Parent.Value)
                                    if (numbersF[j] > Right.Value)
                                    {
                                        Right.Left.Value = numbersF[j];
                                        numbersF.RemoveAt(j);
                                        RightB = true;
                                    }

                                if (numbersF.Count == 0) break;

                            }

                            if (RightA == true)
                                if (RightB == true) break;


                        }


                        if (RightA == true)
                        {
                            Console.WriteLine("Right = " + Right.Right.Value);
                            ForSort[7] = Right.Right.Value;
                        }
                        if (RightB == true)
                        {
                            Console.WriteLine("Left = " + Right.Left.Value);
                            ForSort[6] = Right.Left.Value;
                        }
                        Console.WriteLine("");

                    }
                    if (RightLeft != 899328798)
                    {
                        Parent.Right.Value = RightLeft;
                        Parent.Value = Parent.Right.Value;
                        Console.WriteLine("Parent = " + Parent.Value);
                        bool RightA = false;
                        bool RightB = false;
                        for (int j = 0; j <= numbersF.Count - 1; j++)
                        {
                            if (numbersF.Count == 0) break;
                            if (numbersF[j] >= Center)
                            {
                                if (j == numbersF.Count) break;

                                if (numbersF.Count == 0) break;

                                if (numbersF[j] < Right.Value)
                                    if (numbersF[j] > Parent.Value)
                                    {
                                        Right.Right.Value = numbersF[j];
                                        numbersF.RemoveAt(j);
                                        RightA = true;
                                    }

                                if (numbersF.Count == 0) break;
                                if (j == numbersF.Count) break;



                                if (numbersF[j] < Parent.Value)
                                    if (numbersF[j] > Center)
                                    {
                                        Right.Left.Value = numbersF[j];
                                        numbersF.RemoveAt(j);
                                        RightB = true;
                                    }
                            }

                            if (RightA == true)
                                if (RightB == true) break;


                        }


                        if (RightA == true)
                        {
                            Console.WriteLine("Right = " + Right.Right.Value);
                            ForSort[5] = Right.Right.Value;
                        }
                        if (RightB == true)
                        {
                            Console.WriteLine("Left = " + Right.Left.Value);
                            ForSort[4] = Right.Left.Value;

                        }
                        Console.WriteLine("");

                    }
                    if (Left.Right.Value != 899328798)
                    {
                        int End = Right.Left.Value;
                        Parent.Left.Value = Left.Right.Value;
                        Parent.Value = Parent.Left.Value;
                        Console.WriteLine("Parent = " + Parent.Left.Value);
                        bool RightA = false;
                        bool RightB = false;
                        for (int j = 0; j <= numbersF.Count - 1; j++)
                        {
                            if (numbersF.Count == 0) break;
                            if (numbersF[j] < End)
                            {
                                if (j == numbersF.Count) break;

                                if (numbersF.Count == 0) break;
                                //
                                if (numbersF[j] > Parent.Value)
                                {
                                    Left.Right.Value = numbersF[j];
                                    numbersF.RemoveAt(j);
                                    RightA = true;
                                }

                                if (numbersF.Count == 0) break;

                                //
                                if (numbersF[j] < Parent.Value)
                                    if (numbersF[j] > Left.Value)
                                    {
                                        Left.Left.Value = numbersF[j];
                                        RightB = true;
                                        numbersF.RemoveAt(j);
                                    }



                                if (numbersF.Count == 0) break;


                            }

                            if (RightA == true)
                                if (RightB == true) break;


                        }
                        if (RightA == true)
                        {
                            Console.WriteLine("Right = " + Left.Right.Value);
                            ForSort[3] = Left.Right.Value;

                        }
                        if (RightB == true)
                        {
                            Console.WriteLine("Left = " + Left.Left.Value);
                            ForSort[2] = Left.Left.Value;

                        }
                        Console.WriteLine("");
                    }
                    if (LeftLeft != 899328798)
                    {
                        int End = Left.Left.Value;
                        Parent.Left.Value = LeftLeft;
                        Parent.Value = Parent.Left.Value;
                        Console.WriteLine("Parent = " + Parent.Left.Value);
                        bool RightA = false;
                        bool RightB = false;
                        for (int j = 0; j <= numbersF.Count - 1; j++)
                        {
                            if (numbersF.Count == 0) break;
                            if (numbersF[j] < End)
                            {
  

                                if (numbersF.Count == 0) break;


                                if (numbersF[j] > Parent.Value)
                                {
                                    Left.Right.Value = numbersF[j];
                                    numbersF.RemoveAt(j);
                                    RightA = true;

                                }

                                if (numbersF.Count == 0) break;


                                if (numbersF[j] < Parent.Value)
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



                        if (RightA == true)
                        {
                            Console.WriteLine("Right = " + Left.Right.Value);
                            ForSort[1] = Left.Right.Value;
                        }
                        if (RightB == true)
                        {
                            Console.WriteLine("Left = " + Left.Left.Value);
                            ForSort[0] = Left.Left.Value;
                        }



                        Console.WriteLine("");
                    }
                }

                if (numbersF.Count == 0) break;

                if (TreeHigh >= 3)
                {
                    if(TreeHighElement != 8) for (int p = 0; p <= TreeHighElement; p++) ForSort.Add(0);
                    
                    bool RightTrue = false;
                    bool LeftTrue = false;
                    for (int j = TreeHighElement - 1; j >= 0; j--)
                    {

                        if (numbersF.Count == 0) break;
                        Parent.Value = ForSort[j];
                        Console.WriteLine("Parent = " + Parent.Value);
                        int last = ForSort[j - 1];
                        for (int k = 0; k <= numbersF.Count - 1; k++)
                        {
                            if (Parent.Value == 0) break;

                            if (numbersF[k] > Parent.Value)
                            {
                                Console.WriteLine("Right = " + numbersF[k]);
                                numbersF.RemoveAt(k);
                                RightTrue = true;
                            }

                            if (numbersF.Count == 0) break;
                            if (k == numbersF.Count) break;

                            if (j == 0) last = 0;

                                if (numbersF[k] < Parent.Value)
                                if(numbersF[k] > last)
                                {
                                Console.WriteLine("Left = " + numbersF[k]);
                                numbersF.RemoveAt(k);
                                LeftTrue = true;
                                }

                            if (k == numbersF.Count) break;
                            if (numbersF.Count == 0) break;

                            if (RightTrue == true)
                                if (LeftTrue == true) break;
                        }

                        Console.WriteLine(" ");

                    }

                    TreeHighElement = TreeHighElement + TreeHighElement;
                    TreeHigh++;
                }
            }
        }
        public void Print()
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

