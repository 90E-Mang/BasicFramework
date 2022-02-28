using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_ValueType
{
    #region <값 타입 : 구조체> :  작은 타입을 모아서 의미있는 집합
    struct Book
    {
        public string name;
        public int price;

        public Book(string _name, int _price)       // 생성자 함수   // Book이 가지는member를 초기화(스택에 올라감 !!)
        {
            name = _name;
            price = _price;
        }
    }
    struct Human
    {
        public string name;
        public int age;
    }
    #endregion

    #region <열거형> : 하나의 값타입이다. 개발자를 위한 것(컴파일러에겐 안좋음)
    enum mycolor { black, white, red, green, blue};     // 열거 타입. 내부적으로 상수값을 0부터 n-1까지 자동으로 설정한다.
    enum week {mon, tue = 101, sat, sun};          // 중간에 값을 하나 설정하면 그 이후값은 전에 설정한 값 +1로 자동으로 설정함. 고민하지마 얘들이 정해놓은 규칙임. // 명시적으로 상수값 설정 가능
    #endregion
    class Car
    {
        public string name;
        public int price;

        public Car(string _name, int _price)    // 생성자 함수 member를 초기화(힙에 올라감 !!)
        {
            name = _name;
            price = _price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Value Type
            int i = 100;
            float f = 3.14f;

            Book book = new Book("홍길동전", 10000);
            // **** 구조체에서 [new는 객체를 생성하는 연산자가 아니다] !!! 단지 생성자를 통해서 [초기화]만 한다 !!!! ****
            // Book 구조체가 값 타입임을 증명

            Book book2 = book;              // 구조체의 할당은 새로운 구조체를 하나 더 만드는 거다. 클래스의 객체 생성처럼 주소값을 가지고 있는 변수를 만드는게 아님 !!!!
            book2.name = "방자전";
            book2.price = 25000;
            

            if (book.name.ToString() == book2.name.ToString() && Convert.ToInt32(book.price) == Convert.ToInt32(book2.price))
            {
                Console.WriteLine("구조체가 아닙니다");
                Console.WriteLine("책이름 : {0}, 가격 : {1}", book.name, book.price);
                Console.WriteLine("책이름 : {0}, 가격 : {1}", book2.name, book2.price);
            }
            else
            {
                Console.WriteLine("book과 book2는 구조체로 값 타입입니다.");
                Console.WriteLine("책이름 : {0}, 가격 : {1}", book.name, book.price);
                Console.WriteLine("책이름 : {0}, 가격 : {1}", book2.name, book2.price);
            }

            Car car = new Car("GV80", 1000);
            // new 라는 연산자는 [객체를 생성하는 연산자] (new를 통해서 만들어진 객체는 heap 메모리에 생성)

            Car car2 = car;     // car2 와 car는 같은 객체를 본다
            car2.name = "E500";
            car2.price = 5000;

            if (car.name.ToString() == car2.name.ToString() && Convert.ToInt32(car.price) == Convert.ToInt32(car.price))
            {
                Console.WriteLine("구조체가 아닙니다");
                Console.WriteLine("차이름 : {0}, 가격 : {1}", car.name, car.price);
                Console.WriteLine("차이름 : {0}, 가격 : {1}", car2.name, car2.price);
            }
            else
            {
                Console.WriteLine("car와 car2는 구조체로 값 타입입니다.");
                Console.WriteLine("차이름 : {0}, 가격 : {1}", car.name, car.price);
                Console.WriteLine("차이름 : {0}, 가격 : {1}", car2.name, car2.price);
            }

            Human h;
            h.name = "이맹기";     // 생성자를 직접 구조체안에서 만들던 여기처럼 쓰던 어차피 초기화하고 사용하는 것은 동일하다. 걍 생성자로 초기화하면 됨.
            h.age = 33;
            Console.WriteLine(h.name);
            Console.WriteLine(h.age);

            // 열거타입

            mycolor color;
            // color 열거 타입 변수는 열거형 중에 하나를 가질 수 있다.
            color = mycolor.black;
            Console.WriteLine(color);
            Console.WriteLine((int)color);  // int형으로 캐스팅

            // System이 제공하는 열거타입 : ConsoleColor.
            Console.BackgroundColor = ConsoleColor.Blue;

            week w;
            w = week.sat;   // 개발자는 문자열 형태로 코드를 해석할 수 있어서 편하게 작업 가능
            Console.WriteLine($"w : {w}");

            int inum = 20;
            int inum2 = 30;

            Console.WriteLine($"string ex1 : {inum} + {inum2} = {inum + inum2}");
            Console.WriteLine("string ex2 : {0} + {1} = {2}", inum,inum2,inum+inum2);

            const double PI = 3.14; // 상수 : 관용적 표현 : 상수의 이름은 대문자로 쓰자
            // PI = 3.192;   <- 상수는 변경불가 !!

            // 형변환              !!!!*** 형변환할때는 값을 보는게 아니라 선언한 Type을 기준으로 해야된다 !!!!! ***!!!!
            int num = 1234;
            long lon = num; // long은 int 보다 크기가 크다.
            //long lon = (long)num; 내부적으로 이 코드를 컴파일러가 알아서 수행한다(암시적 형변환). 근데 캐스팅을 이렇게 적어주는게 프로그래밍 측면에서는 좋다.

            // 명시적 형변환(개발자가 의도를 가지고... 실제 코드로 작업)
            long lon2 = 100000;
            int num2 =(int)lon2;    // 여기서 값으로 보면 안되고 뭔 타입인지를 봐야한다 !
            // 다행히 형변환한 값이 int 범위라면 손실이 없어 문제는 없다. 근데 그거 보다 크다면?? 손실이 발생
            Console.WriteLine(num2);

            // 데이터 손실
            long lon3 = 10000000000;
            int num3 = (int)lon3;
            Console.WriteLine(num3);        // 이렇게 int의 범위를 벗어나게되면 손실이 생겨서 이상한 값(쓰레기값)이 들어간다.

            // 결론 : 큰타입을 작은 타입으로 넣는 것은(형변환) 손실을 감안해야됨. 되도록 안하는게 좋다.

            int x = 254;
            byte y = (byte)x;       // byte = 0 ~ 255
            Console.WriteLine("y : {0}", y);

            int x1 = 258;
            byte y1 = (byte)x1;       // byte = 0 ~ 255
            Console.WriteLine("y : {0}", y1); // 찍으면 2가 나오는데 overflow 가 발생, byte는 유일하게 순환해서 255 찍고 돌아서(256 ->0, 257 ->1) 258 -> 2가 나옴. 어쨋든 원하는 값이 아니다.

        }
    }
}
