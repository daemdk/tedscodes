public class TitaniumFactory : CreditCardFactory
{
    public override ICreditCard CreateProduct() => new Titanium();
}