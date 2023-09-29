namespace OOP_Seminar2;

public class Market : IMarketBehaviour, IQueueBehaviour
{
    private readonly Random _random = new();
    private readonly List<Human> _marketVisitors = new();
    private readonly Queue<Human> _queue = new();
    
    public void AcceptToMarket(Actor actor)
    {
        _marketVisitors.Add((Human)actor);
        Console.WriteLine($"{actor.Name} зашел в магазин.");
    }

    public void ReleaseFromMarket(List<Actor> actors)
    {
        foreach (var actor in actors)
        {
            _marketVisitors.Remove((Human)actor);
            Console.WriteLine($"{actor.Name} вышел из магазина.");
        }
    }

    public void Update()
    {
        if (_queue.Count > 0)
        {
            var firstInQueue = _queue.Peek();
            if (firstInQueue.IsTakeOrder()) ReleaseFromQueue();
            else if (!firstInQueue.IsMakeOrder()) TakeOrders();
            else if (firstInQueue.IsMakeOrder()) GiveOrders();
        }
        
        foreach (var human in _marketVisitors.Where(h=> h.IsMakeOrder() == false & !_queue.Contains(h)))
        {
            if (_random.Next(1, 3) == 3)
            {
                Console.WriteLine($"{human.Name} еще смотрит и не встал в очередь");
            }
            else
            {
                TakeInQueue(human);
            }
        }

        
        
        var leavers = new List<Actor>();
        foreach (var human in _marketVisitors.Where(h => h.IsTakeOrder() && !_queue.Contains(h)))
        {
            if (_random.Next(1, 4) > 3)
            {
                Console.WriteLine($"{human.Name}Забрал заказ, но еще что-то смотрит");
            }
            else
            {
                leavers.Add(human);
            }
        }
        ReleaseFromMarket(leavers);
    }

    public void TakeInQueue(Actor actor)
    {
        _queue.Enqueue((Human)actor);
        Console.WriteLine($"{actor.Name} встал в очередь");
    }

    public void TakeOrders()
    {
        var human = _queue.Peek();
        human.SetMakeOrder();
        Console.WriteLine($"Принят заказ от {human.Name}");
    }

    public void GiveOrders()
    {
        var human = _queue.Peek();
        human.SetTakeOrder();
        Console.WriteLine($"Выдан заказ {human.Name}");
    }

    public void ReleaseFromQueue()
    {
        var human = _queue.Dequeue();
        Console.WriteLine($"{human.Name} вышел из очереди");
    }

}