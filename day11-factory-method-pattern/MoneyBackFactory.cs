public class MoneyBackFactory : CreditCardFactory
{
    public override ICreditCard CreateProduct() => new MoneyBack();
}
