using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourth_lesson
{
    internal class Program
    {

        static public void ch5_1()
        {
            // 利用一維陣列求10個數字的計算平均值

            Console.WriteLine("");
            Console.WriteLine("ch5_1 利用一維陣列求10個數字的計算平均值");

            // 宣告一個陣列
            double[] array1 = new double[10];

            Console.WriteLine("請輸入十個數字");

            // 迴圈賦值
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數");
                array1[i] = Convert.ToDouble(Console.ReadLine());
            }

            // 宣告 sum
            double sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum = sum + array1[i];
            }


            // 宣告 avg
            double avg = sum / 10;


            // 輸出數值
            Console.WriteLine($"這十個數的平均值是 {avg}");

        }


        static public void ch5_2()
        {
            //利用一維陣列求10個數字的最大值
            Console.WriteLine("");
            Console.WriteLine("ch5_2 利用一維陣列求10個數字的最大值");

            // 宣告一個陣列
            double[] array1 = new double[10];

            Console.WriteLine("請輸入十個數字");

            // 迴圈賦值
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數");
                array1[i] = Convert.ToDouble(Console.ReadLine());
            }

            // 宣告 sum
            double max = double.MinValue;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                }

            }

            // 輸出數值
            Console.WriteLine($"這十個數的最大值是 {max}");

        }



        static public void ch5_3()
        {
            Console.WriteLine("");
            Console.WriteLine("ch5_3 搜尋問題：輸入10個數字至A[ ]，再輸入x，判斷x是否存在於A陣列中，");
            Console.WriteLine("如果存在，輸出所在的註標(索引)值，若不存在，則告知不存在。");

            // 宣告一個陣列
            double[] array1 = new double[10];

            Console.WriteLine("請輸入十個數字");

            // 迴圈賦值
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數");
                array1[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("請輸入要詢問有沒有在陣列裡的 x 的值");
            double x = Convert.ToDouble(Console.ReadLine());

            bool check = false;

            // 宣告 sum
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == x)
                {
                    check = true;
                    Console.WriteLine($"有在陣列裡，他的 index 值是 {i}");
                }

            }

            if (!check)
            {
                Console.WriteLine("沒有在陣列裡");
            }

        }



        static public void ch5_4()
        {
            Console.WriteLine("");
            Console.WriteLine("ch5_4 兩個二維矩陣相加。以陣列模擬矩陣，求兩個2乘3的二維矩陣相加之結果，");
            Console.WriteLine("第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣，最後將C矩陣內容顯示出來。");

            int[,] arr1 = new int[2, 3];
            int[,] arr2 = new int[2, 3];
            int[,] arr3 = new int[2, 3];

            Console.WriteLine("請輸入矩陣 A 的元素 ? ");

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.WriteLine($"請輸入 [{i},{j}] ? ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("請輸入矩陣 B 的元素 ? ");

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.WriteLine($"請輸入 [{i},{j}] ? ");
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }


            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];

                }
            }


            // 印出新的
            Console.WriteLine("A+B 得到矩陣C的內容");

            // 取得陣列的行數與列數
            int rows = arr3.GetLength(0);
            int cols = arr3.GetLength(1);

            // 輸出陣列元素
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // 使用格式化字串 {0,4} 使得每個元素佔四個位置，並靠右對齊
                    Console.Write(string.Format("{0,4}", arr3[i, j]));
                }
                Console.WriteLine(); // 換行
            }

        }


        static public void ch5_5()
        {
            Console.WriteLine("");
            Console.WriteLine("ch5_5 兩個矩陣相乘。求2乘3的A矩陣乘以3乘1的B矩陣，");
            Console.WriteLine("結果存入2乘1的C矩陣，最後將C矩陣的內容顯示出來。");



            int[,] array1 = new int[2, 3];
            int[,] array2 = new int[3, 1];
            int[,] array3 = new int[2, 1];

            Console.WriteLine("請輸入矩陣 2乘3  A 的元素 ? ");

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.WriteLine($"請輸入 [{i},{j}] ? ");
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("請輸入矩陣 3乘1 B 的元素 ? ");

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.WriteLine($"請輸入 [{i},{j}] ? ");
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }




            for (int i = 0; i < array1.GetLength(0); i++)  // 0 ，1  => m
            {
                for (int j = 0; j < array2.GetLength(1); j++) // 0  => n
                {
                    for (int k = 0; k < array1.GetLength(1); k++) // 0 , 1 ,2  => p
                    {

                        array3[i, j] = array3[i, j] + array1[i, k] * array2[k, j];

                        // [0,0] =[0, 0] * [0,0] + [0,1] * [1,0] + [0, 2] * [2,0]
                        // [1,0] =[1, 0] * [0,0] + [1,1] * [1,0] + [1, 2] * [2,0]
                    }
                }
            }



            Console.WriteLine("相乘得到的 2 x 1 的矩陣 C ");

            // 取得陣列的行數與列數
            int rows = array3.GetLength(0);
            int cols = array3.GetLength(1);

            // 輸出陣列元素
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // 使用格式化字串 {0,4} 使得每個元素佔四個位置，並靠右對齊
                    Console.Write(string.Format("{0,4}", array3[i, j]));
                }
                Console.WriteLine(); // 換行
            }
            // 14 , 32

        }


        static public void Hw_5_1()
        {
            Console.WriteLine("");
            Console.WriteLine("Hw_5_1");
            Console.WriteLine("寫一程式，將 10 個數字讀入 A 陣列，然後逐一檢查此陣列，");
            Console.WriteLine("如 A[i] > 5，則令 A[i]= A[i]-5，否則 A[i]= A[i]+5。");

            // 宣告一個陣列
            double[] arrayA = new double[10];

            Console.WriteLine("請輸入十個數字");

            // 迴圈賦值
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數");
                arrayA[i] = Convert.ToDouble(Console.ReadLine());

                if (arrayA[i] > 5)
                {
                    arrayA[i] = arrayA[i] - 5;
                }
                else
                {
                    arrayA[i] = arrayA[i] + 5;
                }

            }

            // 印出此陣列

            Console.WriteLine("陣列 A 的值是");

            // 迴圈賦值
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.WriteLine(arrayA[i]);
            }


        }


        static public void Hw_5_2()
        {
            Console.WriteLine("");
            Console.WriteLine("Hw_5_2");
            Console.WriteLine("寫一程式，將 10 個數字讀入 A 陣列，");
            Console.WriteLine("對每一個數字令 A[i] = A[i] + i");

            // 宣告一個陣列
            double[] arrayA = new double[10];

            Console.WriteLine("請輸入十個數字");

            // 迴圈賦值
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數");
                arrayA[i] = Convert.ToDouble(Console.ReadLine());

                arrayA[i] = arrayA[i] + i;

            }

            // 印出此陣列

            Console.WriteLine("陣列 A 的值是");

            // 迴圈賦值
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.WriteLine(arrayA[i]);
            }


        }



        static public void Hw_5_3()
        {
            Console.WriteLine("");
            Console.WriteLine("Hw_5_3");
            Console.WriteLine("寫一程式，將 10 個數字讀入 A 陣列，並建立一個 B 陣列");
            Console.WriteLine("如 A[i] >= 0，令 B[i] = 1，否則令 B[i] = 0。");

            // 宣告一個陣列
            double[] arrayA = new double[10];
            double[] arrayB = new double[10];

            Console.WriteLine("請輸入十個數字");

            // 迴圈賦值
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數");
                arrayA[i] = Convert.ToDouble(Console.ReadLine());

                if (arrayA[i] >= 0)
                {
                    arrayB[i] = 1;
                }
                else
                {
                    arrayB[i] = 0;
                }
            }

            // 印出此陣列

            Console.WriteLine("陣列 B 的值是");

            // 迴圈賦值
            for (int i = 0; i < arrayB.Length; i++)
            {
                Console.WriteLine(arrayB[i]);
            }


        }




        static public void Hw_5_4()
        {
            Console.WriteLine("");
            Console.WriteLine("Hw_5_4");
            Console.WriteLine("寫一程式，將 15 個數字存入 3x5 的二維陣列 A 中，");
            Console.WriteLine("求每一行及每一列數字的和。");

            double[,] ArrayA = new double[3, 5];

            double sum = 0;

            Console.WriteLine("請輸入矩陣 3乘5  A 的元素 ? ");

            for (int i = 0; i < ArrayA.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayA.GetLength(1); j++)
                {
                    Console.WriteLine($"請輸入 [{i},{j}] ? ");
                    ArrayA[i, j] = Convert.ToInt32(Console.ReadLine());
                    sum = sum + ArrayA[i, j];
                }
            }

            Console.WriteLine($"每一行及每一列數字的和 = {sum}");



        }


        static public void Hw_5_5()
        {
            Console.WriteLine("");
            Console.WriteLine("Hw_5_5");
            Console.WriteLine("寫一程式，將 15 個數字存入 3x5 的二維陣列 A 中，");
            Console.WriteLine("求每一行及每一列數字的最小值。");

            double[,] ArrayA = new double[3, 5];

            double min = double.MaxValue;

            Console.WriteLine("請輸入矩陣 3乘5  A 的元素 ? ");

            for (int i = 0; i < ArrayA.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayA.GetLength(1); j++)
                {
                    Console.WriteLine($"請輸入 [{i},{j}] ? ");
                    ArrayA[i, j] = Convert.ToInt32(Console.ReadLine());

                    if (ArrayA[i, j] < min)
                    {
                        min = ArrayA[i, j];
                    }
                }
            }

            Console.WriteLine($"每一行及每一列數字的最小值 = {min}");



        }


        static public void Hw_5_6()
        {
            Console.WriteLine("");
            Console.WriteLine("Hw_5_6");
            Console.WriteLine("寫一程式，輸入兩組數字: a1,a2,...,a5 和 b1,b2,...,b5。");
            Console.WriteLine("求 ai + bi ，i=1 到 i=5");


            Console.WriteLine("請輸入 陣列 A 的五個數字 => ex: 1,2,3,4,5");

            string inputStringA = Console.ReadLine();


            double[] inputArrayA = inputStringA.Split(new char[] { ',' }).Select(double.Parse).ToArray();

            while (inputArrayA.Length != 5)
            {
                Console.WriteLine("你沒有輸入五個數字");

                inputStringA = Console.ReadLine();
                inputArrayA = inputStringA.Split(new char[] { ',' }).Select(double.Parse).ToArray();
            }


            Console.WriteLine("請輸入 陣列 B 的五個數字 => ex: 1,2,3,4,5");

            string inputStringB = Console.ReadLine();

            double[] inputArrayB = inputStringB.Split(new char[] { ',' }).Select(double.Parse).ToArray();

            while (inputArrayB.Length != 5)
            {
                Console.WriteLine("你沒有輸入五個數字");

                inputStringB = Console.ReadLine();
                inputArrayB = inputStringB.Split(new char[] { ',' }).Select(double.Parse).ToArray();
            }



            double[] inputArrayC = new double[5];

            for (int i = 0; i < inputArrayA.Length; i++)
            {
                inputArrayC[i] = inputArrayA[i] + inputArrayB[i];
                Console.WriteLine($"A{i + 1} + B{i + 1} ={inputArrayC[i]}");
            }


        }


        static public void Hw_5_7()
        {
            Console.WriteLine("");
            Console.WriteLine("Hw_5_7");
            Console.WriteLine("寫一程式，輸入兩組數字: a1,a2,...,a5 和 b1,b2,...,b5。");
            Console.WriteLine("令 x 為 a 中的最大值，令 y 為 b 中的最大值，求 x 與 y 中較小者。");



            Console.WriteLine("請輸入 陣列 A 的五個數字 => ex: 1,2,3,4,5");

            string inputStringA = Console.ReadLine();


            double[] inputArrayA = inputStringA.Split(new char[] { ',' }).Select(double.Parse).ToArray();

            while (inputArrayA.Length != 5)
            {
                Console.WriteLine("你沒有輸入五個數字");

                inputStringA = Console.ReadLine();
                inputArrayA = inputStringA.Split(new char[] { ',' }).Select(double.Parse).ToArray();
            }


            Console.WriteLine("請輸入 陣列 B 的五個數字 => ex: 1,2,3,4,5");

            string inputStringB = Console.ReadLine();

            double[] inputArrayB = inputStringB.Split(new char[] { ',' }).Select(double.Parse).ToArray();

            while (inputArrayB.Length != 5)
            {
                Console.WriteLine("你沒有輸入五個數字");

                inputStringB = Console.ReadLine();
                inputArrayB = inputStringB.Split(new char[] { ',' }).Select(double.Parse).ToArray();
            }

            double x = double.MinValue;
            double y = double.MinValue;

            for (int i = 0; i < inputArrayA.Length; i++)
            {

                if (inputArrayA[i] > x)
                {
                    x = inputArrayA[i];
                }

                if (inputArrayB[i] > y)
                {
                    y = inputArrayB[i];
                }

            }

            Console.WriteLine(x);
            Console.WriteLine(y);

            if (x > y)
            {
                Console.WriteLine($" x 與 y 中較小為，y = {y}");
            }
            else if (x == y)
            {
                Console.WriteLine($" x 與 y 相等， => x 跟 y  皆為 {y}");

            }
            else
            {
                Console.WriteLine($" x 與 y 中較小為，x = {x}");

            }
        }


        static void Main(string[] args)
        {
            // 練習
            ch5_1();
            ch5_2();
            ch5_3();
            ch5_4();
            ch5_5();

            // 習題
            Hw_5_1();
            Hw_5_2();
            Hw_5_3();
            Hw_5_4();
            Hw_5_5();
            Hw_5_6();
            Hw_5_7();

            Console.ReadKey();
        }
    }
}
