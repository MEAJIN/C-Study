using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 요일에 대한 열거형 번수를 정수형 변수에 대입하여 출력하여 보자.
// 열거형? 상수를 문자열로 대치하여 선언
namespace 혼자해보는_실습
{
    enum Days { sun = 1, Mon, Tue, Wed, Thu, Fri, Sat };
    internal class 열거형_연습
    {
        static void Main(string[] args)
        {
            int nValue = (int)Days.Mon;
            Days day = Days.Tue;
            Console.WriteLine("{0}, {1}", nValue, day);
        }
    }
}
