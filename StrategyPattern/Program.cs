public class Hello
{
    class Navigator
    {
        private RouteStrategy strategy;

        public void BuildRoute(int a, int b)
        {
            this.strategy.BuildRoute(a, b);
        }

        public void SetStrategy(RouteStrategy strategy)
        {
            this.strategy = strategy;
        }
    }

    interface RouteStrategy
    {
        Route BuildRoute(int a, int b);
    }

    class Route
    {

    }

    class RoadStrategy : RouteStrategy
    {
        public Route BuildRoute(int a, int b)
        {
            System.Console.WriteLine("RoadStrategy");
            return new Route();
        }
    }

    public static void Main()
    {
        Navigator navigator = new Navigator();
        navigator.SetStrategy(new RoadStrategy());
        navigator.BuildRoute(1, 1);
    }
}