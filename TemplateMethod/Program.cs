using System;
public class Hello
{
    public abstract class Cooking
    {
        public void Cook()
        {
            this.GetTheIngredients();
            this.Collect();
            this.Warm();
            this.IsDone();
        }
        
        protected abstract void GetTheIngredients();
        protected abstract void Collect();
        protected abstract void Warm();
        
        protected virtual void IsDone() 
        {
            Console.WriteLine("Готово!");
        }
    }
    
    public class Sandwich : Cooking
    {
        protected override void GetTheIngredients()
        {
            Console.WriteLine("Достаем хлебушек, колбаску и сыр.");
        }
        
        protected override void Collect()
        {
            Console.WriteLine("Собираем бутерброд.");
        }
        
        protected override void Warm()
        {
            Console.WriteLine("Подогреваем в микроволновке.");
        }
        
        public override string ToString()
        {
            return "Горячий бутерброд.";
        }
    }
    
    public static void Main()
    {
        var sandwich = new Sandwich();
        Console.WriteLine(sandwich);
        sandwich.Cook();
    }
}
