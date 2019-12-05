﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Postgres.Persistance;

namespace Postgres.Persistance.Migrations
{
    [DbContext(typeof(FrcContext))]
    partial class FrcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Postgres.Domain.Entities.AggregatedEvents", b =>
                {
                    b.Property<Guid>("AggregatedEventsId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("BestImage");

                    b.Property<Guid>("CameraId");

                    b.Property<double>("Confidence");

                    b.Property<double>("FaceConfidence");

                    b.Property<Guid>("IdentityId");

                    b.Property<bool>("Recognized");

                    b.Property<DateTimeOffset>("TimestampEnd");

                    b.Property<DateTimeOffset>("TimestampStart");

                    b.HasKey("AggregatedEventsId");

                    b.ToTable("AggregatedEvents");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.Camera", b =>
                {
                    b.Property<Guid>("CameraId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CameraGroup");

                    b.Property<string>("CameraName");

                    b.Property<byte[]>("DisplayImage");

                    b.Property<decimal>("MaximumHeadSize");

                    b.Property<decimal>("MinimumHeadSize");

                    b.Property<decimal>("Threshold");

                    b.HasKey("CameraId");

                    b.ToTable("Cameras");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<Guid>("CustomerId");

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.FeatureVector", b =>
                {
                    b.Property<int>("FeatureVectorId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CombinedVector");

                    b.Property<string>("ExternailId");

                    b.Property<byte[]>("FeatureVectorData");

                    b.Property<Guid?>("IdentityId");

                    b.Property<Guid?>("ReferenceImageId");

                    b.HasKey("FeatureVectorId");

                    b.ToTable("FeatureVectors");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.FrcEvent", b =>
                {
                    b.Property<int>("FrcEventId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AggregatedEventsId");

                    b.Property<string>("Confidence")
                        .HasColumnType("jsonb");

                    b.Property<decimal>("EventId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<double>("FaceConfidence");

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

            modelBuilder.Entity("Postgres.Domain.Entities.Identity", b =>
                {
                    b.Property<Guid>("IdentityId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Active");

                    b.Property<DateTime?>("AddedAt");

                    b.Property<string>("AddedBy");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<Guid>("CustomerId");

                    b.Property<string>("Email");

                    b.Property<DateTime?>("ExpiryDate");

                    b.Property<string>("ExternalId");

                    b.Property<string>("FirstName");

                    b.Property<int?>("Gender");

                    b.Property<string>("Group");

                    b.Property<string>("Info");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("PostalCode");

                    b.Property<Guid>("ReferenceImageId");

                    b.Property<string>("Street");

                    b.Property<string>("TelephoneNumber");

                    b.HasKey("IdentityId");

                    b.ToTable("Identities");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.IdentityCategory", b =>
                {
                    b.Property<Guid>("IdentityId");

                    b.Property<Guid>("CategoryId");

                    b.HasKey("IdentityId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("IdentityCategories");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.ReferenceImage", b =>
                {
                    b.Property<Guid>("ReferenceImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ExternalImageId");

                    b.Property<Guid>("IdentityId");

                    b.Property<byte[]>("Image");

                    b.HasKey("ReferenceImageId");

                    b.HasIndex("IdentityId");

                    b.ToTable("ReferenceImages");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.Setting", b =>
                {
                    b.Property<int>("SettingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SettingName");

                    b.Property<string>("SettingValue");

                    b.HasKey("SettingId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.SubCategory", b =>
                {
                    b.Property<Guid>("SubCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<string>("SubCategoryName");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("Postgres.Domain.Entities.FrcEvent", b =>
                {
                    b.HasOne("Postgres.Domain.Entities.AggregatedEvents", "AggregatedEvents")
                        .WithMany("FrcEvent")
                        .HasForeignKey("AggregatedEventsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Postgres.Domain.Entities.IdentityCategory", b =>
                {
                    b.HasOne("Postgres.Domain.Entities.Category", "Category")
                        .WithMany("IdentityCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Postgres.Domain.Entities.Identity", "Identity")
                        .WithMany("IdentityCategories")
                        .HasForeignKey("IdentityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Postgres.Domain.Entities.ReferenceImage", b =>
                {
                    b.HasOne("Postgres.Domain.Entities.Identity", "Identity")
                        .WithMany("ReferenceImages")
                        .HasForeignKey("IdentityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Postgres.Domain.Entities.SubCategory", b =>
                {
                    b.HasOne("Postgres.Domain.Entities.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
