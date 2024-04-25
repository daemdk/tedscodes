public class Platinum : ICreditCard
{
    public string GetCardType() => "Platinum";
    public double GetCreditLimit() => 50000;
    public double GetAnnualCharge() => 3000;
}