using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Tests;
[Trait("Category", "UnitIntegratiion")]
public class CancellingAnAccount
{
    // So this file is to just show diff traits and the ability to run tests
    // specifically to a trait so you are not running all the tests all the time
    
    [Fact]
    public async Task CancellingAnAccountNotifies()
    {
        //in thsi test we will cancel an account and it should send and
        // sms noti to the customer and if accoutn is VIP
        //it should notify bank president

        await Task.Delay(1000);// fake delay
    }
}
