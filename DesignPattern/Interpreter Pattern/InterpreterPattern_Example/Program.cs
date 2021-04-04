using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {         
            List<Context> lstElectronic = new List<Context>();
            List<Expression> lstExpressions = new List<Expression>();

            lstElectronic.Add(new Context("IPHONE X"));
            lstElectronic.Add(new Context("D950L"));
            lstElectronic.Add(new Context("D700L"));
            lstElectronic.Add(new Context("IPHONE XR"));
            lstElectronic.Add(new Context("TheCode"));




            lstExpressions.Add(new CheckExpression());
            lstExpressions.Add(new BrandExpression());
            lstExpressions.Add(new ModelExpression());
            lstExpressions.Add(new TypeExpression());

            for (int ac_index = 0; ac_index < lstElectronic.Count; ac_index++)
            {
                for (int exp_index = 0; exp_index < lstExpressions.Count; exp_index++)
                {
                    lstExpressions[exp_index].InterpretContext(lstElectronic[ac_index]);
                }
                Console.WriteLine("-----------------------------------");
            }
            Console.ReadLine();
        }
    }
}
