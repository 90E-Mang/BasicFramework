using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_String_Function_Quiz
{
    // 주민번호 뒷 첫자리 1,3 -> 남자 2,4 여자라고 출력
    // main 함수 주민번호 입력받고
    // 입력값 : 123456-1234567

    // 함수 3개를 static
    // 1. 자리수 체크(기능)함수 (14 ok), return true, false
    // 2. 뒷번호 첫번째 자리값 1~4까지의 값만 혀용 기능 함수 return true false
    // 3. 뒷번호 첫번째 자리 값을 가지고 1,3 남자, 2,4 여자 출력 기능함수 void 출력
    class Program
    {
        static void juminDisplay(string ssn)
        {
            switch (Convert.ToInt32(ssn[7].ToString()))
            {
                case 1:
                case 3:
                    Console.WriteLine("남자");
                    break;
                case 2:
                case 4:
                    Console.WriteLine("여자");
                    break;
            }               
        }
        static bool juminFirstNumber(string str)
        {
            if (Convert.ToInt32(str[7].ToString()) == 0)
            {
                return false;
            }
            return Convert.ToInt32(str[7].ToString()) > 5 ? false : true;
        }
        static bool juminCheck(string str)
        {
            return str.Length == 14 ? true : false;
        }
        static void Main(string[] args)
        {
            bool chk = true;
            while (chk)
            {
                Console.Write("주민등록번호를 입력해주세요. : ");
                string input = Console.ReadLine();

                chk = juminCheck(input);
                if (input.Length == 14)
                {
                    chk = juminFirstNumber(input);
                    if (chk == true)
                    {
                        Console.WriteLine("정상입력");
                    }
                    else
                    {
                        Console.WriteLine("입력오류");
                    }
                    juminDisplay(input);
                }
                else
                {
                    Console.WriteLine("입력오류");
                }
                         
            }
            Console.WriteLine("프로그램 종료.");
        }
    }
}
