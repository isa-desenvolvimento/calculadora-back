﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using calculadora_api.Models;

namespace calculadora_api.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200613135246_AddUsersToDB2")]
    partial class AddUsersToDB2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("calculadora_api.Models.ChequeEmpresarial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contractRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dataBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dataBaseAtual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("encargosMonetarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("indiceBA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("indiceDB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("indiceDataBase")
                        .HasColumnType("real");

                    b.Property<float>("indiceDataBaseAtual")
                        .HasColumnType("real");

                    b.Property<string>("infoParaCalculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("lancamentos")
                        .HasColumnType("real");

                    b.Property<string>("tipoLancamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ultimaAtualizacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("valorDevedor")
                        .HasColumnType("real");

                    b.Property<float>("valorDevedorAtualizado")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("ChequeEmpresarialItems");
                });

            modelBuilder.Entity("calculadora_api.Models.Indice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("indice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("IndiceItems");
                });

            modelBuilder.Entity("calculadora_api.Models.RegistroParcela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("amortizacao")
                        .HasColumnType("real");

                    b.Property<string>("contractRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dataCalcAmor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dataVencimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("encargosMonetarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("indiceDCA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("indiceDV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("indiceDataCalcAmor")
                        .HasColumnType("real");

                    b.Property<float>("indiceDataVencimento")
                        .HasColumnType("real");

                    b.Property<string>("infoParaCalculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("nparcelas")
                        .HasColumnType("real");

                    b.Property<float>("parcelaInicial")
                        .HasColumnType("real");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("subtotal")
                        .HasColumnType("real");

                    b.Property<float>("totalDevedor")
                        .HasColumnType("real");

                    b.Property<string>("ultimaAtualizacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("valorNoVencimento")
                        .HasColumnType("real");

                    b.Property<string>("valorPMTVincenda")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ParceladoPreItems");
                });

            modelBuilder.Entity("calculadora_api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserItems");
                });
#pragma warning restore 612, 618
        }
    }
}
