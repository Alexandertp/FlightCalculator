// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
float velocity = 0;
float distance = 0;
float acceleration = 0;
bool accelerationDecided = false;
while (true)
{
    velocity = validationcheck("Velocity");
    acceleration = validationcheck("Acceleration");
    distance = validationcheck("Distance");
}



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


float time = 0;
float position = 0;
float time2ndpow = (float)Math.Pow(time, 2);
velocity = distance / time;
acceleration = (float)0.5 * acceleration * time2ndpow + velocity * time + position;

// properly need a better name for the float
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