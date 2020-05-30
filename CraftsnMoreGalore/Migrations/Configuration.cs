namespace CraftsnMoreGalore.Migrations
{
    using CraftsnMoreGalore.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CraftsnMoreGalore.DAL.CraftStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CraftsnMoreGalore.DAL.CraftStoreContext";
        }

        protected override void Seed(CraftsnMoreGalore.DAL.CraftStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // Deletes all data, from all tables, except for __MigrationHistory
            context.Database.ExecuteSqlCommand("sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'");
            context.Database.ExecuteSqlCommand("sp_MSForEachTable 'IF OBJECT_ID(''?'') NOT IN (ISNULL(OBJECT_ID(''[dbo].[__MigrationHistory]''),0)) DELETE FROM ?'");
            context.Database.ExecuteSqlCommand("EXEC sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'");

            var crafts = new List<Craft>()
            {
                Craft.Wreath("~/Content/Images/Wreaths/wreath1.png", "Thanksgiving", "A festive wreath perfect for your Fall decor. The bright orange mesh, bow, and pumpkin sign are sure to spice up your home or office"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath2.png", "Witch", "A witchly wreath to add to your Halloween decor"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath3.png", "Pumpkin Truck", "This cute Fall wreath will add a homey touch in any setting"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath4.png", "Sunny Day", "Every house needs a ray of sunshine, so why not add some brightness to your home?"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath5.png", "Hocus Pocus", "This wreath looks ready to sprout a gnarled, warty nose, and fly off into the night on a broomstick"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath6.png", "Lavender Peony", "Capturing the simple beauty of its namesake flower, this wreath will be great in creating a cozy home"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath7.png", "Blue Anemone", "This striking wreath captures the appearance of a sea anemone with lightning blue tendrils"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath8.png", "Fall Wagon", "Capture the youthful delight of Fall with this pumpkin wagon wreath"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath9.png", "Rudolf", "An adorable rendition of the world's favorite reindeer"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath10.jpeg", "Welcome Blue", "A simple wreath perfect for welcoming visitors into your home"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath11.jpeg", "Busy Bee", "An ode to the busy bees that keep our world's plants fertilized. Thanks little guys."),
                Craft.Wreath("~/Content/Images/Wreaths/wreath13.jpeg", "Lil' Miss Lady Bug", "Ever hear the story that ladybugs give good luck? Why not bring some of that good fortune to your home with this beautiful wreath."),
                Craft.Wreath("~/Content/Images/Wreaths/wreath14.jpeg", "Sea Foam", "Bring a piece of the sea into your home with this briny wreath"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath15small.jpg", "Family Custom", "Wreaths are made to order. Grab one now with your family name or whatever message you want on the sign!"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath16.jpg", "Possible with God", "A quaint wreath with a friendly message from the Bible"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath17.jpg", "Semi", "A modest wreath showcasing the custom signs that can be made to order"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath18.jpg", "Blonde Reindeer", "A burlap reindeer in tan"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath19.jpg", "Brunette Reindeer", "A burlap reindeer in brown"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath20.jpg", "Zebra", "A simple wreath with the markings of my favorite animal, the zebra!"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath21.jpg", "Reindeer Red", "Run run Rudolph and get this holidy wreath while you can"),
                Craft.Wreath("~/Content/Images/Wreaths/wreath22.jpg", "Blessed Home", "Add a blessing from up above with this wreath"),
                Craft.Shirt("~/Content/Images/Shirts/shirt1.jpg", "Anchor", "A sign or tshirt design that can be made to order with any name or short phrase"),
                Craft.Shirt("~/Content/Images/Shirts/shirt2.jpg", "Moon 1/2", "First half of a couples' tshirt that is out of this world"),
                Craft.Shirt("~/Content/Images/Shirts/shirt3.jpg", "Friends", "A touching tshirt for any that know someone fighting cancer"),
                Craft.Shirt("~/Content/Images/Shirts/shirt4.jpg", "Lucky girlfriend", "A couples' shirt for the lucky girl"),
                Craft.Shirt("~/Content/Images/Shirts/shirt5.jpg", "Programming", "A programmertastic shirt that only computer gurus will get"),
                Craft.Misc("~/Content/Images/Misc/glasses1.jpg", "Special Date Glasses", "Commemorate the special day with custom glasses made to order"),
                Craft.Misc("~/Content/Images/Misc/mask1.jpg", "Custom Face Mask", "Face masks can be made to order with any size and fabric"),
                Craft.Misc("~/Content/Images/Misc/mousepad1.jpg", "Custom mousepad", "Mouse pads can be made to order with any text and simple images"),
            };

            crafts.ForEach(c => context.Crafts.Add(c));
            context.SaveChanges();

        }
    }
}
