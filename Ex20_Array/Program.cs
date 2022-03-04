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

            int[] varray = new int[] {12,56,45,90,56,10 };
            Console.WriteLine("인덱스 값 : {0}", Array.IndexOf(varray, 45));
            Console.WriteLine("인덱스 값 : {0}", Array.LastIndexOf(varray,56));

            Array.Sort(varray);     // 초급자는 쓰지말것. 알고리즘 공부 존나하고 쓰자 과제할때 쓰면 0점...
            Console.WriteLine("자동 정렬 Asc");
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine($"varray : {i},{varray[i]}");
            }
            Console.WriteLine("자동 정렬 Desc >> 선행 >> sort");
            Array.Reverse(varray);
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine($"varray : {i},{varray[i]}");
            }

            // 정렬코드는 직접 구현(swap 방식, bubble sort)
            Console.WriteLine("clear");
            Array.Clear(varray, 2, 3);          // [2][3][4] 값을 0으로 초기화
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine($"varray : {i},{varray[i]}");
            }

            int[] a = new int[] {45,12,88,97,10};
            int[] b = new int[5];   // 방 5개 >> default 값 0이 들어있음.

            Array.Copy(a, b, 3);
            foreach (int temp in b)
            {
                Console.WriteLine($"b[{temp}]");
            }

            // 2차원 배열
            // 행, 열
            int[,] arr5 = new int[3,2];
            arr5[0, 0] = 100;
            Console.WriteLine($"arr5 : {arr5[0,0]}");

            int[,] arr6 = new int[3, 2] { {1,2},{3,4},{5,6} };  // 2차원 배열 초기화
            // 출력하려면?
            // ㄴ 행을 고정하고 열을 바꿔서 출력
            // 아래는 개 무식한 하드코딩식 출력
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"arr6[{i},{j}] = {arr6[i,j]}");
                }
            }
            // 행의 갯수와 열의 갯수를 이렇게 뽑아서 쓰자
            Console.WriteLine($"행의 수 : {arr6.GetLength(0)}");
            Console.WriteLine($"열의 수 : {arr6.GetLength(1)}");
            for (int i = 0; i < arr6.GetLength(0); i++)
            {
                for (int j = 0; j < arr6.GetLength(1); j++)
                {
                    Console.WriteLine($"arr6[{i},{j}] = {arr6[i, j]}");
                }
            }

            // 좌석배치(영화관), 경도위도 값, 바둑판, ....
        }
    }
}
