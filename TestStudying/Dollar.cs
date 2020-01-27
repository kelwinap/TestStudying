public class Dollar : Money
{
    public Dollar(int amount, string currency) : base(amount, currency)
    {
        
    }
    public override Money times(int Multiplier)
    {
        return new Dollar(Amount * Multiplier, currency);
    }
    
}