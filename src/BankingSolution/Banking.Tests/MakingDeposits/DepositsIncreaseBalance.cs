using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain;

namespace Banking.Tests.MakingDeposits;
[Trait("Category", "Unit")]
public class DepositsIncreaseBalance
{
    [Theory]
    [InlineData(110.10)]
    [InlineData(.25)]
    //[InlineData(-23.52)] // shouldnt be able to deposit negative into account
    //[InlineData(0)] // same for zero
    //[Fact]
    public void MakingADeposit(decimal amountToDeposit)
    {
        var account = new BankAccount();
        var openingBalance = new BankAccount().GetBalance();
        //var amountToDeposit = 100.10M;

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());

    }

    [InlineData(-23.52)] // shouldnt be able to deposit negative into account
    [InlineData(0)] // same for zero
    [Theory]
    public void InvalidAmountsCannotBeDeposited(decimal amountToDeposit)
    {
        var account = new BankAccount();
        var openingBalance = new BankAccount().GetBalance();

        //account.Deposit(amountToDeposit); // this would throw an exception and fail the test because it comes before the assert

        Assert.Throws<InvalidTransactionAmountException>(() => account.Deposit(amountToDeposit));

        Assert.Equal(openingBalance, account.GetBalance());
    }

}
