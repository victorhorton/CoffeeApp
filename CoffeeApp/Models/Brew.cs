using System;
namespace CoffeeApp.Models
{

    public enum BrewType
    {
        Drip,
        FrenchPress,
        PourOver,
        ColdBrew,
        Other
    }

    public class Brew
    {
        public int Id { get; set; }
        public string CoffeeOrigin { get; set; }
        public BrewType BrewType { get; set; }

        public Brew()
        {
        }
    }
}