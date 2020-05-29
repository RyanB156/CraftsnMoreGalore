using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CraftsnMoreGalore.Models
{
    public enum CraftType { Wreath, Shirt }

    public class Craft
    {

        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public Craft() { }

        private Craft(int index, string path, string name, string description, string type)
        {
            Id = index;
            ImagePath = path;
            Name = name;
            Description = description;
            Type = type;
        }

        public static Craft Wreath(int id, string path, string name, string description)
        {
            return new Craft(id, path, name, description, "Wreath");
        }

        public static Craft Shirt(int id, string path, string name, string description)
        {
            return new Craft(id, path, name, description, "Shirt");
        }
    }
}