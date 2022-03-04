using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_class
{
    // 연습 클래스 생성
    // 클래스 == 설계도 == 데이터 타입
    class Person    // 설계도라고 정의하려면? 최소 속성(고유, 상태, 부품) + 기능을 가져야함. 그래야 객체를 생성하는데 무리가 없다 !
    {
        // 속성(정보를 담는 그릇 : 크기 + 이름 -> 변수)
        int num;        // 클래스가 가지는 변수 : instance variable : 생성되는 객체마다 가지는 변수 
                        // Person p = new Person(); Person p2 = new Person(); 
                        // p.num과 p2.num은 다른 것이다 !
                        // 기본적인 접근자를 가지고 있다. 아무것도 명시하지 않으면 private가 된다.
                        // TIP) java의 경우 안쓰면 default(C# = internal) 이다.
                        // private -> 데이터를 보호하겠다 ! ... 설계도(클래스)를 만든 사람의 의지 !
        // 객체지향 언어의 특징
        // 캡슐화(은닉화)를 구현하는 기술이 private ! 이를 통해 자원을 보호함 !
        // 1. private : 클래스 내부에서는 모두 같은 식구, 객체 입장에서는 볼 수 없음.
        // 2. public  : 클래스 내부건 객체 입장이건 다 같은 식구 ! 상관없이 볼 수 있다 ! 직접할당 시, 보호문제 때문에 거의 안써야한다 !
        // 3. private 사용하면서 객체가 사용할 수 있게...
        // 3.1 함수생성 : public이면서 캡슐화된 자원에 read, write가 가능한 함수 !(간접할당)
        private int k;
        public int p;
        private string ename;

        public int getK()       // 보호된 자원의 값을 return ! (읽기전용)
        {
            return k;
        }
        public void setK(int data)      // 보호된 자원의 값에 쓰기 (쓰기전용)
        {
            if (data < 0)           // 설계자의 의도 : -값을 받지 않겠다 !
            {
                k = 0;
            }
            else
            {
                k = data;
            }           
        }
        
        // property 얘는 함수아니다 ! private 한 member field에 대해서 간접적인 데이터 처리 목적 -> 캡슐화 된 자원에 read, write 할 수 있다.
        // int num > property > get, set > read, write 구현
        // property는 smart field 라는 이름으로도 불린다.
        public int Num 
        {
            get { return num; }
            set { num = value; }
        }
        // ename의 property
        public string Ename
        {
            get { return ename + "님"; }
            set { ename = value; }
        }
    }

    class Apt
    {
        private string aptname;
        private string aptcolor;

        // 함수 이용
        // 특수한 목적의 함수(사용방법은 member field의 초기화)
        // 설계 약속 : 함수의 이름 클래스 이름과 똑같이....
        public Apt() // 원칙적으로 함수는 public void or public int or public string .... 같이 void형이나 return하는 형태가 숨겨져있다. 생성자는 void가 숨겨져있음. 빼고적는다 
        {            // 생성자 함수 (Constructor) >> 객체가 생성될 때 호출되는 함수
                     // Apt apt = new Apt();
                     // 1. 생성자 실행되고 member field가 memory에 올라간다 X
                     // 2. member field가 먼저 memory에 올라가고 생성자 함수가 실행된다 O
            aptname = "삼성";
            aptcolor = "red";
        }

        public Apt(string aptname, string aptcolor) // 생성자 함수 // overloading(함수의 이름은 같은데 parameter의 갯수와 type를 다르게 씀)
        {
            this.aptname = aptname;
            this.aptcolor = aptcolor;
        }

        public string Aptname
        {
            get { return aptname; }
        }
        public string Aptcolor
        {
            get { return aptcolor; }
        }
    }
    // 요구사항
    // 아파트를 만들때 특별한 요구사항이 없으면 이름과 색상은 기본설정을 한다. 그리고 필요시 강제로 이름, 색상을 넣을 수 있게 한다.
    // Apt apt = new Apt(); set 안하고 바로 생성했을때 aptname과 aptcolor는 null이 기본값이다.
    class Program
    {
        static void Main(string[] args)
        {
            // 2명의 사람을 만들자 !
            Person person = new Person();
            Person person2 = new Person();

            // person.num = 100; <- person 변수가 직접적으로 num 변수에 접근하는 것을 막는다.

            person.p = 100;  // 직접할당
            person2.p = 200; // 직접할당

            // p라는 변수에 양수값만 넣고싶은데
            person.p = -100; // <- 이런 식으로 직접접근할 때 문제가 발생

            person.setK(-100);
            Console.WriteLine(person.getK());

            person.Num = 555;       // set {num = value;} 동작
            Console.WriteLine($"get {person.Num}");     // get {return num;} 동작

            person.Ename = "이맹기";
            Console.WriteLine($"get ename : {person.Ename}");

            Apt apt = new Apt();
            Console.WriteLine($"apt.name : {apt.Aptname}");
            Console.WriteLine($"apt.color : {apt.Aptcolor}");

            Apt apt2 = new Apt("LG","yellow");      // 객체를 생성하면서 바로 초기화 가능
            Console.WriteLine($"apt.name : {apt2.Aptname}");
            Console.WriteLine($"apt.color : {apt2.Aptcolor}");

            #region <정리>
            /*
             * 1. class == 설계도 == 데이터 타입
             * 2. 클래스의 가장 기본적인 구성요소는 속성(정보):member field 과 기능(함수): method
             * 3. 클래스를 이루는 요소 중 : 속성(instance variable(member field))
             * 3.1 private 접근자를 통해서 캡슐화를 함(C#은 별도로 접근자를 적지않으면 기본적으로 private)
             * 3.2 객체 입장에서 read, write(직접할당 불가)
             * 3.3 별도의 함수를(public) 통해서 get, set 구현
             * 3.4 전용 (read, write) > property
             * 3.5 member field property 구현함으로써 간접적인 데이터 처리(read, write) 가능
             * 
             */
            #endregion

        }
    }
}
