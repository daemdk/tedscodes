public class Titanium : ICreditCard
{
    public string GetCardType() => "Titanium";
    public double GetCreditLimit() => 25000;
    public double GetAnnualCharge() => 1500;
}