using CodeFirstCRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCRUD.Config
{
    internal class KisiCFG : IEntityTypeConfiguration<Kisi>
    {
        public void Configure(EntityTypeBuilder<Kisi> builder)
        {
            builder.HasKey(x => x.KisiID);
            builder.Property(x=>x.Ad).HasMaxLength(100);
            builder.Property(x=>x.Soyad).HasMaxLength(100);
            builder.Property(x=>x.Telefon).HasMaxLength(20);

            builder.HasData(
                new Kisi { KisiID = 1, Ad = "Burak", Soyad = "Kilicaslan", Telefon = "5554443322" },
                new Kisi { KisiID = 2, Ad = "Beyza", Soyad = "Kilicaslan", Telefon = "9990001122" },
                new Kisi { KisiID = 3, Ad = "John", Soyad = "Doe", Telefon = "5555555555" },
                new Kisi { KisiID = 4, Ad = "Nancy", Soyad = "Grancer", Telefon = "7778889900" },
                new Kisi { KisiID = 5, Ad = "David", Soyad = "Concord", Telefon = "3334058725" }
                );
        }
    }
}
