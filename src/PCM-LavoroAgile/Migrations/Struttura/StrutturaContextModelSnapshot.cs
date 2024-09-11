﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PCM_LavoroAgile.Migrations.Struttura
{
    [DbContext(typeof(StrutturaContext))]
    partial class StrutturaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Model.SegreteriaTecnica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChildId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATION_DATE");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("EDIT_TIME");

                    b.Property<string>("EmailUtente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("SegreteriaTecnica");
                });

            modelBuilder.Entity("Domain.Model.Struttura", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChildId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATION_DATE");

                    b.Property<bool>("DirettaCollaborazione")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("EDIT_TIME");

                    b.Property<int>("NumeroLivelli")
                        .HasColumnType("int");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StrutturaCompleta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrutturaLiv1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrutturaLiv2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrutturaLiv3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Strutture");
                });

            modelBuilder.Entity("Domain.Model.Struttura", b =>
                {
                    b.OwnsOne("Domain.Model.Referente", "ReferenteInterno", b1 =>
                        {
                            b1.Property<Guid>("StrutturaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Email")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("EmailReferenteInterno");

                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier")
                                .HasColumnName("IdReferenteInterno");

                            b1.Property<string>("NomeCognome")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("ReferenteInterno");

                            b1.HasKey("StrutturaId");

                            b1.ToTable("Strutture");

                            b1.WithOwner()
                                .HasForeignKey("StrutturaId");
                        });

                    b.OwnsOne("Domain.Model.Dirigente", "CapoIntermedio", b1 =>
                        {
                            b1.Property<Guid>("StrutturaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Email")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("EmailCapoIntermedio");

                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier")
                                .HasColumnName("IdCapoIntermedio");

                            b1.Property<string>("NomeCognome")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("CapoIntermedio");

                            b1.HasKey("StrutturaId");

                            b1.ToTable("Strutture");

                            b1.WithOwner()
                                .HasForeignKey("StrutturaId");
                        });

                    b.OwnsOne("Domain.Model.Dirigente", "CapoStruttura", b1 =>
                        {
                            b1.Property<Guid>("StrutturaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Email")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("EmailCapoStruttura");

                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier")
                                .HasColumnName("IdCapoStruttura");

                            b1.Property<string>("NomeCognome")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("CapoStruttura");

                            b1.HasKey("StrutturaId");

                            b1.ToTable("Strutture");

                            b1.WithOwner()
                                .HasForeignKey("StrutturaId");
                        });

                    b.OwnsOne("Domain.Model.Dirigente", "DirigenteResponsabile", b1 =>
                        {
                            b1.Property<Guid>("StrutturaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Email")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("EmailDirigenteResponsabile");

                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier")
                                .HasColumnName("IdDirigenteResponsabile");

                            b1.Property<string>("NomeCognome")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("DirigenteResponsabile");

                            b1.HasKey("StrutturaId");

                            b1.ToTable("Strutture");

                            b1.WithOwner()
                                .HasForeignKey("StrutturaId");
                        });

                    b.OwnsOne("Domain.Model.Dirigente", "ResponsabileAccordo", b1 =>
                        {
                            b1.Property<Guid>("StrutturaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Email")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("EmailResponsabileAccordo");

                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier")
                                .HasColumnName("IdResponsabileAccordo");

                            b1.Property<string>("NomeCognome")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("ResponsabileAccordo");

                            b1.HasKey("StrutturaId");

                            b1.ToTable("Strutture");

                            b1.WithOwner()
                                .HasForeignKey("StrutturaId");
                        });

                    b.Navigation("CapoIntermedio");

                    b.Navigation("CapoStruttura");

                    b.Navigation("DirigenteResponsabile");

                    b.Navigation("ReferenteInterno");

                    b.Navigation("ResponsabileAccordo");
                });
#pragma warning restore 612, 618
        }
    }
}
