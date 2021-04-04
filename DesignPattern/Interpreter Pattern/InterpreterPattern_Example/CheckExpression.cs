

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class CheckExpression : Expression
    {
        public void InterpretContext(Context context)
        {

            string ac_model = context.getModel();
            if (ac_model.StartsWith("I") || ac_model.StartsWith("D"))
            {
                if (ac_model.Length <= 2 || ac_model.Length <=15)
                {
                    context.setIselectronic(true);
                    Console.WriteLine(ac_model + " is an electronic...");
                }
                else
                {
                    context.setIselectronic(false);
                    Console.WriteLine(ac_model + " is not electronic...");
                }
            }
            else
            {
                context.setIselectronic(false);
                Console.WriteLine(ac_model + " is not electronic...");
            }
        
        }
    }
}
