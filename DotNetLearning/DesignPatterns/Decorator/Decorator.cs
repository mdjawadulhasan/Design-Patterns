public abstract class Beverage
{
    public abstract string GetDescription();
    public abstract double Cost();
}

public class Coffee : Beverage
{
    public override double Cost()
    {
        return 1.0;
    }

    public override string GetDescription()
    {
        return "Coffee With";
    }
}

public abstract class BeverageDecorator : Beverage
{
    protected Beverage beverage;
    public BeverageDecorator(Beverage beverage)
    {
        this.beverage = beverage;
    }
}


public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(Beverage beverage):base(beverage) { }

    public override double Cost()
    {
        return beverage.Cost() + 10;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Milk";
    }
}

public class CreamDecorator : BeverageDecorator
{
    public CreamDecorator(Beverage beverage) : base(beverage) { }

    public override double Cost()
    {
        return beverage.Cost() + 20;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Cream";
    }
}

//public class Program
//{
//    public static void Main()
//    {
//        Beverage beverage = new Coffee();
//        Console.WriteLine(beverage.GetDescription());

//        beverage = new MilkDecorator(beverage);
//        Console.WriteLine(beverage.GetDescription());


//        beverage = new CreamDecorator(beverage);
//        Console.WriteLine(beverage.GetDescription());
//    }
//}