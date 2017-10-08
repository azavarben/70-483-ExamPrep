#define DEBUGCODE
#define BEN


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.PreprocessorDirectives
{
    class Demo
    {
        public static string DoStuff()
        {
            var returnString = string.Empty;

#if BEN
            returnString = "Ben";
#else
            compiler will totally ignore this shit, not even in the compiled dll
#endif

#if NOTDEFINED
            NOTDEFINED is not defined using a define, duh
#endif

            return returnString;
        }
    }
}
