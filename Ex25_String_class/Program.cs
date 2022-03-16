using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_String_class
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "가";
            string b = "나";
            string c = a + b;
            Console.WriteLine($"C : {c}");

            string[] strarr = new string[] {"가","나","다","라","마" };

            foreach (string to in strarr)
            {
                Console.WriteLine($"to : {to}");
            }

            // 주의사항 : string은 int, double 처럼 사용하면 된다.(값타입 처럼)

            string str = "가나다라마가나";
            int loc = str.IndexOf("다");
            Console.WriteLine($"loc : {loc}");

            int lastloc = str.LastIndexOf("가");
            Console.WriteLine($"lastloc : {lastloc}");

            string strinsert = str.Insert(2,"H");
            Console.WriteLine($"Insert : {strinsert}");

            string strremove = str.Remove(0,3);
            Console.WriteLine($"Remove : {strremove}");

            string strreplace = str.Replace("라", "new");
            Console.WriteLine($"strreplace : {strreplace}");

            string strsubstring = str.Substring(0,1);   // 0,0을 넣으면 아무일도 일어나지 않는다 0,1을 써야 자기자신값
            Console.WriteLine($"substring : {strsubstring}");

            // 문제
            string super = "슈퍼맨/팬티.노랑색/우하하-우하하";
            // 슈퍼맨 팬티 노랑색 우하하 우하하 이 각각을 따로 추출 --> Split

            char[] ch = new char[] {'/','.','-' };
            string[] strarray = super.Split(ch);

            foreach (var temp in strarray)
            {
                Console.WriteLine($"super array : {temp}");
            }

            int sum = 0;
            string[] numarr = {"1","2","3","4","5" };
            // 문제1) : 배열에 있는 문자값들의 합을 sum 변수에 담아서 출력; 결과 : 15

            for (int i = 0; i < numarr.Length; i++)
            {
                sum += Convert.ToInt32(numarr[i]);
            }
            Console.WriteLine($"sum : {sum}");

            string jumin = "123456-1234567";
            int sum2 = 0;
            //문제2) 주민번호의 합을 구하세요.(string은 char[] 이다)
            // hint) jumin[i] >> return char >> 정수 >> 문자열 >> 정수
            string[] juminsplit = jumin.Split('-');
            for (int i = 0; i < jumin.Length; i++)
            {
                if (jumin[i].ToString() == "-")
                {
                    continue;
                }
                sum2 += int.Parse(jumin[i].ToString());
            }

            #region<듣기만하고 기억에서 삭제 !>

            string strA = "hello";
            Console.WriteLine(strA.GetHashCode());

            string strB = "hello";
            Console.WriteLine(strB.GetHashCode());
            // 같은 주소

            string strC = strA;
            Console.WriteLine(strC.GetHashCode());
            //////////////////////////////////////

            strC = "World";
            Console.WriteLine(strC.GetHashCode());

            string strD = "가";
            Console.WriteLine(strD.GetHashCode());
            strD += "나";
            Console.WriteLine(strD.GetHashCode());
            strD += "다";
            Console.WriteLine(strD.GetHashCode());
            strD += "라";
            Console.WriteLine(strD.GetHashCode());
            strD += "마";
            Console.WriteLine(strD.GetHashCode());

            Console.WriteLine($"strD : {strD}");


            // why ? 문자열의 누적 >> string 으로 하면 병신짓
            // 문자열 누적할때는 얘를 써보자
            StringBuilder sb = new StringBuilder();
            sb.Append("가");
            sb.Append("나");
            sb.Append("다");

            // 문자열의 누적 (데이터 양 많은 경우)

            #endregion
        }
    }
}
