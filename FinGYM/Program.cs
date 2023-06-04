using FinGYM.BuisnessLogic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinGYM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Datacontext dbcontext = new Datacontext();

            Database.SetInitializer<Datacontext>(new DropCreateDatabaseIfModelChanges<Datacontext>());

            Manger m1 = new Manger() { UserName = "enjy", PassWord = "123"  };


            Equipments eqp1 = new Equipments() { name = "Turola", price = 7000, totalNumber = 2, DeleivryDate = DateTime.Today , manager = m1 };
            Equipments eqp2 = new Equipments() { name = "Walking", price = 10000, totalNumber = 1, DeleivryDate = DateTime.Today, manager = m1 };
            Equipments eqp3 = new Equipments() { name = "picycle", price = 3000, totalNumber = 4, DeleivryDate = DateTime.Today, manager = m1 };
            Equipments eqp4 = new Equipments() { name = "steel", price = 5000, totalNumber = 3, DeleivryDate = DateTime.Today, manager = m1 };


            Classes class1 = new Classes() { name = "KickiingBox" , manger = m1 };
            Classes class2 = new Classes() { name = "yoga" , manger = m1 };
            Classes class3 = new Classes() { name = "zomba", manger = m1 };
            Classes class4 = new Classes() { name = "karateh", manger = m1 };

            Coach c1 = new Coach() { name = "enjy", age = 22, gender = "Female", HireDate = DateTime.Now, Phone = "0125000000", Salary = 3500, classId = class1.ID , manger= m1};
            Coach c2 = new Coach() { name = "mohamed", age = 42, gender = "Male", HireDate = DateTime.Now, Phone = "0125005550", Salary = 5500, classId = class2.ID , manger= m1 };
            Coach c3 = new Coach() { name = "kerols", age = 25, gender = "Male", HireDate = DateTime.Now, Phone = "0125000000", Salary = 3500, classId = class1.ID, manger = m1 };
            Coach c4 = new Coach() { name = "abderahman", age = 57, gender = "Male", HireDate = DateTime.Now, Phone = "0125005550", Salary = 5500, classId = class2.ID, manger = m1 };


            Employee e1 = new Employee() { name = "Alaa", Age = 33, Gender = "Male", HireDate = DateTime.Now, Phone = "0125005550", Salary = 5500, jobTitle = "Security" , manager= m1};
            Employee e2 = new Employee() { name = "salma", Age = 45, Gender = "Female", HireDate = DateTime.Now, Phone = "0127589450", Salary = 3500, jobTitle = "Cleaner" , manager = m1 };
            Employee e3 = new Employee() { name = "safaa", Age = 33, Gender = "Female", HireDate = DateTime.Now, Phone = "0125005550", Salary = 5500, jobTitle = "Security", manager = m1 };
            Employee e4 = new Employee() { name = "asmaa", Age = 45, Gender = "Female", HireDate = DateTime.Now, Phone = "0127589450", Salary = 3500, jobTitle = "Cleaner", manager = m1 };

            Trainee t1 = new Trainee() { name = "noha ", age = 31, gender = "Female", Duration = 3, Phone = "01235555", StartJoinDate = DateTime.Now, SubtractionFees = 350, clas = class1 ,coach =c1 ,manger = m1  };
            Trainee t2 = new Trainee() { name = "adel", age = 35, gender = "Male", Duration = 5, Phone = "0125005550", StartJoinDate = DateTime.Now, SubtractionFees = 550, clas = class2, coach = c2, manger = m1 };
            Trainee t3 = new Trainee() { name = "gamal ", age = 31, gender = "Male", Duration = 3, Phone = "01235555", StartJoinDate = DateTime.Now, SubtractionFees = 350, clas = class1, coach = c1, manger = m1 };
            Trainee t4 = new Trainee() { name = "ali", age = 35, gender = "Male", Duration = 5, Phone = "0125005550", StartJoinDate = DateTime.Now, SubtractionFees = 550, clas = class2, coach = c2, manger = m1 };

            dbcontext.Mangers.Add(m1);

            dbcontext.Equipments.Add(eqp1);
            dbcontext.Equipments.Add(eqp2);
            dbcontext.Equipments.Add(eqp3);
            dbcontext.Equipments.Add(eqp4);


            dbcontext.Classes.Add(class1);
            dbcontext.Classes.Add(class2);
            dbcontext.Classes.Add(class3);
            dbcontext.Classes.Add(class4);

            dbcontext.Choachs.Add(c1);
            dbcontext.Choachs.Add(c2);
            dbcontext.Choachs.Add(c3);
            dbcontext.Choachs.Add(c4);


            dbcontext.Employees.Add(e1);
            dbcontext.Employees.Add(e2);
            dbcontext.Employees.Add(e3);
            dbcontext.Employees.Add(e4);

            dbcontext.Trainees.Add(t1);
            dbcontext.Trainees.Add(t2);
            dbcontext.Trainees.Add(t3);
            dbcontext.Trainees.Add(t4);




            dbcontext.SaveChanges();

            /////////////////////////////////////////////////////////////////////////


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcomeform());


            /////////////////////////////////////////////////////////////////////////



            //using (var context = new Datacontext())
            //{
            //    Classes ZombaClass = new Classes() { name = "Zomba", classID = 3 };
            //    Trainee t3= context.Trainees.FirstOrDefault(t => t.name =="noha") ;
            //    Trainee t4= context.Trainees.FirstOrDefault(t => t.name == "adel");

            //    ZombaClass.trainees.Add(t3);
            //    ZombaClass.trainees.Add(t4);


            //    context.Classes.Add(ZombaClass);
            //    context.SaveChanges();
            //}



            // Associate the objects with each other



        }
    }
}
