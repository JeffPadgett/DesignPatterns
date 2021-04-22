using System;

namespace SimpleFactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzaType) => pizzaType switch
        {
            "cheese" => new CheesePizza(),
            "pepperoni" =>  new PepperoniPizza(),
            "clam" => new ClamPizza(),
            "veggie" => new VeggiePizza(),
            _ => throw new Exception("No pizza of this type exist.")           
        };
    }
    
    
}
