using FitStudBoomer.Domain;
using FitStudBoomer.Factories;
using FitStudBoomer.Strategies;
using System;

class Program
{

    static void Main()
    {

        Choice Choice = new("User");
        Console.WriteLine(">>> Welcome to FitStudio Boomerang <<<\n");

        Console.WriteLine(">Enter the membership type you would like to create: ");

        Console.WriteLine("> G - Gym");
        Console.WriteLine("> P - Gym + Pool");
        Console.WriteLine("> T - Personal Training");

        string membershipType = Console.ReadLine();

        MembershipFactory factory = GetFactory(membershipType);
        IMembership membership = factory.GetMembership();

        Console.WriteLine("\n> Membership you've just created: \n");

        Console.WriteLine(
            $"\nName:\t\t{membership.Name}\n" +
            $"\tDescription:\t{membership.Description}\n" +
            $"\tPrise:\t\t{membership.GetPrice()}");

        Console.WriteLine(">>> Where to next? <<<\n");
        Console.WriteLine("> Go - Go work out!");
        Console.WriteLine("> No - Not today(");

        string? numb = Console.ReadLine();
        switch (numb)
        {
            case "Go":
                Choice.SetServices(new Sport());
                Choice.Step();
                break;
            case "No":
                Choice.SetServices(new Laziness());
                Choice.Step();
                break;
        };


        Console.ReadLine();
    }

    private static MembershipFactory GetFactory(string membersipType) =>
        membersipType.ToLower() switch
        {
            "g" => new GymMembershipFactory(100, "Basic membership"),
            "p" => new GymPlusPoolMembershipFactory(150, "Good prise membership"),
            "t" => new PersonalTrainingMembershipFactory(400, "Best for professionals"),
            _ => null
        };
}