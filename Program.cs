using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdLesson
{
    internal class Program
    {

        static public void introduce()
        {

            Console.WriteLine("introduce");

            // for 迴圈
            Console.WriteLine("for 迴圈");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }


            // while 迴圈
            Console.WriteLine("while 迴圈");
            int a = 0;
            while (a < 5)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.ReadKey();
        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_1()
        {

            Console.WriteLine("practice_ch3_1_for");

            // ch3-1 practice
            // 讀入五個整數，求這五個整數的和

            int sum = 0;
            int count = 5;

            Console.WriteLine("請輸入五個整數");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());
                sum += tmp;
            }

            Console.WriteLine($"這五個數的總和是{sum}");

            Console.ReadKey();

        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_1_while()
        {

            Console.WriteLine("practice_ch3_1_while");

            // ch3-1 practice while
            // 讀入五個整數，求這五個整數的和


            int sum = 0;
            int count = 5;
            int i = 0;

            Console.WriteLine("請輸入五個整數");

            while (i < count)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());
                sum += tmp;
                i++;
            }

            Console.WriteLine($"這五個數的總和是{sum}");

            Console.ReadKey();

        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_2_for()
        {

            Console.WriteLine("practice_ch3_2_for");

            // ch3-2 practice for
            // 求 N 個整數的和， N 由使用者輸入。

            Console.WriteLine("請問要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());
                sum += tmp;
            }

            Console.WriteLine($"{N} 個數的總和為 {sum}");


            Console.ReadKey();
        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_2_while()
        {

            Console.WriteLine("practice_ch3_2_while");

            // ch3-2 practice while
            // 求 N 個整數的和， N 由使用者輸入。

            Console.WriteLine("請問要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i = 0;

            while (i < N)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());
                sum += tmp;
                i++;
            }


            Console.WriteLine($"{N} 個數的總和為 {sum}");


            Console.ReadKey();
        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_3_for()
        {

            Console.WriteLine("practice_ch3_3_for");

            // ch3-3 practice for
            // 假設有N個正整數，求其中的最大值。

            // 先假設最大值 (MAX) 等於 0，然後逐一檢查讀入的每一個數字，
            // 如果比 MAX 還大，就令 MAX 等於這個數字，
            // 如果沒有比 MAX 大，就不做任何事情，
            // 最後 MAX 一定會是這一串數字中的最大值。


            Console.WriteLine("請輸入要比較的正整數的數量");
            int N = Convert.ToInt32(Console.ReadLine());

            //int max = 0;
            int max = int.MinValue; // 這樣寫才可以確保，在後續程式中會被正確更新為更大的值
            // MinValue 是求最大值 => 代表意思 => 是整數型別的最小值，其值為 -2147483648
            // MaxValue是求最小值 => 代表意思 => 整數型別的最大值，其值為 2,147,483,647


            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"請輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp > max)
                {
                    max = tmp;
                }

            }


            Console.WriteLine($"輸入的數字,最大的是 {max}");

            Console.ReadKey();

        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------


        static public void practice_ch3_3_while()
        {

            Console.WriteLine("practice_ch3_3_while");

            // ch3-3 practice while
            // 假設有N個正整數，求其中的最大值。

            // 先假設最大值 (MAX) 等於 0，然後逐一檢查讀入的每一個數字，
            // 如果比 MAX 還大，就令 MAX 等於這個數字，
            // 如果沒有比 MAX 大，就不做任何事情，
            // 最後 MAX 一定會是這一串數字中的最大值。


            Console.WriteLine("請輸入要比較的正整數的數量");
            int N = Convert.ToInt32(Console.ReadLine());

            //int max = 0;
            int max = int.MinValue; // 這樣寫才可以確保，在後續程式中會被正確更新為更大的值
            // MinValue 是求最大值 => 代表意思 => 是整數型別的最小值，其值為 -2147483648
            // MaxValue是求最小值 => 代表意思 => 整數型別的最大值，其值為 2,147,483,647


            int i = 0;

            while (i < N)
            {
                Console.WriteLine($"請輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp > max)
                {
                    max = tmp;
                }

                i++;
            }


            Console.WriteLine($"輸入的數字,最大的是 {max}");

            Console.ReadKey();

        }



        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_4_for()
        {
            Console.WriteLine("practice_ch3_4_for");

            // ch3-4 practice for
            // 假設有 N 個正整數，求最大奇數值。

            // 用 % (取餘數)運算，例如將 n 除以 2 之後若餘 0，為偶數，若餘 1 則為奇數。

            Console.WriteLine("請輸入要比較的正整數的數量");
            int N = Convert.ToInt32(Console.ReadLine());

            int max = int.MinValue; // 這樣寫才可以確保，在後續程式中會被正確更新為更大的值


            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"請輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp > max && (tmp % 2 == 1))
                {
                    max = tmp;
                }

            }

            if (max == int.MinValue)
            {
                Console.WriteLine("沒有輸入任何奇數");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"輸入的數字,最大的奇數是 {max}");

            Console.ReadKey();


        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_4_while()
        {
            Console.WriteLine("practice_ch3_4_while");

            // ch3-4 practice while
            // 假設有 N 個正整數，求最大奇數值。

            // 用 % (取餘數)運算，例如將 n 除以 2 之後若餘 0，為偶數，若餘 1 則為奇數。

            Console.WriteLine("請輸入要比較的正整數的數量");
            int N = Convert.ToInt32(Console.ReadLine());

            int max = int.MinValue; // 這樣寫才可以確保，在後續程式中會被正確更新為更大的值

            int i = 0;

            while (i < N)
            {
                Console.WriteLine($"請輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp > max && (tmp % 2 == 1))
                {
                    max = tmp;
                }
                i++;
            }


            if (max == int.MinValue)
            {
                Console.WriteLine("沒有輸入任何奇數");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"輸入的數字,最大的奇數是 {max}");

            Console.ReadKey();


        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_5_for()
        {
            Console.WriteLine("practice_ch3_5_for");

            // ch3-5 practice for
            // 求 N 階層，即求 1x2x3x4x...xN

            // 提示 => 請求輸入 N ，讓 for 迴圈自 2 依序乘到 N，
            // 所以要寫成 for(int i = 2;i < N+1; i++)

            Console.WriteLine("請輸入要求得的 N 階層");
            int N = Convert.ToInt32(Console.ReadLine());
            int value = 1;

            if (N < 0)
            {
                Console.WriteLine("請輸入正整數");
                Console.ReadKey();
                return;
            }

            for (int i = 2; i < N + 1; i++)
            {
                value = value * i;
            }

            Console.WriteLine($"{N}! = {value}");


            Console.ReadKey();

        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------


        static public void practice_ch3_5_while()
        {
            Console.WriteLine("practice_ch3_5_while");

            // ch3-5 practice while
            // 求 N 階層，即求 1x2x3x4x...xN

            // 提示 => 請求輸入 N ，讓 for 迴圈自 2 依序乘到 N，
            // 所以要寫成 for(int i = 2;i < N+1; i++)

            Console.WriteLine("請輸入要求得的 N 階層");
            int N = Convert.ToInt32(Console.ReadLine());
            int value = 1;

            if (N < 0)
            {
                Console.WriteLine("請輸入正整數");
                Console.ReadKey();
                return;
            }

            int i = 2;

            while (i < N + 1)
            {
                value = value * i;
                i++;
            }


            Console.WriteLine($"{N}! = {value}");


            Console.ReadKey();

        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_6_for()
        {
            Console.WriteLine("practice_ch3_6_for");

            // ch3-6 practice for
            // 輸出一個九九乘法表。
            // 利用兩層迴圈，又稱巢狀迴圈。
            // 迴圈的層數沒有限制，但越多效率越差。

            Console.WriteLine("開始輸出99乘法表：");


            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }

            Console.ReadKey();

        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_6_while()
        {
            Console.WriteLine("practice_ch3_6_while");

            // ch3-6 practice while
            // 輸出一個九九乘法表。
            // 利用兩層迴圈，又稱巢狀迴圈。
            // 迴圈的層數沒有限制，但越多效率越差。

            Console.WriteLine("開始輸出99乘法表：");

            int i = 1;
            while (i < 10)
            {
                int j = 1;
                while (j < 10)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                    j++;
                }
                i++;
            }

            Console.ReadKey();

        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_7_for()
        {
            Console.WriteLine("practice_ch3_7_for");

            // ch3-7 practice for
            // 輸出一個九九乘法表 => 輸出格式符合 PPT 的圖

            //“\t”稱跳脫字元，是Tab的意思。
            // 常用的還有”\n”，是換行的意思。
            // print()函數內定結尾會自動加上換行， =>  C# 是不是沒有
            // 加上end =“ “參數後就會依我們加入的文字當結尾。  =>  C# 是不是沒有



            Console.WriteLine("開始輸出99乘法表：");
            Console.WriteLine();

            for (int k = 0; k < 7; k = k + 3)
            {


                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1 + k; j < 4 + k; j++)
                    {
                        Console.Write($"{j} x {i} = {i * j}   \t");

                    }

                    Console.Write("\n");

                }


                Console.WriteLine();
            }


            Console.ReadKey();

        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch3_7_while()
        {
            Console.WriteLine("practice_ch3_7_while");

            // ch3-7 practice while
            // 輸出一個九九乘法表 => 輸出格式符合 PPT 的圖

            //“\t”稱跳脫字元，是Tab的意思。
            // 常用的還有”\n”，是換行的意思。
            // print()函數內定結尾會自動加上換行， =>  C# 是不是沒有
            // 加上end =“ “參數後就會依我們加入的文字當結尾。  =>  C# 是不是沒有



            Console.WriteLine("開始輸出99乘法表：");
            Console.WriteLine();

            int k = 0;

            while (k < 7)
            {
                int i = 1;
                while (i < 10)
                {

                    int j = 1 + k;
                    while (j < 4 + k)
                    {
                        Console.Write($"{j} x {i} = {i * j}   \t");
                        j++;
                    }
                    Console.Write("\n");
                    i++;
                }

                k = k + 3;
                Console.WriteLine();
            }

            Console.ReadKey();

        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_1_for()
        {
            // ch 3-1. 寫一程式，輸入10個整數，求其最小值。

            Console.WriteLine("Hw3_1_for");

            int min = int.MaxValue;
            int count = 10;

            Console.WriteLine("請輸入十個整數");


            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp < min)
                {
                    min = tmp;
                }
            }


            Console.WriteLine($"這十個數的最小值是{min}");

            Console.ReadKey();

        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_1_while()
        {
            // ch 3-1. 寫一程式，輸入10個整數，求其最小值。

            Console.WriteLine("Hw3_1_while");

            int min = int.MaxValue;
            int count = 10;
            int i = 0;

            Console.WriteLine("請輸入十個整數");

            while (i < count)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp < min)
                {
                    min = tmp;
                }
                i++;
            }

            Console.WriteLine($"這十個數的最小值是{min}");

            Console.ReadKey();

        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_2_for()
        {
            Console.WriteLine("Hw3_2_for");
            // ch 3-2. 寫一程式，輸入 N 個整數，求其最小值。

            Console.WriteLine("請輸入要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            int min = int.MaxValue;


            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp < min)
                {
                    min = tmp;
                }
            }


            Console.WriteLine($"這 {N} 個數的最小值是 {min}");

            Console.ReadKey();

        }





        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------


        static public void Hw3_2_while()
        {
            Console.WriteLine("Hw3_2_while");
            // ch 3-2. 寫一程式，輸入 N 個整數，求其最小值。

            Console.WriteLine("請輸入要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            int min = int.MaxValue;
            int i = 0;

            while (i < N)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp < min)
                {
                    min = tmp;
                }
                i++;
            }


            Console.WriteLine($"這 {N} 個數的最小值是 {min}");

            Console.ReadKey();

        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------


        static public void Hw3_3_for()
        {
            Console.WriteLine("Hw3_3_for");
            // ch 3-3. 寫一程式，輸入10個整數，列出其中所有大於12的數字。

            string output = "";
            int count = 10;

            Console.WriteLine("請輸入十個整數");


            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                string tmp = Console.ReadLine();

                if (Convert.ToInt32(tmp) > 12)
                {
                    if (output.Length > 0)
                    {
                        output = output + "，";
                    }
                    output = output + tmp;
                }
            }


            Console.WriteLine($"大於 12 的整數有 {output}");

            Console.ReadKey();



        }



        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_3_while()
        {
            Console.WriteLine("Hw3_3_while");
            // ch 3-3. 寫一程式，輸入10個整數，列出其中所有大於12的數字。

            string output = "";
            int count = 10;

            Console.WriteLine("請輸入十個整數");

            int i = 0;

            while (i < count)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                string tmp = Console.ReadLine();

                if (Convert.ToInt32(tmp) > 12)
                {
                    if (output.Length > 0)
                    {
                        output = output + "，";
                    }
                    output = output + tmp;
                }
                i++;
            }


            Console.WriteLine($"大於 12 的整數有 {output}");

            Console.ReadKey();



        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_4_for()
        {
            Console.WriteLine("Hw3_4_for");
            // ch 3-4. 寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。

            int count = 10;
            int sum = 0;
            string output = "";

            Console.WriteLine("請輸入十個整數");


            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                string tmp = Console.ReadLine();

                if (Convert.ToInt32(tmp) > 12)
                {

                    sum = sum + Convert.ToInt32(tmp);

                    if (output.Length > 0)
                    {
                        output = output + "，";
                    }
                    output = output + tmp;
                }
            }


            Console.WriteLine($"大於 12 的整數為 {output}");
            Console.WriteLine($"大於 12 的整數總合為 {sum}");

            Console.ReadKey();


        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_4_while()
        {
            Console.WriteLine("Hw3_4_while");
            // ch 3-4. 寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。

            int count = 10;
            int sum = 0;
            string output = "";

            Console.WriteLine("請輸入十個整數");

            int i = 0;
            while (i < count)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                string tmp = Console.ReadLine();

                if (Convert.ToInt32(tmp) > 12)
                {

                    sum = sum + Convert.ToInt32(tmp);

                    if (output.Length > 0)
                    {
                        output = output + "，";
                    }
                    output = output + tmp;
                }
                i++;
            }



            Console.WriteLine($"大於 12 的整數為 {output}");
            Console.WriteLine($"大於 12 的整數總合為 {sum}");

            Console.ReadKey();


        }



        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_5_for()
        {
            Console.WriteLine("Hw3_5_for");
            // ch 3-5. 寫一程式，輸入N個數字，求其所有奇數中的最大值。
            // 例如輸入11,12,3,24,15，答案是15。


            Console.WriteLine("請輸入要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            int max = int.MinValue;


            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp > max && (tmp % 2 != 0))
                {
                    max = tmp;
                }
            }


            if (max % 2 == 0)
            {

                Console.WriteLine($"這 {N} 個數沒有奇數，{max}");
            }
            else
            {

                Console.WriteLine($"這 {N} 個數的最大的奇數是 {max}");
            }



            Console.ReadKey();
        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_5_while()
        {
            Console.WriteLine("Hw3_5_while");
            // ch 3-5. 寫一程式，輸入N個數字，求其所有奇數中的最大值。
            // 例如輸入11,12,3,24,15，答案是15。


            Console.WriteLine("請輸入要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            int max = int.MinValue;


            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp > max && (tmp % 2 != 0))
                {
                    max = tmp;
                }
                i++;
            }


            if (max % 2 == 0)
            {

                Console.WriteLine($"這 {N} 個數沒有奇數，{max}");
            }
            else
            {

                Console.WriteLine($"這 {N} 個數的最大的奇數是 {max}");
            }



            Console.ReadKey();
        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_6_for()
        {
            Console.WriteLine("Hw3_6_for");
            // ch 3-6. 寫一程式，輸入N個數字，求其所有正數之平方的加總。 => 求正數平方和
            // 例如輸入1,-2,3,-4,5五個數字，得到
            // 1 平方 + (-2)平方 + 3平方 + (-4)平方 + 5平方 = 1 + 9 + 25 = 35


            Console.WriteLine("請輸入要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            double sum = 0.0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                double tmp = Convert.ToDouble(Console.ReadLine());

                if (tmp > 0)
                {
                    sum = sum + Math.Pow(tmp, 2);
                }


            }


            Console.WriteLine($"正整數平方和為 {sum}");

            Console.ReadKey();


        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_6_while()
        {
            Console.WriteLine("Hw3_6_while");
            // ch 3-6. 寫一程式，輸入N個數字，求其所有正數之平方的加總。 => 求正數平方和
            // 例如輸入1,-2,3,-4,5五個數字，得到
            // 1 平方 + (-2)平方 + 3平方 + (-4)平方 + 5平方 = 1 + 9 + 25 = 35

            Console.WriteLine("請輸入要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            double sum = 0.0;

            int i = 0;

            while (i < N)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                double tmp = Convert.ToDouble(Console.ReadLine());

                if (tmp > 0)
                {
                    sum = sum + Math.Pow(tmp, 2);
                }


                i++;
            }


            Console.WriteLine($"正整數平方和為 {sum}");

            Console.ReadKey();
        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_7_for()
        {
            Console.WriteLine("Hw3_7_for");
            // ch 3-7. 寫一程式，輸入 N 個數字，
            // 其中有些是負數，將這些負數轉換成正數，例如 -7 會被轉換成 7

            Console.WriteLine("請輸入要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            string output = "";


            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (output.Length != 0)
                {
                    output = output + "，";
                }

                output = output + Convert.ToString(Math.Abs(tmp));


            }

            Console.WriteLine($"使用者輸入的數字都轉成正數是 {output}");
            Console.ReadKey();

        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_7_while()
        {
            Console.WriteLine("Hw3_7_while");
            // ch 3-7. 寫一程式，輸入 N 個數字，
            // 其中有些是負數，將這些負數轉換成正數，例如 -7 會被轉換成 7

            Console.WriteLine("請輸入要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            string output = "";

            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (output.Length != 0)
                {
                    output = output + "，";
                }

                output = output + Convert.ToString(Math.Abs(tmp));


                i++;
            }



            Console.WriteLine($"使用者輸入的數字都轉成正數是 {output}");
            Console.ReadKey();
        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_addition_1_for()
        {
            Console.WriteLine("Hw3_addition_1_for");
            // ch3 補充習題 1 => 判斷 101-200 之間有多少個質數，並輸出所有質數。

            int start = 101;
            int end = 200;

            int count = 0;

            for (int i = start; i < end + 1; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < start + 1; j++)
                {
                    if (i % j == 0 && j != start)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    count++;
                }


            }

            Console.WriteLine($"質數有 {count} 個");
            Console.ReadKey();



        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_addition_1_while()
        {
            Console.WriteLine("Hw3_addition_1_while");
            // ch3 補充習題 1 => 判斷101-200之間有多少個質數，並輸出所有質數。

            int start = 101;
            int end = 200;

            int count = 0;

            int i = 101;

            while (i < end + 1)
            {
                bool isPrime = true;

                for (int j = 2; j < start + 1; j++)
                {
                    if (i % j == 0 && j != start)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    count++;
                }

                i++;
            }

            Console.WriteLine($"質數有 {count} 個");
            Console.ReadKey();

        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_addition_2_for()
        {
            Console.WriteLine("Hw3_addition_2_for");
            // ch3 補充習題 2 => 輸入一個數，輸出其質因數

            string output = "";

            Console.WriteLine("請輸入一個整數幫你輸出他的質因數");

            int inputNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= inputNumber; i++)
            {
                if (inputNumber % i == 0)
                {
                    // 判斷此數是不是質數
                    bool isPrime = true;


                    // 檢查是否能被 2 到其平方根之間的任何數整除
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                        }
                    }




                    if (isPrime)
                    {
                        if (output.Length != 0)
                        {
                            output = output + "，";
                        }

                        output = output + Convert.ToString(i);

                    }
                }


            }

            Console.WriteLine($"輸入的數是 {inputNumber}，他的質因數有 {output}");

            Console.ReadKey();





        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_addition_2_while()
        {
            Console.WriteLine("Hw3_addition_2_while");
            // ch3 補充習題 2 => 輸入一個數，輸出其質因數

            string output = "";

            Console.WriteLine("請輸入一個整數幫你輸出他的質因數");

            int inputNumber = Convert.ToInt32(Console.ReadLine());

            int i = 2;

            while (i <= inputNumber)
            {
                i++;

                if (inputNumber % i == 0)
                {
                    // 判斷此數是不是質數
                    bool isPrime = true;


                    int j = 2;

                    while (j <= Math.Sqrt(i))
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                        }
                        j++;
                    }


                    if (isPrime)
                    {
                        if (output.Length != 0)
                        {
                            output = output + "，";
                        }

                        output = output + Convert.ToString(i);

                    }
                }

            }



            Console.WriteLine($"輸入的數是 {inputNumber}，他的質因數有 {output}");

            Console.ReadKey();
        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_addition_3_for()
        {
            Console.WriteLine("Hw3_addition_3_for");
            // ch3 補充習題 3 => 求100到300中可以被3與7整除的個數。

            int count = 0;

            for (int i = 100; i <= 300; i++)
            {
                if ((i % 3) == 0 && (i % 7) == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"100到300中可以被3與7整除的個數，有 {count} 個");
            Console.ReadKey();

        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw3_addition_3_while()
        {
            Console.WriteLine("Hw3_addition_3_while");
            // ch3 補充習題 3 => 求100到300中可以被3與7整除的個數。

            int count = 0;

            int i = 100;

            while (i <= 300)
            {
                if ((i % 3) == 0 && (i % 7) == 0)
                {
                    count++;
                }
                i++;
            }



            Console.WriteLine($"100到300中可以被3與7整除的個數，有 {count} 個");
            Console.ReadKey();

        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch4_1()
        {

            Console.WriteLine("practice_ch4_1");
            // ch4-1 求最大公約數(Greatest Common Divisor，簡寫G.C.D.，或稱最大公因數)。
            // 輸入2個數，求最大公約數


            Console.WriteLine("輸入2個數，求最大公因數");

            Console.WriteLine("第一個數");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("第二個數");
            int y = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            int max = 1;

            while ((i <= x) || (i <= y))
            {

                if (x % i == 0 && y % i == 0)
                {
                    if (max < i)
                    {
                        max = i;
                    }
                }

                i++;
            }


            Console.WriteLine($"輸入的數是 {x} ， {y}， 他們的最大公因數是 {max}");

            Console.ReadKey();


        }



        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void practice_ch4_2()
        {
            Console.WriteLine("practice_ch4_2");
            // ch4-2 計算 N 個數字的和。
            // 檢查 i 有沒有超過 N，超過就不做了

            Console.WriteLine("請輸入要計算幾個數字的和");

            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"請輸入第 {i + 1} 個數字");
                int tmp = Convert.ToInt32(Console.ReadLine());

                sum = sum + tmp;

                i++;


            }

            Console.WriteLine($"輸入的總和是{sum}");

            Console.ReadKey();



        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw4_1()
        {
            Console.WriteLine("Hw4_1");
            // ch4-1 利用 while 寫一程式求 N 個數字的最大值。

            Console.WriteLine("請輸入要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            int max = int.MinValue;
            int i = 0;

            while (i < N)
            {
                Console.WriteLine($"輸入第 {i + 1} 個數");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp > max)
                {
                    max = tmp;
                }
                i++;
            }


            Console.WriteLine($"這 {N} 個數的最大值是 {max}");

            Console.ReadKey();
        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw4_2()
        {
            Console.WriteLine("Hw4_2");
            // ch4-2 利用while寫一程式求一個等差級數數字的和，
            // 一共有N個數字，程式應該輸入最小的起始值以及數字間的差。
            // (即從起始值開始，間格差，共N個 的總和)

            Console.WriteLine("請問此等差數列有幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("請問首項是多少 ?");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("請問公差是多少 ?");
            int d = Convert.ToInt32(Console.ReadLine());


            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum = sum + a + (i - 1) * d;
            }

            Console.WriteLine($"總和: {sum}");

            Console.ReadKey();


        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw4_3()
        {
            Console.WriteLine("Hw4_3");
            // ch4-3 .利用while寫一程式，讀入 N 個數字，
            // 然後找出所有小於13的數，再求這些數字的和。

            Console.WriteLine("請輸入要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"輸入第 {i + 1} 的數字");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp < 13)
                {
                    sum = sum + tmp;
                }

                i++;
            }

            Console.WriteLine($"小於13的數字總和為 {sum}");
            Console.ReadKey();
        }



        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw4_4()
        {
            Console.WriteLine("Hw4_4");
            // ch4-4 利用while寫一程式，讀入N個數字，
            // 找到第一個大於7而小於10的數字就停止，而且列印出這個數字。


            Console.WriteLine("請輸入要輸入幾個整數 ?");
            int N = Convert.ToInt32(Console.ReadLine());
            int chooseNumber = 0;

            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"輸入第 {i + 1} 的數字");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp > 7 && tmp < 10)
                {
                    chooseNumber = tmp;
                    break;
                }

                i++;
            }

            if (chooseNumber == 0)
            {
                Console.WriteLine("沒有輸入大於7而小於10的數字");
            }
            else
            {

                Console.WriteLine($"輸入大於7而小於10的數字為 {chooseNumber}");
            }

            Console.ReadKey();

        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw4_5()
        {
            Console.WriteLine("Hw4_5");

            // ch4-5 利用 while寫一程式，讀入 a1,a2,…,a5 和 b1,b2,…,b5 。
            // 找到第一個 ai > bi，即停止，並列印出ai及bi。

            Console.WriteLine("請輸入 a1 ~ a5");

            int[] A_number = new int[5];
            int[] B_number = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"請輸入的 a{i + 1} ");
                A_number[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"請輸入的 b{i + 1} ");
                B_number[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {

                if (A_number[i] > B_number[i])
                {
                    Console.WriteLine($"Ai > Bi，Ai={A_number[i]}，Bi={B_number[i]}");
                }
                else
                {
                    if (i == 4)
                    {
                        Console.WriteLine("沒有一項符合 ai > bi");
                    }
                }
            }

            Console.ReadKey();

        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw4_addition_1()
        {
            Console.WriteLine("Hw4_addition_1");
            // 補充題目 1
            // Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。
            // 假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。

            Console.WriteLine("請輸入分鐘數");
            int minutes = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            count = minutes / 5;

            Console.WriteLine($"吃了{count}個漢堡");

            Console.ReadKey();


        }


        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw4_addition_2()
        {
            Console.WriteLine("Hw4_addition_2");
            // 補充題目 2
            // 小明貸款買房花560萬，每個月可還4萬，每還12個月，
            // 因為年終獎金可以多還一萬，請問需要幾個月還清。

            int money = 560;
            int month = 0;
            int year = 0;

            while (money > 0)
            {


                money = money - 4;

                if (year == 12)
                {
                    money = money - 1;
                    year = 0;
                }

                month++;
                year++;
            }


            Console.WriteLine($"需要花 {month} 個月");
            Console.ReadKey();




        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------

        static public void Hw4_addition_3()
        {
            Console.WriteLine("Hw4_addition_3");
            // 補充題目 3
            // 系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！，
            // 猜錯時，要提示是比較大還是比較小。

            Console.WriteLine("請猜 1~100 的數字");

            Random random = new Random();

            int random_number = random.Next(101);


            int chooseNumber = 0;
            while (chooseNumber != random_number)
            {
                Console.WriteLine("請輸入數字");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp > random_number)
                {
                    Console.WriteLine("答案比較小");
                }
                else if (tmp == random_number)
                {
                    Console.WriteLine($"恭喜答對了，是 {random_number}");
                    chooseNumber = random_number;

                }
                else
                {
                    Console.WriteLine("答案比較大");
                }

            }



            Console.ReadKey(true);



        }

        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        // -----------------------------------------------------------------------------------------



        static void Main(string[] args)
        {
            introduce();
            practice_ch3_1();
            practice_ch3_1_while();
            practice_ch3_2_for();
            practice_ch3_2_while();
            practice_ch3_3_for();
            practice_ch3_3_while();
            practice_ch3_4_for();
            practice_ch3_4_while();
            practice_ch3_5_for();
            practice_ch3_5_while();
            practice_ch3_6_for();
            practice_ch3_6_while();
            practice_ch3_7_for();
            practice_ch3_7_while();

            Hw3_1_for();
            Hw3_1_while();
            Hw3_2_for();
            Hw3_2_while();
            Hw3_3_for();
            Hw3_3_while();
            Hw3_4_for();
            Hw3_4_while();
            Hw3_5_for();
            Hw3_5_while();
            Hw3_6_for();
            Hw3_6_while();
            Hw3_7_for();
            Hw3_7_while();

            Hw3_addition_1_for();
            Hw3_addition_1_while();
            Hw3_addition_2_for();
            Hw3_addition_2_while();
            Hw3_addition_3_for();
            Hw3_addition_3_while();



            practice_ch4_1();
            practice_ch4_2();



            Hw4_1();
            Hw4_2();
            Hw4_3();
            Hw4_4();
            Hw4_5();
            Hw4_addition_1();
            Hw4_addition_2();
            Hw4_addition_3();

        }
    }
}
