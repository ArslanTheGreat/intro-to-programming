using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain;

namespace Banking.Tests.MakingWithdrawals;
[Trait("Category", "Unit")]
public class WithdrawalsDecreasesBalance
{
    [Theory] // vs [Fact] is what you are doing a fact or a theory is there '
             // one singualar true thing or can it be multiple
    [InlineData(110.10)]
    [InlineData(50)]
    // [InlineData(80000)] // this is an overdraft
    //[Fact]
    public void MakingAWithdrawal(decimal amountToWithdraw)
    {
        var account = new BankAccount();
        var openingBalance = new BankAccount().GetBalance();
        

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());

    }
}
