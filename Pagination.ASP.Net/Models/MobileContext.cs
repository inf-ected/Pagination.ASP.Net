using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pagination.ASP.Net.Models
{
    public class MobileContext:DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public MobileContext():base("DefaultConnection"){}
    }

    public class MobileDbInitilizer : DropCreateDatabaseAlways<MobileContext> 
    {
        protected override void Seed(MobileContext db)
        {

            db.Phones.AddRange(new Phone[] {
            new Phone() {Model="Sumsung Galaxy III", Producer="Samsung" },
            new Phone() {Model="Sumsung Ace II", Producer="Samsung" },
            new Phone() {Model="HTC HERO", Producer="HTC" },
            new Phone() {Model="HTC One S", Producer="HTC" },
            new Phone() {Model="HTC One X", Producer="HTC" },
            new Phone() {Model="LG Optimus 3D", Producer="LG" },
            new Phone() {Model="Nokia N9", Producer="Nokia" },
            new Phone() {Model="Sumsung Galaxy Nexus", Producer="Samsung" },
            new Phone() {Model="Sony Xperia X10", Producer="SONY" },
            new Phone() {Model="Sumsung Galaxy II", Producer="Samsung" }
            });

            db.SaveChanges();
        }
    }
}   