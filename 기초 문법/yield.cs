using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 씨샾겅부
{
    internal class yield
    {
        static IEnumerable<int> GetNumber()
        {
            yield return 10;  // 첫번째 루프에서 리턴되는 값
            yield return 20;  // 두번째 루프에서 리턴되는 값
            yield return 30;  // 세번째 루프에서 리턴되는 값
        }

        static void Main(string[] args)
        {
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);
            }
        }
    }
}
