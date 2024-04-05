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
            GetInputAndAddAmount("gaz", gas);
            break;
        case "W":
            GetInputAndAddAmount("wodę", water);
            break;
        case "P":
            GetInputAndAddAmount("prąd", electricity);
            break;
        case "Ś":
            GetInputAndAddAmount("śmieci", garbage);
            break;
        case "S":
            GetInputAndAddAmount("ścieki", sewage);
            break;
        case "C":
            GetInputAndAddAmount("czynsz", rent);
            break;
        case "I":
            GetInputAndAddAmount("internet", internet);
            break;
        default:
            Console.WriteLine("Wprowadziłeś niewłaściwą literę");
            break;

    }
}

Console.WriteLine("Aby zobaczyć statystyki wpisz literę według poniższej instrukcji:");
Console.WriteLine("G - gaz; W - woda; P - prąd; Ś - śmieci; S - ścieki; C - czynsz; I - internet");
Console.WriteLine("albo wpisz dowolny inny znak, żeby zakończyć");
var inputs = Console.ReadLine();

var statisticsGas = gas.GetStatistics();
var statisticsWater = water.GetStatistics();
var statisticsElectricity = electricity.GetStatistics();
var statisticsGarbage = garbage.GetStatistics();
var statisticsSewage = sewage.GetStatistics();
var statisticsRent = rent.GetStatistics();
var statisticsInternet = internet.GetStatistics();

switch (inputs)
{
    case "G":
        WriteStatistics(statisticsGas);
        break;
    case "W":
        WriteStatistics(statisticsWater);
        break;
    case "P":
        WriteStatistics(statisticsElectricity);
        break;
    case "Ś":
        WriteStatistics(statisticsGarbage);
        break;
    case "S":
        WriteStatistics(statisticsSewage);
        break;
    case "C":
        WriteStatistics(statisticsRent);
        break;
    case "I":
        WriteStatistics(statisticsInternet);
        break;
    default:
        Console.WriteLine(value: "Zapraszamy ponownie");
        break;
}

void GetInputAndAddAmount(string name, HomeUtilitiesSaved utility)
{
    Console.WriteLine($"Wprowadź kwotę za {name}:");
    var input = Console.ReadLine();
    try
    {
        utility.AddAmount(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

static void WriteStatistics(Statistics statistics)
{
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine($"Min: {statistics.Min}");
}