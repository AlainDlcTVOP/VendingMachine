using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    abstract class Product : IVending
    {
        public Dictionary<int, int> EndTransaction()
        {
            throw new NotImplementedException();
        }

        public abstract void Examine();
        

        public int InsertMoney(int money)
        {
            throw new NotImplementedException();
        }

        public int Purchase(int input)
        {
            throw new NotImplementedException();
        }

        public List<string> ShowAll()
        {
            throw new NotImplementedException();
        }

        public abstract void Use();
      
    }
}
