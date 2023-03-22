using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TFGTest.Model
{
    internal class ProductModel
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }


        //Contructor
        public ProductModel(int id, string name, string description, string category)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
        }
        
        public ProductModel(){} //Default Constructor

        // Overrides ToString
        public override string? ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
