public class Franc: Money
{
    public Franc(int amount, string currency): base(amount, currency)
    {
        
    }
    
    public override Money times(int Multiplier)
    {
        return new Franc(Amount * Multiplier, currency);
    }
}