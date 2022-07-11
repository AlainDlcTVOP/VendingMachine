using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
     interface IVending
    {
        int Purchase(int input);
        List<String> ShowAll();
        int InsertMoney(int money);
        Dictionary<int, int> EndTransaction();
    }
}
