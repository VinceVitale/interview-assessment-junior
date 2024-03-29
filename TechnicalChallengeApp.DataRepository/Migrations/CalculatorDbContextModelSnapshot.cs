﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechnicalChallengeApp.DataRepository;

namespace TechnicalChallengeApp.DataRepository.Migrations
{
    [DbContext(typeof(CalculatorDbContext))]
    partial class CalculatorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("TechnicalChallengeApp.DataRepository.Table.SessionData", b =>
                {
                    b.Property<Guid>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("ButtonsPushed")
                        .HasColumnType("INTEGER");

                    b.HasKey("SessionId");

                    b.ToTable("SessionData");
                });
#pragma warning restore 612, 618
        }
    }
}
