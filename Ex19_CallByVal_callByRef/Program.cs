using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_CallByVal_callByRef
{
    /*
    class Test
    {
        public void print()
        {
            printdata();
        }
        private int printdata() // private 함수의 의미?? 
        {
            // 1. 클래스 내부에서만 사용 가능
            // 2. 다른 함수를 도와줄 목적
            // 3. 주로 공통함수(출력이라든지,,)에 사용
            return 10;
        }

        public void method(Car c)   // 주소
        {

        }
        public void method(int i)   // 값
        {

        }
    }
    class Car
    {

    }
    */
    class Car
    {
        public int speed;
        public void run(int data)
        {
            speed += data;
            data = 100;
        }
    }
    class Car2
    {
        public int speed;
        public void run(ref int data)           // 주소값이 넘어옴
        {
            speed += data;
            data = 50;       // 주소값을 찾아가서 나온 값을 50으로 바꾼거임.
        }
    }
    class Car3
    {
        public int speed;
        public void run(out int data)           // 주소값이 넘어옴 
        {
            data = 100;      // out과 ref 차이는 그냥 초기화 안된 변수를 가져와서 함수안에서 초기화 하냐(out) 주소값을 보냐(ref)다. 근데 안중요
            speed += data;
            data = 50;       // 주소값을 찾아가서 나온 값을 50으로 바꾼거임.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            int data20 = 20;    
            car.run(data20);    // data20 변수가 가지는 값을 전달
            Console.WriteLine(car.speed);
            Console.WriteLine($"data20 : {data20}");
///////////////////////////////////////////////////////////////////////////

            Car2 car2 = new Car2();
            int data30 = 20;
            car2.run(ref data30);    // 사실 이렇게 ref 자체를 쓸일은 거의 없다고 보면 된다.

            Console.WriteLine(car2.speed);
            Console.WriteLine($"data30 : {data30}");
            /////////////////////////////////////////////////////////////
            Car3 car3 = new Car3();
            int data40 = 20;
            car3.run(out data40);    // 사실 이렇게 out 자체를 쓸일은 거의 없다고 보면 된다.

            Console.WriteLine(car3.speed);
            Console.WriteLine($"data40 : {data40}");
        }
    }
}
