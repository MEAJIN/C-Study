using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_study
{
    class A
    {

    }

    class B
    {

    }

    internal class as연산자_연습
    {
        // 형변환과 변환 조사
        // 캐스트 연산자의 역할과 불변환은 null 리턴
        // 
        // 형식
        // 결과형 = 참조형, 언바싱, 박싱 as 변환형
        
        static void Main()
        {
            string str1 = "123";
            object obj = str1;
            string str2 = obj as string;
            Console.WriteLine(str2);

            A test1 = new A();
            object obj1 = test1;
            B test2 = obj1 as B;
            if (test2 == null)
                Console.WriteLine("형변환 실패");
            else
                Console.WriteLine("형변환 성공");


        }
    }
}
