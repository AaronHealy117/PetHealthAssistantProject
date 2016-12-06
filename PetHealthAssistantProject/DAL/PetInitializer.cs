using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PetHealthAssistantProject.Models;

namespace PetHealthAssistantProject.DAL
{
    public class PetInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PetContext>
    {
        protected override void Seed(PetContext context)
        {
            var pets = new List<Pet>
            {
            new Pet{Breed="Kerry Blue Terrier", Size="Medium", Shedding="No", Drooling="No", Weather="Cold", ExerciseNeeds="High"},
            new Pet{Breed="Beagle", Size="Small", Shedding="No", Drooling="No", Weather="Hot", ExerciseNeeds="Medium"},
            new Pet{Breed="Mastiff", Size="Large", Shedding="No", Drooling="Yes", Weather="Cold", ExerciseNeeds="Medium"},
            };
            pets.ForEach(s => context.Pet.Add(s));
            context.SaveChanges();


            var medi = new List<Food>
            {
            new Food{ Foods="Dry Food", Edible="Yes", Amount="Portioned to dog size" },
            new Food{Foods="Wet Food", Edible="Yes", Amount="Portioned to dog size"},
            new Food{ Foods="Cheese/Milk", Edible="Yes", Amount="Small amounts every so often"},
            new Food{ Foods="Chocolate", Edible="No!", Amount="Never ever"},
            new Food{ Foods="Apple", Edible="Yes", Amount="Small amounts but so seeds or cores ever"},
            };
            medi.ForEach(s => context.Food.Add(s));
            context.SaveChanges();

            var vet = new List<Vet>
            {
            new Vet{VetHospitalName="Clondalkin Veterinary", VetSpeciality="Dog Surgery", VetAddress="47 Monastery Road South" ,VetAppointment="Monday-Friday"},
            new Vet {VetHospitalName="Tallaght Veterinary", VetSpeciality="General Vet", VetAddress="The Square North Side" ,VetAppointment="Monday-Sunday"},
            };
            vet.ForEach(s => context.Vet.Add(s));
            context.SaveChanges();

            var walk = new List<Walks>
            {
                new Walks { WalksPark="Corcagh Park", WalksAddress="Corcagh Park, Green Park, Clondalkin" },
                new Walks { WalksPark="Phoenix Park", WalksAddress="Phoenix ark, Green Park, Clondalkin"},
            };
            walk.ForEach(s => context.Walks.Add(s));
            context.SaveChanges();

        }
    }
}