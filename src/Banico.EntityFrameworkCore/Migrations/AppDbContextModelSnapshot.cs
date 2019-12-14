﻿// <auto-generated />
using System;
using Banico.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Banico.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Banico.Core.Entities.Config", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<string>("Module");

                    b.Property<string>("Name");

                    b.Property<string>("Tenant");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedDate");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Configs");

                    b.HasData(
                        new
                        {
                            Id = "a27e4323-3df8-45b3-9991-41749ec763d1",
                            CreatedDate = new DateTimeOffset(new DateTime(2019, 12, 14, 0, 43, 44, 486, DateTimeKind.Unspecified).AddTicks(5900), new TimeSpan(0, 0, 0, 0, 0)),
                            Module = "",
                            Name = "initialized",
                            UpdatedDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = "n"
                        },
                        new
                        {
                            Id = "dd787709-2339-4aee-97d7-c17ff88d90da",
                            CreatedDate = new DateTimeOffset(new DateTime(2019, 12, 14, 0, 43, 44, 488, DateTimeKind.Unspecified).AddTicks(2550), new TimeSpan(0, 0, 0, 0, 0)),
                            Module = "admin",
                            Name = "canActivate",
                            UpdatedDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = "admin"
                        });
                });

            modelBuilder.Entity("Banico.Core.Entities.ContentItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias");

                    b.Property<string>("Attribute01");

                    b.Property<string>("Attribute02");

                    b.Property<string>("Attribute03");

                    b.Property<string>("Attribute04");

                    b.Property<string>("Attribute05");

                    b.Property<string>("Attribute06");

                    b.Property<string>("Attribute07");

                    b.Property<string>("Attribute08");

                    b.Property<string>("Attribute09");

                    b.Property<string>("Attribute10");

                    b.Property<string>("Attribute11");

                    b.Property<string>("Attribute12");

                    b.Property<string>("Attribute13");

                    b.Property<string>("Attribute14");

                    b.Property<string>("Attribute15");

                    b.Property<string>("Attribute16");

                    b.Property<string>("Attribute17");

                    b.Property<string>("Attribute18");

                    b.Property<string>("Attribute19");

                    b.Property<string>("Attribute20");

                    b.Property<int>("ChildCount");

                    b.Property<string>("Content");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<string>("Module");

                    b.Property<string>("Name");

                    b.Property<string>("ParentId");

                    b.Property<string>("SectionItems");

                    b.Property<string>("Tenant");

                    b.Property<string>("Type");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ContentItems");
                });

            modelBuilder.Entity("Banico.Core.Entities.ContentSectionItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentItemId");

                    b.Property<string>("SectionItemId");

                    b.HasKey("Id");

                    b.HasIndex("ContentItemId");

                    b.HasIndex("SectionItemId");

                    b.ToTable("ContentSectionItems");
                });

            modelBuilder.Entity("Banico.Core.Entities.Invite", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Email");

                    b.Property<string>("Inviter");

                    b.HasKey("Id");

                    b.ToTable("Invites");
                });

            modelBuilder.Entity("Banico.Core.Entities.Section", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<string>("Modules");

                    b.Property<string>("Name");

                    b.Property<string>("Tenant");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Banico.Core.Entities.SectionItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias");

                    b.Property<int>("ChildCount");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("ParentId");

                    b.Property<string>("PathName");

                    b.Property<string>("PathUrl");

                    b.Property<string>("Section");

                    b.Property<string>("Tenant");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("SectionItems");
                });

            modelBuilder.Entity("Banico.Core.Entities.ContentSectionItem", b =>
                {
                    b.HasOne("Banico.Core.Entities.ContentItem")
                        .WithMany("ContentSectionItems")
                        .HasForeignKey("ContentItemId");

                    b.HasOne("Banico.Core.Entities.SectionItem", "SectionItem")
                        .WithMany()
                        .HasForeignKey("SectionItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
