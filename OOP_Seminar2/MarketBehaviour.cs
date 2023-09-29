namespace OOP_Seminar2;

public interface IMarketBehaviour
{
    public void AcceptToMarket(Actor actor);
    public void ReleaseFromMarket(List<Actor> actors);
    public void Update();
}