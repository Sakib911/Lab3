using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Account
    {
        string accName, acid;
        int balance;

        public string getAccName()
        {
            return accName;
        }
        public void setAccName(String AccName)
        {
            accName = AccName;
        }
        public string getAcid()
        {
            return accName;
        }
        public void setAcid(String Acid)
        {
            acid = Acid;
        }
        public int getBalance()
        {
            return balance ;
        }
        public void setBalance(int Balance)
        {
            balance= Balance ;
        }

        public void Deposit(int ammount)
        {
            balance = balance + ammount;
        }
        public void withdraw(int ammount)
        {
            balance = balance - ammount;
        }
    }
}
