namespace OOP_Seminar2;

public class Human : Actor, IActorBehaviour
{
    public Human(string name)
    {
        _name = name;
    }

    public override string GetName() => _name;

    public void SetMakeOrder() => _isMakeOrder = true;

    public void SetTakeOrder() => _isTakeOrder = true;

    public new bool IsMakeOrder() => _isMakeOrder;

    public new bool IsTakeOrder() => _isTakeOrder;
}