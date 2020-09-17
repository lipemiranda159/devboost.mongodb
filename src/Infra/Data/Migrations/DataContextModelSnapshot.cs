﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using devboost.dronedelivery.Infra.Data;

namespace devboost.dronedelivery.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("devboost.dronedelivery.core.domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("devboost.dronedelivery.core.domain.Entities.DadosPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dados")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PagamentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PagamentoId");

                    b.ToTable("DadosPagamentos");
                });

            modelBuilder.Entity("devboost.dronedelivery.core.domain.Entities.Drone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Autonomia")
                        .HasColumnType("int");

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<int>("Carga")
                        .HasColumnType("int");

                    b.Property<float>("Perfomance")
                        .HasColumnType("real");

                    b.Property<int>("Velocidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Drone");
                });

            modelBuilder.Entity("devboost.dronedelivery.core.domain.Entities.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusPagamento")
                        .HasColumnType("int");

                    b.Property<int>("TipoPagamento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("devboost.dronedelivery.core.domain.Entities.PedidoDrone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHoraFinalizacao")
                        .HasColumnType("datetime2");

                    b.Property<double>("Distancia")
                        .HasColumnType("float");

                    b.Property<int>("DroneId")
                        .HasColumnType("int");

                    b.Property<string>("PedidoId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusEnvio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DroneId");

                    b.ToTable("PedidoDrones");
                });

            modelBuilder.Entity("devboost.dronedelivery.core.domain.Entities.DadosPagamento", b =>
                {
                    b.HasOne("devboost.dronedelivery.core.domain.Entities.Pagamento", null)
                        .WithMany("DadosPagamentos")
                        .HasForeignKey("PagamentoId");
                });

            modelBuilder.Entity("devboost.dronedelivery.core.domain.Entities.PedidoDrone", b =>
                {
                    b.HasOne("devboost.dronedelivery.core.domain.Entities.Drone", "Drone")
                        .WithMany()
                        .HasForeignKey("DroneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}