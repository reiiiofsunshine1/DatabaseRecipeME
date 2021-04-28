using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePersonalPBO
{
    class customer
    { 
        public int Id { get; private set; }
        public String myName { get; private set; }
        public String myAddress { get; private set; }
        public void userDet(int id, String uName, String uAdd)
        {
            Id = id;
            myName = uName;
            myAddress = uAdd;
        }
    }
}
