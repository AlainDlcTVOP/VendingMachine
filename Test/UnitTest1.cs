using VendingMachine;

namespace Test
    
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Machine machine = new Machine();
            int value = 100;
            machine.InsertMoney(false,value.ToString());
            Assert.Equal(machine.kronorpool,value);
        }
        
    }
}