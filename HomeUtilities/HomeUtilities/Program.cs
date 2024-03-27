using HomeUtilities;

Console.WriteLine("Witamy w programie 'Home Utilities' liczącą koszty za zużyte media");
Console.WriteLine("=====================================");
Console.WriteLine("Wybierz, za co chcesz wpisać należność");

var gas = new HomeUtilitiesSaved("Gas");
var water = new HomeUtilitiesSaved("Water");
var electricity = new HomeUtilitiesSaved("Electrycity");
var garbage = new HomeUtilitiesSaved("Garbage");
var sewage = new HomeUtilitiesSaved("Sewage");
var rent = new HomeUtilitiesSaved("Rent");
var internet = new HomeUtilitiesSaved("Internet");

gas.AmountAdded += GasAmountAdded;
void GasAmountAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową kwotę za gas");
}

water.AmountAdded += WaterAmountAdded;
void WaterAmountAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową kwotę za wodę");
}

electricity.AmountAdded += ElectrticityAmountAdded;
void ElectrticityAmountAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową kwotę za prąd");
}

garbage.AmountAdded += GarbageAmountAdded;
void GarbageAmountAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową kwotę za śmieci");
}

sewage.AmountAdded += SewageAmountAdded;
void SewageAmountAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową kwotę za ścieki");
}

rent.AmountAdded += RentAmountAdded;
void RentAmountAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową kwotę za czynsz");
}

internet.AmountAdded += InternetAmountAdded;
void InternetAmountAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową kwotę za internet");
}

while (true)
{
    Console.WriteLine("Chcąc wprowadzić należność za konkretne medium, wpisz literę według poniższej instrukcji:");
    Console.WriteLine("G - gaz; W - woda; P - prąd; Ś - śmieci; S - ścieki; C - czynsz; I - internet; q - zakończ i przejdź do statystyk");
    var input = Console.ReadLine();
    if (input == "q")
    { 
        break; 
    }
    switch (input) 
    {
        case "G":
            Console.WriteLine("Wprowadź kwotę za gas:");
            var input1 = Console.ReadLine();
            try
            {
                gas.AddAmount(input1);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exceptio catched: {e.Message}");
            }
            break;
        case "W":
            Console.WriteLine("Wprowadź kwotę za wodę:");
            var input2 = Console.ReadLine();
            try
            {
                water.AddAmount(input2);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exceptio catched: {e.Message}");
            }
            break;
        case "P":
            Console.WriteLine("Wprowadź kwotę za prąd:");
            var input3 = Console.ReadLine();
            try
            {
                electricity.AddAmount(input3);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exceptio catched: {e.Message}");
            }
            break;
        case "Ś":
            Console.WriteLine("Wprowadź kwotę za śmieci:");
            var input4 = Console.ReadLine();
            try
            {
                garbage.AddAmount(input4);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exceptio catched: {e.Message}");
            }
            break;
        case "S":
            Console.WriteLine("Wprowadź kwotę za ścieki:");
            var input5 = Console.ReadLine();
            try
            {
                sewage.AddAmount(input5);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exceptio catched: {e.Message}");
            }
            break;
        case "C":
            Console.WriteLine("Wprowadź kwotę za czynsz:");
            var input6 = Console.ReadLine();
            try
            {
                rent.AddAmount(input6);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exceptio catched: {e.Message}");
            }
            break;
        case "I":
            Console.WriteLine("Wprowadź kwotę za internet:");
            var input7 = Console.ReadLine();
            try
            {
                internet.AddAmount(input7);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exceptio catched: {e.Message}");
            }
            break;
        default:
            Console.WriteLine("Wprowadziłeś niewłaściwą literę");
            break;

    }

    //    if (input == "q")
    //    {
    //        break;
    //    }
    //    else if (input == "G")
    //    {
    //        Console.WriteLine("Wprowadź kwotę za gas:");
    //        var input1 = Console.ReadLine();
    //        try
    //        {
    //            gas.AddAmount(input1);
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine($"Exceptio catched: {e.Message}");
    //        }
    //    }
    //    else if (input == "W")
    //    {
    //        Console.WriteLine("Wprowadź kwotę za wodę:");
    //        var input1 = Console.ReadLine();
    //        try
    //        {
    //            water.AddAmount(input1);
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine($"Exceptio catched: {e.Message}");
    //        }
    //    }
    //    else if (input == "P")
    //    {
    //        Console.WriteLine("Wprowadź kwotę za prąd:");
    //        var input1 = Console.ReadLine();
    //        try
    //        {
    //            electricity.AddAmount(input1);
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine($"Exceptio catched: {e.Message}");
    //        }
    //    }
    //    else if (input == "Ś")
    //    {
    //        Console.WriteLine("Wprowadź kwotę za śmieci:");
    //        var input1 = Console.ReadLine();
    //        try
    //        {
    //            garbage.AddAmount(input1);
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine($"Exceptio catched: {e.Message}");
    //        }
    //    }
    //    else if (input == "S")
    //    {
    //        Console.WriteLine("Wprowadź kwotę za ścieki:");
    //        var input1 = Console.ReadLine();
    //        try
    //        {
    //            sewage.AddAmount(input1);
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine($"Exceptio catched: {e.Message}");
    //        }
    //    }
    //    else if (input == "C")
    //    {
    //        Console.WriteLine("Wprowadź kwotę za czynsz:");
    //        var input1 = Console.ReadLine();
    //        try
    //        {
    //            rent.AddAmount(input1);
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine($"Exceptio catched: {e.Message}");
    //        }
    //    }
    //    else if (input == "I")
    //    {
    //        Console.WriteLine("Wprowadź kwotę za internet:");
    //        var input1 = Console.ReadLine();
    //        try
    //        {
    //            internet.AddAmount(input1);
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine($"Exceptio catched: {e.Message}");
    //        }
    //    }
    //    else 
    //    {
    //        Console.WriteLine("Wprowadziłeś niewłaściwą literę");
    //    }

}

Console.WriteLine("Aby zobaczyć statystyki wpisz literę według poniższej instrukcji:");
Console.WriteLine("G - gaz; W - woda; P - prąd; Ś - śmieci; S - ścieki; C - czynsz; I - internet");
Console.WriteLine("albo wpisz dowolny inny znak, żeby zakończyć");
var inputs = Console.ReadLine();

var statistics1 = gas.GetStatistics();
var statistics2 = water.GetStatistics();
var statistics3 = electricity.GetStatistics();
var statistics4 = garbage.GetStatistics();
var statistics5 = sewage.GetStatistics();
var statistics6 = rent.GetStatistics();
var statistics7 = internet.GetStatistics();

switch (inputs)
{
    case "G":
        Console.WriteLine($"Average: {statistics1.Average:N2}");
        Console.WriteLine($"Max: {statistics1.Max}");
        Console.WriteLine($"Min: {statistics1.Min}");
        break;
    case "W":
        Console.WriteLine($"Average: {statistics2.Average:N2}");
        Console.WriteLine($"Max: {statistics2.Max}");
        Console.WriteLine($"Min: {statistics2.Min}");
        break;
    case "P":
        Console.WriteLine($"Average: {statistics3.Average:N2}");
        Console.WriteLine($"Max: {statistics3.Max}");
        Console.WriteLine($"Min: {statistics3.Min}");
        break;
    case "Ś":
        Console.WriteLine($"Average: {statistics4.Average:N2}");
        Console.WriteLine($"Max: {statistics4.Max}");
        Console.WriteLine($"Min: {statistics4.Min}");
        break;
    case "S":
        Console.WriteLine($"Average: {statistics5.Average:N2}");
        Console.WriteLine($"Max: {statistics5.Max}");
        Console.WriteLine($"Min: {statistics5.Min}");
        break;
    case "C":
        Console.WriteLine($"Average: {statistics6.Average:N2}");
        Console.WriteLine($"Max: {statistics6.Max}");
        Console.WriteLine($"Min: {statistics6.Min}");
        break;
    case "I":
        Console.WriteLine($"Average: {statistics7.Average:N2}");
        Console.WriteLine($"Max: {statistics7.Max}");
        Console.WriteLine($"Min: {statistics7.Min}");
        break;
    default:
        Console.WriteLine("Zapraszamy ponownie");
        break;
}