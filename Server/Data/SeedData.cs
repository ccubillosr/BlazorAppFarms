using BlazorAppFarms.Shared.Models;
using static BlazorAppFarms.Shared.Models.Animal;
using System.Diagnostics;
using System.Xml.Linq;

namespace BlazorAppFarms.Server.Data
{
    public class SeedData
    {
        public static void Initialize(BlazorAppFarmsServerContext db)
        {
                var animals = new Animal[]
                {
                    new Animal()
                    {
                        AnimalId=1,
                        Name="Bull1",
                        Breed="Bull",
                        BirthDate= DateTime.Now.AddDays(-700),
                        Sex=Gender.Male,
                        Price=5000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=2,
                        Name="Bull2",
                        Breed="Bull Terrier",
                        BirthDate= DateTime.Now.AddDays(-350),
                        Sex=Gender.Male,
                        Price=7000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=3,
                        Name="Cow1",
                        Breed="Cow Terrier",
                        BirthDate= DateTime.Now.AddDays(-350),
                        Sex=Gender.Female,
                        Price=10000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=4,
                        Name="Cow2",
                        Breed="Cow",
                        BirthDate= DateTime.Now.AddDays(-700),
                        Sex=Gender.Female,
                        Price=10000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=5,
                        Name="Bull3",
                        Breed="Bull Happy",
                        BirthDate= DateTime.Now.AddDays(-350),
                        Sex=Gender.Male,
                        Price=10000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=6,
                        Name="Cow3",
                        Breed="Cow Happy",
                        BirthDate= DateTime.Now.AddDays(-350),
                        Sex=Gender.Female,
                        Price=10000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=7,
                        Name="Bull4",
                        Breed="Bull",
                        BirthDate= DateTime.Now.AddDays(-350),
                        Sex=Gender.Male,
                        Price=7000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=8,
                        Name="Cow4",
                        Breed="Cow",
                        BirthDate= DateTime.Now.AddDays(-350),
                        Sex=Gender.Female,
                        Price=7000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=9,
                        Name="Bull5",
                        Breed="Bull Terrier",
                        BirthDate= DateTime.Now.AddDays(-400),
                        Sex=Gender.Male,
                        Price=12000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=10,
                        Name="Cow5",
                        Breed="Cow Terrier",
                        BirthDate= DateTime.Now.AddDays(-400),
                        Sex=Gender.Female,
                        Price=12000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=11,
                        Name="Bull6",
                        Breed="Bull Happy",
                        BirthDate= DateTime.Now.AddDays(-500),
                        Sex=Gender.Male,
                        Price=15000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=12,
                        Name="Cow6",
                        Breed="Cow Happy",
                        BirthDate= DateTime.Now.AddDays(-500),
                        Sex=Gender.Female,
                        Price=15000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=13,
                        Name="Bull7",
                        Breed="Bull",
                        BirthDate= DateTime.Now.AddDays(-600),
                        Sex=Gender.Male,
                        Price=16000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=14,
                        Name="Cow7",
                        Breed="Cow",
                        BirthDate= DateTime.Now.AddDays(-600),
                        Sex=Gender.Female,
                        Price=16000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=15,
                        Name="Bull8",
                        Breed="Bull Terrier",
                        BirthDate= DateTime.Now.AddDays(-900),
                        Sex=Gender.Male,
                        Price=17000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=16,
                        Name="Cow8",
                        Breed="Cow Terrier",
                        BirthDate= DateTime.Now.AddDays(-900),
                        Sex=Gender.Female,
                        Price=17000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=17,
                        Name="Bull9",
                        Breed="Bull Happy",
                        BirthDate= DateTime.Now.AddDays(-1000),
                        Sex=Gender.Male,
                        Price=18000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=18,
                        Name="Cow9",
                        Breed="Cow Happy",
                        BirthDate= DateTime.Now.AddDays(-1000),
                        Sex=Gender.Female,
                        Price=18000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=19,
                        Name="Bull10",
                        Breed="Bull",
                        BirthDate= DateTime.Now.AddDays(-2000),
                        Sex=Gender.Male,
                        Price=20000,
                        Status= StatusInd.Active,
                    },
                    new Animal()
                    {
                        AnimalId=20,
                        Name="Cow10",
                        Breed="Cow",
                        BirthDate= DateTime.Now.AddDays(-2000),
                        Sex=Gender.Female,
                        Price=20000,
                        Status= StatusInd.Active,
                    },
                };
                db.Animal.AddRange(animals);
                db.SaveChanges();
        }
        public static void  Remover(BlazorAppFarmsServerContext db)
        {
            Animal animal = new Animal();
            for (int i = 1;i <= 20;i++) 
            {
                animal.AnimalId = i; 
                db.Animal.Remove(animal);
                db.SaveChanges();
            }
        }

    }
}
