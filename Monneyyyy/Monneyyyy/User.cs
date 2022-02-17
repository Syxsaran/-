using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monneyyyy
{
    internal class User
    {
        private string _incomemoney;
        private string _outmoney;
        private string _inorout;


        //constructor
        public User(string incomemoney, string outmoney, string inorout)
        {
            this._incomemoney = incomemoney;
            this._outmoney = outmoney;
            this._inorout = inorout;

        }

        //encapsulation
        public string getIn() { return this._incomemoney; }
        public string getOut() { return this._outmoney; }
        public string getOr() { return this._inorout; }
    }
}
