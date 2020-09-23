using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication
{
    class IdGenerator
    {
        static int id = 0;
        string storeId;

        public string GenerateID()
        {
            string gid = DateTime.Now.ToString("yyyy-MM");
            storeId = gid + ++id;
            return storeId;
        }
    }
}
