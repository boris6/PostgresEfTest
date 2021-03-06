﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Postgres.Persistance;

namespace Postgres.Persistance.Migrations
{
    [DbContext(typeof(FrcContext))]
    [Migration("20190312140639_ExternalIdAddition")]
    partial class ExternalIdAddition
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Postgres.Domain.Entities.AggregatedEvents", b =>
                {
                    b.Property<Guid>("AggregatedEventsId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("BestImage");

                    b.Property<string>("CameraId");

                    b.Property<double>("Confidence");

                    b.Property<string>("IdentityId");

                    b.Property<bool>("Recognized");

                    b.Property<DateTimeOffset>("TimestampEnd");

                    b.Property<DateTimeOffset>("TimestampStart");

                    b.HasKey("AggregatedEventsId");

                    b.ToTable("AggregatedEvents");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.Camera", b =>
                {
                    b.Property<string>("CameraId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CameraGroup");

                    b.Property<string>("CameraName");

                    b.HasKey("CameraId");

                    b.ToTable("Cameras");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.FrcEvent", b =>
                {
                    b.Property<int>("FrcEventId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AggregatedEventsId");

                    b.Property<string>("Confidence")
                        .HasColumnType("jsonb");

                    b.Property<int>("Framenumber");

                    b.Property<string>("HeadId");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Rectangle")
                        .HasColumnType("jsonb");

                    b.Property<DateTimeOffset>("Timestamp");

                    b.HasKey("FrcEventId");

                    b.HasIndex("AggregatedEventsId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GroupName");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.Identity", b =>
                {
                    b.Property<string>("IdentityId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("ExternalId");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Info");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.HasKey("IdentityId");

                    b.ToTable("Identities");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.IdentityGroup", b =>
                {
                    b.Property<string>("IdentityId");

                    b.Property<int>("GroupId");

                    b.HasKey("IdentityId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("IdentityGroups");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.FrcEvent", b =>
                {
                    b.HasOne("Postgres.Domain.Entities.AggregatedEvents", "AggregatedEvents")
                        .WithMany("FrcEvent")
                        .HasForeignKey("AggregatedEventsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Postgres.Domain.Entities.IdentityGroup", b =>
                {
                    b.HasOne("Postgres.Domain.Entities.Group", "Group")
                        .WithMany("IdentityGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Postgres.Domain.Entities.Identity", "Identity")
                        .WithMany("IdentityGroups")
                        .HasForeignKey("IdentityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
