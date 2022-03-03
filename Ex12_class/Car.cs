using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    // 요구사항
    // 자동차는 이름을 가지고 있다, 색상을 가지고 있다
    // 기본 이름과 색상을 가지고 있고, 요구에 따라 이름과 색상을 옵션으로 선택할 수 있다.
    // 자동차를 생성하고 자동차의 이름과 색상정보를 확인할 수 있다.
    // 자동차 생성 후에는 자동차의 이름과 색상을 변경할 수 없다.
    public class Car
    {
        private string name;
        private string color;

        public Car()
        {
            this.name = "Proto V1";
            this.color = "Silver";
        }

        public Car(string carname, string carcolor)
        {
            this.name = carname;
            this.color = carcolor;
        }

        public string Name      // read
        {
            get { return name; }
        }
        public string Color     // read
        {
            get { return color; }
        }
        public void Carinfo()
        {
            Console.WriteLine($"차 이름은 {this.name}, 색상은 {this.color}");
        }
    }
}
