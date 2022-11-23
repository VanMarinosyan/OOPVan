namespace Packt.Shared
{
   public partial class Person                    //regex
   {
     // aproperty defined using C# 1-5 sytax
     public string Origin
     {
        get
        {
            return $"{Name} was born on {HomePlanet}";
        }
     }
     // two proporties defined using C# 6+ lambda expression
     public string Greeting => $"{Name} says 'Hello'";
     public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

     public string FavoriteIceCream{ get; set;}  //auto syntax

    private string favoritePrimaryColor;

     public string FavoritePrimaryColor
   {
    get
    {
        return favoritePrimaryColor;
    }
    set
    {
       switch ( value.ToLower())
       {
        case "red":
        case "green":
        case "blue":
        favoritePrimaryColor = value;
        break;
        throw new System.ArgumentException(
            $"{value} is not a primary color. " +
            "Choose from: red, green, blue");
       }
    }
   }
   }

   
}