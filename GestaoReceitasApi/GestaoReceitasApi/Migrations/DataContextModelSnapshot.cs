﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GestaoReceitas.Domain.Entities.Ingredientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Medida")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("QtdMedida")
                        .HasColumnType("double");

                    b.Property<int?>("ReceitasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReceitasId");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("GestaoReceitas.Domain.Entities.Receitas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AutorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaReceita")
                        .HasColumnType("int");

                    b.Property<double>("Custo")
                        .HasColumnType("double");

                    b.Property<string>("Descrição")
                        .HasColumnType("longtext");

                    b.Property<int>("Dificuldade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<double>("Tempo")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("GestaoReceitas.Domain.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GestaoReceitas.Domain.Entities.Ingredientes", b =>
                {
                    b.HasOne("GestaoReceitas.Domain.Entities.Receitas", null)
                        .WithMany("Ingredientes")
                        .HasForeignKey("ReceitasId");
                });

            modelBuilder.Entity("GestaoReceitas.Domain.Entities.Receitas", b =>
                {
                    b.HasOne("GestaoReceitas.Domain.Entities.Users", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorId");

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("GestaoReceitas.Domain.Entities.Receitas", b =>
                {
                    b.Navigation("Ingredientes");
                });
#pragma warning restore 612, 618
        }
    }
}
