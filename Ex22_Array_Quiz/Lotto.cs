using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex22_Array_Quiz
{
    class Lotto
    {
        private int[] numbers;
        private Random random;

        public Lotto()          // member field 초기화가 목적인 생성자에서 처리...
        {
            numbers = new int[6];   // 배열의 초기화(최초로 값을 갖는 행위)
            random = new Random();
        }

        public void getReadLottoNumbers()
        {

        }
        public void displayLottoNumbers()
        {

        }

        // 추가적인 함수의 구현
    }
}
/*
 *  static void main(){
 *  Lotto lotto = new Lotto();
 *  lotto.getReadNumbers();
 *  lotto.displayLottoNumbers();
 * 
 * 
 * 
 * }
 */
