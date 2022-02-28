using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Basic            // 논리적 묶음의 단위(클래스명 충돌 방지)
{
    // 클래스는 설계도 == 클래스는 타입이다
    // 우리가 배우는 언어는 클래스를 만들려고 하는거 class를 붙이면 설계도(클래스 만들기)임 : 재사용성(객채 생성가능)
    // 클래스 2가지 : Main이 있냐(직접 실행되는 클래스 .exe) 없냐(독자적 실행 불가 다른 클래스를 도와줌 .dll)
    // 원칙적인 방법은 모든 클래스는 new 라는 연산자를 통해서 메모리에 로드된다. 그래야 사용가능함.
    // Program p = new program();
    class car   // dll
    {

    }

    class Test
    {
        public int data;
    }
    class Program       // exe
    {
        static void Main(string[] args)     // 함수(method) > 기능 > static (독자적으로 메모리에 올라감) > 이름이 Main() > 실행가능(stack)
        {
            // Console.WriteLine("월요일만 되면 짖는 개 " + ":" + " 왈 ! 왈 ! 왈 ! 크르르으ㅡ으 왈왈왈!!");

            // 데이터 타입과 변수
            char c;     // 2byte        //한글 1자 : 2byte  영문자, 특수문자, 공백 : 1byte >> 약속 >> 한 문자를 2byte로 ! (UNICODE)
            c = 'L';

            char d;
            d = '가';
            Console.WriteLine("c:{0}. d:{1}", c,d);

            // 지역변수는 반드시 [초기화]를 통해서 사용한다.
            short s;
            s = 1000;
            Console.WriteLine(s);

            int i = 100000000;
            Console.WriteLine(i);

            //1.12 실수 리터럴(있는 값 그대로 !)의 기본형을 double로 본다.
            float f = 1.12f;        // 접미사 대문자든 소문자든 노상관 f를 붙여서 4byte의 float 형으로 사용.
            Console.WriteLine(f);

            double dd = 1.123456789;        // double은 기본형, 접미사 없어도 상관없다 !
            Console.WriteLine(dd);

            bool b = true;      // 논리적인 구조 ( 제어구조에서 논리 판단)

            // 값 타입 증명하기
            // aa가 value type 임을 증명하기
            int aa = 100;
            int bb = aa;    // 할당(값할당)
            bb = 200;
            Console.WriteLine("aa값은 {0}", aa);
            Console.WriteLine(aa.GetHashCode()); // aa의 값이 찍힘.

            // 참조 타입 증명
            Test t = new Test();
            Console.WriteLine(t.GetHashCode());
            t.data = 100;

            Test t2 = t;    // 할당 (주소값)
            t2.data = 1111;
            Console.WriteLine("t객체의 data 변수값은 {0}", t.data);
            Console.WriteLine(t == t2);
            Console.WriteLine("{0} - {1}", t.GetHashCode(), t2.GetHashCode());
        }
    }
}
