using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21_Object_Array
{
    // class 생성
    class Ani
    {
        private string dogname;

        public Ani()
        {

        }
        public Ani(string dongname)
        {
            this.dogname = dongname;
        }
        public void aniDisplay()
        {
            Console.WriteLine($"개이름 : {this.dogname}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // int[] arr = new int[] {1,2,3,4,5 };
            Ani[] arr = new Ani[3];     // 여기까지만 하면 Ani 객체를 만들기 위한 방만 3개 만든거임(빈방, 방타입만 Ani) : 방의 값은 null
            // 각각의 방에 값을 넣자
            // ㄴ 각각의 방에 Ani 타입을 갖는 주소를 넣어라
            Ani a = new Ani("댕댕이");
            Ani a1 = new Ani("댕청이");
            Ani a2 = new Ani("멍청이");

            arr[0] = a;     // 주소값 전달(Ani 타입)
            arr[1] = a1;
            arr[2] = a2;

            arr[0].aniDisplay();
            arr[1].aniDisplay();
            arr[2].aniDisplay();
            */

            Ani[] arr = new Ani[3];
            arr[0] = new Ani("댕댕이");
            arr[1] = new Ani("댕청이");
            arr[2] = new Ani("멍청이");

            Ani[] arr2 = new Ani[] { new Ani("댕댕이"), new Ani("댕청이"), new Ani("멍청이") };

            Ani[] arr3 = { new Ani("댕댕이"), new Ani("댕청이"), new Ani("멍청이") };
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i].aniDisplay();
            }
            // foreach로
            foreach (Ani temp in arr3)
            {
                temp.aniDisplay();
            }
        }
    }
}
