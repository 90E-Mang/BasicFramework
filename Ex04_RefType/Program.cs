using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_RefType
{
    // 수업에서나 namespace안에 클래스를 자꾸 만드는거지... 사실 클래스는 따로파서 dll 참조로 만드는거임(별도의 라이브러리 생성)... 실무에서 똥싸지말자
    // 변수의 구분 : static 변수, instance variable, local variable, block variable(for문 같은곳 안에서 생성되고 종료되면 사라지는 변수)
    class Test      // 설계도
    {
        public int i;   // member field(instance variable), i변수는 클래스 내에서는 유효한 자원! 기본적으로 초기화 안하면 0이 들어감.
        public void print() // 함수 기능
        {
            int data = 100; // local variable, 힙 영역에서 객체가 생성되도 지역변수는 생성안됨. 함수는 무조건 스택에서 실행되는데 그때 생긴다.
            Console.WriteLine("data : {0}", data);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.print();

            Test test2 = new Test();
            test2.print();

            Test test3 = new Test();
            test3.print();

            //test, test2, test3는 참조 타입이다(객체 참조 변수, 주소값을 가지고 있다)

            string kb = "존나춥다";
            
        }
    }
}
