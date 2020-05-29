using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CraftsnMoreGalore.Models;

namespace CraftsnMoreGalore.DAL
{
    public class CraftStoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CraftStoreContext>
    {
        protected override void Seed(CraftStoreContext context)
        {
            var crafts = new List<Craft>()
            {
                Craft.Wreath(1, "~/Content/Images/wreath1.png", "Thanksgiving", "A festive wreath perfect for your Fall decor. The bright orange mesh, bow, and pumpkin sign are sure to spice up your home or office"),
                Craft.Wreath(2, "~/Content/Images/wreath2.png", "Witch", "A witchly wreath to add to your Halloween decor"),
                Craft.Wreath(3, "~/Content/Images/wreath3.png", "Pumpkin Truck", "This cute Fall wreath will add a homey touch in any setting"),
                Craft.Wreath(4, "~/Content/Images/wreath4.png", "Sunny Day", "Every house needs a ray of sunshine, so why not add some brightness to your home?"),
                Craft.Wreath(5, "~/Content/Images/wreath5.png", "Hocus Pocus", "This wreath looks ready to sprout a gnarled, warty nose, and fly off into the night on a broomstick"),
                Craft.Wreath(6, "~/Content/Images/wreath6.png", "Lavender Peony", "Capturing the simple beauty of its namesake flower, this wreath will be great in creating a cozy home"),
                Craft.Wreath(7, "~/Content/Images/wreath7.png", "Blue Anemone", "This striking wreath captures the appearance of a sea anemone with lightning blue tendrils"),
                Craft.Wreath(8, "~/Content/Images/wreath8.png", "Fall Wagon", "Capture the youthful delight of Fall with this pumpkin wagon wreath"),
                Craft.Wreath(9, "~/Content/Images/wreath9.png", "Rudolf", "An adorable rendition of the world's favorite reindeer"),
                Craft.Wreath(10, "~/Content/Images/wreath10.jpeg", "Welcome Blue", "A simple wreath perfect for welcoming visitors into your home"),
                Craft.Wreath(11, "~/Content/Images/wreath11.jpeg", "Busy Bee", "An ode to the busy bees that keep our world's plants fertilized. Thanks little guys."),
                Craft.Wreath(12, "~/Content/Images/wreath13.jpeg", "Lil' Miss Lady Bug", "Ever hear the story that ladybugs give good luck? Why not bring some of that good fortune to your home with this beautiful wreath."),
                Craft.Wreath(13, "~/Content/Images/wreath14.jpeg", "Sea Foam", "Bring a piece of the sea into your home with this briny wreath"),
                Craft.Wreath(14, "~/Content/Images/wreath15small.jpg", "Family Custom", "Wreaths are made to order. Grab one now with your family name or whatever message you want on the sign!")
            };
            crafts.ForEach(c => context.Crafts.Add(c));
            context.SaveChanges();
        }
    }
}