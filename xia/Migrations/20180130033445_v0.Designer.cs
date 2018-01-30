﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using xia.DAL;

namespace xia.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20180130033445_v0")]
    partial class v0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("xia.DAL.Models.User", b =>
                {
                    b.Property<int>("USR_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("USR_CUR_HP");

                    b.Property<int>("USR_CUR_MP");

                    b.Property<int>("USR_EXP");

                    b.Property<int>("USR_LEVEL");

                    b.Property<int>("USR_LILIANG");

                    b.Property<int>("USR_MAX_HP");

                    b.Property<int>("USR_MAX_MP");

                    b.Property<int>("USR_MINJIE");

                    b.Property<int>("USR_MONEY");

                    b.Property<string>("USR_NAME");

                    b.Property<int>("USR_NEXT_LEVEL");

                    b.Property<string>("USR_SEX");

                    b.Property<string>("USR_WUXING");

                    b.HasKey("USR_ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}