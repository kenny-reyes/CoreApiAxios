using System;
using Microsoft.EntityFrameworkCore.Metadata;

namespace api.Domain
{
    public class Character
    {
        public int id { get; set; }
        public string gender { get; set; }
        public string name { get; set; }
        public string species { get; set; }
        public string image { get; set; }
    }
}
