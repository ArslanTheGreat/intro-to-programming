
namespace Banking.Tests.MakingWithdrawals;
public class OverdraftNotAllowed
{

    [Fact]
    
    public void OverdraftDoesNotDecreaseYourBalance()
    {
        // given i have a bank account with x balance
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        // when i withdraw x+1 from the account

        try
        {
            account.Withdraw(openingBalance + .01M);
        }
        catch (Exception)
        {

            // I dont care what happend or nothing happend
            // we just want to make sure that overdraft doesnt decrease balance

        }
        // then the accoount still has a balance of x
        Assert.Equal(openingBalance, account.GetBalance());
    }


    [Fact]
    public void AnOverdraftExceptionIsProvided()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        
        Assert.Throws<AccountOverdraftException>(() => account.Withdraw(openingBalance + .01M));
    }
}
