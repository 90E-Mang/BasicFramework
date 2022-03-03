using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_static
{
    /* static 자원
     * 1. 객체 생성 이전에 메모리에 올라가는 자원
     * 2. 객체를 생성하지 않고도 직접적인 접근(사용)이 가능한 자원
     * 3. static을 가질 수 있는 놈의 종류는 static class, static field(!!중요!!), static constructor, static method(!!!중요!!!)
     * 4. static 한 단어로 : 공유자원(단 객체간)
     * 5. static 자원 접근(사용) 방법....
     *     class Sample{
     *      public static int s;
     *      public static void print(){
     *          // static method 하는데 why 만들어서 쓰냐??
     *          // 얻는 이점이 뭐임?
     *          // new 하지 않고 사용할 수 있는 함수
     *          
     *          // [자주 사용]하는 함수니까 -> 편리하게 사용
     *      }
     *      }
     *      static 자원은 성능 향상에 도움이 된다, 아니다 ? --> 안된다 !
     *      static 소멸시점 -> App 종료될때... 그래서 남발하면 성능에 악영향을 미친다.
     *      그리고 매우 위험한 자원이다 ! (공유자원이니까 값같은게 같이 바뀜!!)
     */
    public class Sample
    {
        public static int s;    // static variable 
        public int i;   // instance variable ( new Sample(); 하면 heap에 생성되고 사용가능.

        public void print()
        {
            int l = 100; // local variable (함수 호출되면 생성되고 함수가 끝나면 얘도 뒤짐)
        }
        public void printstatic()
        {
            Console.WriteLine($"static s : {s}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample.s = 100;         // static 자원은 클래스 이름으로 접근.
            // 원칙적으로는 클래스는 반드시 new를 통해서 메모리에 road 하고 사용
            // Sample sample = new Sample();....
            Sample sa = new Sample();
            sa.printstatic();
            Sample sa2 = new Sample();
            sa2.printstatic();
            Sample sa3 = new Sample();
            sa3.printstatic();

            // Tip)
            // java 와의 차이점
            // java는 참조변슈로 static 자원에 접근 가능
            // C# 참조변수는 접근 불가(누구의 것도 아님) : sa.s = 200 (x)
        }
    }
}
