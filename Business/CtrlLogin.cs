using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.Business
{
    public class CtrlLogin
    {
        public bool isValidLogin(string email, string pwd)
        {
            bool isValid = false;
            if(!String.IsNullOrEmpty(email))
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
