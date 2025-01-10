using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolutions
{
    public class UserModel
    {
        public string FirstName { get; set; }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 125)
                {
                    throw new ArgumentOutOfRangeException("value", "That's not a valid age at all.");
                }
                else
                {
                    _age = value;
                }
            }
        }

        private int _zipcode;

        public int Zipcode
        {
            get { return _zipcode; }
            set
            {
                if (value.ToString().Length == 5 && int.TryParse(value.ToString(), out int _zipcode) == true)
                {
                    _zipcode = value;
                }
                else
                {
                    throw new Exception("That either isn't the right length or isn't a number ding dong.");
                }
            }
        }
    }
}
