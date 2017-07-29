using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Smartstartups.Models
{
    public partial class SmartStartupContext : DbContext
    {
        public virtual DbSet<Demographics> Demographics { get; set; }
        public virtual DbSet<Neis> Neis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NTUSR11\SQLEXPRESS;Database=SmartStartup;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Demographics>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("decimal")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Age0to14Percentage).HasColumnType("varchar(50)");

                entity.Property(e => e.Age15to64Percentage).HasColumnType("varchar(50)");

                entity.Property(e => e.Age65andOver).HasColumnType("varchar(50)");

                entity.Property(e => e.Asgs2015STCode)
                    .IsRequired()
                    .HasColumnName("ASGS 2015 S T code")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FemaleNo)
                    .HasColumnName("Female no")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LgaCode)
                    .HasColumnName("LGA code")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LgaName)
                    .HasColumnName("LGA name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MalesNo)
                    .HasColumnName("Males no")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MedianAgeOfFemales)
                    .HasColumnName("Median age of Females")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MedianAgeOfMales)
                    .HasColumnName("Median age of Males")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MedianAgeOfPersons)
                    .HasColumnName("Median age of Persons")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PersonsNo).HasColumnType("varchar(50)");

                entity.Property(e => e.STName)
                    .HasColumnName("S T name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SexRatioNo)
                    .HasColumnName("Sex RatioNo")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Neis>(entity =>
            {
                entity.HasKey(e => e.BusinessId)
                    .HasName("PK_Neis");

                entity.Property(e => e.BusinessId)
                    .HasColumnName("business_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AgeGroup)
                    .HasColumnName("age_group")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AnzsicCode)
                    .HasColumnName("anzsic_code")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DisabilityInd)
                    .HasColumnName("disability_ind")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ExOffenderInd)
                    .HasColumnName("ex_offender_ind")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ExitReason)
                    .HasColumnName("exit_reason")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.GenderCd)
                    .HasColumnName("gender_cd")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.HomelessInd)
                    .HasColumnName("homeless_ind")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IndigenousInd)
                    .HasColumnName("indigenous_ind")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IndustryType)
                    .HasColumnName("industry_type")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Metro)
                    .HasColumnName("metro")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NeisAllowanceInd)
                    .HasColumnName("neis_allowance_ind")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NeisType)
                    .HasColumnName("neis_type")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NesbInd)
                    .HasColumnName("nesb_ind")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RefugeeInd)
                    .HasColumnName("refugee_ind")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SoleParentInd)
                    .HasColumnName("sole_parent_ind")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Successful)
                    .HasColumnName("successful")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Surveyed)
                    .HasColumnName("surveyed")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvEndDem)
                    .HasColumnName("sv_end_dem")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvEndHealth)
                    .HasColumnName("sv_end_health")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvEndLoc)
                    .HasColumnName("sv_end_loc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvEndMentor)
                    .HasColumnName("sv_end_mentor")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvEndOth)
                    .HasColumnName("sv_end_oth")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvEndProfit)
                    .HasColumnName("sv_end_profit")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvEndTrain)
                    .HasColumnName("sv_end_train")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvHoursWork)
                    .HasColumnName("sv_hours_work")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvInOperation)
                    .HasColumnName("sv_in_operation")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvMonth)
                    .HasColumnName("sv_month")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvSatBusTrain)
                    .HasColumnName("sv_sat_bus_train")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvSatMentor)
                    .HasColumnName("sv_sat_mentor")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvSatOverall)
                    .HasColumnName("sv_sat_overall")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvStaffGt35h)
                    .HasColumnName("sv_staff_gt35h")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvStaffLt35h)
                    .HasColumnName("sv_staff_lt35h")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvTailorSup)
                    .HasColumnName("sv_tailor_sup")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SvYear)
                    .HasColumnName("sv_year")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}