﻿// <auto-generated />
using System;
using ClickExpress.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClickExpress.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClickExpress.Models.Pedido", b =>
                {
                    b.Property<int>("Id_contrato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dt_contrato")
                        .HasColumnType("datetime2");

                    b.Property<string>("End_Destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("End_Partida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Horario")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int>("Usuario_Id")
                        .HasColumnType("int");

                    b.HasKey("Id_contrato");

                    b.HasIndex("Usuario_Id");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("ClickExpress.Models.Usuario", b =>
                {
                    b.Property<int>("Id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf_Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Num_endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Veiculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_usuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ClickExpress.Models.Cliente", b =>
                {
                    b.HasBaseType("ClickExpress.Models.Usuario");

                    b.Property<string>("Desc_pedido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dt_pedido")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_pedido")
                        .HasColumnType("int");

                    b.Property<int>("Qtde_pedidos")
                        .HasColumnType("int");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ClickExpress.Models.Prestador", b =>
                {
                    b.HasBaseType("ClickExpress.Models.Usuario");

                    b.Property<DateTime>("Dt_entrega")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_entrega")
                        .HasColumnType("int");

                    b.Property<int>("Qtde_entregas")
                        .HasColumnType("int");

                    b.ToTable("Prestadores");
                });

            modelBuilder.Entity("ClickExpress.Models.Pedido", b =>
                {
                    b.HasOne("ClickExpress.Models.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("Usuario_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ClickExpress.Models.Cliente", b =>
                {
                    b.HasOne("ClickExpress.Models.Usuario", null)
                        .WithOne()
                        .HasForeignKey("ClickExpress.Models.Cliente", "Id_usuario")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClickExpress.Models.Prestador", b =>
                {
                    b.HasOne("ClickExpress.Models.Usuario", null)
                        .WithOne()
                        .HasForeignKey("ClickExpress.Models.Prestador", "Id_usuario")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClickExpress.Models.Usuario", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
