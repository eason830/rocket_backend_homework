using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        // 習題 ch2-1，寫一程式，輸入 x 和 y ，如果 x > y，則列印 x，否則列印 y
        public static void Hw2_1()
        {
            Console.WriteLine("Hw2_1");
            Console.WriteLine("請輸入 x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入 y");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine($"最大值是 x ，他的值是 {x}");
            }
            else if (x == y)
            {
                Console.WriteLine($"x = y ，他們的值是 {x}");
            }
            else
            {
                Console.WriteLine($"最大值是 y ，他的值是 {y}");
            }

            Console.ReadKey();
        }

        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------


        // 習題 ch2-2 寫一程式，輸入 x 和 y ，如果 x 和 y 都是正數，令 z = 1，
        //                      如兩者均為負數，令z = -1，否則令 z = 0

        public static void Hw2_2()
        {
            Console.WriteLine("Hw2_2");
            Console.WriteLine("請輸入 x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入 y");
            double y = Convert.ToDouble(Console.ReadLine());



            if (x > 0 && y > 0)
            {
                double z = 1;
                Console.WriteLine($"z 的值是 {z}");
            }
            else if (x < 0 && y < 0)
            {
                double z = -1;
                Console.WriteLine($"z 的值是 {z}");
            }
            else
            {
                double z = 0;
                Console.WriteLine($"z 的值是 {z}");
            }

            Console.ReadKey();

        }

        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------

        // 習題 ch2-3 寫一程式，輸入 x 、 y 、 u 、 v，
        // 如果 ( x + y ) > ( u + v )，則令 z = x - y，否則令 z = u - v

        public static void Hw2_3()
        {
            Console.WriteLine("Hw2_3");
            Console.WriteLine("請輸入 x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入 y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入 u");
            double u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入 v");
            double v = Convert.ToDouble(Console.ReadLine());


            if ((x + y) > (u + v))
            {
                double z = x - y;
                Console.WriteLine($"z 的值是 {z}");
            }
            else
            {
                double z = u - v;
                Console.WriteLine($"z 的值是 {z}");
            }
            Console.ReadKey();

        }


        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------

        // 習題 ch2-4 寫一程式，輸入 x、y、u、v，
        // 如果(x+y) / (u-v) >= 2，令 z = x-y，否則令 z = u-v。

        public static void Hw2_4()
        {
            Console.WriteLine("Hw2_4");
            Console.WriteLine("請輸入 x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入 y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入 u");
            double u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入 v");
            double v = Convert.ToDouble(Console.ReadLine());

            if (u == v)
            {
                Console.WriteLine("u 不能跟 v 相等 ，分母不能為 0");
                Console.ReadKey();
                return ;
            }


            if ( (x + y) / (u - v) >= 2)
            {
                double z = x - y;
                Console.WriteLine($"z 的值是 {z}");
            }
            else
            {
                double z = u - v;
                Console.WriteLine($"z 的值是 {z}");
            }

            Console.ReadKey();
        }



        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------


        // 習題 ch2-5  寫一程式，輸入x和y，如果 x >= y，令 z =x2 (x平方)，否則令 z=y2 (y平方)


        public static void Hw2_5()
        {
            Console.WriteLine("Hw2_5");
            Console.WriteLine("請輸入 x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入 y");
            double y = Convert.ToDouble(Console.ReadLine());


            if(x >= y)
            {
                double z = Math.Pow(x,2);
                Console.WriteLine($"z 的值是 {z}");
            }
            else
            {
                double z = Math.Pow(y,2);
                Console.WriteLine($"z 的值是 {z}");
            }

            Console.ReadKey();
        }


        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------


        // 習題 ch2-6  根據流程圖
        // 請輸入 income
        // 如果 income > 4090000 => rate = 0.4 、 difference = 721100
        // 如果 income > 2180000 => rate = 0.3 、 difference = 312100
        // 如果 income > 1090000 => rate = 0.21 、 difference = 115900
        // 如果 income > 410000 => rate = 0.13 、 difference = 28700
        // else => rate = 0.6 、 difference = 0
        // tax = (income * rate) - difference
        // 列印出 tax


        public static void Hw2_6()
        {
            Console.WriteLine("Hw2_5");
            Console.WriteLine("請輸入 income");
            double income = Convert.ToDouble(Console.ReadLine());

            double rate, difference;
               
            if(income > 4090000)
            {
               rate = 0.4;
               difference = 721100;
            }
            else if (income > 2180000) 
            {
                rate = 0.3;
                difference = 312100;
            }
            else if (income > 1090000)
            {
                rate = 0.21;
                difference = 115900;
            }
            else if (income > 410000)
            {
                rate = 0.13;
                difference = 28700;
            }
            else
            {
                rate = 0.6;
                difference = 0;
            }

            double tax = (income * rate) - difference;
            Console.WriteLine($"tax 的值為 {tax}");

            Console.ReadKey();

        }




        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------

        // 習題 ch2-7  根據流程圖
        // 請輸入 x y 座標，輸出他是在哪一個象限
        // 輸入 x 、 y
        // x > 0 && y > 0  印出 1st quadrant \n
        // x > 0 && y == 0 印出 X-axis \n
        // x > 0 && y < 0 印出 4th quadrant \n

        // x == 0 && y == 0 印出 Origin \n
        // x == 0 && y != 0 印出 Y-axis \n

        // x < 0 && y > 0 印出 2nd quadrant \n
        // x < 0 && y ==0 印出 X-axis \n
        // x < 0 && y < 0 印出 3th quadrant \n


        public static void Hw2_7() 
        {

            Console.WriteLine("Hw2_7");
            Console.WriteLine("請輸入 x 座標");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入 y 座標");
            double y = Convert.ToDouble(Console.ReadLine());

            if(x > 0 && y > 0)
            {
                Console.WriteLine("1st quadrant \n");
            }
            else if(x > 0 && y == 0)
            {
                Console.WriteLine("X-axis \n");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4th quadrant \n");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Origin \n");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Y-axis \n");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2nd quadrant \n");
            }
            else if(x < 0 && y == 0)
            {
                Console.WriteLine("X-axis \n");
            } 
            else if(x < 0 && y < 0)
            {
                Console.WriteLine("3th quadrant \n");
            }
            else 
            {
                Console.WriteLine("應該沒有此可能");
            }

            Console.ReadKey();


        }


        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------

        // 補充習題 1 =>  Hw_additional_01
        // sagit 是一位高中電腦老師，這學期正在教學生寫C++程式。
        // 他的評分標準是依照每一位學生在 ZeroJudge 系統上解出的題數，
        // 去計算出對應的得分。規則如下：
        // 答對題數在 0~10 者，每題給6分。
        // 題數在 11~20 者，從第11題開始，每題給2分。(前10題還是每題給6分)
        // 題數在 21~40 者，從第21題開始，每題給1分。
        // 題數在 40 以上者，一律100分。
        // 請輸入答對題數，輸出統計後分數

        public static void Hw_additional_01() 
        {
            Console.WriteLine("Hw_additional_01");

            Console.WriteLine("請輸入答對的題數");
            int rightNumber = Convert.ToInt32(Console.ReadLine());
            int score;

            if(rightNumber <= 10 && rightNumber > 0)
            {
                score = rightNumber *6;
            }
            else if ( rightNumber <= 20 &&  rightNumber > 10)
            {
                score = 60 + (rightNumber - 10) * 2;
            }
            else if (rightNumber <= 40 &&  rightNumber > 20)
            {
                score = 80 + (rightNumber - 20) * 1;
            }else if ( rightNumber > 40)
            {
                score = 100;
            } 
            else
            {
                score = 0;
            }

            Console.WriteLine($"您的得分是 {score} 分");
            Console.ReadKey(); 

        }



        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------

        // 補充習題 2 =>  Hw_additional_02
        // 請輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重。

        public static void Hw_additional_02()
        {

            Console.WriteLine("Hw_additional_02");

            Console.WriteLine("請輸入身高 ( m 為基本單位)");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("請輸入體重 ( kg 為基本單位)");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);

            if( bmi < 18.5 && bmi > 0)
            {
                Console.WriteLine($"您的 BMI 是 {bmi} , 過輕");
            }
            else if (bmi >= 18.5 && bmi < 24)
            {
                Console.WriteLine($"您的 BMI 是 {bmi} , 正常範圍");
            }
            else if ( bmi >= 24 && bmi < 27)
            {
                Console.WriteLine($"您的 BMI 是 {bmi} , 過重");
            }
            else if (bmi >= 27 && bmi < 30)
            {
                Console.WriteLine($"您的 BMI 是 {bmi} , 輕度肥胖");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.WriteLine($"您的 BMI 是 {bmi} , 中度肥胖");
            }
            else if (bmi >= 35)
            {
                Console.WriteLine($"您的 BMI 是 {bmi} , 重度肥胖");
            }
            else
            {
                Console.WriteLine("數值可能輸入有問題喔");
            }

            Console.ReadKey();


        }



        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------

        // 補充習題 3 =>  Hw_additional_03
        // 請隨意輸入三個數，請由大到小 依序印出。

        public static void Hw_additional_03()
        {

            Console.WriteLine("Hw_additional_03");

            double[] numThree = new double[3];
            Console.WriteLine("請隨意輸入三個數");
            
            for(int i = 0;i < numThree.Length; i++)
            {
                numThree[i]= Convert.ToDouble(Console.ReadLine());
            }

            Array.Reverse(numThree);



            string arrayAsString = string.Join(", ", numThree);
            Console.WriteLine($"陣列大到小: {arrayAsString}");

            Console.ReadKey ();



        }


        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------

        // 補充習題 4 =>  Hw_additional_04
        // 企業發放的獎金根據利潤提成。
        // 利潤低於或等於10萬元時，獎金可提10%；
        // 利潤高于10萬元，低於20萬元時，
        // 低於10萬元的部分按10%提成，
        // 高於10萬元的部分，可提成7.5%；
        // 20萬到40萬之間時，
        // 高於20萬元的部分，可提成5%；
        // 40萬到60萬之間時高於40萬元的部分，可提成3%；
        // 60萬到100萬之間時，高於60萬元的部分，可提成1.5%，
        // 高於100萬元時，超過100萬元的部分按1%提成，從鍵盤輸入當月利潤I，求應發放獎金總數？


        public static void Hw_additional_04()
        {

            Console.WriteLine("Hw_additional_04");
            Console.WriteLine("請輸入當月利潤");

            double money = Convert.ToDouble(Console.ReadLine());

            double moneyGet;

            if(money > 0 && money <= 100000) {
                moneyGet = money * 0.1;
            }
            else if (money > 100000 && money <= 200000)
            {
                moneyGet = 100000 * 0.1 + (money - 100000) * 0.075;
            }
            else if (money > 200000 && money <= 400000)
            {
                moneyGet = 100000 * 0.1 + 100000 * 0.075 + (money - 200000) * 0.05;
            }
            else if (money > 400000 && money <= 600000)
            {
                moneyGet = 100000 * 0.1 + 100000 * 0.075 + 200000 * 0.05 + (money - 400000) * 0.03;
            }
            else if (money > 600000 && money <= 1000000)
            {
                moneyGet = 100000 * 0.1 + 100000 * 0.075 + 200000 * 0.05 + 200000 * 0.03 + (money - 600000) * 0.015;
            }
            else if (money > 1000000)
            {
                moneyGet = 100000 * 0.1 + 100000 * 0.075 + 200000 * 0.05 + 200000 * 0.03 + 400000 * 0.015 + (money - 1000000) * 0.01;
            }
            else
            {
                moneyGet = 0;

            }


            Console.WriteLine( $"當月獎金為 {moneyGet} 元");



            Console.ReadKey();

        }


        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------


        static void Main(string[] args)
        {
            //Hw2_1();
            //Hw2_2();
            //Hw2_3();
            //Hw2_4();
            //Hw2_5();
            //Hw2_6();
            //Hw2_7();
            //Hw_additional_01();
            //Hw_additional_02();
            //Hw_additional_03();
            Hw_additional_04();




        }
    }
}
