using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hw06
{
    internal class Program
    {


        // function 作業

        public static void hw05_func01()
        {
            // 1.寫一個function 可以把一般對話框的文字轉成HTML。
            // > 轉成 & gt;
            // < 轉成 & lt;
            // \r\n 轉成<br>
            // | 轉成 & brvbar;
            // 空白 轉成 &nbsp;


            // 先將 string 裡面的特殊字元轉換
            // 再將它放入 html 裡面

            Console.WriteLine("1.寫一個function 可以把一般對話框的文字轉成HTML");

            Console.WriteLine("請輸入文字");

            string inputText;
            inputText = Console.ReadLine();

            // 如果有特殊字元要取代
            string ouputText = inputText.Replace(">", "&gt;").Replace("<", "&lt;").Replace("<", "&lt;").Replace("|", "& brvbar;").Replace(@"\r\n", "<br>").Replace(" ", "&nbsp;");

            // 裝在 Div 裡面
            string ouputHtml = $"<div>{ouputText}</div>";


            Console.WriteLine(ouputHtml);
        }

        public static void hw05_func02()
        {
            // 2. 寫一個function，回傳輸入的值是否數字

            Console.WriteLine("2.寫一個function，回傳輸入的值是否數字");

            Console.WriteLine("請輸入值");

            string inputText = Console.ReadLine();


            // 判斷可不可以轉型成 double
            double number;

            bool isDouble = double.TryParse(inputText, out number);

            if (isDouble)
            {
                Console.WriteLine("True 是數字");
            }
            else
            {
                Console.WriteLine("False 不是數字");
            }

        }


        public static void hw05_func03()
        {
            // 3. 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
            Console.WriteLine("3. 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式");

            Console.WriteLine("請輸入值");
            string input = Console.ReadLine();

            // 建立正則表達式的 pattern
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex ReObj = new Regex(pattern); // 創立一個 Regex 物件

            Console.WriteLine(ReObj.IsMatch(input)); // 會回傳 True/False

        }

        public static void hw05_func04()
        {
            // 4.寫一個function，回傳輸入的值是否符合手機格式
            Console.WriteLine("4. 寫一個function，回傳輸入的值是否符合手機格式");

            Console.WriteLine("請輸入值");
            string input = Console.ReadLine();

            // 09 開頭 => 然後後面接八個數字
            // 建立正則表達式的 pattern
            string pattern = @"^[0]+[9]+\d{8}$";

            Regex ReObj = new Regex(pattern); // 創立一個 Regex 物件

            Console.WriteLine(ReObj.IsMatch(input)); // 會回傳 True/False

        }


        public static void hw05_func05()
        {
            // 5. 寫一個function，回傳輸入的值是否符合身分證字號格式

            Console.WriteLine("5. 寫一個function，回傳輸入的值是否符合身分證字號格式");

            Console.WriteLine("請輸入值");
            string input = Console.ReadLine();

            string pattern = @"^[A-Za-z]\d{9}$";

            Regex ReObj = new Regex(pattern); // 創立一個 Regex 物件

            Console.WriteLine(ReObj.IsMatch(input)); // 會回傳 True/False
        }

        public static void hw05_func06()
        {
            // 6. 寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點

            Console.WriteLine("請輸入文字");

            string input = Console.ReadLine();

            Console.WriteLine("請輸入大於幾個字，就要使用 ... 省略");

            int max = Convert.ToInt32(Console.ReadLine());


            if (input.Length > max)
            {
                input = input.Remove(max);
                input = input + "...";
            }

            Console.WriteLine(input);

        }

        public static void hw05_func07()
        {
            // 7. 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式

            Console.WriteLine("7. 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式");

            Console.WriteLine("請輸入日期: 請照著此格式 2024/04/17");

            string input = Console.ReadLine();


            // 檢查格式是不是 2024/04/17

            string pattern = @"^\d{4}/\d{2}/\d{2}$";

            Regex ReObj = new Regex(pattern); // 創立一個 Regex 物件


            if (!ReObj.IsMatch(input))
            {
                Console.WriteLine("輸入不符合格式");
                return;
            }



            // 將字串分割，去拿到 年 月 日
            string[] inputSplit = input.Split('/');


            int[] inputSplitInt = new int[inputSplit.Length];

            for (int i = 0; i < inputSplitInt.Length; i++)
            {

                if (int.TryParse(inputSplit[i], out int number))
                {
                    inputSplitInt[i] = number;
                }
                else
                {
                    Console.WriteLine($"無法將 '{inputSplit[i]}' 轉換為整數。");
                    return;
                }
            }



            //轉換的格式 => 民國年.月.日格式
            string dateFormat = $"轉換完 :民國{inputSplitInt[0] - 1911}年{inputSplitInt[1]}月{inputSplitInt[2]}日 ";

            Console.WriteLine(dateFormat);
        }


        public static void hw05_func08()
        {
            // 8. 寫一個function，輸入一個日期，把把該日期轉成民國XX年XX月XX日 星期X 格式
            Console.WriteLine("8. 寫一個function，輸入一個日期，把把該日期轉成民國XX年XX月XX日 星期X 格式");

            Console.WriteLine("請輸入日期: 請照著此格式 2024/04/01");

            string input = Console.ReadLine();


            // 檢查格式

            string pattern = @"^\d{4}/\d{2}/\d{2}$";

            Regex ReObj = new Regex(pattern); // 創立一個 Regex 物件


            if (!ReObj.IsMatch(input))
            {
                Console.WriteLine("輸入不符合格式");
                return;
            }

            // 將字串分割，去拿到 年 月 日
            string[] inputSplit = input.Split('/');

            int[] inputSplitInt = new int[inputSplit.Length];

            for (int i = 0; i < inputSplitInt.Length; i++)
            {

                if (int.TryParse(inputSplit[i], out int number))
                {
                    inputSplitInt[i] = number;
                }
                else
                {
                    Console.WriteLine($"無法將 '{inputSplit[i]}' 轉換為整數。");
                    return;
                }
            }

            // 測試範例：輸入日期
            DateTime inputDate = new DateTime(inputSplitInt[0], inputSplitInt[1], inputSplitInt[2]);

            string[] chineseDayOfWeek = { "一", "二", "三", "四", "五", "六", "日" };



            //轉換的格式 => 民國年.月.日 星期幾 格式
            string dateFormat = $"轉換完 :民國{inputSplitInt[0] - 1911}年{inputSplitInt[1]}月{inputSplitInt[2]}日，星期{chineseDayOfWeek[Convert.ToInt32(inputDate.DayOfWeek) - 1]}";

            Console.WriteLine(dateFormat);

        }

        public static void hw05_func09()
        {
            // 9. 寫一個function，回傳輸入的年是否閏年
            Console.WriteLine("9. 寫一個function，回傳輸入的年是否閏年");


            Console.WriteLine("請輸入西元年份");

            string userInput = Console.ReadLine();

            // 判斷使用者輸入的值，是可以轉換成整數的，沒有亂輸入
            if (int.TryParse(userInput, out int inputYear))
            {
                // 轉換成功，inputYear 為轉換後的整數值
            }
            else
            {
                // 轉換失敗，輸入的值無法轉換為整數
                Console.WriteLine($"您輸入的值 {userInput} 無法轉換為整數。");
            }

            Console.WriteLine(inputYear);

            // 判斷閏年的規則：
            // 1. 西元年份能被4整除但不能被100整除，或者能被400整除的年份為閏年
            if (inputYear % 4 == 0 && inputYear % 100 != 0 || inputYear % 400 == 0)
            {
                Console.WriteLine("這是閏年");
            }
            else
            {
                Console.WriteLine("這不是閏年");
            }



        }



        public static void hw05_func10()
        {
            // 10. 寫一個function，輸入手機號碼，
            // 回傳今天運勢(手機運勢算法：用你的手機號碼的最後四位數除以80，
            // 再減去整數部分（只留小數），再乘以80，就會得到一個數，
            // 這就是代表吉凶的數字，印出結果。)

            Console.WriteLine("10. 寫一個function，輸入手機號碼，回傳今天運勢(手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)");

            Console.WriteLine("請輸入手機號碼?");

            string input = Console.ReadLine();

            // 09 開頭 => 然後後面接八個數字
            // 建立正則表達式的 pattern
            string pattern = @"^[0]+[9]+\d{8}$";

            Regex ReObj = new Regex(pattern); // 創立一個 Regex 物件


            if (!ReObj.IsMatch(input))
            {
                Console.WriteLine("手機格式不符合");
                return;
            }

            // 取得手機最後四位數
            double lastFour = double.Parse(input.Substring(6));

            Console.WriteLine(lastFour);

            double answer = ((lastFour / 80.0) % 1.0) * 80;


            Console.WriteLine($"今天的吉凶數字是{Math.Round(answer)}");

        }


        public static void hw05_string01()
        {
            // 1 .輸入姓名，輸出 Hi~輸入的姓名，
            // 比如說輸入Justin，輸出 Hi~Justin。
            Console.WriteLine("1. 輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。");

            Console.WriteLine("請輸入姓名");

            string input = Console.ReadLine();
            Console.WriteLine($"Hi~{input}");

        }

        public static void hw05_string02()
        {
            // 2.請輸入任何一個字，是否出現在
            // 人人為我，我為人人、饒人不癡漢，癡漢不饒人”
            // 這個字串裡。
            Console.WriteLine("2.請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。\r\n");

            Console.WriteLine("請輸入一個字");

            string input = Console.ReadLine();

            string text = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";

            bool check = text.Contains(input);

            Console.WriteLine(check);

        }


        public static void hw05_string03()
        {
            // 3.輸入一段字，輸出每個之間多一個-，
            // 如輸入apple ，輸出a-p-p-l-e。

            Console.WriteLine("3.輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。\r\n");

            Console.WriteLine("請輸入一段字");

            string input = Console.ReadLine();

            char[] inputChar = input.ToCharArray();

            string output = "";

            for (int i = 0; i < inputChar.Length; i++)
            {

                if (i != inputChar.Length - 1)
                {
                    output += inputChar[i] + "-";
                }
                else
                {
                    output += inputChar[i];
                }

            }

            Console.WriteLine(output);

        }


        public static void hw05_string04()
        {
            // 4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。

            Console.WriteLine("4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。");

            Console.WriteLine("請輸入一個檔名");

            string input = Console.ReadLine();

            int number = input.IndexOf(".");

            string output = input.Substring(number + 1);

            Console.WriteLine(output);


        }

        public static void hw05_string05()
        {
            // 5.輸入一個大於五個字的單字，
            // 若小於五個字輸出長度不夠，
            // 若大於五個字，則輸出前三個字。
            // Length  Substring()

            Console.WriteLine("5.輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。Length  Substring()\r\n");

            Console.WriteLine("請輸入一個大於五的單字");


            string input = Console.ReadLine();
            if (input.Length < 5)
            {
                Console.WriteLine("輸入長度不夠");
            }
            else
            {
                input = input.Substring(0, 3);
                Console.WriteLine("輸出前三個字: " + input);
            }



        }



        public static void hw05_string06()
        {

            // 6. 輸入一段字，輸出把輸入的一段字裡面的我，
            // 改成小明，如輸入我在唱歌，
            // 輸出小明在唱歌。
            // Replace()

            Console.WriteLine("6.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()\r\n");

            string input = Console.ReadLine();

            input = input.Replace("我", "小明");

            Console.WriteLine("輸出的內容:" + input);


        }

        public static void hw05_string07()
        {
            // 7.輸入一串字，顯示輸入幾個字。Length
            Console.WriteLine("7.輸入一串字，顯示輸入幾個字。Length\r\n");


            Console.WriteLine("請輸入一串字");


            string input = Console.ReadLine();

            int inputLength = input.Length;

            Console.WriteLine("輸入了" + inputLength + "個字");


        }



        public static void hw05_string_additional_01()
        {
            // 1.連續輸入10組字，若沒輸入過，
            // 就顯示沒出現過，若輸入過，就顯示輸入過。

            Console.WriteLine("1.連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。");


            string[] inputArray = new string[10];


            for (int i = 0; i < inputArray.Length; i++)
            {

                Console.WriteLine($"請輸入第{i + 1}組字");
                string input = Console.ReadLine();
                inputArray[i] = input;

                bool check = false;


                for (int j = 0; j < inputArray.Length; j++)
                {

                    if (inputArray[j] == input && i != j)
                    {
                        check = true;
                    }

                }


                if (check)
                {
                    Console.WriteLine("有重複了");
                }
                else
                {
                    Console.WriteLine("沒有重複");
                }

            }





        }


        public static void hw05_string_additional_02()
        {
            // 2.用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出
            //Fifa
            //fIfa
            //fiFa
            //fifA

            Console.WriteLine("2.用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出\r\nFifa\r\nfIfa\r\nfiFa\r\nfifA");

            Console.WriteLine("請輸入字串");

            string input = Console.ReadLine();

            input = input.ToLower();


            for (int i = 0; i < input.Length; i++)
            {

                for (int j = 0; j < input.Length; j++)
                {

                    if (i == j)
                    {
                        char upChar = input[j];

                        upChar = char.ToUpper(upChar);

                        Console.Write(upChar);
                    }
                    else
                    {
                        Console.Write(input[j]);
                    }


                }

                Console.WriteLine("");
            }








        }

        public static void hw05_string_additional_03()
        {
            // 3.輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。

            Console.WriteLine("3.輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。");


            Console.WriteLine("請輸入時間: (格式 => 11:30 )");

            string input = Console.ReadLine();


            string[] inputArray = input.Split(':');


            Console.WriteLine($"輸出{inputArray[0]}點{inputArray[1]}分");


        }

        public static void hw05_string_additional_04()
        {

            // 4.輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出
            //< ul >
            //   < li > Justin </li>
            //   < li > Amy </li>
            //   < li > David </li>
            //</ ul >
            Console.WriteLine("4.輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出\r\n<ul>\r\n\t<li>Justin<li>\t\r\n\t<li>Amy<li>\r\n\t<li>David<li>\r\n</ul>");


            Console.WriteLine("請輸入字， ex:Justin,Amy,David");

            string input = Console.ReadLine();

            string[] inputArray = input.Split(',');

            string ouput = "";

            ouput += "<ul> \r\n";

            for (int i = 0; i < inputArray.Length; i++)
            {
                ouput += "  <li>" + inputArray[i] + "</li> \r\n";
            }

            ouput += "</ul>";

            Console.WriteLine(ouput);

        }

        public static void hw05_string_additional_05()
        {

            // 5.輸入5處數字，用空白隔開，
            // 輸出結果。例如：輸入‘11 19 12 25 1 7 12，
            // 輸出總和是87

            Console.WriteLine("5.輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87\r\n");

            Console.WriteLine("請輸入五個數字，用空白隔開 => ex:11 19 12 25 13");

            string input = Console.ReadLine();

            string[] inputArray = input.Split(' ');

            int sum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                sum += Convert.ToInt32(inputArray[i]);
            }

            Console.WriteLine(sum);
        }



        public static void hw05_string_additional_06()
        {
            // 6.輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ
            Console.WriteLine("6.輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ\r\n");

            string input = Console.ReadLine();

            char[] inputArray = input.ToCharArray();

            Array.Reverse(inputArray);

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i]);
            }

            Console.ReadKey();

        }




        static void Main(string[] args)
        {

            // hw05
            hw05_func01();
            hw05_func02();
            hw05_func03();
            hw05_func04();
            hw05_func05();
            hw05_func06();
            hw05_func07();
            hw05_func08();
            hw05_func09();
            hw05_func10();

            hw05_string01();
            hw05_string02();
            hw05_string03();
            hw05_string04();
            hw05_string05();
            hw05_string06();
            hw05_string07();


            hw05_string_additional_01();
            hw05_string_additional_02();
            hw05_string_additional_03();
            hw05_string_additional_04();
            hw05_string_additional_05();
            hw05_string_additional_06();

        }
    }
}
