public class PlatinumFactory : CreditCardFactory
{
    public override ICreditCard CreateProduct() => new Platinum();
}