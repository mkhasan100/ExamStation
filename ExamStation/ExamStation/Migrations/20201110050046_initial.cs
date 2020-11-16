using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentEmail = table.Column<string>(nullable: true),
                    ExamId = table.Column<int>(nullable: false),
                    QuestionBankId = table.Column<int>(nullable: false),
                    StudentAnswer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true),
                    ClassNumeric = table.Column<int>(nullable: true),
                    TeacherName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<byte>(nullable: false),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instruction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuMaster",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    SerialNo = table.Column<int>(nullable: false),
                    isActive = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    isAdmin = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuMaster", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Notice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    WriteNotice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnlineExam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamTitle = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true),
                    StudentGroup = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Instruction = table.Column<string>(nullable: true),
                    ExamStatus = table.Column<string>(nullable: false),
                    ExamType = table.Column<string>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    MarkType = table.Column<string>(nullable: false),
                    PassValue = table.Column<double>(nullable: false),
                    PaymentStatus = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Published = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineExam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    GuardianId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuardianName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    FatherProfession = table.Column<string>(nullable: true),
                    MotherProfession = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.GuardianId);
                });

            migrationBuilder.CreateTable(
                name: "QuestionGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionLevel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false),
                    Class = table.Column<string>(nullable: true),
                    TeacherName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(nullable: true),
                    Guardian = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    BloodGroup = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    OptionalSubject = table.Column<string>(nullable: true),
                    RegisterNo = table.Column<int>(nullable: true),
                    Roll = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    ExtraActivities = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true),
                    TeacherName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    PassMark = table.Column<int>(nullable: false),
                    FinalMark = table.Column<string>(nullable: true),
                    SubjectName = table.Column<string>(nullable: true),
                    SubjectAuthor = table.Column<string>(nullable: true),
                    SubjectCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TakeExamMapper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(nullable: false),
                    QuestionBankId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeExamMapper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    JoiningDate = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionBank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionGroupId = table.Column<int>(nullable: true),
                    DifficultyLevelId = table.Column<int>(nullable: true),
                    Question = table.Column<string>(nullable: false),
                    Explanation = table.Column<string>(nullable: true),
                    Hints = table.Column<string>(nullable: true),
                    Mark = table.Column<double>(nullable: false),
                    QuestionTypeId = table.Column<int>(nullable: false),
                    TotalOption = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionBank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionBank_QuestionGroup_QuestionGroupId",
                        column: x => x.QuestionGroupId,
                        principalTable: "QuestionGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnswersOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionBankId = table.Column<int>(nullable: true),
                    Option = table.Column<string>(nullable: true),
                    IsAnswer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswersOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswersOptions_QuestionBank_QuestionBankId",
                        column: x => x.QuestionBankId,
                        principalTable: "QuestionBank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "Id", "ClassName", "ClassNumeric", "Note", "TeacherName" },
                values: new object[,]
                {
                    { 1, "One", 1, "Nothing", "Hasan" },
                    { 2, "Two", 2, "Nothing", "Rakib" },
                    { 3, "Three", 3, "Nothing", "Imran" },
                    { 4, "Four", 4, "Nothing", "Masum" },
                    { 5, "Five", 5, "Nothing", "Rafi" }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Details", "Photo", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eid ul-Azha is an important religious holiday.", (byte)0, "EidUlAzha" },
                    { 2, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eid ul-Fitr is an important religious holiday.", (byte)0, "EidUlFitr" }
                });

            migrationBuilder.InsertData(
                table: "Instruction",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "Before the Exam, Bring your Student ID Booklet or University Library Card (i.e. 3212****). You will not be allowed into the exam hall", "Exam Instruction For Student 1" },
                    { 2, "Before the Exam, Bring your Student ID Booklet or University Library Card (i.e. 3212****). You will not be allowed into the exam hall", "Exam Instruction For Student 2" },
                    { 3, "Before the Exam, Bring your Student ID Booklet or University Library Card (i.e. 3212****). You will not be allowed into the exam hall", "Exam Instruction For Student 3" },
                    { 4, "Before the Exam, Bring your Student ID Booklet or University Library Card (i.e. 3212****). You will not be allowed into the exam hall", "Exam Instruction For Student 4" },
                    { 5, "Before the Exam, Bring your Student ID Booklet or University Library Card (i.e. 3212****). You will not be allowed into the exam hall", "Exam Instruction For Student 5" }
                });

            migrationBuilder.InsertData(
                table: "Notice",
                columns: new[] { "Id", "Date", "Title", "WriteNotice" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holyday", "Have a Good Day" },
                    { 1, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programing Contest", "On 16-07-2020 will held a programming contest in Varsity campus" }
                });

            migrationBuilder.InsertData(
                table: "OnlineExam",
                columns: new[] { "Id", "Class", "Cost", "Description", "Duration", "ExamStatus", "ExamTitle", "ExamType", "Instruction", "MarkType", "PassValue", "PaymentStatus", "Published", "Section", "StudentGroup", "Subject" },
                values: new object[,]
                {
                    { 1, "One", 0.0, "Description Here", 10, "One Time", "Quiz", "Only Duration", "Exam Instruction For Student 1", "40", 33.0, "Free", "Yes", "A", "Science", "Physics" },
                    { 2, "Two", 0.0, "Description Here", 30, "One Time", "MCQ", "Date and Duration", "Exam Instruction For Student 2", "40", 33.0, "Free", "Yes", "B", "Math", "Chemistry" },
                    { 3, "Three", 0.0, "Description Here", 10, "One Time", "Class Test", "Date, Time And Duration", "Exam Instruction For Student 3", "40", 33.0, "Free", "Yes", "C", "Chemistry", "Math" },
                    { 4, "Four", 0.0, "Description Here", 30, "One Time", "Mid Term", "Only Duration", "Exam Instruction For Student 4", "40", 33.0, "Free", "Yes", "D", "General Knowledge", "Biology" },
                    { 5, "Five", 0.0, "Description Here", 10, "One Time", "Final", "Date and Duration", "Exam Instruction For Student 5", "40", 33.0, "Free", "Yes", "E", "Computer Science", "English" }
                });

            migrationBuilder.InsertData(
                table: "Parent",
                columns: new[] { "GuardianId", "Address", "Email", "FatherName", "FatherProfession", "GuardianName", "MotherName", "MotherProfession", "Phone", "Photo" },
                values: new object[,]
                {
                    { 1, "Islambagh", "siddik100@gmail.com", "Abu Siddik", "Teacher", "Abu Siddik", "MST Ruma", "Teacher", 115847895, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg" },
                    { 2, "Islambagh", "siddik100@gmail.com", "Abu Siddik", "Teacher", "Ruma", "MST Ruma", "Teacher", 115847895, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg" },
                    { 3, "Islambagh", "siddik100@gmail.com", "Abu Siddik", "Teacher", "Kamrunnahar", "MST Ruma", "Teacher", 115847895, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg" },
                    { 4, "Dhaka", "jewel100@gmail.com", "Jewel", "Software Engineer", "Jewel", "Shimu", "Teacher", 115847895, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg" },
                    { 5, "Dhaka", "jewel100@gmail.com", "Zaman", "Software Engineer", "Zaman", "MST Shimu", "Teacher", 115847895, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg" }
                });

            migrationBuilder.InsertData(
                table: "QuestionBank",
                columns: new[] { "Id", "DifficultyLevelId", "Explanation", "Hints", "Mark", "Question", "QuestionGroupId", "QuestionTypeId", "TotalOption" },
                values: new object[,]
                {
                    { 7, 4, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is General Knowledge", null, 0, null },
                    { 10, 1, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Science Describe it", null, 0, null },
                    { 9, 1, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Science", null, 0, null },
                    { 6, 3, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Chemistry Describe it", null, 0, null },
                    { 8, 4, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is General Knowledge Describe it", null, 0, null },
                    { 4, 2, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Math Describe it", null, 0, null },
                    { 3, 2, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Math", null, 0, null },
                    { 2, 1, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Describe it", null, 0, null },
                    { 1, 1, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer", null, 0, null },
                    { 5, 3, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Chemistry", null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "QuestionGroup",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Science" },
                    { 2, "Math" },
                    { 3, "Chemistry" },
                    { 4, "General Knowledge" },
                    { 5, "Computer Science" }
                });

            migrationBuilder.InsertData(
                table: "QuestionLevel",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Easy" },
                    { 2, "Very Easy" },
                    { 3, "Medium" },
                    { 4, "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Section",
                columns: new[] { "Id", "Capacity", "Category", "Class", "Note", "SectionName", "TeacherName" },
                values: new object[,]
                {
                    { 5, 40, "E", "Five", "Nothing", "E", "Rafi" },
                    { 4, 40, "D", "Four", "Nothing", "D", "Masum" },
                    { 3, 40, "C", "Three", "Nothing", "C", "Imran" },
                    { 1, 40, "A", "One", "Nothing", "A", "Hasan" },
                    { 2, 40, "B", "Two", "Nothing", "B", "Rakib" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Address", "BloodGroup", "Class", "Country", "DateOfBirth", "Email", "ExtraActivities", "Gender", "Group", "Guardian", "OptionalSubject", "Phone", "Photo", "RegisterNo", "Religion", "Remarks", "Roll", "Section", "State", "StudentName" },
                values: new object[,]
                {
                    { 1, null, "B-", "One", "Bangladesh", new DateTime(2002, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "saif100@gmail.com", "Nothing", "Male", "Science", "Abu Siddik", "", 1548959585, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg", 1010, "Muslim", "Student-1", 1, "A", "Islambagh", "Saif" },
                    { 2, null, "A+", "Two", "Bangladesh", new DateTime(2006, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "asif100@gmail.com", "Nothing", "Male", "Computer Science", "Ruma", "", 154895896, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg", 1011, "Muslim", "Student-2", 2, "B", "Islambagh", "Asif" },
                    { 3, null, "AB+", "Three", "Bangladesh", new DateTime(2011, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "musa100@gmail.com", "Nothing", "Male", "General Knowledge", "Kamrunnahar", "", 168548958, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg", 1012, "Muslim", "Student-3", 3, "C", "Islambagh", "Musa" },
                    { 4, null, "A-", "Four", "Bangladesh", new DateTime(2011, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "saad100@gmail.com", "Nothing", "Male", "Math", "Jewel", "", 198758485, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg", 1013, "Muslim", "Student-4", 1, "D", "Dhaka", "Saad" },
                    { 5, null, "B+", "Five", "Bangladesh", new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayisha100@gmail.com", "Nothing", "Female", "Chemistry", "Zaman", "", 178458723, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg", 1014, "Muslim", "Student-5", 4, "E", "Dhaka", "Ayisha" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "ClassName", "FinalMark", "PassMark", "SubjectAuthor", "SubjectCode", "SubjectName", "TeacherName", "Type" },
                values: new object[,]
                {
                    { 5, "Five", "40", 33, "Allen", "1126", "English", "Rafi", "Optional" },
                    { 4, "Four", "40", 33, "Barry", "1125", "Biology", "Masum", "Mandatory" },
                    { 2, "Two", "40", 33, "Jogn", "1123", "Chemistry", "Rakib", "Mandatory" },
                    { 1, "One", "40", 33, "Mark Wood", "1122", "Physics", "Hasan", "Optional" },
                    { 3, "Three", "40", 33, "Clark", "1124", "Math", "Imran", "Optional" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherId", "Address", "DateOfBirth", "Designation", "Email", "Gender", "JoiningDate", "Phone", "Photo", "Religion", "TeacherName" },
                values: new object[,]
                {
                    { 4, "Dhaka", new DateTime(1996, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "ICT Specialist", "masum100@gmail.com", "Male", new DateTime(2020, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1245154789, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg", "Muslim", "Masum" },
                    { 1, "Islambagh", new DateTime(1997, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "hasan100@gmail.com", "Male", new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1234567895, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg", "Muslim", "Hasan" },
                    { 2, "Dhaka", new DateTime(1995, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Developer", "rakib100@gmail.com", "Male", new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1254621458, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg", "Muslim", "Rakib" },
                    { 3, "Dhaka", new DateTime(1991, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programmer", "imran100@gmail.com", "Male", new DateTime(2020, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1201201456, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg", "Muslim", "Imran" },
                    { 5, "Dhaka", new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "rafi100@gmail.com", "Male", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1452548514, "d5a3b4f1-faad-48a5-b438-8109d1f9be69_hasan.jpg", "Muslim", "Rafi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswersOptions_QuestionBankId",
                table: "AnswersOptions",
                column: "QuestionBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionBank_QuestionGroupId",
                table: "QuestionBank",
                column: "QuestionGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "AnswersOptions");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Instruction");

            migrationBuilder.DropTable(
                name: "MenuMaster");

            migrationBuilder.DropTable(
                name: "Notice");

            migrationBuilder.DropTable(
                name: "OnlineExam");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropTable(
                name: "QuestionLevel");

            migrationBuilder.DropTable(
                name: "QuestionType");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "TakeExamMapper");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "QuestionBank");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "QuestionGroup");
        }
    }
}
