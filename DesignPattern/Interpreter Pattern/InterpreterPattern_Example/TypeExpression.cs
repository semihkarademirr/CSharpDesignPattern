using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class TypeExpression : Expression
    {
        public void InterpretContext(Context context)
        {
            if (context.getIselectronic() == true)
            {
                string ac_model = context.getModel();
                if (context.getLenght() == 5 && context.getLastChar().Equals("L"))
                {              
                    Console.WriteLine("Electronic type is Hybrid Computer");
                }
                else
                    
                Console.WriteLine("Electronic type is Mobile Phone");
            }
            else
            
            Console.WriteLine("Type could not be interpreted");
        }
    }
}
