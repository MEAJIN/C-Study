using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_study
{
    internal class is연산자_연습
    {
        static void Main(string[] args)
        {
            // is연산자
            // 형식 호환을 조사하는 연산자
            //
            // 형식 :
            // A(변수) is B(클래스형 도는 데이터형)
            // 결과는 true, false

            int nValue = 10;
            if (nValue is float)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");

            if (nValue is object)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");

            object obj = nValue;
            if(obj is int)
            {
                Console.WriteLine("호환됨");
            }
            else
            {
                Console.WriteLine("호환 안 됨");
            }
        }
    }
}
