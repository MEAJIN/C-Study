using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// #warning 예제 -----------------------------------
#if (!ENTERPRISE_EDITION)
#warning This class should be used in Enterprise Edition
#endif

namespace 씨샾겅부
{
    class EnterpriseUtility
    {
    }
}

// #error 예제 --------------------------------------
#define STANDARD_EDITION
#define ENTERPRISE_EDITION

#if (STANDARD_EDITION && ENTERPRISE_EDITION)
#error Use either STANDARD or ENTERPRISE edition. 
#endif

namespace 씨샾겅부
{
    class Class1
    {
    }
}

