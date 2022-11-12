//Skriv ut ett välkomstmeddelande till användaren
using System.Runtime.CompilerServices;

Console.WriteLine("Hej, det här programmet beräknar ditt BMI och ditt BMR!");

//Deklarera de variabler som behövs för att beräkna BMI
double weight;
double height;
double BMI;
double BMR;
int age;
bool bAge;
bool bWeight;
bool bHeight;
bool validAge;
bool validWeight;
bool validHeight;
const string kvinna = "kvinna";
const string man = "man";
string? strGender;
string? strAge;
string? strWeight;
string? strHeight;

/* Be användaren mata in om de är man eller kvinna.
 Med try och catch får användaren försöka tills det blir rätt.*/

bool loop = true;
do
{
    Console.Write("Ange om du är kvinna eller man: ");
    strGender = Console.ReadLine();
    switch (strGender)
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

/* Be användaren mata in sin ålder, sin längd och sin vikt.
Läs in värdet och kontrollera om användaren matat in ett giltig värde, inom giltiga intervall.
50 [cm] ≤ längd ≤ 220 [cm]     // användarens längd

10 [kg] ≤ vikt ≤ 250 [kg]       // användarens vikt

18 [år] ≤ ålder ≤ 70 [år]        // användarens ålder
 */

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


do
{
    Console.Write("Ange din vikt i kg: (Exempel: 64) ");
    strWeight = Console.ReadLine();

    bWeight = double.TryParse(strWeight, out weight);
    validWeight = !bWeight|| weight < 10 || weight > 250;
    if (validWeight)
    {
        Console.WriteLine("Det inmatade värdet är ogiltigt, försök igen!");
    }

} while (validWeight);



do
{
    Console.Write("Ange din längd i meter: (Exmpel: 1,69) ");
    strHeight = Console.ReadLine();
    bHeight = double.TryParse(strHeight, out height);
    validHeight = !bHeight|| height < 0.10 || height >2.20;
    if (validHeight)
    {
        Console.WriteLine("Det inmatade värdet är ogiltigt, försök igen!");
    }

} while (validHeight);


//Räkna ut BMI
BMI = ((1.3 * weight) / Math.Pow(height, 2.5));

//Skriv ut användarens BMI avrundat till två decimaler
Console.WriteLine("Ditt BMI är: " + Math.Round(BMI, 2));

/*Testa användarens BMI mot BMI-tabell, hitta och skriv ut rätt kategori:
BMI under 18.5  	undervikt   

BMI 18.5–25   		sund och normal vikt        

BMI 25–30        	övervikt     

BMI 30–40      		kraftig övervikt

BMI över 40     	extrem övervikt*/

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


//BMR kvinna eller man
if (strGender == kvinna)
{
    BMR = (655.1 + (9.563 * weight) + (1.85 * height) - (4.676 * age));
  
}

else
{
    BMR = (66.47 + (13.75 * weight) + (5.003 * height) - (6.755 * age));

}
Console.WriteLine("Ditt BMR är: " + Math.Round(BMR, 2) + " kcal per dygn. ");



