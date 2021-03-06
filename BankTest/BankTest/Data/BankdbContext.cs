﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using BankTest.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BankTest.Data
{
    public partial class BankdbContext : DbContext
    {
        public BankdbContext()
        {
        }

        public BankdbContext(DbContextOptions<BankdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Iban).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_Account_Bank");

                entity.HasOne(d => d.BankNavigation)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Account_Customer");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.Psw).IsUnicode(false);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Customer_Bank");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasOne(d => d.IbanNavigation)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.Iban)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Transaction_Account");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.LoginName).ValueGeneratedNever();

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}