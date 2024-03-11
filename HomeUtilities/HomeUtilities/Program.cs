using HomeUtilities;

Console.WriteLine("Witamy w programie 'Home Utilities'");
Console.WriteLine("=====================================");
Console.WriteLine("Wybierz, za co chcesz wpisać należność");

var gas = new HUGasInFile("Gas");
var water = new HUGasInFile("Water");
var electricity = new HUGasInFile("Electrycity");
var garbage = new HUGasInFile("Garbage");
var sewage = new HUGasInFile("Sewage");
var rent = new HUGasInFile("Rent");
var internet = new HUGasInFile("Internet");

while (true)
{
    Console.WriteLine("Chcąc wprowadzić należność za konkretne medium, wpisz literę według poniższej instrukcji:");
    Console.WriteLine("G - gaz; W - woda; P - prąd; Ś - śmieci; S - ścieki; C - czynsz; I - internet; q - zakończ");
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

var statistics = gas.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");