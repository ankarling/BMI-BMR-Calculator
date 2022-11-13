//Skriv ut ett välkomstmeddelande till användaren
Console.WriteLine("Hej, det här programmet beräknar ditt BMI och ditt BMR.");

/* METOD: ReadGender, läser in värde, kontrollerar om det är ett giltigt värde och
  returnerar "man" eller "kvinna" beroende på vad användaren skrev in */
static string ReadGender()
{
    const string kvinna = "kvinna";
    const string man = "man";
    string? gender;

    bool loop = true;
    do
    {
        Console.Write("Ange om du är kvinna eller man: ");
        gender = Console.ReadLine();



        switch (gender)
        {
            case kvinna:
                loop = false;
                break;

            case man:
                loop = false;
                break;

            default:
                Console.WriteLine("Felaktigt inmatat värde, försök igen!");
                break;
        }
    } while (loop);
    return gender;

}

/* METOD: ReadAge: Be användaren mata in sin ålder.
Läs in värdet och kontrollera om användaren matat in ett giltig värde, inom intervallet:
18 [år] ≤ ålder ≤ 70 [år] */
static int ReadAge()
{
    int age;
    bool bAge;
    bool invalidAge;
    string? strAge;

    do
    {
        Console.Write("Ange din ålder, giltigt intervall är mellan 18 - 70 år: (Exempel: 39) ");
        strAge = Console.ReadLine();

        bAge = int.TryParse(strAge, out age);
        validAge = (!bAge || age < 18 || age > 70);
        if (validAge)
        {
            Console.WriteLine("Det inmatade värdet är ogiltigt, försök igen!");
        }

    } while (validAge);

    return age;

}

/* METOD: ReadWeight: Be användaren mata in sin vikt.
Läs in värdet och kontrollera om användaren matat in ett giltig värde, inom intervallet:
10 [kg] ≤ vikt ≤ 250 [kg] */
static double ReadWeight()
{
    string? strWeight;
    double weight;
    bool bWeight;
    bool invalidWeight;

    do
    {
        Console.Write("Ange din vikt i kg: (Exempel: 64) ");
        strWeight = Console.ReadLine();

        bWeight = double.TryParse(strWeight, out weight);
        validWeight = !bWeight || weight < 10 || weight > 250;
        if (validWeight)
        {
            Console.WriteLine("Det inmatade värdet är ogiltigt, försök igen!");
        }

    } while (validWeight);

    return weight;

}

/* METOD: ReadHeight: Be användaren mata in sin längd.
Läs in värdet och kontrollera om användaren matat in ett giltig värde, inom intervallet:
50 [cm] ≤ längd ≤ 220 [cm] */
static double ReadHeight()
{
    string? strHeight;
    double height;
    bool bHeight;
    bool invalidHeight;

    do
    {
        Console.Write("Ange din längd i meter: (Exmpel: 1,69) ");
        strHeight = Console.ReadLine();
        bHeight = double.TryParse(strHeight, out height);
        validHeight = !bHeight || height < 0.10 || height > 2.20;
        if (validHeight)
        {
            Console.WriteLine("Det inmatade värdet är ogiltigt, försök igen!");
        }

    } while (validHeight);

    return height;

}

//Räkna ut BMI
static double BMICalculator()
{
    double BMI = ((1.3 * weight) / Math.Pow(height, 2.5));
    return BMI;
}

//Skriv ut användarens BMI avrundat till två decimaler
Console.WriteLine("Ditt BMI är: " + Math.Round(BMI, 2));


/* Testa användarens BMI mot BMI-tabell och skriver ut
 användarens BMI-kategori */

static void BMICat(string name)
{
    if (BMI < 18.5)
    {
        Console.WriteLine("Du är underviktig.");
    }
    else if (BMI <= 25)
    {
        Console.WriteLine("Du är normalviktig");
    }

    else if (BMI <= 30)
    {
        Console.WriteLine("Du är överviktig");
    }

    else if (BMI <= 40)
    {
        Console.WriteLine("Du är kraftigt överviktig.");
    }

    else
    {
        Console.WriteLine("Du är extremt överviktig. ");
    }
}

//Skriv ut användarens BMR avrundat till två decimaler. 
static double BMRCalculator()
{
    double BMR;

    if (strGender == kvinna)
    {
        BMR = (655.1 + (9.563 * weight) + (1.85 * height) - (4.676 * age));

    }

    else
    {
        BMR = (66.47 + (13.75 * weight) + (5.003 * height) - (6.755 * age));

    }

}
Console.WriteLine("Ditt BMR är: " + Math.Round(BMR, 2) + " kcal per dygn. ");