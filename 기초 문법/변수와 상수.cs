using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 씨샾겅부
{
    internal class 변수
    {
        // 필드 (클래스 내에서 공통적으로 사용되는 전역 변수)
        int globalVar;
        const int MAX = 1024;

        public void Method1()
        {
            // 로컬변수
            int localVar;

            // 아래 할당이 없으면 에러 발생
            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }

/*    // 모든 프로그램에는 Main()이 있어야함
    class program
    {
        static void Main(string[] args)
        {
            변수 obj = new 변수();
            obj.Method1();
        }
    }*/

    internal class 상수
    {
        // 상수
        const int MAX_VALUE = 1024;

        // readonly 필드
        readonly int Max;
        public 상수()
        {
            Max = 1;
        }
    }
}
