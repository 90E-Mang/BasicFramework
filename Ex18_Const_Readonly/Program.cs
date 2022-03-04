using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_Const_Readonly
{
    class Test
    {
        // const 상수 생성 시,
        // 1. 객체간 공유자원 > 자동으로 static이 내부적으로 붙는다.
        // 2. 의무적 초기화가 필요하다.(선언과 동시에 초기화를 해야된다.)
        public const int MAXVALUE = 10000;

        // readonly 상수 생성 시,
        // 1. 반드시 선언과 동시에 초기화 할 필요는 업다.
        // 2. 생성자에서 딱 1번만 값을 할당할 수 있다.(이후 변경 불가)
        public readonly int readdata;   

        public Test(int data)
        {
            readdata = data; // new 통한 생성 시, 객체마다 다른 상수값을 가지게 할 수 있다.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // const 
            Console.WriteLine(Test.MAXVALUE); // 모든 객체의 공유자원

            Test t = new Test(10);
            Console.WriteLine($"t.readdata : {t.readdata}");
            Test t2 = new Test(20);
            Console.WriteLine($"t.readdata : {t2.readdata}");
            // t2.readdata = 200;   <- 이미 값을 가지고 있어서 변경 불가 read만 가능.
        }
    }
}
