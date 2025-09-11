

namespace Banking.Tests.MakingWithdrawals;

[Trait("Category", "Unit")]
public class WithdrawalsDecreasesBalance
{
    [Theory] // vs [Fact] is what you are doing a fact or a theory is there '
             // one singualar true thing or can it be multiple
    [InlineData(110.10)]
    [InlineData(50)]
    //[InlineData(80000)]// this is an overdraft it should fail
    //[Fact]
    public void MakingAWithdrawal(decimal amountToWithdraw) // "Primitive Obsession"
    {
        var account = new BankAccount();
        var openingBalance = new BankAccount().GetBalance();


        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());

    }

    [Fact]
    public void MayWithdrawFullBalance() // have this test because user should be 
                                         // able to withdraw full balance
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Withdraw(openingBalance);

        Assert.Equal(0M, account.GetBalance());
    }
   
}
