// Day 11 - Factory Method Pattern
// Please read readme.md first.

Console.WriteLine("Hello, Day 11!");

var moneyBackFactory = new MoneyBackFactory();
var moneyBackCard = moneyBackFactory.CreateProduct();
Console.WriteLine($"Card Type: {moneyBackCard.GetCardType()}, Limit: {moneyBackCard.GetCreditLimit()}, Annual Charge: {moneyBackCard.GetAnnualCharge()}");
