using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class BrandExpression : Expression
    {
        public void InterpretContext(Context context)
        {
            if (context.getIselectronic() == true)
            {
                if (context.getFirstChar().Equals("I"))
                    Console.WriteLine("Brand is  APPLE");
                else if (context.getFirstChar().Equals("D"))
                    Console.WriteLine("Brand is  DELL");              
            }
            else 
                Console.WriteLine("Brand could not be interpreted");
        }
    }
}
