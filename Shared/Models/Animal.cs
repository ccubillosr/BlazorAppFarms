using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorAppFarms.Shared.Data;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
namespace BlazorAppFarms.Shared.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string? Name { get; set; }
        public string? Breed { get; set; }
        public DateTime? BirthDate { get; set; }
        public enum Gender { Male, Female }
        public Gender Sex { get; set; }
        public float? Price { get; set; }
        public enum StatusInd { Active, Inactive }
        public StatusInd? Status { get; set;}
    }
}
