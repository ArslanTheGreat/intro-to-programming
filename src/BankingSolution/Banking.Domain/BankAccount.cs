


namespace Banking.Domain;

public class BankAccount
{
    private decimal balance = 5000M; //Fields
     
    // An object own some data and owns states where we can access and manipulate that data
    // So a Service

    public decimal GetBalance()
    {
        
        return balance; // hardcoded slime
    }

    public void Deposit(decimal amountToDeposit)
    {
        balance += amountToDeposit;

    }

    public void Withdraw(decimal amountToWithdraw)
    {
        balance -= amountToWithdraw;
    }
}