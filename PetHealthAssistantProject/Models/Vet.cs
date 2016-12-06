using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetHealthAssistantProject.Models
{
    public class Vet
    {
        public int ID { get; set; }
        public String VetHospitalName { get; set; }
        public String VetSpeciality { get; set; }
        public String VetAddress { get; set; }
        public String VetAppointment { get; set; }
    }
}