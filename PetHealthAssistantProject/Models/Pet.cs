using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetHealthAssistantProject.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Breed { get; set; }
        public string Size { get; set; }
        public string Shedding { get; set; }
        public string Drooling { get; set; }
        public string Weather { get; set; }
        public string ExerciseNeeds { get; set; }
    }
}