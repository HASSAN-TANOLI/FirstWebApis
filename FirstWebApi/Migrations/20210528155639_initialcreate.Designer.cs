﻿// <auto-generated />
using FirstWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FirstWebApi.Migrations
{
    [DbContext(typeof(EmployeeDBcontext))]
    [Migration("20210528155639_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FirstWebApi.Models.Employes", b =>
                {
                    b.Property<int>("Employesid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("empaddress");

                    b.Property<string>("empdesignation");

                    b.Property<string>("empemail");

                    b.Property<string>("empname");

                    b.Property<int>("empsalary");

                    b.HasKey("Employesid");

                    b.ToTable("Emoployes");
                });
#pragma warning restore 612, 618
        }
    }
}