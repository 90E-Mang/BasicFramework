using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // 제어문과 연산자 같이 연습

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"i : {i}");
            //}

            // 아래의 방식은 잘 사용하지 않는 방식이다. i를 한번 밖에 못쓰니까 그냥 for문 안에다 선언하자
            //int i;
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"i : {i}");
            //} // for문이 끝나도 바깥에 i가 선언되어있기 때문에, i가 10인 상태로 빠져나옴
            //
            //Console.WriteLine(i);       // 그래서 여기서 찍으면 10이 나옴.   

            // 이런식으로 쓰자
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i : {i}");
            }

            for(int i = 2; i < 10; i++)
            {
                //Console.WriteLine($"구구단 {i}단");
                for(int j = 1; j < 10; j++)
                {
                    if (i == j) break;  // 현 제어구문을 탈출
                    //Console.Write($"{i} x {j} = {i*j}\t");
                    Console.Write("*");
                }
                Console.WriteLine(); //  엔터 !
            }

            for (int i = 2; i < 10; i++)
            {
                //Console.WriteLine($"구구단 {i}단");
                for (int j = 1; j < 10; j++)
                {
                    if (i == j) continue; // continue는 아래 문장을 skip하라
                    Console.Write($"{i} x {j} = {i*j}\t");
                    //Console.Write("*");
                }
                Console.WriteLine(); //  엔터 !
            }

            int result;
            Console.WriteLine("숫자값을 입력하세요 : ");
            result = int.Parse(Console.ReadLine()); // int형으로(정수값으로) 변환

            switch (result)
            {
                case 1: Console.WriteLine(result);
                    break;
                case 2: Console.WriteLine(result);
                    break;
                case 3: Console.WriteLine(result);
                    break;
                case 4: Console.WriteLine(result);
                    break;
                case 5: Console.WriteLine(result);
                    break;
                default: Console.WriteLine("nothing");
                    break;
            }

            // 1~100까지 합을 구하세여
            // while(조건){ } 
            int kk = 1;
            int kksum = 0; // 지역번수 사용전에 반드시 초기화 !!!
            while (kk <= 100)
            {
                kksum += kk;
                // 반드시 내부에서 증가감을 처리해야됨 !!
                kk++;
            }

            Console.WriteLine($"누적합 : {kksum}, kk = {kk}");

            // 1 ~ 100 까지 홀수 합
            int jj = 2;
            int jjsum = 0;
            while (jj <= 100)
            {
                if (jj % 2 == 0)
                {
                    jjsum += jj;
                }
                jj++;
            }
            Console.WriteLine($"누적합 : {jjsum}, jj = {jj}");

            int odd = 1;
            int oddsum = 0;
            while (odd <= 100)
            {
                if (odd % 2 == 0)
                {
                    odd++;
                    continue; // 아래쪽 skip 구문 !!
                }
                oddsum += odd;
                odd++;
            }
            Console.WriteLine($"홀수합 : {oddsum}, odd = {odd}");

            int Even = 0;
            int Odd = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Even += i;
                }
                else
                {
                    Odd += i;
                }
            }
            Console.WriteLine($"짝수 : {Even}, 홀수 : {Odd}");

            Console.Write("사용자 ID : ");
            string id = Console.ReadLine();
            Console.Write("사용자 PW : ");
            string pwd = Console.ReadLine();

            // &&, 연산자의 강점 -> 일단 연산이 빠르다(앞 조건의 false면 뒤 조건은 확인도 안함!)
            // if(i < 10 && j < 20 && k < 100.....)
            // if(i < 10 || j < 20 || k < 100.....)

            if (id == "admin" && pwd == "1234") // id부터 false 면 무조건 false 뒤에꺼는 보지도 않음.
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("넌 누구냐 !");
            }

            if ('A' != 65) // 'A'가 정수 65랑 다르냐?
            {
                // ㅇㅇ 다름(true)
                Console.WriteLine("True");
            }
            else
            {
                // ㄴㄴ 같은거임(false)
                Console.WriteLine("False");
            }

            // 연산자 중에서 암기(Today Point) : 삼항연산자

            int p2 = 10;
            int k2 = -10;

            int result2 = (p2 == k2) ? p2 : k2;
            Console.WriteLine($"result2 = {result2}");

            if (p2 == k2)
            {
                result2 = p2;
            }
            else
            {
                result2 = k2;
            }
            Console.WriteLine($"result2 = {result2}");

            int x1 = 3;
            int x2 = 5;

            // 비트 연산
            // 10진수 3을 2진수로 
            // 128  64  32  16  8  4  2  1      (2의 배수)
            //                  0  0  1  1      (10진수 3의 2진수값)
            //                  0  1  0  1      (10진수 5의 2진수값)
            // AND              0  0  0  1      (3과 5의 AND 연산)      > 10진수로? > 1
            // OR               0  1  1  1      (3과 5의 OR 연산)       > 10진수로? > (1+2+4) > 7
            Console.WriteLine($"x1 & x2 = {(x1&x2)}");      // 1
            Console.WriteLine($"x1 | x2 = {(x1 | x2)}");    // 7

            for (int i = 65; i < 91; i++)
            {               
                if (Convert.ToChar(i) == 'F') Console.WriteLine();
                if(Convert.ToChar(i) == 'K') Console.WriteLine();
                if(Convert.ToChar(i) == 'P') Console.WriteLine();
                if (Convert.ToChar(i) == 'U') Console.WriteLine();
                Console.Write(Convert.ToChar(i) + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < 101; i++)
            {
                if (i % 10 != 0)
                {
                    Console.Write(i + " ");
                }
                else if (i % 10 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    if (i + j == 6)
                    {
                        Console.WriteLine($"{i}와 {j}의 합은 6입니다.");
                    }
                }
            }
            Console.WriteLine("직각삼각형 1,3,5,7,9 별찍기");
            for (int i = 2; i < 11; )
            {
                for (int j = 1; j < 11; j++)
                {
                    if (i == j) break;
                    Console.Write("*");
                }
                Console.WriteLine();
                i += 2;
            }

            Console.WriteLine("역삼각형 10,8,6,4,2 별찍기");
            for (int i = 11; i > 2;)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (i == j) break;
                    Console.Write("*");
                }
                Console.WriteLine();
                i -= 2;
            }

            Console.WriteLine("1,3,5,7,9,7,5,3,1 다이아몬드 만들기");

            for (int i = 1; i <= 10; i++)
            {
                if (i <= 5)
                {
                    for (int j = 0; j <= 5 - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int z = 1; z <= i * 2 - 1; z++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else if (i > 5)
                {
                    for (int j = 0; j < (i - 5) + 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int z = 10; z > (i - 5) * 2 + 1; z--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("입력받은 수 만큼 별그리기");
            int input;
            Console.Write("반복 횟수를 입력하세요 :");
            input = int.Parse(Console.ReadLine());
            if (input <= 0)
            { Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다."); }
            else
            {
                for (int i = 0; i < input; i++)
                {
                    for (int j = 0; j < input; j++)
                    {
                        Console.Write("*");
                        if (j == i) break;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
