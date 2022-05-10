using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCV
{
    internal class Class1
    {
        static void Main()
        {
            // 객체 형식 (스택)
            // 일반적 선언과 new를 통해 생성한 객체에 대한 초기값을 출력해 보자.
            int nVal1 = 12;
            int nVal2 = new int();
            Console.WriteLine("{0}, {1}", nVal1, nVal2);

            // 참조 형식 (힙) +스택
            // 실제 값(데이터) 영역에는 1,2,3 이 들어감 (힙)
            // 값이 저장된 힙의 메모리 주소를 저장 = Array1 (스택)
            int[] Array1 = { 1, 2, 3 };
            int[] RefArray; // 참조형 배열 변수
            RefArray = Array1;
            RefArray[1] = 20;
            Console.WriteLine("{0}, {1}, {2}", Array1[0], Array1[1], Array1[2]);
        }
    }
}
