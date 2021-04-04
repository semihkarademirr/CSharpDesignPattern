using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class ModelExpression : Expression
    {
        public void InterpretContext(Context context)
        {
            if (context.getIselectronic() == true)
            {
                Console.WriteLine("Model is : " + context.getModel());
            }
            else
                Console.WriteLine("Model could not be interpreted");
        }
    }
}
