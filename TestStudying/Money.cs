public class Money
{
    public virtual Money times(int multiplier) {
        return null;
    }
    protected string currency { get; set; }

    protected int Amount { get; set; }
    
    public string Currency() {
        return this.currency;
    }

    public Money(int amount, string currency) {
        this.Amount = amount;
        this.currency = currency;
    }

    public static Dollar dollar(int amount)
    {
        return new Dollar(amount, "USD");
    }

    public static Franc franc(int amount)
    {
        return new Franc(amount, "CHF");
    }

    public override bool Equals(object obj)
    {
        Money money = (Money)obj;
        return Amount == money.Amount && GetType().Equals(money.GetType());
    }
}