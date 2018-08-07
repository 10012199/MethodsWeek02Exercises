using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacobExample
{
    public class FirstName
    {
        string fname;

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        // Public int Fname { get; set; } -> prop <tab><tab>.        

        public FirstName (string _fname)
        {
            Fname = _fname;
        }
    }
}
