using System;

public class Hello
{
    class Creator
    {
        public void Send()
        {
            Console.WriteLine("Factory Method!");
        }
    }

    class ConcreteCreator : Creator
    {

    }

    class Product
    {
        public void CreateProduct()
        {
            Console.WriteLine("Product has been created!");
        }
    }

    class ConcreteProduct : Product
    {

    }

    public static void Main()
    {
        Creator cr = new Creator();
        cr.Send();
        ConcreteCreator ccr = new ConcreteCreator();
        ccr.Send();
        Product pr = new Product();
        pr.CreateProduct();
        ConcreteProduct cpr = new ConcreteProduct();
        cpr.CreateProduct();
    }
}