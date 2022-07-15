using VendingMachine;

namespace Test
    
{
    public class UnitTest1
    {
        [Fact]
        public void InsertMoneyTest()
        {
            Machine machine = new Machine();
            int value = 100;
            machine.InsertMoney(false,value.ToString());
            Assert.Equal(machine.kronorpool,value);
        }
        [Fact]
        public void ExecutePurchaseTest()
        {
            Machine machine = new Machine();
            int value = 100;
            machine.InsertMoney(false, value.ToString());
            machine.ExecutePurchase(new Drink ("cola", 20,"","" ));
            Assert.Equal(80, machine.kronorpool);
        }

        [Fact]
        public void EndTransactionTest()
        {
            Machine machine = new Machine();
            int value = 100;
            int[] x = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
           
            machine.InsertMoney(false, value.ToString()); 
            machine.EndTransaction();
          
            Assert.Equal(machine.kronorpool, 0 );
        }
        [Fact]
        public void EndTransactionTest2()
        {
            Machine machine = new Machine();
          
            int[] x = new int[8];
            int[] xs = new int[] {0,0,0,0,1,1,1,2};
            machine.kronorpool = 37;
            x=machine.EndTransaction();

            Assert.Equal(x, xs);
        }
    }
}