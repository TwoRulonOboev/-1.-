using System;

// Подсистема 1: Тесто
public class DoughMaker
{
    public void PrepareDough()
    {
        Console.WriteLine("Тесто подготовлено.");
    }
}

// Подсистема 2: Начинка
public class ToppingAdder
{
    public void AddCheese()
    {
        Console.WriteLine("Сыр добавлен.");
    }

    public void AddTomatoes()
    {
        Console.WriteLine("Помидоры добавлены.");
    }

    public void AddPepperoni()
    {
        Console.WriteLine("Пепперони добавлено.");
    }
}

// Подсистема 3: Выпечка
public class Oven
{
    public void Bake()
    {
        Console.WriteLine("Пицца выпекается.");
    }
}

// Подсистема 4: Доставка
public class DeliveryService
{
    public void Deliver()
    {
        Console.WriteLine("Пицца доставлена клиенту.");
    }
}

// Фасад: Упрощенный интерфейс для работы с пиццерией
public class PizzaFacade
{
    private DoughMaker doughMaker;
    private ToppingAdder toppingAdder;
    private Oven oven;
    private DeliveryService deliveryService;

    public PizzaFacade()
    {
        doughMaker = new DoughMaker();
        toppingAdder = new ToppingAdder();
        oven = new Oven();
        deliveryService = new DeliveryService();
    }

    public void MakePizza()
    {
        doughMaker.PrepareDough();
        toppingAdder.AddCheese();
        toppingAdder.AddTomatoes();
        oven.Bake();
        deliveryService.Deliver();
    }

    public void MakePepperoniPizza()
    {
        doughMaker.PrepareDough();
        toppingAdder.AddCheese();
        toppingAdder.AddPepperoni();
        oven.Bake();
        deliveryService.Deliver();
    }
}

// Пример использования
public class Program
{
    public static void Main(string[] args)
    {
        PizzaFacade pizzaFacade = new PizzaFacade();

        // Заказ обычной пиццы
        Console.WriteLine("Заказ пиццы:");
        pizzaFacade.MakePizza();

        // Заказ пиццы с пепперони
        Console.WriteLine("\nЗаказ пиццы с пепперони:");
        pizzaFacade.MakePepperoniPizza();
    }
}
