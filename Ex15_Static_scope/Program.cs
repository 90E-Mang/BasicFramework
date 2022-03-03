using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Static_scope
{
    public class Test               // 원칙 : class 내부에선 private와 public을 구분하지 않는다 없음 !!!!
    {
        private static int i;       // private 접근자 > class 이름으로 접근 불가능 > Test.i 으로 안됨 !!
        public static int j;        // public 접근자 > class 이름으로 접근 가능 > Test.i 가능 !!

        // 클래스가 일반자원과 static 자원 다가지고 있는 경우
        // 일반함수에서 static member 가지고 놀 수 있다.(메모리 생성 시점이 항상 static이 우선이다.)
        // static 함수에서 일반 member 가지고 놀 수 있다?? -> 안됨 !!! (static은 일반 자원보다 항상 우선 생성되니까!)

        public static void method()
        {
            i = 1;
            j = 1;
            Console.WriteLine($"method => i : {i}, j : {j}");
        }
        public void gMethod()   // 일반함수 >> memory에서 >> Test t = new Test(); 실행 >> memory에
        {                       // 일반함수가 static 자원을 가지고 노는 것은 당연하다. 생성시점이 static보다 늦기 때문에
            i = 111;
            j = 222;
            Console.WriteLine($"gMethod => i : {i}, j : {j}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test.method();
            //gMethod() 는 안됨 ... -> memory에 올려야댐.. -> new !
            Test t1 = new Test();
            t1.gMethod();       // 일반자원 사용
        }
    }
}
