using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    internal interface IAccount
    {
        bool PasswordCheaker(string password);
        void ShowInfo();
    }
}
