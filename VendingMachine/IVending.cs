using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
     interface IVending
    {
        public Product Purchase(int input);
        public void ShowAll();
        public int InsertMoney(int money);
        public void EndTransaction();
    }
}
