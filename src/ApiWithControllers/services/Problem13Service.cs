namespace ApiWithControllers.services;

public class Problem13Service
{

    private readonly IConfiguration _configuration;

    // wait, where does configuration come from!?!??!
    // (this is DI, we'll cover that next session)
    public Problem13Service(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string Solve()
    {
        // load the huge number from appsettings
        var hugeNumber = _configuration.GetSection("Problem_13:EntireNumber").Get<string>() ?? "WRONG";

        // split the string into separate lines
        string[] lines = hugeNumber.Split("\n".ToCharArray());

        // create an empty list
        List<double> numbers = new List<double>();

        // convert the string line to a number and add it to the list of numbers
        for (int i = 0; i < lines.Length; i++)
        {
            numbers.Add(Convert.ToDouble(lines[i]));
        }
        // sum all numbers together
        var sum = numbers.Sum();
        return "" + sum;
    }
}