using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열은 객체다
            // 1. new 통해서 생성
            // 2. heap 메모리에 생성
            // 3. 고정배열(정적배열) : 배열의 크기가 한번 설정되면 변경 불가
            // 4. 자료구조의 기본

            int[] arr = new int[5];                     // 방의 값은 default 값으로 초기하
            Console.WriteLine(arr[0]);
            int[] arr2 = new int[5] {10,20,30,40,50 };       // 원하는 값으로 초기화
            Console.WriteLine(arr2[0]);
            int[] arr3 = new int[] {1,2,3,4,5 };             // 컴파일러가 5개로 알아서 잡아줌. 이렇게도 많이 씀.

            // 컴파일러에게 맡긴다..
            int[] arr4 = {100,200,300,400,500 };                // -> 컴파일러가 알아서 new 해서 생성해줌 가장 선호하는 방법임.
            // 궁합
            // for문
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr4[i]);
            }
            Console.WriteLine(arr4.Length);
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.WriteLine(arr4[i]);
            }

            Console.WriteLine("foreach");
            foreach (int temp in arr4)                  // 열거된(나열된) 자원에 순차적으로 접근해서 뽑아줌.
            {                                           // foreach의 단점. 인덱스를 알 수 없음. javascrpit에서는 인덱스를 뽑아줌.
                Console.WriteLine($"arr4 : {temp}");
            }
            // Console.WriteLine($"arr : {arr}");
            // 배열의 할당

            int[] ar = { 1, 3, 5, 7, 9 };
            int[] ar2 = ar; // 할당(***주소값 할당***)
            for (int i = 0; i < ar2.Length; i++)
            {
                ar2[i] += i;
            }
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine($"ar : {ar[i]}");
            }

            string[] strarr = {"이맹기","임현기","백신맞음","잠온다" };
        }
    }
}
