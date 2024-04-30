using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw06_file
{
    internal class Program
    {

        // String 題目

        public static void hw06_string01()
        {
            // 1 .輸入姓名，輸出 Hi~輸入的姓名，
            // 比如說輸入Justin，輸出 Hi~Justin。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string01 => 輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。");

            Console.WriteLine("請輸入姓名");

            string input = Console.ReadLine();
            Console.WriteLine($"Hi~{input}");

        }

        public static void hw06_string02()
        {
            // 2.請輸入任何一個字，是否出現在
            // 人人為我，我為人人、饒人不癡漢，癡漢不饒人”
            // 這個字串裡。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string02 => 請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。\r\n");

            Console.WriteLine("請輸入一個字");

            string input = Console.ReadLine();

            string text = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";

            bool check = text.Contains(input);

            Console.WriteLine(check);

        }


        public static void hw06_string03()
        {
            // 3.輸入一段字，輸出每個之間多一個-，
            // 如輸入apple ，輸出a-p-p-l-e。

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string03 => 輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。\r\n");

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


        public static void hw06_string04()
        {
            // 4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string04 => 輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。");

            Console.WriteLine("請輸入一個檔名");

            string input = Console.ReadLine();

            int number = input.IndexOf(".");

            string output = input.Substring(number + 1);

            Console.WriteLine(output);


        }

        public static void hw06_string05()
        {
            // 5.輸入一個大於五個字的單字，
            // 若小於五個字輸出長度不夠，
            // 若大於五個字，則輸出前三個字。
            // Length  Substring()
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string05 => 輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。Length  Substring()\r\n");

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



        public static void hw06_string06()
        {

            // 6. 輸入一段字，輸出把輸入的一段字裡面的我，
            // 改成小明，如輸入我在唱歌，
            // 輸出小明在唱歌。
            // Replace()
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string06 => 輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()\r\n");

            string input = Console.ReadLine();

            input = input.Replace("我", "小明");

            Console.WriteLine("輸出的內容:" + input);


        }

        public static void hw06_string07()
        {
            // 7.輸入一串字，顯示輸入幾個字。Length
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string07 => 輸入一串字，顯示輸入幾個字。Length\r\n");


            Console.WriteLine("請輸入一串字");


            string input = Console.ReadLine();

            int inputLength = input.Length;

            Console.WriteLine("輸入了" + inputLength + "個字");


        }



        // ---------------------------------------------------------

        // 字串補充練習題

        public static void hw06_string_additional_01()
        {
            // 1.連續輸入10組字，若沒輸入過，
            // 就顯示沒出現過，若輸入過，就顯示輸入過。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string_additional_01 => 連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。");


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


        public static void hw06_string_additional_02()
        {
            // 2.用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出
            //Fifa
            //fIfa
            //fiFa
            //fifA
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string_additional_02 => 用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出\r\nFifa\r\nfIfa\r\nfiFa\r\nfifA");

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

        public static void hw06_string_additional_03()
        {
            // 3.輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string_additional_03 => 輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。");


            Console.WriteLine("請輸入時間: (格式 => 11:30 )");

            string input = Console.ReadLine();


            string[] inputArray = input.Split(':');


            Console.WriteLine($"輸出{inputArray[0]}點{inputArray[1]}分");


        }

        public static void hw06_string_additional_04()
        {

            // 4.輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出
            //< ul >
            //   < li > Justin </li>
            //   < li > Amy </li>
            //   < li > David </li>
            //</ ul >
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string_additional_04 => 輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出\r\n<ul>\r\n\t<li>Justin<li>\t\r\n\t<li>Amy<li>\r\n\t<li>David<li>\r\n</ul>");


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

        public static void hw06_string_additional_05()
        {

            // 5.輸入5處數字，用空白隔開，
            // 輸出結果。例如：輸入‘11 19 12 25 1 7 12，
            // 輸出總和是87
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string_additional_05 => 輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87\r\n");

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



        public static void hw06_string_additional_06()
        {
            // 6.輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_string_additional_06 => 輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ\r\n");

            string input = Console.ReadLine();

            char[] inputArray = input.ToCharArray();

            Array.Reverse(inputArray);

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i]);
            }


        }



        // ---------------------------------------------------------




        // 檔案題目
        public static void hw06_file01()
        {

            // 1.寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_file01 => 寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)");

            //指定檔案  lyrics.txt

            string path = @"C:\Users\Eason\Desktop\c_sharp\homework_rocket_backend\homework\file\lyrics.txt";

            string[] createLines =
                {

                "走廊灯关上 书包放 走到房间窗外望",
                "回想刚买的书 一本名叫半岛铁盒",
                "放在床边堆好多 第一页第六页第七页序",
                "我永远都想不到陪我看这书的你会要走",

                "不再是 不再有 现在已经看不到",
                "铁盒的钥匙孔 透了光 看见它锈了好久",
                "好旧好旧 外围的灰尘包围了我",
                "好暗好暗 铁盒的钥匙我找不到",

                "放在糖果旁的是 我很想回忆的甜",
                "然而过滤了你和我 沦落而成美",
                "沉在盒子里的是 你给我的快乐",
                "我很想记得可是我记不得",

                "为什么这样子 你拉著我 说你有些犹豫",
                "怎么这样子 雨还没停你就撑伞要走",
                "已经习惯不去阻止你 过好一阵子你就会回来",
                "印象中的爱情好像顶不住那时间",
                "为什么这样子 你看著我说你已经决定",
                "我拉不住你 他的手应该比我更暖",
                "铁盒的序变成了日记 变成了空气演化成回忆",
                "印象中的爱情好像顶不住那时间 所以你弃权",

                "走廊灯关上 书包放 走到房间窗外望",
                "回想刚买的书 一本名叫半岛铁盒",
                "放在床边堆好多 第一页第六页第七页序",
                "我永远都想不到陪我看这书的你会要走",

                "不再是 不再有 现在已经看不到",
                "铁盒的钥匙孔 透了光 看见它锈了好久",
                "好旧好旧 外围的灰尘包围了我",
                "好暗好暗 铁盒的钥匙我找不到",

                "放在糖果旁的是 我很想回忆的甜",
                "然而过滤了你和我 沦落而成美",
                "沉在盒子里的是 你给我的快乐",
                "我很想记得可是我记不得",

                "为什么这样子 你拉著我 说你有些犹豫",
                "怎么这样子 雨还没停你就撑伞要走",
                "已经习惯不去阻止你 过好一阵子你就会回来",
                "印象中的爱情好像顶不住那时间",

                "为什么这样子 你拉著我 说你有些犹豫",
                "怎么这样子 雨还没停你就撑伞要走",
                "已经习惯不去阻止你 过好一阵子你就会回来",
                "印象中的爱情好像顶不住那时间",
                "为什么这样子 你看著我说你已经决定",
                "我拉不住你 他的手应该比我更暖",
                "铁盒的序变成了日记 变成了空气演化成回忆",
                "印象中的爱情好像顶不住那时间 所以你弃权"

            };


            File.WriteAllLines(path, createLines, Encoding.UTF8);
            Console.WriteLine("寫入到 lyrics.txt 完成");





        }


        public static void hw06_file02()
        {
            // 讀取 1.txt 顯示在畫面上。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_file02 => 讀取 1.txt 顯示在畫面上");
            string path = @"C:\Users\Eason\Desktop\c_sharp\homework_rocket_backend\homework\file\1.txt";

            string[] read = File.ReadAllLines(path);

            foreach (string line in read)
            {
                Console.WriteLine(line);
            }



        }


        // ---------------------------------------------------------

        // 檔案處理補充練習題

        public static void hw06_file_additional_01()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_file_additional_01 => 寫入九九乘法表資料到一個文字檔到自己指定的文字檔。");


            // 先將九九乘法表資料的 string 做出來
            string output = "";

            int k = 1;

            while (k <= 7)
            {


                for (int i = 1; i <= 9; i++)
                {

                    for (int j = k; j <= k + 2; j++)
                    {
                        output += $"{j} x {i} = {i * j}\t";
                    }

                    output += "\r\n";
                }

                k = k + 3;

                output += "\r\n";

            }


            //Console.WriteLine(output);

            string path = @"C:\Users\Eason\Desktop\c_sharp\homework_rocket_backend\homework\file\9x9.txt";

            string createText = output;

            File.WriteAllText(path, output);

            Console.WriteLine("將九九乘法表資料寫入到 9x9.txt ");


        }


        public static void hw06_file_additional_02()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_file_additional_02 => 讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF-8)\r\n\r\n");

            string path = @"C:\Users\Eason\Desktop\c_sharp\homework_rocket_backend\homework\file\9x9.txt";


            string read = File.ReadAllText(path, Encoding.UTF8);

            //Console.WriteLine(read);

            // replace 將數字轉換成中文的數字 壹貳叁肆伍陸柒捌玖拾


            read = read.Replace("0", "零");
            read = read.Replace("1", "壹");
            read = read.Replace("2", "貳");
            read = read.Replace("3", "叄");
            read = read.Replace("4", "肆");
            read = read.Replace("5", "伍");
            read = read.Replace("6", "陸");
            read = read.Replace("7", "柒");
            read = read.Replace("8", "捌");
            read = read.Replace("9", "玖");

            Console.WriteLine(read);



        }


        public static void hw06_file_additional_03()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_file_additional_03 => 讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡");


            // 讀取 .csv 的檔案
            string path = @"C:\Users\Eason\Desktop\c_sharp\homework_rocket_backend\homework\file\fc4bb.csv";
            string pathHtml = @"C:\Users\Eason\Desktop\c_sharp\homework_rocket_backend\homework\file\output.html";

            string[] read = File.ReadAllLines(path);

            // 建立 StringBuilder 來儲存 HTML 表格內容
            StringBuilder htmlContent = new StringBuilder();

            // 建立 HTML 內容
            htmlContent.AppendLine("<!DOCTYPE html>");
            htmlContent.AppendLine("<html>");
            htmlContent.AppendLine("<head>");
            htmlContent.AppendLine("<title> csv 轉換成 html table</title>");
            htmlContent.AppendLine("<style>td{border:1px solid #000;}</style>");
            htmlContent.AppendLine("</head>");
            htmlContent.AppendLine("<body>");
            htmlContent.AppendLine("<table>");

            foreach (string line in read)
            {
                htmlContent.AppendLine("<tr>");

                // 分割每一行的資料以逗號為分隔符
                string[] cells = line.Split(',');

                foreach (string cell in cells)
                {
                    htmlContent.AppendLine($"<td>{cell}</td>");
                }


                htmlContent.AppendLine("</tr>");

            }



            htmlContent.AppendLine("</table>");
            htmlContent.AppendLine("</body>");
            htmlContent.AppendLine("</html>");

            // 將 HTML 內容儲存到指定的檔案
            File.WriteAllText(pathHtml, htmlContent.ToString());

            Console.WriteLine($"HTML 表格已儲存至 {pathHtml}");



        }


        // ---------------------------------------------------------

        // 亂數題目
        public static void hw06_random01()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_random01 => 請隨機由0~99產生一個數字輸出。");
            //Console.WriteLine("Random rom= new Random();//亂數種子");
            //Console.WriteLine("int I = rom.Next(0, 100);//回傳0-99的亂數\r\n");

            Random random1 = new Random();
            int random_number = random1.Next(0, 100);

            Console.WriteLine($"產出的是{random_number}");


        }


        public static void hw06_random02()
        {
            // 請隨機由0~99產生10個數字輸出。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_random02 => 請隨機由0~99產生10個數字輸出。\r\n\r\n");


            Random random2 = new Random();

            int[] numberArray = new int[10];

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = random2.Next(0, 99);
            }


            foreach (int i in numberArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("");


        }


        public static void hw06_random03()
        {
            // 隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_random03 => 隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。\r\n");

            // 假設有 10 位學生的數學成績跟國文成績

            string[] students = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

            Random random = new Random();


            string path = @"C:\Users\Eason\Desktop\c_sharp\homework_rocket_backend\homework\file\students.txt";

            string output = "";

            foreach (string student in students)
            {
                output += student + "，" + random.Next(0, 100) + "\r\n";

            }

            File.WriteAllText(path, output);

            Console.WriteLine("已寫入文字檔 => students.txt");



        }



        // ---------------------------------------------------------


        // 亂數補充題
        public static void hw06_random_additional_01()
        {
            // 請設計樂透開獎程式。
            // 大樂透 => 49 取 6 不可以重複
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_random_additional_01 => 請設計樂透開獎程式，從 49 個號碼取 6 個號碼，號碼不能重複");


            Random random1 = new Random();

            int number = random1.Next(1, 50);


            // 建立數字陣列 => 六個樂透號碼
            int[] numberArray = new int[6];

            int count = 6;
            int index = 0;

            while (index < count)
            {

                int newNumber = random1.Next(1, 50);

                // 使用 Array.Existis 去判斷陣列有無重複
                if (!Array.Exists(numberArray, num => num == newNumber))
                {
                    numberArray[index] = newNumber;
                    index++;
                }
            }


            string outputText = "";

            for (int i = 0; i < numberArray.Length; i++)
            {
                outputText += numberArray[i];

                if (i < numberArray.Length - 1)
                {
                    outputText += "，";
                }

            }


            Console.WriteLine($"樂透彩的號碼為: {outputText}");



        }


        public static void hw06_random_additional_02()
        {
            // 請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。
            // 讀取 restaruant.txt ，然後隨機抽出其中一間

            string path = @"C:\Users\Eason\Desktop\c_sharp\homework_rocket_backend\homework\file\restaurant.txt";

            string content = File.ReadAllText(path);

            //Console.WriteLine(content);

            // 這裡會有錯誤， 因為 \r\n 是轉義字符
            //string[] contentArray = content.Split("\r\n");
            string[] contentArray = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);



            foreach (string line in contentArray)
            {
                //Console.WriteLine(line);
            }


            // 使用 Random 去抽取 => 陣列的 index

            Random random1 = new Random();

            int chooseRestaurantIndex = random1.Next(0, contentArray.Length);


            string chooseRestaurant = contentArray[chooseRestaurantIndex];

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_random_additional_02 => 讀取文字檔  restaurant.txt ，隨機抽出今天中午要吃哪一家");

            Console.WriteLine($"從 restaurant.txt 抽取的餐廳是 {chooseRestaurant}");

        }


        public static void hw06_random_additional_03()
        {

            // 請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，
            // 隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
            // 使用 classmates.txt 的名單， 然後隨機抽取直到全部學員抽過，
            // 抽過的名單，會到 classmatesOnDuty.txt

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_random_additional_03");
            Console.WriteLine("請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，");
            Console.WriteLine("隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。");
            Console.WriteLine("使用 classmates.txt 的名單， 然後隨機抽取直到全部學員抽過，");
            Console.WriteLine("抽過的名單，會到 classmatesOnDuty.txt");


            // 取得學員清單
            string path = @"C:\Users\Eason\Desktop\c_sharp\homework_rocket_backend\homework\file\classmates.txt";

            string content = File.ReadAllText(path);


            //string[] contentArray = content.Split("\r\n");
            string[] contentArray = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string line in contentArray)
            {
                //Console.WriteLine(line);
            }

            // on duty 過的名單
            string path2 = @"C:\Users\Eason\Desktop\c_sharp\homework_rocket_backend\homework\file\clssmatesOnDuty.txt";

            string content2 = File.ReadAllText(path2);


            //string[] contentArray2 = content2.Split("\r\n");
            string[] contentArray2 = content2.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);


            foreach (string line in contentArray2)
            {
                //Console.WriteLine(line);
            }



            // 目標執行一次，抽一個值日生到 on duty 名單上

            // 先拿已經當過值日生的名單
            // 將所有的清單，將當過的拿掉再去隨機 ，
            // 如果所有人都當過值日生，就要跳出提示

            // 取得沒當過值日生的名單
            string[] filterClassmates = new string[contentArray.Length];

            int index = 0;


            for (int i = 0; i < contentArray.Length; i++)
            {

                bool inInside = false;


                // 檢查有沒有在第二個陣列裡面

                for (int j = 0; j < contentArray2.Length; j++)
                {
                    if (contentArray[i] == contentArray2[j])
                    {
                        inInside = true;
                    }
                }

                if (!inInside)
                {
                    filterClassmates[index] = contentArray[i];
                    index++;
                }

            }


            // 沒有當值日生的名單 => 需要篩選掉空元素的項

            // 使用 LINQ 篩選掉空元素
            filterClassmates = filterClassmates.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            // 輸出篩選後的陣列元素
            //Console.WriteLine("篩選後的陣列：");

            foreach (var item in filterClassmates)
            {
                //Console.WriteLine(item);
            }



            // 這邊判定 filterClassmates 都當過的時候，就直接 return 並且顯示已經都當過了
            if (filterClassmates.Length == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("讀取完 classmatesOnDuty.txt => 全部人都當過值日生了");
                return;
            }



            // 沒有當值日生的名單
            //Console.WriteLine("");
            //Console.WriteLine("沒有當值日生的名單");

            // 從全部陣列篩選掉已經當過值日生的清單
            foreach (string line in filterClassmates)
            {
                //Console.WriteLine(line);
            }


            // 從此陣列名單 Random 一位去加到 classmatesOnDuty.txt 上

            Random random = new Random();

            int randomClassmatesIndex = random.Next(0, filterClassmates.Length);
            string randomClassmate = filterClassmates[randomClassmatesIndex] + "\r\n";

            Console.WriteLine(" ");
            Console.WriteLine("抽到今天要當值日生的學生 " + randomClassmate);

            File.AppendAllText(path2, randomClassmate);


            Console.WriteLine("顯示已經當過值日生的學生");

            // 更新一下，加上 random 的那一位學生
            content2 = File.ReadAllText(path2);

            // 轉義字符的問題
            //contentArray2 = content2.Split("\r\n");
            contentArray2 = content2.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            // 顯示 on duty 的學生
            foreach (string line in contentArray2)
            {
                Console.WriteLine(line);
            }




        }


        // ---------------------------------------------------------


        // 日期題目
        public static void hw06_dateTime01()
        {
            // 顯示現在日期與時間。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_dateTime01 => 顯示現在日期與時間");

            DateTime now = DateTime.Now;

            Console.WriteLine("");
            Console.WriteLine($"今年是{now.Year}年{now.Month}月{now.Day}日，現在是{now.Hour}點{now.Minute}分{now.Second}秒");

        }


        public static void hw06_dateTime02()
        {

            // 顯示再過30天為哪一天
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_dateTime02 => 顯示再過30天為哪一天");
            Console.WriteLine("");


            DateTime now = DateTime.Now;

            DateTime next30days = now.AddDays(30);

            Console.WriteLine($"再過30天是{next30days.Year}年{next30days.Month}月{next30days.Day}日");

        }


        public static void hw06_dateTime03()
        {

            // 顯示24小時前的年月日時分秒。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_dateTime03 => 顯示24小時前的年月日時分秒。\r\n");
            Console.WriteLine("");


            DateTime now = DateTime.Now;

            DateTime past = now.AddDays(-1);

            Console.WriteLine($"顯示24小時前是{past.Year}年{past.Month}月{past.Day}日 {past.Hour}點{past.Minute}分{past.Second}秒");


        }


        public static void hw06_dateTime04()
        {


            // 取得目前是幾月。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_dateTime04 => 取得目前是幾月。\r\n");
            Console.WriteLine("");


            DateTime now = DateTime.Now;

            Console.WriteLine($"當前是{now.Month}月");

        }

        public static void hw06_dateTime05()
        {

            // 取得明年是否為閏年。(可以試試民國)
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_dateTime05 => 取得明年是否為閏年。(可以試試民國)");
            Console.WriteLine("");


            Console.WriteLine("請輸入民國年份，幫你判定是不是閏年");

            // 取得輸入的民國年份

            int yearByT = Convert.ToInt32(Console.ReadLine());

            int input = 1911 + yearByT;



            if (DateTime.IsLeapYear(input))
            {
                Console.WriteLine($"民國{yearByT}是閏年");
            }
            else
            {
                Console.WriteLine($"民國{yearByT}不是閏年");
            }



        }



        public static void hw06_dateTime06()
        {

            // 取得離2025年1月1日還有幾天。
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_dateTime06 => 取得離2025年1月1日還有幾天。\r\n");
            Console.WriteLine("");

            DateTime now = DateTime.Now;
            DateTime theDate = new DateTime(2025, 1, 1);


            int next = (int)(theDate - now).TotalDays;

            Console.WriteLine($"離2025年1月1日還有{next}天");


        }



        // ---------------------------------------------------------

        // 日期補充題
        public static void hw06_dateTime_additional_01()
        {

            //星期一，猴子穿新衣，
            //星期二，猴子肚子餓，
            //星期三，猴子去爬山，
            //星期四，猴子看電視，
            //呈期五，猴子去跳舞，
            //星期六，猴子去斗六，
            //星期日，猴子過生日。
            //請顯示今天猴子做甚麼事。

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_dateTime_additional_01 => 根據今天禮拜幾，顯示猴子要做什麼事情");
            Console.WriteLine("");


            DateTime now = DateTime.Now;
            DayOfWeek dayOfWeek = now.DayOfWeek;

            //Console.WriteLine(dayOfWeek);

            string doWhat = "";

            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    doWhat = "猴子過生日";
                    break;
                case DayOfWeek.Monday:
                    doWhat = "猴子穿新衣";
                    break;
                case DayOfWeek.Tuesday:
                    doWhat = "猴子肚子餓";
                    break;
                case DayOfWeek.Wednesday:
                    doWhat = "猴子去爬山";
                    break;
                case DayOfWeek.Thursday:
                    doWhat = "猴子看電視";
                    break;
                case DayOfWeek.Friday:
                    doWhat = "猴子去跳舞";
                    break;
                case DayOfWeek.Saturday:
                    doWhat = "猴子去斗六";
                    break;

                default:
                    break;
            }


            Console.WriteLine($"今天是 {dayOfWeek}，{doWhat}");


        }



        public static void hw06_dateTime_additional_02()
        {

            // 輸入‘兩個日期，輸出兩個日期相差幾天。

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_dateTime_additional_02 => 輸入‘兩個日期，輸出兩個日期相差幾天。\r\n");
            Console.WriteLine("");


            // 請輸入日期1
            Console.WriteLine("請輸入第一個日期(格式 => 2024/4/29)");

            string dateInput1 = Console.ReadLine();

            string[] dateInput1Array = dateInput1.Split('/');




            DateTime dateTimeInput1 = new DateTime(int.Parse(dateInput1Array[0]), int.Parse(dateInput1Array[1]), int.Parse(dateInput1Array[2]));

            //Console.WriteLine(dateTimeInput1);


            // 請輸入日期2
            //Console.WriteLine("請輸入第二個日期(格式 => 2024/4/29)");
            Console.WriteLine("請輸入第二個日期(格式 => 2024/4/29)");
            string dateInput2 = Console.ReadLine();
            string[] dateInput1Array2 = dateInput2.Split('/');

            DateTime dateTimeInput2 = new DateTime(int.Parse(dateInput1Array2[0]), int.Parse(dateInput1Array2[1]), int.Parse(dateInput1Array2[2]));


            //Console.WriteLine(dateTimeInput2);


            // 比較兩者差幾天 => 記得使用絕對值表示差了幾天

            int betweenDay = (int)(dateTimeInput2 - dateTimeInput1).TotalDays;

            Console.WriteLine($"{dateInput1}跟{dateInput2}，此兩天差了{Math.Abs(betweenDay)}天");


        }


        public static void hw06_dateTime_additional_03()
        {

            //  兩光法師時常替人占卜，由於他算得又快有便宜，
            //  因此生意源源不絕，時常大排長龍，他想算得更快一點，
            //  因此找了你這位電腦高手幫他用電腦來加快算命的速度。
            //  他的占卜規則很簡單，規則是這樣的，
            //  隨機產生一個今年日期，然後依照下面的公式：
            //  M = 月
            //  D = 日
            //  S = (M * 2 + D) % 3
            //  得到 S 的值，再依照 S 的值從 0 到 2 分別給與 普通、吉、大吉 等三種不同的運勢，輸出運勢。

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("hw06_dateTime_additional_03 => 兩光法師使用隨機產生一個今年日期，使用隨機日期算出運氣");
            Console.WriteLine("");

            DateTime now = DateTime.Now;

            // random date

            DateTime startDate = new DateTime(now.Year, 1, 1);
            //Console.WriteLine(startDate);


            // random
            Random randomNumber = new Random();

            // 加上 random day
            DateTime luckDate = startDate.AddDays(randomNumber.Next(366));

            Console.WriteLine($"隨機的日期是 {luckDate}");



            // 公式

            //  M = 月
            //  D = 日
            //  S = (M * 2 + D) % 3
            //  得到 S 的值，再依照 S 的值從 0 到 2 分別給與 普通、吉、大吉 等三種不同的運勢，輸出運勢。

            int M = luckDate.Month;
            int D = luckDate.Day;
            int S = (M * 2 + D) % 3;


            switch (S)
            {
                case 0: Console.WriteLine("運勢:普通"); break;
                case 1: Console.WriteLine("運勢:吉"); break;
                case 2: Console.WriteLine("運勢:大吉"); break;
                default: break;
            }

            Console.ReadKey();


        }


        // ---------------------------------------------------------



        static void Main(string[] args)
        {
            // String 題目
            hw06_string01();
            hw06_string02();
            hw06_string03();
            hw06_string04();
            hw06_string05();
            hw06_string06();
            hw06_string07();

            // 字串補充練習題
            hw06_string_additional_01();
            hw06_string_additional_02();
            hw06_string_additional_03();
            hw06_string_additional_04();
            hw06_string_additional_05();
            hw06_string_additional_06();

            // 檔案題目
            hw06_file01();
            hw06_file02();

            // 檔案處理補充練習題
            hw06_file_additional_01();
            hw06_file_additional_02();
            hw06_file_additional_03();

            // 亂數題目
            hw06_random01();
            hw06_random02();
            hw06_random03();

            // 亂數補充題
            hw06_random_additional_01();
            hw06_random_additional_02();
            hw06_random_additional_03();


            // 日期題目
            hw06_dateTime01();
            hw06_dateTime02();
            hw06_dateTime03();
            hw06_dateTime04();
            hw06_dateTime05();
            hw06_dateTime06();


            // 日期補充題
            hw06_dateTime_additional_01();
            hw06_dateTime_additional_02();
            hw06_dateTime_additional_03();


        }
    }
}
