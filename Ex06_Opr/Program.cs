using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Opr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 연습 Main 함수 안에서 작업
            Console.WriteLine(100+200);     // 숫자 : 산술연산
            Console.WriteLine("100"+"100"); // 문자열 : 결합연산(연결연산)
            Console.WriteLine("100"+100);   // 숫자 + 문자열 : 결합연산(연결연산) 숫자를 문자로 변환함.

            int i = 10; // 지역변수 항상 초기화
            int j;
            j = i++;    // 후치증가(후증가)
            Console.WriteLine("i : {0}, j : {1}", i,j); // i는 11, j는 10이 됨.

            j = ++i;    // 전치증가(선증가)
            Console.WriteLine("i : {0}, j : {1}", i, j);// i는 12가 되고 이걸 12에 할당

            //이렇게 혼자 쓰면 별 의미 없음 전, 후치 동일
            int k = 100;
            k++;
            ++k;

            int sum = 0;
            int s2 = 100;
            //sum = sum + s2; // sum이 2번...
            sum += s2;//  위에꺼를 줄이면 이렇게 됨.

            int ysum;
            int y = 10;
            ysum = y++ + 10;
            Console.WriteLine($"y : {y}, ysum : {ysum}");

            int a = 10;
            int b = 20;
            if (a > 5 && b > 10)    // true && ture &&연산자는 둘다 true 여야 true
            {
                Console.WriteLine("true");
            }
            /*
             *  SQL 언어
             *  select * from emp where sal > 1000 and job = 'IT'
             *  
             *  select * from emp where sal > 1000 or job = 'IT'
             *  
             *  0  1 조합
             *              and         or
             *  0  0        0(false)    0(false)
             *  0  1        0           1(true)
             *  1  0        0           1(true)
             *  1  1        1(true)     1(true)
             * 
             */
        }
    }
}
