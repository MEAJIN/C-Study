using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[] { 1,3,5,2,4 };

            quick_sort(Arr, 0, Arr.Length - 1);

            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + " ");
            }

            Console.ReadLine();
        }

        private static int ArrayDivide(int[] Arr, int left, int right)
        {
            int PivotValue, temp;
            int index_L, index_R;

            index_L = left;
            index_R = right; 

            //Pivot 값은 0번 인덱스의 값을 가짐 
            PivotValue = Arr[left];

            while (index_L < index_R)
            {
                Console.Write(Arr);

                //Pivot 값 보다 작은경우 index_L 증가(이동)
                while ((index_L <= right) && (Arr[index_L] < PivotValue))
                {
                    index_L++;

                    Console.Write(Arr);
                }

                //Pivot 값 보다 큰경우 index_R 감소(이동)
                while ((index_R >= left) && (Arr[index_R] > PivotValue))
                {
                    index_R--;

                    Console.Write(Arr);
                }

                //index_L 과 index_R 이 교차되지 않음
                if (index_L < index_R)
                {
                    temp = Arr[index_L]; // 위
                    Arr[index_L] = Arr[index_R];
                    Arr[index_R] = temp;

                    //같은 값이 존재 할 경우 
                    if (Arr[index_L] == Arr[index_R])
                    {
                        index_R--;
                    }
                }
            }

            //index_L 과 index_R 이 교차된 경우 반복문을 나와 해당 인덱스값을 리턴
            //즉, 옮겨진 피벗의 위치 정보를 반환
            return index_R;
        }

        private static void quick_sort(int[] Arr, int left, int right)
        {
            if (left < right)
            {
                int PivotIndex = ArrayDivide(Arr, left, right); // 둘로 나눠서
                Console.Write(Arr);

                // 정복(Conquer)
                quick_sort(Arr, left, PivotIndex - 1); // 왼쪽 영역 정렬 (재귀)
                Console.Write(Arr);

                quick_sort(Arr, PivotIndex + 1, right); // 오른쪽 영역 정렬 (재귀)
                Console.Write(Arr);

            }
        }
    }
}
