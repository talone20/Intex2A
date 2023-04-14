﻿// <auto-generated />
using System;
using Intex2A.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Intex2A.Migrations
{
    [DbContext(typeof(IntexDbContext))]
    partial class IntexDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Intex2A.Models.burialmain", b =>
                {
                    b.Property<double>("id")
                        .HasColumnType("double precision");

                    b.Property<string>("adultsubadult")
                        .HasColumnType("text");

                    b.Property<string>("ageatdeath")
                        .HasColumnType("text");

                    b.Property<string>("area")
                        .HasColumnType("text");

                    b.Property<long?>("burialid")
                        .HasColumnType("bigint");

                    b.Property<string>("burialmaterials")
                        .HasColumnType("text");

                    b.Property<string>("burialnumber")
                        .HasColumnType("text");

                    b.Property<string>("clusternumber")
                        .HasColumnType("text");

                    b.Property<string>("dataexpertinitials")
                        .HasColumnType("text");

                    b.Property<TimeSpan?>("dateofexcavation")
                        .HasColumnType("interval");

                    b.Property<string>("depth")
                        .HasColumnType("text");

                    b.Property<string>("eastwest")
                        .HasColumnType("text");

                    b.Property<string>("excavationrecorder")
                        .HasColumnType("text");

                    b.Property<string>("facebundles")
                        .HasColumnType("text");

                    b.Property<string>("fieldbookexcavationyear")
                        .HasColumnType("text");

                    b.Property<string>("fieldbookpage")
                        .HasColumnType("text");

                    b.Property<string>("goods")
                        .HasColumnType("text");

                    b.Property<string>("hair")
                        .HasColumnType("text");

                    b.Property<string>("haircolor")
                        .HasColumnType("text");

                    b.Property<string>("headdirection")
                        .HasColumnType("text");

                    b.Property<string>("length")
                        .HasColumnType("text");

                    b.Property<string>("northsouth")
                        .HasColumnType("text");

                    b.Property<string>("photos")
                        .HasColumnType("text");

                    b.Property<string>("preservation")
                        .HasColumnType("text");

                    b.Property<string>("samplescollected")
                        .HasColumnType("text");

                    b.Property<string>("sex")
                        .HasColumnType("text");

                    b.Property<string>("shaftnumber")
                        .HasColumnType("text");

                    b.Property<string>("southtofeet")
                        .HasColumnType("text");

                    b.Property<string>("southtohead")
                        .HasColumnType("text");

                    b.Property<string>("squareeastwest")
                        .HasColumnType("text");

                    b.Property<string>("squarenorthsouth")
                        .HasColumnType("text");

                    b.Property<string>("text")
                        .HasColumnType("text");

                    b.Property<string>("westtofeet")
                        .HasColumnType("text");

                    b.Property<string>("westtohead")
                        .HasColumnType("text");

                    b.Property<string>("wrapping")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("burialmain");
                });
#pragma warning restore 612, 618
        }
    }
}
