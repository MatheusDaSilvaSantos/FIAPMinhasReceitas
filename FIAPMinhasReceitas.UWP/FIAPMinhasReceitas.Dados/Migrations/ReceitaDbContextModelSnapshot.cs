﻿// <auto-generated />
using FIAPMinhasReceitas.Dados;
using FIAPMinhasReceitas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FIAPMinhasReceitas.Dados.Migrations
{
    [DbContext(typeof(ReceitaDbContext))]
    partial class ReceitaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("FIAPMinhasReceitas.Models.Receita", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Categoria");

                    b.Property<byte[]>("ImagemBytes");

                    b.Property<string>("Instrucoes");

                    b.Property<int>("MinutosPreparo");

                    b.Property<decimal>("Preco");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });
#pragma warning restore 612, 618
        }
    }
}
