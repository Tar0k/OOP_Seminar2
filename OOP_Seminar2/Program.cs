using OOP_Seminar2;

var market = new Market();

for (var i = 0; i < 5; i++)
{
    market.AcceptToMarket(new Human(Faker.Name.First()));
}

for (var i = 0; i < 50; i++)
{
    market.Update();
}
