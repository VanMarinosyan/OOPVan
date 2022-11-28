using Packt.Shared;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        var bob = new Person();
        WriteLine(bob.ToString());
        bob.Name = "Bob";

        bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlimpia;
        WriteLine(format: "{0}'s Favorite wonder is {1}. It's integer is {2}.",
            arg0: bob.Name,
            arg1: bob.FavoriteAncientWonder,
            arg2: (int)bob.FavoriteAncientWonder);

        bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
        // bob.BucketList = (WondersOfTheAncientWorld)18;
        WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

        bob.Children.Add(new Person { Name = "Alfred" });
        bob.Children.Add(new Person { Name = "Zoe" });

        WriteLine($"{bob.Name} has {bob.Children.Count} children");
        for (int child = 0; child < bob.Children.Count; child++)
        {
            WriteLine($"{bob.Children[child].Name}");
        }
        BankAccount.Interestrate = 0.012M;
        var jonesAccount = new BankAccount();
        jonesAccount.AccountName = "Mrs. Jones";
        jonesAccount.Balance = 2400;

        WriteLine(format: "{0} earned {1:C} interest.",
          arg0: jonesAccount.AccountName,
          arg1: jonesAccount.Balance * BankAccount.Interestrate);

        var gerrierAccount = new BankAccount();
        gerrierAccount.AccountName = "Ms. Gerrier";
        gerrierAccount.Balance = 98;

        WriteLine(format: "{0} earned {1:C} interest.",
          arg0: gerrierAccount.AccountName,
          arg1: gerrierAccount.Balance * BankAccount.Interestrate);

        WriteLine($"{bob.Name} is a {Person.Species}");

        WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

        var blankPerson = new Person();
        WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
           arg0: blankPerson.Name,
           arg1: blankPerson.HomePlanet,
           arg2: blankPerson.Instantiated);

        var gunny = new Person("Gunny", "Mars");
        WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
        arg0: gunny.Name,
        arg1: gunny.HomePlanet,
        arg2: gunny.Instantiated);  

         (string, int) fruit = bob.GetFruit();
         WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

         bob.SayHello();
         bob.SayHelloTo("Mark");

         WriteLine (bob.OptionalParametrs(number: 52.7, command: "Hide!"));

         var sam = new Person    //proporty
         {
          Name = "Sam",
          DateOfBirth = new DateTime(1972, 1, 27)
         };
         WriteLine(sam.Origin);
         WriteLine(sam.Greeting);
         WriteLine(sam.Age);

         sam.FavoriteIceCream = "Chocolate Fudge";
         WriteLine($"Sam`s favorite ice-cream is {sam.FavoriteIceCream}.");
         sam.FavoritePrimaryColor = "Red";
         WriteLine($"Sam`s favorite primary color is {sam.FavoritePrimaryColor}.");

         sam.Children.Add(new Person { Name = "Charlie"});
         sam.Children.Add(new Person { Name = "Ella"});
         WriteLine($"Sam`s first child is {sam.Children[0].Name}");
         WriteLine($"Sam`s second child is {sam.Children[1].Name}");
         WriteLine($"Sam`s first child is {sam[0].Name}");
         WriteLine($"Sam`s second child is {sam[1].Name}");


         Employee john = new Employee
         {
          Name = "John Jones",
          DateOfBirth = new DateTime(1990, 7, 28)
         };
         john.WriteToConsole();


         john.EmployeeCode = "JJ001";
         john.HireDate = new DateTime(2014, 11, 23);
         WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

         WriteLine (john.ToString());
         WriteLine (bob.ToString());


         

    }
}