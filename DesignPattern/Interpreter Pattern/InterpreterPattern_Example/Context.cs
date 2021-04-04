using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class Context
    {
        private string ac_model = "";
        private bool electronic = false;

        public Context(string _ac_model)
        {
            this.ac_model = _ac_model;
        }

        public string getModel()
        {
            return this.ac_model;
        }

        public int getLenght()
        {
            return this.ac_model.Length;
        }

        public string getLastChar()
        {
            return this.ac_model[this.ac_model.Length - 1].ToString();
        }

        public string getFirstChar()
        {
            return this.ac_model[0].ToString();
        }

        public void setIselectronic(bool _electronic)
        {
            this.electronic = _electronic;
        }

        public bool getIselectronic()
        {
            return this.electronic;
        }
    }
}
