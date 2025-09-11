


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
        if (amountToDeposit <= 0)
        {
            throw new InvalidTransactionAmountException();
        }
        balance += amountToDeposit;

    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw <= 0) // These are sometimes called "Guard" clauses.
        {
            throw new InvalidTransactionAmountException();
        }
        if (amountToWithdraw <= balance)
        {
            balance -= amountToWithdraw;
        }
        else
        {
            throw new AccountOverdraftException();
        }
    }
}
