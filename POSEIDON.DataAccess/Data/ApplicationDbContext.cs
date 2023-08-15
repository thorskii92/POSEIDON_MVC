using Microsoft.EntityFrameworkCore;
using POSEIDON.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEIDON.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Barangay> Barangays { get; set; }
        public DbSet<Cluster> Clusters { get; set; }
        public DbSet<MeterReader> MeterReaders { get; set; }
        public DbSet<Classification> Classifications { get; set; }
        public DbSet<Plant> Plants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Province>().HasData(new Province
            {
                Id = 1,
                Name = "Palawan",
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
            });

            modelBuilder.Entity<District>().HasData(
                new District
            {
                Id = 1,
                Name = "Aborlan",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 2,
                Name = "Agutaya",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 3,
                Name = "Araceli",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 4,
                Name = "Balabac",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 5,
                Name = "Bataraza",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 6,
                Name = "Brooke's Point",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 7,
                Name = "Busuanga",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 8,
                Name = "Cagayancillo",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 9,
                Name = "Coron",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 10,
                Name = "Culion",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 11,
                Name = "Cuyo",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 12,
                Name = "Dumaran",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 13,
                Name = "El Nido",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 14,
                Name = "Kalayaan",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 15,
                Name = "Linapacan",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 16,
                Name = "Magsaysay",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 17,
                Name = "Narra",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 18,
                Name = "Puerto Princesa",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 19,
                Name = "Quezon",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 20,
                Name = "Rizal",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 21,
                Name = "Roxas",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 22,
                Name = "San Vicente",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 23,
                Name = "Sofronio Española",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }, new District
            {
                Id = 24,
                Name = "Taytay",
                ProvinceId = 1,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            }
            );

            modelBuilder.Entity<Barangay>().HasData(new Barangay
            {
                Id = 1,
                Name = "Punta-Baja",
                DistrictId = 20,
                BarangayCode = "01",
                LocationType = "Urban",
                Status = "Active",
                PlantId=1,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Barangay
            {
                Id = 2,
                Name = "Bunog",
                DistrictId = 20,
                BarangayCode = "02",
                LocationType = "Rural",
                Status = "Active",
                PlantId = 1,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Barangay
            {
                Id = 3,
                Name = "Iraan",
                DistrictId = 20,
                BarangayCode = "03",
                LocationType = "Rural",
                Status = "Active",
                PlantId = 1,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Barangay
            {
                Id = 4,
                Name = "Campong-Ulay",
                DistrictId = 20,
                BarangayCode = "04",
                LocationType = "Rural",
                Status = "Active",
                PlantId = 1,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Barangay
            {
                Id = 5,
                Name = "Ransang",
                DistrictId = 20,
                BarangayCode = "05",
                LocationType = "Rural",
                Status = "Inactive",
                PlantId = 1,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Barangay
            {
                Id = 6,
                Name = "Candawaga",
                DistrictId = 20,
                BarangayCode = "06",
                LocationType = "Rural",
                Status = "Inactive",
                PlantId = 1,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Barangay
            {
                Id = 7,
                Name = "Culasian",
                DistrictId = 20,
                BarangayCode = "07",
                LocationType = "Rural",
                Status = "Inactive",
                PlantId = 1,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Barangay
            {
                Id = 8,
                Name = "Panalingaan",
                DistrictId = 20,
                BarangayCode = "08",
                LocationType = "Rural",
                Status = "Inactive",
                PlantId = 1,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Barangay
            {
                Id = 9,
                Name = "Taburi",
                DistrictId = 20,
                BarangayCode = "09",
                LocationType = "Rural",
                Status = "Inactive",
                PlantId = 1,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Barangay
            {
                Id = 10,
                Name = "Latud",
                DistrictId = 20,
                BarangayCode = "10",
                LocationType = "Rural",
                Status = "Inactive",
                PlantId = 1,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Barangay
            {
                Id = 11,
                Name = "Canipaan",
                DistrictId = 20,
                BarangayCode = "11",
                LocationType = "Rural",
                Status = "Inactive",
                PlantId = 1,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            });

            modelBuilder.Entity<Cluster>().HasData(new Cluster
            {
                Id = 1,
                Name = "Malapandeg",
                BarangayId = 1,
                Code="001",
                Status = "Active",
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Cluster
            {
                Id = 2,
                Name = "Katutubo",
                BarangayId = 1,
                Code = "002",
                Status = "Active",
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            });

            modelBuilder.Entity<Plant>().HasData(new Plant
            {
                Id = 1,
                Name = "Calupisan River Water System",
                DistrictId = 1,               
                Status = "Active",
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            }, new Plant
            {
                Id = 2,
                Name = "Magtayob River Water System",
                DistrictId = 1,              
                Status = "Active",
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now
            });
        }
    }

}
