using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 혼자해보는_실습
{
    public struct Mystruct
    {
        public int 국어, 영어, 수학, 합계;
        public float 평균;
        public void Compute()
        {
            합계 = 국어 + 영어 + 수학;
            평균 = 합계 / 3.0f;
        }


    }
    internal class 구조체_연습
    {
        static void Main(string[] args)
        {
            Mystruct Test1 = new Mystruct();
            Test1.국어 = 80;
            Test1.영어 = 90;
            Test1.수학 = 88;
            Test1.Compute();
            Console.WriteLine("총점 : {0}, 평균 : {1}", Test1.합계, Test1.평균);
        }
    }


}
