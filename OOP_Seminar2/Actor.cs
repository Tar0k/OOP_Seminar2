namespace OOP_Seminar2;

public abstract class Actor
{
    protected string _name;
    protected bool _isMakeOrder;
    protected bool _isTakeOrder;


    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public bool IsMakeOrder
    {
        get => _isMakeOrder;
        set => _isMakeOrder = value;
    }

    public bool IsTakeOrder
    {
        get => _isTakeOrder;
        set => _isTakeOrder = value;
    }

    public abstract string GetName();
}