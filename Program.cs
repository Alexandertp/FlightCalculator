float velocity = 0;
float distance = 0;
float acceleration = 0;
float time = 0;
float position = 0;
//bool accelerationDecided = false;

//velocity = validationcheck("Velocity");
//acceleration = validationcheck("Acceleration");
//distance = validationcheck("Distance");
//time = validationcheck("time");
//position = validationcheck("position");
decisionMaker();



/*while (accelerationDecided == false)
{
    try
    {
        acceleration = float.Parse(Console.ReadLine());
        accelerationDecided = true;
    }
    catch (InvalidCastException)
    {
        Console.WriteLine("Deeeet vidst ikke et tal det der, prøv igen");
        accelerationDecided = false;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Du har fucket et eller andet op, min kode er perfekt, det er en ommer");
        accelerationDecided = false;
    }
} */



float time2ndpow = (float)Math.Pow(time, 2);
velocity = distance / time;
acceleration = (float)0.5 * acceleration * time2ndpow + velocity * time + position;
Console.WriteLine(acceleration);
// properly need a better name for the float
void decisionMaker()
{
    Console.WriteLine("Hvad vil du gerne beregne?");
    Console.WriteLine("1.Fart 2.Planet Størrelse");
    string UserInput = Console.ReadLine().ToLower();
    switch (UserInput)
    {
        case "1.":
        case "1":
        case "fart":
        case "speed":
            Console.WriteLine(Math.Pow(10, -11));
            float planetRadius = validationcheck("Planet Radius");
            
            Console.WriteLine(CalculateRequiredSpeed(planetRadius));
            break;

        case "2.":
        case "2":
        case "størrelse":
        case "size":
        case "planet størrelse":
        case "planet size":
        case "planet":

            break;
        
        
        default:
            break;
    }

}
double CalculateRequiredSpeed(float radius)
{
    double output = 0;
    double M = 5.98 * Math.Pow(10, 24);
    double G = (Math.Sqrt(6.67 * Math.Pow(10, -11)));
    output = Math.Sqrt(G * M / (radius * 10));
    return output;
}
float validationcheck(string NameOfVariable)
{
    Console.WriteLine("sæt en verdi for: " + NameOfVariable);
    float tal = 0;
    bool check = false;
    while (check == false)
    {
        try
        {
            tal = float.Parse(Console.ReadLine());
            check = true;
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Deeeet vidst ikke et tal det der, prøv igen");
            check = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Du har fucket et eller andet op, min kode er perfekt, det er en ommer");
            check = false;
        }
    }
    Console.WriteLine(NameOfVariable + " er sat til: " + tal);
    return tal;
}