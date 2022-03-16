using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Constructor
{
    /* 생성자 함수(특수한 목적의 함수) : 멤버필드에 초기화를 목적으로 함
     * 생성방법 : 함수의 이름 > class 이름과 동일, 접근자 public , 리턴타입은 없음 (void) 
     * 종류 : default constructor , overloding constructor (parameter 개수와 타입을 달리해서)
     * 실행시점 : 객체 생성과 동시에 호출되는 함수 (new test(), new test(100,200) > 생성자가 호출되기 전에 당근 member field 먼저 memory에 있다.
     */
    class Test
    {
        // 1. 생성자를 구현하지 않으면 컴파일러가 자동으로 생성자 하나를 만든다
        //2. Test(){} 자동생성
    }
    class Test2
    {
        public Test2() // 파라미터없 - > default 생성자
        {
            //어떤 자원 초기화가 필요하면 ... 
        }
    }
    class Test3
    {
        public Test3() { } //defalut
        public Test3(int i) //overloading
        {

        }
    }

    class Test4
    {
        public Test4(int i) //overloading 만 생성
        {

        } //overloading 생성자 하나라도 존재하면 default는 반드시 구현을 통해 사용 가능
        //개발자 의도 : 당신이 객체를 생성시 반드시 parameter 1개를 가지고 생성 하세요
    }

    class Test5
    {
        public Test5(int i)
        {

        }
        public Test5(int i, int j)
        {

        }
        public Test5(int i, int j, int k) // 이것도 가능!
        {

        }
    }

    class Book
    {
        private string bname;
        private int price;

        //public Book() { }
        //할당을 하는 코드 3번 반복 - > 안 좋은 코드
        //개발자의 의도 옵션 3가지 
        public Book(string bname)
        {
            this.bname = bname;
            this.price = 1000;
        }
        public Book(int price)
        {
            this.price = price;
            this.bname = "무제";
        }
        public Book(string bname, int price)
        {
            this.bname = bname;
            this.price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
        }
    }
}
