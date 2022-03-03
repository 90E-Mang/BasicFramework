using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Static
{
    /* 비행기를 주문 제작 판매 하는 회사
     * 비행기를 생산하는 설계도를 작성 하려고 함
     * 요구사항
     * 1. 비행기를 생산하고 나면 비행기의 이름과 번호를 부여해야함
     * 2. 비행기가 생산되면 비행기의 이름과 번호 맞게 부여되었는지 확인 하는 작업이 필요(출력정보 확인)
     * 3. 공장장은 현재까지 만들어진 비행기의 총대수(누적)을 확인할 수 있습니다.
     * 
     */
    public class AirPlane
    {
        private static int totalaircount;       // point (객체간 공유자원) // Airplain.totalaircount = 10;
        string planename;
        int planeNo;

        // public Airplane(){} // 기본 생성자 함수...

        public AirPlane(string name, int num)   // 오버로딩 생성자 함수 통해서 강제로 입력...
        {
            this.planename = name;
            this.planeNo = num;
            // 누적대수
            totalaircount++;
        }

        public string PlaneName
        {
            get { return planename; }
        }
        public int PlaneNo
        {
            get { return planeNo; }
        }
        public void airDisplay()
        {
            Console.WriteLine($"비행기 이름 : {this.planename}, 비행기 번호 : {this.planeNo}");
        }
        public void chkplanecount()
        {
            Console.WriteLine($"만들어진 비행기 수 : {totalaircount}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AirPlane a1 = new AirPlane("대한항공",707);
            a1.airDisplay();
            a1.chkplanecount();
            AirPlane a2 = new AirPlane("아시아나",708);
            a2.airDisplay();
            a2.chkplanecount();
            AirPlane a3 = new AirPlane("진에어",710);
            a3.airDisplay();
            a3.chkplanecount();
        }
    }
}
