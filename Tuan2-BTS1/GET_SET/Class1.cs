using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET_SET
{
    class Employee2
    {
        private string code;
        private string name;
        public string Code
        {
            get
            {
                return this.code;
            }
            set
            {
                this.code = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public Employee2(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }
}
