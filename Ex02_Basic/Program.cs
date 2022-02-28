using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03_EmpLib;

namespace Ex02_Basic
{

    class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();        // 객체 생성할 때, 객체 참조 변수는 디폴트로 4byte를 준다.
            Console.WriteLine(emp.GetHashCode());
            emp.Empno = 17931119;
            emp.Ename = "이맹기";
            emp.Sal = 10000;
            Console.WriteLine(emp.Empno);
            emp.EmpPrint();
        }
    }
}
