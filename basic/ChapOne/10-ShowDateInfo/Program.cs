using System;
using System.Text;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowDateInfo();
        }

        static void ShowDateInfo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Your's date:");
            String yourDate = Console.ReadLine();

            try
            {
                DateTime parseDate = DateTime.Parse(yourDate);
                Console.WriteLine("Năm: " + parseDate.Year);
                Console.WriteLine("Tháng: " + parseDate.Month);
                Console.WriteLine("Thứ: " + parseDate.DayOfWeek);
            }
            catch (Exception)
            {
                Console.WriteLine("Giá trị nhập không hợp lệ");
            }
        }

        static void ATM()
        {
            // Số tiền ATM không có giới hạn
            // Input: 100.000(chia hết cho 10000)
            // Output: Số tờ tiền ít nhất
            Console.OutputEncoding = Encoding.UTF8;

            // Định nghĩa mệnh giá các tờ tiền
            const int FIVE_HUNDRED_THOUSAND = 500000;
            const int TWO_HUNDRED_THOUSAND  = 200000;
            const int ONE_HUNDRED_THOUSAND  = 100000;
            const int FIFTY_THOUSAND        = 50000;
            const int TWEENTY_THOUSAND      = 20000;
            const int TEN_THOUSAND          = 10000;

            // Số lượng các tờ tiền
            int fiveHundredThousand = 0;
            int twoHundredThousand  = 0;
            int oneHundredThousand  = 0;
            int fiftyThousand       = 0;
            int tweentyThousand     = 0;
            int tenThousand         = 0;

            int money = 0;

            do
            {
                Console.WriteLine("Your's money: ");
                money = Convert.ToInt32(Console.ReadLine());
            } while (money % 10000 != 0);

            // Số tờ tiền 500000
            GetValue(ref money, FIVE_HUNDRED_THOUSAND, ref fiveHundredThousand);
            // Số tờ tiền 200000
            GetValue(ref money, TWO_HUNDRED_THOUSAND, ref twoHundredThousand);
            // Số tờ tiền 100000
            GetValue(ref money, ONE_HUNDRED_THOUSAND, ref oneHundredThousand);
            // Số tờ tiền 50000
            GetValue(ref money, FIFTY_THOUSAND, ref fiftyThousand);
            // Số tờ tiền 20000
            GetValue(ref money, TWEENTY_THOUSAND, ref tweentyThousand);
            // Số tờ tiền 10000
            GetValue(ref money, TEN_THOUSAND, ref tenThousand);
        }

        private static void GetValue(ref int money, int moneyValue,ref int totalValue)
        {
            if (money >= moneyValue)
            {
                totalValue = money / moneyValue;
                money = money % moneyValue;
                Console.WriteLine("Mệnh giá {0} có {1} tờ", String.Format("{0:n0}", moneyValue), totalValue);
            }
        }

        static void Study()
        {
            // Tham trị: Kết thúc hàm, biến vẫn giữ giá trị ban đầu
            // Tham chiếu: Kết thúc hàm, biến thay đổi giá trị ban đầu
                // ref: Biến phải có giá trị ban đầu
                // out: Biến không cần xác định giá trị ban đầu, nhưng trong hàm phải gán lại giá trị cho biến
            Console.OutputEncoding = Encoding.UTF8;
            int number = 5;
            Console.WriteLine("Trước: " + number);
            SumSimple(ref number);
            Console.WriteLine("Sau: " + number);
        }

        private static void SumSimple(ref int number)
        {
            Console.OutputEncoding = Encoding.UTF8;
            number += 10;
            Console.WriteLine("Trong: " + number);
        }

        static void SecretNumber()
        {
            Console.OutputEncoding = Encoding.UTF8;

            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 12;
            const int TOTAL_PLAY = 2;
            int yourNumber = 0;
            int score = 0;

            Random rand = new Random();
            int secretNumber = rand.Next(MIN_NUMBER, MAX_NUMBER + 1);

            while (yourNumber != secretNumber)
            {
                Console.WriteLine("Your's Number ({0}-{1}):", MIN_NUMBER, MAX_NUMBER);
                yourNumber = Convert.ToInt32(Console.ReadLine());

                if (yourNumber > secretNumber)
                {
                    Console.WriteLine("Số bạn nhập lớn hơn số bí mật");
                }
                else if (yourNumber < secretNumber)
                {
                    Console.WriteLine("Số bạn nhập bé hơn số bí mật");
                }
                else
                {
                    Console.WriteLine("Successful");
                }
                score++;
                if (score == TOTAL_PLAY)
                {
                    Console.WriteLine("Bạn thua rồi");
                    break;
                }
            }

            Console.WriteLine("Score: " + score);
            Console.WriteLine("secretNumber: " + secretNumber);
        }

        static void ShapeOne()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //*
            //**
            //***
            //****

            int height = 10;
            for (int i = 1; i <= height; i++)
            {
                String character = (i % 2 == 1) ? "*" : "+";
                PrintCharacterOnLine(character, i);
                Console.WriteLine();
            }
        }
        private static void PrintCharacterOnLine(string character, int totalCharacter)
        {
            for (int j = 1; j <= totalCharacter; j++)
            {
                Console.Write(character);
            }
        }

        static void Caculator()
        {
            int numberFirst;
            int numberSecond;
            int result = 0;
            String caculate;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số thứ nhất: ");
            numberFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập vào số thứ hai: ");
            numberSecond = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập vào phép toán: ");
            caculate = Console.ReadLine();

            switch (caculate)
            {
                case "+":
                    result = numberFirst + numberSecond;
                    break;
                case "-":
                    result = numberFirst - numberSecond;
                    break;
                case "x":
                case "X":
                case "*":
                    result = numberFirst * numberSecond;
                    break;
                case ":":
                case "/":
                    result = numberFirst/numberSecond;
                    break;
                default:
                    caculate = "+";
                    result = numberFirst + numberSecond;
                    break;
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("{0} {1} {2} = {3}", numberFirst, caculate, numberSecond, result);
        }

        static void Avg()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int numberTotal = 0;
            int numberStart = 1;
            int numberSum = 0;

            Console.WriteLine("Nhập vào tổng số con số muốn tính giá trị trung bình: ");
            numberTotal = Convert.ToInt32(Console.ReadLine());

            while (numberStart <= numberTotal)
            {
                Console.WriteLine("Nhập vào số thứ {0}: ", numberStart);
                numberSum += Convert.ToInt32(Console.ReadLine());
                numberStart++;
            }
            Console.WriteLine("Giá trị trung bình là {0} : ", (double)numberSum/numberTotal);
        }

        static void ExeBCCThree()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int numberStart = 0;

            Console.WriteLine("Enter your age:");
            try
            {
                numberStart = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                numberStart = 2;
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numberStart, i, numberStart * i);
            }
        }

        static void ExeBCCTwo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Console.Write("{0} x {1} = {2} \t", j, i, i*j);
                }
                Console.WriteLine();
            }
        }

        static void ExeBCCOne()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, i*j);
                }
                Console.WriteLine("----------------------------");
            }
        }

        static void ExeMaxNumber()
        {
            int numberOne = 285;
            int numberTwo = 125;
            int numberThree = 185;
            int numberFour = 325;

            int maxNumber = Math.Max(Math.Max(numberOne, numberTwo), Math.Max(numberThree, numberFour));

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Trong 4 số {0} - {1} - {2} - {3}, thì số lớn nhất là {4}"
                                , numberOne, numberTwo, numberThree, numberFour, maxNumber);
        }

        static void ExeFilm()
        {
            // age
            // >= 16 Được xem phim Titanic
            // < 16 Không được xem phim Titanic
            int age = 16;
            String filmName = "Titanic";
            String result = (age < 16) ? "Không được xem phim" : "Được xem phim";

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(result + " " + filmName);
        }
    }
}
