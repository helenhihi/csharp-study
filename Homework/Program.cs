using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//2-1 문제
            Console.WriteLine("Hello C#");
            Console.Write("10+10 ");
            Console.WriteLine("=20");
            Console.WriteLine("C#의 세계에 오신 것을 환영합니다.");
            Console.WriteLine("감사합니다.");

            //68p. 3-1문제 심화문제
            int boxWidth = 286;
            double pi = 3.141592;
            string handWriting = "문자열도 있음";
            Console.WriteLine(boxWidth);
            Console.WriteLine(pi);
            Console.WriteLine(handWriting);

            //4-1 문제
            Console.WriteLine(10 + 5);
            Console.WriteLine(20 - 10);
            Console.WriteLine(4 * 7);
            Console.WriteLine(20 / 7);
            Console.WriteLine(20 % 7);

            //4-2 문제
            Console.WriteLine("안녕" + "하세요");

            //100p. 4-1문제 심화문제
            int number = 2;
            number = number * 3;
            number = number - 4;
            number = number % 2;
            Console.WriteLine(number);

            //100p. 4-2문제 심화문제
            int pocketMoney = 10;
            int aramMoney;
            int woramMoney;
            int remainMoney;

            aramMoney = pocketMoney / 2 - 1;       //4
            remainMoney = pocketMoney - aramMoney; //6

            woramMoney = remainMoney / 2 + 2;       //5
            remainMoney = remainMoney - woramMoney; //1

            Console.WriteLine(aramMoney);           //4
            Console.WriteLine(woramMoney);          //5
            Console.WriteLine(remainMoney);         //1

            //124p. 5-1문제 심화문제
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            string userInput1 = Console.ReadLine();
            double number1 = double.Parse(userInput1);
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            string userInput2 = Console.ReadLine();
            double number2 = double.Parse(userInput2);

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / number2);

            //124p. 5-3문제 심화문제
            int money = 10;
            Console.WriteLine("주머니에는 동전이 {0}개 들어 있습니다.", money);

            Console.WriteLine("어머니는 몇 개의 동전을 주머니에 넣었나요?");
            int motherMoney = int.Parse(Console.ReadLine());
            Console.WriteLine("아람이는 몇 개의 동전을 꺼냈나요?");
            int AramMoney = int.Parse(Console.ReadLine());
            Console.WriteLine("우람이는 몇 개의 동전을 꺼냈나요?");
            int WoramMoney = int.Parse(Console.ReadLine());

            Console.WriteLine("주머니에 남아 있는 동전의 개수는 {0}개 입니다.", money + motherMoney - AramMoney - WoramMoney);

            //164p. 6-2문제 심화문제
            Console.WriteLine("숫자를 입력하세요.");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput > 20 && (userInput % 3 == 0))
            {
                Console.WriteLine("20보다 큰 3의 배수입니다.");
            }

            //195p. 7 - 2문제 심화문제
            string[] subjects = { "국어", "영어", "수학", "과학", "사회" };
            int[] scores = new int[5];

            Console.Write(subjects[0]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[0] = int.Parse(Console.ReadLine());

            Console.Write(subjects[1]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[1] = int.Parse(Console.ReadLine());

            Console.Write(subjects[2]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[2] = int.Parse(Console.ReadLine());

            Console.Write(subjects[3]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[3] = int.Parse(Console.ReadLine());

            Console.Write(subjects[4]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("다섯 과목의 총 점수는 {0} 점입니다.", scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine("다섯 과목의 평균 점수는 {0} 점입니다.", (scores[0] + scores[1] + scores[2] + scores[3] + scores[4]) / 5);

            //236p. 8-2문제 심화문제
            Console.WriteLine("총학생 수를 입력하세요.");
            int studentNumbers = int.Parse(Console.ReadLine());

            string[] subjects = { "국어", "영어", "수학" };
            int[] scores = new int[studentNumbers];
            int index = 0;
            int total = 0;

            while (index < studentNumbers)
            {
                Console.Write(subjects[index]);
                Console.WriteLine(" 점수를 입력하세요.");
                scores[index] = int.Parse(Console.ReadLine());
                total = total + scores[index];
                index = index + 1;
            }

            Console.Write("총점은 ");
            Console.Write(total);
            Console.WriteLine("점 입니다.");

            Console.Write("평균은 ");
            Console.Write(total / studentNumbers);
            Console.WriteLine("점 입니다.");


            //276p. 9-2문제 심화문제
            int classroomLength = 5;
            int students = 10;
            int sum = 0;
            int average = 0;

            for (int i = 0; i < classroomLength; i++)
            {
                sum = 0;

                for (int j = 0; j < students; j++)
                {
                    int score = int.Parse(Console.ReadLine());
                    sum = sum + score;
                }
                average = sum / students;
                Console.Write(average);
            }*/

























            /*//308p. 10-1문제 심화문제
            Random random = new Random();

            int number = random.Next(1, 101);

            while (true)
            {
                Console.WriteLine("> 숫자를 입력하세요.");
                int guess = int.Parse(Console.ReadLine());

                if (number < guess)
                {
                    Console.WriteLine("더 작은 숫자입니다.");
                }

                if (number > guess)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                }

                if (number == guess)
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
            }*/
            /*
                        //308p. 10-2문제 심화문제
                        Random random = new Random();

                        int 가위 = 1;
                        int 바위 = 2;
                        int 보 = 3;
                        bool bUserWinner = false;

                        int computer = random.Next(1, 4);

                        while (true)
                        {
                            Console.WriteLine("> 1(=가위), 2(=바위), 3(=보) 중에 하나의 숫자를 고르세요.");
                            int user = int.Parse(Console.ReadLine());

                            if (user <= 0 || 3 < user)
                            {
                                continue;
                            }

                            if (computer - user == 2 )
                            {
                                bUserWinner = true;
                            }

                            if (user > computer && computer - user != -2)
                            {
                                bUserWinner = true;
                            }

                            if (bUserWinner)
                            {

                            }
                            else
                            {

                            }


                            if (number < guess || guess == 가위 && number == 보 || guess == 바위 && number == 가위 || guess == 보 && number == 바위)
                            { 
                                Console.WriteLine("이겼습니다.");
                                Console.WriteLine("컴퓨터: " + number);
                                break;
                            }

                            if (number == guess)
                            { 
                                Console.WriteLine("비겼습니다.");
                                Console.WriteLine("컴퓨터: " + number);*/
            /*     }
             }
 */


        }
    }
}



