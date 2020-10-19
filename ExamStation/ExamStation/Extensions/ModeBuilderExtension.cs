using ExamStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamStation.Extesions
{
    public static class ModeBuilderExtension
    {
        public static void Seed(this ModelBuilder modeBuilder)
        {
            modeBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, StudentName = "Saif", Guardian = "Abu Siddik", /*DateOfBirth = Convert.ToDateTime(16-05-2002),*/ Gender ="Male", BloodGroup = "B-", Religion = "Muslim", Email = "saif100@gmail.com", Phone = 01548959585, State= "Islambagh", Country= "Bangladesh", Class = "One", Section="A", Group = "Science", OptionalSubject= "", RegisterNo = 1010, Roll = 1, ExtraActivities = "Nothing", Remarks = "Student-1" },
                new Student { StudentId = 2, StudentName = "Asif", Guardian = "Ruma", /*DateOfBirth = Convert.ToDateTime(01-03-2006),*/ Gender ="Male", BloodGroup = "A+", Religion = "Muslim", Email = "asif100@gmail.com", Phone = 0154895896, State= "Islambagh", Country= "Bangladesh", Class = "Two", Section="B", Group = "Computer Science", OptionalSubject= "", RegisterNo = 1011, Roll = 2, ExtraActivities = "Nothing", Remarks = "Student-2" },
                new Student { StudentId = 3, StudentName = "Musa", Guardian = "Kamrunnahar",/* DateOfBirth = Convert.ToDateTime(02-04-2011),*/ Gender ="Male", BloodGroup = "AB+", Religion = "Muslim", Email = "musa100@gmail.com", Phone = 0168548958, State= "Islambagh", Country= "Bangladesh", Class = "Three", Section="C", Group = "General Knowledge", OptionalSubject= "", RegisterNo = 1012, Roll = 3, ExtraActivities = "Nothing", Remarks = "Student-3" },
                new Student { StudentId = 4, StudentName = "Saad", Guardian = "Jewel", /*DateOfBirth = Convert.ToDateTime(08-09-2011),*/ Gender ="Male", BloodGroup = "A-", Religion = "Muslim", Email = "saad100@gmail.com", Phone = 0198758485, State= "Dhaka", Country= "Bangladesh", Class = "Four", Section="D", Group = "Math", OptionalSubject= "", RegisterNo = 1013, Roll = 1, ExtraActivities = "Nothing", Remarks = "Student-4" },
                new Student { StudentId = 5, StudentName = "Ayisha", Guardian = "Zaman", /*DateOfBirth = Convert.ToDateTime(01-02-2018),*/ Gender ="Female", BloodGroup = "B+", Religion = "Muslim", Email = "ayisha100@gmail.com", Phone = 0178458723, State= "Dhaka", Country= "Bangladesh", Class = "Five", Section="E", Group = "Chemistry", OptionalSubject= "", RegisterNo = 1014, Roll = 4, ExtraActivities = "Nothing", Remarks = "Student-5" }               
            );

            modeBuilder.Entity<Parent>().HasData(
                new Parent { GuardianId = 1, GuardianName = "Abu Siddik", FatherName = "Abu Siddik", MotherName = "MST Ruma", FatherProfession = "Teacher", MotherProfession = "Teacher", Email = "siddik100@gmail.com", Phone = 0115847895, Address ="Islambagh"},
                new Parent { GuardianId = 2, GuardianName = "Ruma", FatherName = "Abu Siddik", MotherName = "MST Ruma", FatherProfession = "Teacher", MotherProfession = "Teacher", Email = "siddik100@gmail.com", Phone = 0115847895, Address ="Islambagh"},
                new Parent { GuardianId = 3, GuardianName = "Kamrunnahar", FatherName = "Abu Siddik", MotherName = "MST Ruma", FatherProfession = "Teacher", MotherProfession = "Teacher", Email = "siddik100@gmail.com", Phone = 0115847895, Address ="Islambagh"},
                new Parent { GuardianId = 4, GuardianName = "Jewel", FatherName = "Jewel", MotherName = "Shimu", FatherProfession = "Software Engineer", MotherProfession = "Teacher", Email = "jewel100@gmail.com", Phone = 0115847895, Address ="Dhaka"},
                new Parent { GuardianId = 5, GuardianName = "Zaman", FatherName = "Zaman", MotherName = "MST Shimu", FatherProfession = "Software Engineer", MotherProfession = "Teacher", Email = "jewel100@gmail.com", Phone = 0115847895, Address ="Dhaka"}
                );

            modeBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherId = 1, TeacherName = "Hasan", Designation = "Software Engineer", /*DateOfBirth = Convert.ToDateTime(01-08-1997),*/ Gender = "Male", Religion = "Muslim", Email = "hasan100@gmail.com", Phone = 01234567895, Address = "Islambagh", /*JoiningDate = Convert.ToDateTime(01 - 10 - 2020)*/ },
                new Teacher { TeacherId = 2, TeacherName = "Rakib", Designation = "Software Developer",/* DateOfBirth = Convert.ToDateTime(25-05-1995),*/ Gender = "Male", Religion = "Muslim", Email = "rakib100@gmail.com", Phone = 01254621458, Address = "Dhaka", /*JoiningDate = Convert.ToDateTime(02 - 10 - 2020)*/ },
                new Teacher { TeacherId = 3, TeacherName = "Imran", Designation = "Programmer", /*DateOfBirth = Convert.ToDateTime(01- 09-1991),*/ Gender = "Male", Religion = "Muslim", Email = "imran100@gmail.com", Phone = 01201201456, Address = "Dhaka", /*JoiningDate = Convert.ToDateTime(03 - 10 - 2020)*/ },
                new Teacher { TeacherId = 4, TeacherName = "Masum", Designation = "ICT Specialist", /*DateOfBirth = Convert.ToDateTime(16-02-1996),*/ Gender = "Male", Religion = "Muslim", Email = "masum100@gmail.com", Phone = 01245154789, Address = "Dhaka", /*JoiningDate = Convert.ToDateTime(04 - 10 - 2020)*/ },
                new Teacher { TeacherId = 5, TeacherName = "Rafi", Designation = "Developer",/* DateOfBirth = Convert.ToDateTime(30-07-1995),*/ Gender = "Male", Religion = "Muslim", Email = "rafi100@gmail.com", Phone = 01452548514, Address = "Dhaka", /*JoiningDate = Convert.ToDateTime(05 - 10 - 2020)*/ }
               );

            modeBuilder.Entity<Class>().HasData(
                new Class { Id = 1, ClassName = "One", ClassNumeric = 1, TeacherName = "Hasan", Note = "Nothing", },
                new Class { Id = 2, ClassName = "Two", ClassNumeric = 2, TeacherName = "Rakib", Note = "Nothing", },
                new Class { Id = 3, ClassName = "Three", ClassNumeric = 3, TeacherName = "Imran", Note = "Nothing", },
                new Class { Id = 4, ClassName = "Four", ClassNumeric = 4, TeacherName = "Masum", Note = "Nothing", },
                new Class { Id = 5, ClassName = "Five", ClassNumeric = 5, TeacherName = "Rafi", Note = "Nothing", }
                );

            modeBuilder.Entity<Section>().HasData(
               new Section { Id = 1, SectionName = "A", Category = "A", Capacity = 40, Class = "One", TeacherName= "Hasan", Note="Nothing" },
               new Section { Id = 2, SectionName = "B", Category = "B", Capacity = 40, Class = "Two", TeacherName= "Rakib", Note="Nothing" },
               new Section { Id = 3, SectionName = "C", Category = "C", Capacity = 40, Class = "Three", TeacherName= "Imran", Note="Nothing" },
               new Section { Id = 4, SectionName = "D", Category = "D", Capacity = 40, Class = "Four", TeacherName= "Masum", Note="Nothing" },
               new Section { Id = 5, SectionName = "E", Category = "E", Capacity = 40, Class = "Five", TeacherName= "Rafi", Note="Nothing" }
               );

            modeBuilder.Entity<Subject>().HasData(
               new Subject { Id = 1, ClassName = "One", TeacherName = "Hasan", Type = "Optional", PassMark = 33, FinalMark = "40", SubjectName = "Physics", SubjectAuthor="Mark Wood", SubjectCode="1122" },
               new Subject { Id = 2, ClassName = "Two", TeacherName = "Rakib", Type = "Mandatory", PassMark = 33, FinalMark = "40", SubjectName = "Chemistry", SubjectAuthor="Jogn", SubjectCode="1123" },
               new Subject { Id = 3, ClassName = "Three", TeacherName = "Imran", Type = "Optional", PassMark = 33, FinalMark = "40", SubjectName = "Math", SubjectAuthor="Clark", SubjectCode="1124" },
               new Subject { Id = 4, ClassName = "Four", TeacherName = "Masum", Type = "Mandatory", PassMark = 33, FinalMark = "40", SubjectName = "Biology", SubjectAuthor="Barry", SubjectCode="1125" },
               new Subject { Id = 5, ClassName = "Five", TeacherName = "Rafi", Type = "Optional", PassMark = 33, FinalMark = "40", SubjectName = "English", SubjectAuthor="Allen", SubjectCode="1126" }
               );

            modeBuilder.Entity<QuestionGroup>().HasData(
                new QuestionGroup {Id = 1, Title = "Science"},
                new QuestionGroup {Id = 2, Title = "Math" },
                new QuestionGroup {Id = 3, Title = "Chemistry" },
                new QuestionGroup {Id = 4, Title = "General Knowledge" },
                new QuestionGroup {Id = 5, Title = "Computer Science" }
            );

            modeBuilder.Entity<QuestionLevel>().HasData(
                new QuestionLevel{ Id = 1, Title = "Easy" },
                new QuestionLevel{ Id = 2, Title = "Very Easy" },
                new QuestionLevel{ Id = 3, Title = "Medium" },
                new QuestionLevel{ Id = 4, Title = "Hard" }
              );

            //modeBuilder.Entity<QuestionBank>().HasData(
            //    new QuestionBank { Id = 1, QuestionGroup = QuestionGroup, DifficultyLevel = "Easy", Question ="What is Computer", Explanation= "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", Hints="Nothing", Mark=40, QuestionType="Single Answer" },
            //    new QuestionBank { Id = 2, QuestionGroupId = Science, DifficultyLevel = "Easy", Question ="What is Computer Describe it", Explanation= "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", Hints="Nothing", Mark=40, QuestionType="Single Answer" },
            //    new QuestionBank { Id = 3, QuestionGroupId = Math, DifficultyLevel = "Very Easy", Question = "What is Math", Explanation= "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", Hints="Nothing", Mark=40, QuestionType="Multi Answer" },
            //    new QuestionBank { Id = 4, QuestionGroupId = Math, DifficultyLevel = "Very Easy", Question = "What is Math Describe it", Explanation= "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", Hints="Nothing", Mark=40, QuestionType="Multi Answer" },
            //    new QuestionBank { Id = 5, QuestionGroupId = Chemistry, DifficultyLevel = "Medium", Question = "What is Chemistry", Explanation= "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", Hints="Nothing", Mark=40, QuestionType="Fill In The Blanks" },
            //    new QuestionBank { Id = 6, QuestionGroupId = Chemistry, DifficultyLevel = "Medium", Question = "What is Chemistry Describe it", Explanation= "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", Hints="Nothing", Mark=40, QuestionType="Fill In The Blanks" },
            //    new QuestionBank { Id = 7, QuestionGroupId = General Knowledge, DifficultyLevel = "Hard", Question = "What is General Knowledge", Explanation= "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", Hints="Nothing", Mark=40, QuestionType= "Single Answer" },
            //    new QuestionBank { Id = 8, QuestionGroupId = General Knowledge", DifficultyLevel = "Hard", Question = "What is General Knowledge Describe it", Explanation= "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", Hints="Nothing", Mark=40, QuestionType= "Single Answer" },
            //    new QuestionBank { Id = 9, QuestionGroupId = "Computer Science", DifficultyLevel = "Easy", Question = "What is Computer Science", Explanation= "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", Hints="Nothing", Mark=40, QuestionType= "Multi Answer" },
            //    new QuestionBank { Id = 10, QuestionGroupId = "Computer Science", DifficultyLevel = "Easy", Question = "What is Computer Science Describe it", Explanation= "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", Hints="Nothing", Mark=40, QuestionType= "Multi Answer" }
            //   );

            modeBuilder.Entity<OnlineExam>().HasData(
                new OnlineExam { Id = 1, ExamTitle = "Quiz", Description = "Description Here", Class = "One", Section = "A", StudentGroup = "Science", Subject = "Physics", Instruction = "Exam Instruction For Student 1", ExamStatus = "One Time", ExamType = "Only Duration", Duration = 10, MarkType = "40", PassValue = 33, PaymentStatus="Free", Published="Yes" },
                new OnlineExam { Id = 2, ExamTitle = "MCQ", Description = "Description Here", Class = "Two", Section = "B", StudentGroup = "Math", Subject = "Chemistry", Instruction = "Exam Instruction For Student 2", ExamStatus = "One Time", ExamType = "Date and Duration", Duration = 30, MarkType = "40", PassValue = 33, PaymentStatus="Free", Published="Yes" },
                new OnlineExam { Id = 3, ExamTitle = "Class Test", Description = "Description Here", Class = "Three", Section = "C", StudentGroup = "Chemistry", Subject = "Math", Instruction = "Exam Instruction For Student 3", ExamStatus = "One Time", ExamType = "Date, Time And Duration", Duration = 10, MarkType = "40", PassValue = 33, PaymentStatus="Free", Published="Yes" },
                new OnlineExam { Id = 4, ExamTitle = "Mid Term", Description = "Description Here", Class = "Four", Section = "D", StudentGroup = "General Knowledge", Subject = "Biology", Instruction = "Exam Instruction For Student 4", ExamStatus = "One Time", ExamType = "Only Duration", Duration = 30, MarkType = "40", PassValue = 33, PaymentStatus="Free", Published="Yes" },
                new OnlineExam { Id = 5, ExamTitle = "Final", Description = "Description Here", Class = "Five", Section = "E", StudentGroup = "Computer Science", Subject = "English", Instruction = "Exam Instruction For Student 5", ExamStatus = "One Time", ExamType = "Date and Duration", Duration = 10, MarkType = "40", PassValue = 33, PaymentStatus="Free", Published="Yes" }
                );

            modeBuilder.Entity<Instruction>().HasData(
                new Instruction { Id = 1, Title = "Exam Instruction For Student 1", Content = "Before the Exam, Bring your Student ID Booklet or University Library Card (i.e. 3212****). You will not be allowed into the exam hall", },
                new Instruction { Id = 2, Title = "Exam Instruction For Student 2", Content = "Before the Exam, Bring your Student ID Booklet or University Library Card (i.e. 3212****). You will not be allowed into the exam hall", },
                new Instruction { Id = 3, Title = "Exam Instruction For Student 3", Content = "Before the Exam, Bring your Student ID Booklet or University Library Card (i.e. 3212****). You will not be allowed into the exam hall", },
                new Instruction { Id = 4, Title = "Exam Instruction For Student 4", Content = "Before the Exam, Bring your Student ID Booklet or University Library Card (i.e. 3212****). You will not be allowed into the exam hall", },
                new Instruction { Id = 5, Title = "Exam Instruction For Student 5", Content = "Before the Exam, Bring your Student ID Booklet or University Library Card (i.e. 3212****). You will not be allowed into the exam hall", }
               );

            modeBuilder.Entity<Notice>().HasData(
                new Notice { Id = 1, Title = "Programing Contest", /*Date = Convert.ToDateTime(16 - 07 - 2020),*/ WriteNotice= "On 16-07-2020 will held a programming contest in Varsity campus" },
                new Notice { Id = 2, Title = "Holyday", /*Date = Convert.ToDateTime(23-10-2020),*/ WriteNotice= "Have a Good Day" }
                );

            modeBuilder.Entity<Event>().HasData(
                new Event { Id = 1, Title = "EidUlAzha", /*Date = Convert.ToDateTime(16-07-2020),*/ Details = "Eid ul-Azha is an important religious holiday." },
                new Event { Id = 2, Title = "EidUlFitr", /*Date = Convert.ToDateTime(06-05-2020),*/ Details = "Eid ul-Fitr is an important religious holiday." }
                );

        }
    }
}
    