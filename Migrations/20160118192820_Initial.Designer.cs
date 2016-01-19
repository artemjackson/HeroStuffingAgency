using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using HeroesStaffingAgency.Models;

namespace HeroesStaffingAgency.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160118192820_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("HeroesStaffingAgency.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Photo");

                    b.Property<string>("Pseudonym");

                    b.Property<string>("Sex");

                    b.HasKey("Id");
                });
        }
    }
}
