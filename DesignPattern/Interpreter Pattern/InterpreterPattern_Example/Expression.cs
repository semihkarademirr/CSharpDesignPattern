using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    interface Expression
    {
        void InterpretContext(Context context);
    }
}
