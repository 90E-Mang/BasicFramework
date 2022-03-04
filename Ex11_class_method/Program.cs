using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_class_method
{
    // 설계도 : 속성 + 기능

    // 기능 == 행위 == method(함수)
    class Test
    {
        private int i;      // instance variable(member field)

        // 행위 기능
        // method는 누군가 이름을 부르면 실행(method call 되면 실행)
        // 4가지
        // 1.void, parameter(x)     : public void m(){실행코드;}
        // 2.void, parameter(O)     : public void m(int i){실행코드;}
        // 3.return, parameter(x)   : public int m(){return i;}
        // 4.return, parameter(O)   : public int m(int i){return i;}

        // parameter 인수, 인자, 매개값(변수)

        public void callMethod()
        {
            // 실행블럭
            Console.WriteLine("Normal Method");
        }
        public void callMethod2(int i)
        {
            // 개발자 마음
            if (i < 10)
            {
                Console.WriteLine("????");
            }
            else
            {
                Console.WriteLine("!!!!!!");
            }
        }

        public string callMethod3()
        {
            // return type 함수의 결과로 string과 같은 type을 전달
            return "type만 맞으면 이렇게 써도 되지롱";
        }
        public string callMethod4(string str)
        {
            return str + "이렇게 해도 됨ㅋㅋ";
        }

        // 추가적으로
        // return (O), parameter (O)
        public int callMethod5(int i, int j, int k)
        {
            return i + j + k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            // 함수는 호출에 의해서 실행
            test.callMethod();
            test.callMethod2(7);
            string result = test.callMethod3();
            Console.WriteLine(result);

            result = test.callMethod4("요건 알고 있었냐?");
            Console.WriteLine(result);

            int value = test.callMethod5(1,2,3);
            Console.WriteLine(value);
        }
    }
}
