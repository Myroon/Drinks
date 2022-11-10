// Code sample - 11/07/2022
// Myron Oslie - myronoslie@gmail.com

using System;
using System.Collections.Generic;

namespace Drink
{  
  class Drink
  {
    public string name;
    public bool carbonated;

    public virtual void Description() { }

    public string Carbonated(bool carbonated)
    {
      return (carbonated ? "" : "not ") + "carbonated";
    }
  }

  class Beer : Drink
  {
    readonly double alcoholContent;

    public override void Description()
    {
      Console.Write($"{name}, {Carbonated(carbonated)}, {alcoholContent}%. ");
    }

    public Beer(string name, bool carbonated, double alcoholContent)
    {
      this.name = name;
      this.carbonated = carbonated;
      this.alcoholContent = alcoholContent;
    }
  }

  class Juice : Drink
  {
    readonly string fruitType;

    public override void Description()
    {
      Console.Write($"{name}, {Carbonated(carbonated)}, made from {fruitType}. ");
    }

    public Juice(string name, bool carbonated, string fruitType)
    {
      this.name = name;
      this.carbonated = carbonated;
      this.fruitType = fruitType;
    }
  }

  class Soda : Drink
  {
    public override void Description()
    {
      Console.Write($"{name}, {Carbonated(carbonated)}. ");
    }

    public Soda(string name, bool carbonated)
    {
      this.name = name;
      this.carbonated = carbonated;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      List<Drink> drinkList = new List<Drink>();
      drinkList.Add(new Juice("Orange Juice", false, "oranges"));
      drinkList.Add(new Beer("Budweiser", true, 5));
      drinkList.Add(new Soda("Pepsi", true));
      drinkList.Add(new Juice("Grape Juice", false, "grapes"));
      drinkList.Add(new Beer("Terminator", true, 6.8));
      drinkList.Add(new Soda("Royal Crown", true));

      foreach (Drink drink in drinkList)
      {
        drink.Description(); 
      }
      Console.WriteLine();
      // output: Orange Juice, not carbonated, made from oranges. Budweiser, carbonated, 5%. Pepsi, carbonated. Grape Juice, not carbonated, made from grapes. Terminator, carbonated, 6.8%. Royal Crown, carbonated.
    }
  }
}
