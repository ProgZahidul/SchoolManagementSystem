using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.DAL.SchoolContext
{

    public class SchoolDbContext : IdentityDbContext
    {

        public DbSet<Attendance> dbsAttendance { get; set; }
        public DbSet<Standard> dbsStandard { get; set; }
        public DbSet<Department> dbsDepartment { get; set; }
        public DbSet<ExamSchedule> dbsExamSchedule { get; set; }
        public DbSet<ExamSubject> dbsExamSubject { get; set; }
        public DbSet<ExamType> dbsExamType { get; set; }
        public DbSet<Mark> dbsMark { get; set; }
        public DbSet<MarkEntry> dbsMarkEntry { get; set; }
        public DbSet<Staff> dbsStaff { get; set; }
        public DbSet<StaffExperience> dbsStaffExperience { get; set; }
        public DbSet<StaffSalary> dbsStaffSalary { get; set; }
        public DbSet<Student> dbsStudent { get; set; }
        public DbSet<Subject> dbsSubject { get; set; }
        public DbSet<FeeType> dbsFeeType { get; set; }
        public DbSet<FeeStructure> dbsFeeStructure { get; set; }
        public DbSet<FeePayment> dbsFeePayment { get; set; }
        public DbSet<DueBalance> dbsDueBalance { get; set; }
        public DbSet<FeePaymentDetail> dbsfeePaymentDetails { get; set; }


        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }


        //This SaveChanges() method is implemented for inserting Computed column [NetSalary column from StaffSalary Table] into Database.
        public override int SaveChanges()
        {
            // Calculate NetSalary before saving changes
            foreach (var entry in ChangeTracker.Entries<StaffSalary>())
            {
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    var staffSalary = entry.Entity;
                    staffSalary.CalculateNetSalary();
                }
            }
            

            return base.SaveChanges();
        }




        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<IdentityUserLogin<string>>()
            .HasKey(u => new { u.UserId, u.LoginProvider, u.ProviderKey });

            modelBuilder.Entity<IdentityUserRole<string>>()
        .HasKey(r => new { r.UserId, r.RoleId });


        
            // Configure the foreign key constraint for dbsMark referencing dbsSubject

            modelBuilder.Entity<Mark>()
                .HasOne(m => m.Subject)
                .WithMany()
                .HasForeignKey(m => m.SubjectId)
                .OnDelete(DeleteBehavior.NoAction)
                ; // Specify ON DELETE NO ACTION




            //    modelBuilder.Entity<StaffExperience>()
            //.Property(p => p.ServiceDuration)
            //.HasComputedColumnSql("DATEDIFF(year, JoiningDate, ISNULL(LeavingDate, GETDATE()))"); // Calculate duration in years



            modelBuilder.Entity<Subject>()
        .HasIndex(s => s.SubjectCode)
        .IsUnique();


            modelBuilder.Entity<Student>()
        .HasIndex(s => s.AdmissionNo)
        .IsUnique();


            modelBuilder.Entity<Student>()
        .HasIndex(s => s.EnrollmentNo)
        .IsUnique();



            modelBuilder.Entity<Standard>().HasData(new Standard[]

           {
                new Standard
                {
                    StandardId=1,
                    StandardName="ClassOne"
                },
                new Standard
                {
                    StandardId=2,
                    StandardName="ClassTwo"
                },
                new Standard
                {
                    StandardId=3,
                    StandardName="ClassThree"
                }

           });

            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new Student
                {
                    StudentId=1,
                    StudentName= "Hasan Mahmud",
                     StudentDOB = DateTime.ParseExact("01-01-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    StandardId=1
                },
                new Student
                {
                    StudentId=2,
                    StudentName= "Salman Khan",
                     StudentDOB = DateTime.ParseExact("01-01-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    StandardId=1
                },
                new Student
                {
                    StudentId=3,
                    StudentName= "Rakib Kibriya",
                     StudentDOB = DateTime.ParseExact("01-01-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    StandardId=2
                },
                new Student
                {
                    StudentId=4,
                    StudentName= "Jalal Ahmed",
                     StudentDOB = DateTime.ParseExact("01-01-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    StandardId=2
                }

            });

            modelBuilder.Entity<FeeType>().HasData(new FeeType[]
            {
                new FeeType
                {
                    FeeTypeId=1,
                    TypeName="Tusion Fee",
                },
                new FeeType
                {
                    FeeTypeId=2,
                    TypeName="Libaray Fee",
                },
                new FeeType
                {
                    FeeTypeId=3,
                    TypeName="Transfort Fee",
                }
            });

            modelBuilder.Entity<FeeStructure>().HasData(new FeeStructure[]
           {
                new FeeStructure
                {
                    FeeStructureId=1,
                    StandardId=1,
                    StandardName="ClassOne",
                    FeeTypeId=1,
                    TypeName="Tusion Fee",
                    Monthly=true,
                    Yearly=false,
                    FeeAmount=2000
                },
                new FeeStructure
                {
                    FeeStructureId=2,
                    StandardId=1,
                    StandardName="ClassOne",
                    FeeTypeId=2,
                    TypeName="Libaray Fee",
                    Monthly=true,
                    Yearly=false,
                    FeeAmount=400
                },
                new FeeStructure
                {
                    FeeStructureId=3,
                    StandardId=2,
                    StandardName="ClassTwo",
                    FeeTypeId=1,
                    TypeName="Tusion Fee",
                    Monthly=true,
                    Yearly=false,
                    FeeAmount=2500
                },
                new FeeStructure
                {
                    FeeStructureId=4,
                    StandardId=2,
                    StandardName="ClassTwo",
                    FeeTypeId=2,
                    TypeName="Libaray Fee",
                    Monthly=true,
                    Yearly=false,
                    FeeAmount=500
                },
                new FeeStructure
                {
                    FeeStructureId=5,
                    StandardId=3,
                    StandardName="ClassThree",
                    FeeTypeId=1,
                    TypeName="Tusion Fee",
                    Monthly=true,
                    Yearly=false,
                    FeeAmount=2500
                },
                new FeeStructure
                {
                    FeeStructureId=6,
                    StandardId=3,
                    StandardName="ClassThree",
                    FeeTypeId=2,
                     TypeName="Libaray Fee",
                    Monthly=true,
                    Yearly=false,
                    FeeAmount=500
                },
                new FeeStructure
                {
                    FeeStructureId=7,
                    StandardId=1,
                    StandardName="ClassOne",
                    FeeTypeId=3,
                    TypeName="Transfort Fee",
                    Monthly=true,
                    Yearly=false,
                    FeeAmount=600
                }

           });
            modelBuilder.Entity<FeePaymentDetail>().HasData(new FeePaymentDetail[]
            {
                new FeePaymentDetail
                {
                    FeePaymentDetailId = 1,
                    FeePaymentId = 1,
                    FeeTypeName = "Tusion Fee",
                    FeeAmount = 2000
                },
                new FeePaymentDetail
                {
                    FeePaymentDetailId = 2,
                    FeePaymentId = 1,
                    FeeTypeName = "Libaray Fee",
                    FeeAmount = 400
                },
                new FeePaymentDetail
                {
                    FeePaymentDetailId = 3,
                    FeePaymentId = 2,
                    FeeTypeName = "Tusion Fee",
                    FeeAmount = 2000
                }, new FeePaymentDetail
                {
                    FeePaymentDetailId = 4,
                    FeePaymentId = 2,
                    FeeTypeName = "Libaray Fee",
                    FeeAmount = 400
                },
                 new FeePaymentDetail
                {
                    FeePaymentDetailId = 5,
                    FeePaymentId = 3,
                    FeeTypeName = "Tusion Fee",
                    FeeAmount = 2500
                }, new FeePaymentDetail
                {
                    FeePaymentDetailId = 6,
                    FeePaymentId = 3,
                    FeeTypeName = "Libaray Fee",
                    FeeAmount = 500
                }



            });

            modelBuilder.Entity<FeePayment>().HasData(new FeePayment[]
            {
                new FeePayment
                {
                FeePaymentId = 1,
                StudentId = 1,
                StudentName="Hasan Mahmud",
                TotalFeeAmount = 2400,
                Discount = 5,
                AmountAfterDiscount = 2280,
                PreviousDue = 0,
                TotalAmount = 2280,
                AmountPaid = 3000,
                AmountRemaining = -720,
                PaymentDate = DateTime.Parse("2024-02-14T10:42:22.787")
                },
                new FeePayment
                {
                FeePaymentId = 2,
                StudentName="Salman Khan",
                StudentId = 2,
                TotalFeeAmount = 2400,
                Discount = 5,
                AmountAfterDiscount = 2280,
                PreviousDue = 0,
                TotalAmount = 2280,
                AmountPaid = 500,
                AmountRemaining = 1780,
                PaymentDate = DateTime.Parse("2024-02-14T10:42:22.787")
                },
                 new FeePayment
                {
                FeePaymentId = 3,
                StudentId = 3,
                StudentName="Rakib Kibriya",
                TotalFeeAmount = 2400,
                Discount = 5,
                AmountAfterDiscount = 2280,
                PreviousDue = 0,
                TotalAmount = 2280,
                AmountPaid = 500,
                AmountRemaining = 1780,
                PaymentDate = DateTime.Parse("2024-02-14T10:42:22.787")
                }

            });
            base.OnModelCreating(modelBuilder);

        }
    }
}
