using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 씨샾겅부
{
    internal class Enum
    {
        enum City
        {
            Seoul, // 0
            Daejun, // 1
            Busan = 5, // 5
            Jeju = 10 // 10
        }

/*        static void Main(string[] args)
        {
            City myCity;

            // enum 타입에 값을 대입하는 방법
            myCity = City.Seoul;

            // enum을 int로 변환(Casting)하는 방법
            // (int)를 앞에 지정
            int cityVlue = (int)myCity;

            if (myCity == City.Seoul) // enum 값을 비교하는 방법
            {
                Console.WriteLine("Welcome to 서울");
            }
        }*/
    }

    internal class Flags
    {
        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8
        }

        static void Main(string[] args)
        {
            // OR 연산자로 다중 플래그 할당
            Border b = Border.Top | Border.Bottom;

            // & 연산자로 플래그 체크
            if ((b & Border.Top) != 0)
            {
                // HasFlag()이용 플래그 체크 -> 특정 값이 있는지 체크
                if (b.HasFlag(Border.Bottom))
                {
                    // "Top, Bottom" 출력
                    Console.WriteLine(b.ToString());
                }
            }
        }
    }
}