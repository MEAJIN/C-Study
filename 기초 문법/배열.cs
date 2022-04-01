using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 씨샾겅부
{
    internal class 배열
    {
        // 1차 배열
        string[] players = new string[10];
        string[] Regions = { "서울", "경기", "부산" };

        // 2차 배열 선언 및 초기화
        string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

        // 3차 배열 선언
        string[,,] Cubes;
    }

    internal class 가변배열
    {
        public void Method1()
        {
            //Jagged Array (가변 배열)
            //1차 배열 크기(3)는 명시해야
            int[][] A = new int[3][];

            //각 1차 배열 요소당 서로 다른 크기의 배열 할당 가능
            A[0] = new int[2];
            A[1] = new int[3] { 1, 2, 3 };
            A[2] = new int[4] { 1, 2, 3, 4 };

            A[0][0] = 1;
            A[0][1] = 2;
        }
    }

    internal class 배열의_사용
    {
        public void Method2()
        {
            int sum = 0;
            int[] scores = { 80, 78, 60, 90, 100 };
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            Console.WriteLine(sum);
        }
    }

    internal class 배열의_전달
    {
        public void Method3()
        {
            int[] scores = { 80, 78, 60, 90, 100 };
            int sum = CalculateSum(scores); // 배열 전달: 배열명 사용
            Console.WriteLine("배열의 전달 : " + sum);
        }

        static int CalculateSum(int[] scoresArray) // 배열 받는 쪽
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }
            return sum;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            /* 가변배열 obj = new 가변배열();
             obj.Method1();*/

            배열의_전달 obj = new 배열의_전달();
            obj.Method3();
        }
    }
}
