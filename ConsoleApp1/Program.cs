// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Veuillez saisir votre salaire annuel : ");
        double salaireAnnuel = double.Parse(Console.ReadLine());

        double[] salairesMensuels = new double[12];

        double salaireMensuelBase = salaireAnnuel / 12;

        for (int i = 0; i < 11; i++)
        {
            salairesMensuels[i] = salaireMensuelBase;
        }

        double salaireDecembre = salaireMensuelBase + (salaireAnnuel * 0.1) / 12;
        salairesMensuels[11] = salaireDecembre;

        string[] moisDeLannee = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

        for (int i = 0; i < 12; i++)
        {
            if (i == 7)
            {
                Console.WriteLine(moisDeLannee[i] + " : entreprise fermée");
            }
            else
            {
                Console.WriteLine(moisDeLannee[i] + " : " + salairesMensuels[i] + "€");
            }
        }

        Console.ReadLine();
    }
}
class User
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
    public double Tax { get; set; }
    public double CalculateSalary()
    {
        return Salary * (1 - Tax / 100);
    }
}
User user = new User();
Console.WriteLine("Quel est votre ID : ");
user.ID = int.Parse(Console.ReadLine());
Console.WriteLine("Quel est votre Prénom : ");
user.FirstName = Console.ReadLine();
Console.WriteLine("Quel est votre Nom : ");
user.LastName = Console.ReadLine();
Console.WriteLine("Quel est votre Âge : ");
user.Age = int.Parse(Console.ReadLine());
Console.WriteLine("Quel est votre Salaire annuel Brut : ");
user.Salary = int.Parse(Console.ReadLine().Replace("€", ""));
Console.WriteLine("Quel est votre Taux d'imposition : ");
user.Tax = double.Parse(Console.ReadLine().Replace("%", ""));
Console.WriteLine("\nID : " + user.ID);
Console.WriteLine("Prénom : " + user.FirstName);
Console.WriteLine("Nom : " + user.LastName);
Console.WriteLine("Âge : " + user.Age);
Console.WriteLine("Salaire Brut : " + user.Salary + "€");
Console.WriteLine("Taux d'imposition : " + user.Tax + "%");
Console.WriteLine("Salaire Net : " + user.CalculateSalary() + "€");
