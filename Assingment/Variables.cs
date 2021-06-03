using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
   public class Variables
    {
        //String variable set and get
        public string variable { get; set; }

        //Float value get and set
        public float value { get; set; }


        //set and get mehtod of variable
        /// <summary>
        /// setVariable method to set varible
        /// </summary>
        /// <param name="variable">return varible</param>
        public void setVariable(string variable)
        {
            this.variable = variable;
        }

        /// <summary>
        /// This method get the variable
        /// </summary>
        /// <returns></returns>
        public string getVariable()
        {
            return this.variable;
        }


        /// <summary>
        /// Set and get method of value
        /// </summary>
        /// <param name="value">return the value of set</param>
        public void setValue(float value)
        {
            this.value = value;
        }

        /// <summary>
        /// method to retunrn the value
        /// </summary>
        /// <returns>return value</returns>

        public float getValue()
        {
            return this.value;
        }
    }
}

