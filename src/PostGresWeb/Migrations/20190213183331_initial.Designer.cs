﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostGresWeb;

namespace PostGresWeb.Migrations
{
    [DbContext(typeof(FrcContext))]
    [Migration("20190213183331_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PostGresWeb.AggregatedEvents", b =>
                {
                    b.Property<Guid>("AggregatedEventsId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("BestImage");

                    b.Property<int>("IdentityId");

                    b.Property<bool>("Recognized");

                    b.Property<DateTime>("TimestampEnd");

                    b.Property<DateTime>("TimestampStart");

                    b.HasKey("AggregatedEventsId");

                    b.ToTable("AggregatedEvents");
                });

            modelBuilder.Entity("PostGresWeb.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AggregatedEventsId");

                    b.Property<byte[]>("BestImage");

                    b.Property<string>("Confidence")
                        .HasColumnType("jsonb");

                    b.Property<string>("Rectangle")
                        .HasColumnType("jsonb");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("EventId");

                    b.HasIndex("AggregatedEventsId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("PostGresWeb.Identity", b =>
                {
                    b.Property<int>("IdentityId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.HasKey("IdentityId");

                    b.ToTable("Identities");
                });

            modelBuilder.Entity("PostGresWeb.Event", b =>
                {
                    b.HasOne("PostGresWeb.AggregatedEvents")
                        .WithMany("Events")
                        .HasForeignKey("AggregatedEventsId");
                });
#pragma warning restore 612, 618
        }
    }
}
