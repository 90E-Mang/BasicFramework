using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_constructor_static
{
    public class Test
    {
        //public static int staticint = 0; // 이렇게 초기화 하는거 보다는
        //생성자를 통해 초기화 해야 변경사항에 유연하게 대처할 수 있다.

        // 생성자를 통해서 초기화
        public static int staticint;

        public Test() // static 생성자 >> static memver field 가 메모리에 올라가고 나서 바로 자동으로 호출
        {
            staticint = 100;
            // if 같은 제어 로직 사용 가능
        }


        public static void print()
        {
            Console.WriteLine("staticint value : {0}", staticint);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Test.print();

        }
    }
}
