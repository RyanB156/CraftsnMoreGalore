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
            
        }
    }
}