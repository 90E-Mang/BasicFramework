using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Statement2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 간단한 학점 계산기
            // 학점 : A+ A- B+ B- .....F
            // 데이터는 입력받기

            // 판단기준1 : 90점 이상 >> A.... 70점 이상 C 나머지 F
            // 판단기준2 : 95점 이상이다? A+, 아니면 A-
            // 결과 출력

            // 학점계산 로직

            Console.Write("성적을 입력해주세요 : ");
            int score = int.Parse(Console.ReadLine());
            string grade = "";

            if (score >= 90)
            {
                grade = "A";
                grade = (score >= 95) ? (grade += "+") : (grade += "-");    // if를 삼항으로 처리
            }
            else if (score >= 80)                                           // 삼항연산자 말고 이중 if else로 처리
            {
                grade = "B";
                if (score >= 85)
                {
                    grade += "+";
                }
                else
                {
                    grade += "-";
                }
            }

            int m = 3;
            string r = "";
            switch (m)
            {
                case 1:
                case 3:
                    r = $"{m}월 입니다.";
                    Console.WriteLine("31");
                    break;
                case 5:
                case 7:
                default:
                    r = "월 데이터가 아닙니다";
                    break;
            }
            Console.WriteLine(r);

            // 함수().함수().함수() <- 함수 chain 책 112~3 페이지에 있는 PadLeft() 참고
            // 함수(함수(함수())) 무식한 방법... 나 이렇게햇는데..ㅠ
            // C#에서 === 은 없다. 이건 javascript에 있다 ! 값하고 타입하고 다 비교하는 강력한 연산자임.

            // switch case로 한거
            //Console.Write("성적을 입력해주세요 : ");
            //int score = int.Parse(Console.ReadLine());
            //if (score > 100 || score < 0)
            //{
            //    Console.WriteLine("0 ~ 100 까지의 숫자만 입력 가능합니다.");
            //    return;
            //}
            //switch (score/10)
            //{
            //    case 10:
            //        Console.WriteLine($"점수는 {score}점, 학점은 A+ 입니다.");
            //        break;
            //    case 9:
            //        if (score > 94)
            //        {
            //            Console.WriteLine($"점수는 {score}점, 학점은 A+ 입니다.");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"점수는 {score}점, 학점은 A- 입니다.");
            //            break;
            //        }
            //    case 8:
            //        if (score > 84)
            //        {
            //            Console.WriteLine($"점수는 {score}점, 학점은 B+ 입니다.");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"점수는 {score}점, 학점은 B- 입니다.");
            //            break;
            //        }
            //    case 7:
            //        if (score > 74)
            //        {
            //            Console.WriteLine($"점수는 {score}점, 학점은 C+ 입니다.");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"점수는 {score}점, 학점은 C- 입니다.");
            //            break;
            //        }
            //    default:
            //        Console.WriteLine($"점수는 {score}점, 학점은 F 입니다. 재수강 ㅊㅊㅊ");
            //        break;
            //
            //}
        }
    }
}
