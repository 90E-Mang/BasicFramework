using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Statement3
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            // do ~ while
            // 의무(강제) 선행되서 실행...

            int inputdata = 0;

            do
            {
                Console.Write("숫자를 입력해 주세요(0~9) : ");
                inputdata = int.Parse(Console.ReadLine());
            } while (inputdata >= 10); // 조건이 true -> do문을 계속 실행
                                       // 조건이 false -> 탈출
            Console.WriteLine($"당신이 입력한 숫자는 : {inputdata}");


            // 아주 간단한 피보나치 수열
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < 10; i++)
            {
                a = b;
                b = c;
                c = a + b;
                // Console.WriteLine($"{a},{b},{c}");
                Console.WriteLine($"{c}");

                // java 개발자 C# 개발시 나오는 질문 Top10 중에 한가지
                // java에서는 "==" 비교가 주소값 비교, 문자열은 값이 중요 >> 그래서 equals() 통해 값을 비교
                // C#은 == 문자열 비교에서 사용 가능 !
                string opr = "+";
                if (opr == "+")
                {
                    Console.WriteLine("같은 문자열");
                }
            }
        }
    }
}
