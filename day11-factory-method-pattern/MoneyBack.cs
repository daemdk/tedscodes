public class MoneyBack : ICreditCard
{
    public string GetCardType() => "MoneyBack";
    public double GetCreditLimit() => 15000;
    public double GetAnnualCharge() => 500;
}
