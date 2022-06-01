﻿// <auto-generated />
using System;
using ClickExpress.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClickExpress.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220601015007_InserindoTabelasClienteseUsuarios")]
    partial class InserindoTabelasClienteseUsuarios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClickExpress.Models.Item", b =>
                {
                    b.Property<int>("Id_item")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PedidoId_contrato")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id_item");

                    b.HasIndex("PedidoId_contrato");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("ClickExpress.Models.Pedido", b =>
                {
                    b.Property<int>("Id_contrato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro_destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bairro_origem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep_destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep_origem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade_destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade_origem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClienteId_usuario")
                        .HasColumnType("int");

                    b.Property<string>("Complemento_destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento_origem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dt_agendamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Dt_contrato")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_cliente")
                        .HasColumnType("int");

                    b.Property<int>("Id_prestador")
                        .HasColumnType("int");

                    b.Property<int>("Id_usuario")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro_destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro_origem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int?>("PrestadorId_usuario")
                        .HasColumnType("int");

                    b.Property<bool>("Serv_descarrega")
                        .HasColumnType("bit");

                    b.Property<bool>("Serv_montagem")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<string>("UF_destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF_origem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_contrato");

                    b.HasIndex("ClienteId_usuario");

                    b.HasIndex("Id_usuario");

                    b.HasIndex("PrestadorId_usuario");

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

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf_Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
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

                    b.Property<string>("UF")
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

                    b.Property<int>("Id_cliente")
                        .HasColumnType("int");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ClickExpress.Models.Prestador", b =>
                {
                    b.HasBaseType("ClickExpress.Models.Usuario");

                    b.Property<int>("Id_prestador")
                        .HasColumnType("int");

                    b.ToTable("Prestadores");
                });

            modelBuilder.Entity("ClickExpress.Models.Item", b =>
                {
                    b.HasOne("ClickExpress.Models.Pedido", "Pedido")
                        .WithMany("Itens")
                        .HasForeignKey("PedidoId_contrato");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("ClickExpress.Models.Pedido", b =>
                {
                    b.HasOne("ClickExpress.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId_usuario");

                    b.HasOne("ClickExpress.Models.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("Id_usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClickExpress.Models.Prestador", "Prestador")
                        .WithMany()
                        .HasForeignKey("PrestadorId_usuario");

                    b.Navigation("Cliente");

                    b.Navigation("Prestador");

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

            modelBuilder.Entity("ClickExpress.Models.Pedido", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("ClickExpress.Models.Usuario", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
