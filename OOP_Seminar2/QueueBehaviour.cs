namespace OOP_Seminar2;

public interface IQueueBehaviour
{
    public void TakeInQueue(Actor actor);
    public void TakeOrders();
    public void GiveOrders();
    public void ReleaseFromQueue();
}