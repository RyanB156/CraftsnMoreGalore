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

        private Craft(string path, string name, string description, string type)
        {
            ImagePath = path;
            Name = name;
            Description = description;
            Type = type;
        }

        public static Craft Wreath(string path, string name, string description)
        {
            return new Craft(path, name, description, "Wreath");
        }

        public static Craft Shirt(string path, string name, string description)
        {
            return new Craft(path, name, description, "Shirt");
        }

        public static Craft Misc(string path, string name, string description)
        {
            return new Craft(path, name, description, "Misc");
        }
    }
}