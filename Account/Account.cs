using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private String _User;
        private String _Number;
        private String _Login;
        private String _Password;
        private bool logged;
        private double _Balance = 0;

        public Account(String user, String num, String log, String pass)
        {
            _User = user; 
            _Number = num;
            _Login = log;
            _Password = pass;
        }

        public void Zaloguj(String log, String pass)
        {
            if ((_Login == log) && (_Password == pass)) { logged = true; }
        }
        
        public void Logout(String log, String pass)
        {
            if(_Login == log && _Password == pass)
            {
                if (logged == true) logged = false;
            }
        }

        public void ChangePass(String oldPass, String newPass)
        {
            if (logged == true)
            {
                if (_Password == oldPass) _Password = newPass;
            }   
        }

        public void Deposit(double addDeposit)
        {
            if (logged == true)
            {
                _Balance += addDeposit;
            }
        }

        public void PayOut(double removeDeposit)
        {
            if (logged == true)
            {
                _Balance -= removeDeposit;
            }
        }

        public override String ToString()
        {
            return "\nUżytkownik konta " + _User + " o numerze " + _Number + " posiada na koncie " + _Balance + " twoje hasło " + _Password + " stan zalogowania " + logged;
        }
    }
}
