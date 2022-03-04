using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_Array_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예약, 예약 확인, 취소

            string[,] seat = new string[3, 5];  // 3행 5열의 좌석
            // java에서 2차원 배열 String[][] 이렇게... 대괄호 두개

            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    seat[i, j] = "__";
                }
            }
            //for (int i = 0; i < seat.GetLength(0); i++)
            //{
            //    for (int j = 0; j < seat.GetLength(1); j++)
            //    {
            //        Console.WriteLine(seat[i,j]);
            //    }
            //}

            // 예매정보 확인
            seat[2, 1] = "홍길동";
            seat[0, 0] = "이맹기";
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    // __는 빈좌석, 나머진 예매
                    Console.Write(seat[i, j] == "__" ? "[빈좌석]" : "[예매]");
                    
                }
                Console.WriteLine();
            }

            int row, col;
            // 예매 시작
            row = 0;
            col = 0;
            // ㄴ [0,0] 좌석을 예매하겠다
            if (seat[row,col] == "__")
            {
                Console.WriteLine("예매 가능한 좌석 입니다.");
            }
            else
            {
                Console.WriteLine("이미 예약되었습니다.");
            }

            // 예매 가능하게 좌석 초기화
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    seat[i, j] = "__";  // 좌석 초기화
                }
            }
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    // __는 빈좌석, 나머진 예매
                    Console.Write(seat[i, j] == "__" ? "[빈좌석]" : "[예매]");

                }
                Console.WriteLine();
            }
        }
    }
}
