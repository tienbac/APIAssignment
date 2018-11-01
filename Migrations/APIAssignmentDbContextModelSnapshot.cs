﻿// <auto-generated />
using System;
using APIAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIAssignment.Migrations
{
    [DbContext(typeof(APIAssignmentDbContext))]
    partial class APIAssignmentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIAssignment.Models.Credential", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedTimeMls");

                    b.Property<long>("ExpiredTimeMls");

                    b.Property<long?>("MemberId");

                    b.Property<string>("SecretToken");

                    b.Property<int>("Status");

                    b.Property<string>("Token");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("APIAssignment.Models.Member", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Avatar");

                    b.Property<long>("Birthday");

                    b.Property<long>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("Introduction");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<string>("Salt");

                    b.Property<int>("Status");

                    b.Property<long>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("APIAssignment.Models.Song", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<long>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Link");

                    b.Property<int>("MemberId");

                    b.Property<long?>("MemberId1");

                    b.Property<string>("Name");

                    b.Property<string>("Singer");

                    b.Property<int>("Status");

                    b.Property<string>("Thumbnail");

                    b.Property<long>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("MemberId1");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("APIAssignment.Models.Credential", b =>
                {
                    b.HasOne("APIAssignment.Models.Member", "Member")
                        .WithMany("Credentials")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("APIAssignment.Models.Song", b =>
                {
                    b.HasOne("APIAssignment.Models.Member", "Member")
                        .WithMany("Songs")
                        .HasForeignKey("MemberId1");
                });
#pragma warning restore 612, 618
        }
    }
}
