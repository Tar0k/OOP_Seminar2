// See https://aka.ms/new-console-template for more information

using OOP_Seminar2;

var market = new Market();

for (var i = 0; i < 5; i++)
{
    market.AcceptToMarket(new Human(Faker.Name.First()));
}

for (var i = 0; i < 15; i++)
{
    market.Update();
}
