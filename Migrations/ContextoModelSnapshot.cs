﻿// <auto-generated />
using Alvin_P1_API.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Alvin_P1_API.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Alvin_P1_API.Entidades.Ciudades", b =>
                {
                    b.Property<int>("ciudadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("ciudadId");

                    b.ToTable("Ciudades");
                });
#pragma warning restore 612, 618
        }
    }
}
