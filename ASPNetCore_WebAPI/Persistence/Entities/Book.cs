using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNetCoreWebAPI.API.Persistence.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int NumberOfPages { get; set; }
        public string PrintedLanguage { get; set; }
        public DateTime FirstPublished { get; set; }
    }
}
