﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessAddress = table.Column<string>(nullable: true),
                    BusinessAddressPostalCode = table.Column<string>(nullable: true),
                    BusinessAddressCity = table.Column<string>(nullable: true),
                    BusinessAddressCountry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AppSettings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxExpiryDays = table.Column<int>(nullable: false),
                    MaxExtensionDays = table.Column<int>(nullable: false),
                    MaxInAdvanceDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSettings", x => x.ID);
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
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PEWelders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    NationalNumber = table.Column<string>(nullable: true),
                    IdNumber = table.Column<string>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEWelders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationTypeName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UIColors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtendableStatus = table.Column<int>(nullable: false),
                    HasPassed = table.Column<bool>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UIColors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UsersToApprove",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true),
                    BusinessPhone = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    BusinessAddress = table.Column<string>(nullable: true),
                    BusinessAddressPostalCode = table.Column<string>(nullable: true),
                    BusinessAddressCity = table.Column<string>(nullable: true),
                    BusinessAddressCountry = table.Column<string>(nullable: true),
                    CompanyMainPhone = table.Column<string>(nullable: true),
                    CompanyEmail = table.Column<string>(nullable: true),
                    WebPage = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    EmailLanguage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersToApprove", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressID = table.Column<int>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyMainPhone = table.Column<string>(nullable: true),
                    CompanyEmail = table.Column<string>(nullable: true),
                    WebPage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Companies_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AllowedRegistrationTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationTypeID = table.Column<int>(nullable: true),
                    AvailableRegistrationTypeID = table.Column<int>(nullable: false),
                    ExtendableStatus = table.Column<int>(nullable: false),
                    HasPassed = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedRegistrationTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AllowedRegistrationTypes_RegistrationTypes_AvailableRegistrationTypeID",
                        column: x => x.AvailableRegistrationTypeID,
                        principalTable: "RegistrationTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AllowedRegistrationTypes_RegistrationTypes_RegistrationTypeID",
                        column: x => x.RegistrationTypeID,
                        principalTable: "RegistrationTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyContacts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true),
                    AddressID = table.Column<int>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    BusinessPhone = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContacts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CompanyContacts_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyContacts_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyContacts_Contacts_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyContacts_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamCenters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamCenters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExamCenters_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCenters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(nullable: false),
                    Letter = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCenters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TrainingCenters_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListExamCenter",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamCenterID = table.Column<int>(nullable: false),
                    CompanyContactID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListExamCenter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ListExamCenter_CompanyContacts_CompanyContactID",
                        column: x => x.CompanyContactID,
                        principalTable: "CompanyContacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListExamCenter_ExamCenters_ExamCenterID",
                        column: x => x.ExamCenterID,
                        principalTable: "ExamCenters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingCenterID = table.Column<int>(nullable: false),
                    ExamCenterID = table.Column<int>(nullable: false),
                    ExamDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Examinations_ExamCenters_ExamCenterID",
                        column: x => x.ExamCenterID,
                        principalTable: "ExamCenters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examinations_TrainingCenters_TrainingCenterID",
                        column: x => x.TrainingCenterID,
                        principalTable: "TrainingCenters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListTrainingCenter",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingCenterID = table.Column<int>(nullable: false),
                    CompanyContactID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListTrainingCenter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ListTrainingCenter_CompanyContacts_CompanyContactID",
                        column: x => x.CompanyContactID,
                        principalTable: "CompanyContacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListTrainingCenter_TrainingCenters_TrainingCenterID",
                        column: x => x.TrainingCenterID,
                        principalTable: "TrainingCenters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PEPassports",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingCenterID = table.Column<int>(nullable: false),
                    PEWelderID = table.Column<int>(nullable: false),
                    AVNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEPassports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PEPassports_PEWelders_PEWelderID",
                        column: x => x.PEWelderID,
                        principalTable: "PEWelders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PEPassports_TrainingCenters_TrainingCenterID",
                        column: x => x.TrainingCenterID,
                        principalTable: "TrainingCenters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreviousRegistrationID = table.Column<int>(nullable: true),
                    ExaminationID = table.Column<int>(nullable: false),
                    PEPassportID = table.Column<int>(nullable: false),
                    RegistrationTypeID = table.Column<int>(nullable: false),
                    ProcessID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: true),
                    HasPassed = table.Column<bool>(nullable: true),
                    CertificatePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Registrations_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registrations_Examinations_ExaminationID",
                        column: x => x.ExaminationID,
                        principalTable: "Examinations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registrations_PEPassports_PEPassportID",
                        column: x => x.PEPassportID,
                        principalTable: "PEPassports",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registrations_Registrations_PreviousRegistrationID",
                        column: x => x.PreviousRegistrationID,
                        principalTable: "Registrations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registrations_Processes_ProcessID",
                        column: x => x.ProcessID,
                        principalTable: "Processes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registrations_RegistrationTypes_RegistrationTypeID",
                        column: x => x.RegistrationTypeID,
                        principalTable: "RegistrationTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Revokes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationID = table.Column<int>(nullable: false),
                    CompanyContactID = table.Column<int>(nullable: false),
                    RevokeDate = table.Column<DateTime>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revokes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Revokes_CompanyContacts_CompanyContactID",
                        column: x => x.CompanyContactID,
                        principalTable: "CompanyContacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Revokes_Registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "Registrations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "ID", "BusinessAddress", "BusinessAddressCity", "BusinessAddressCountry", "BusinessAddressPostalCode" },
                values: new object[,]
                {
                    { 1, "Antoon Van Osslaan 1, Bus 4", "Brussel", "Belgium", "1120" },
                    { 11, "Rue du Lascentrum", "Brussel", "Belgium", "1000" },
                    { 10, "Rue de Nestor", "Brussel", "Belgium", "1000" },
                    { 9, "Rue de Vinçotte", "Brussel", "Belgium", "1000" },
                    { 8, "Rue d'Ores", "Brussel", "Belgium", "1000" },
                    { 7, "Rademakerstraat 8/4", "Lissewege", "Belgium", "8380" },
                    { 12, "Rue de Company", "Brussel", "Belgium", "1000" },
                    { 5, "Quai du Pont Canal 5", "Strépy-Bracquegnies", "Belgium", "7110" },
                    { 4, "Quai des usines 16", "Brussel", "Belgium", "1000" },
                    { 3, "Liège Science Park, Rue du Bois St-Jean, 15-17", "Seraing", "Belgium", "4102" },
                    { 2, "KielStraat 1", "Zeebrugge", "Belgium", "8380" },
                    { 6, "Rue de Limbourg, 41B", "Verviers", "Belgium", "4800" }
                });

            migrationBuilder.InsertData(
                table: "AppSettings",
                columns: new[] { "ID", "MaxExpiryDays", "MaxExtensionDays", "MaxInAdvanceDays" },
                values: new object[] { 1, 365, 270, 30 });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ID", "Birthday", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leen", "Dezillie" },
                    { 2, new DateTime(1977, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fabrice", "Vermeiren" },
                    { 3, new DateTime(1984, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koen", "Nies" },
                    { 4, new DateTime(1982, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bastien", "De Spiegelaere" }
                });

            migrationBuilder.InsertData(
                table: "PEWelders",
                columns: new[] { "ID", "FirstName", "IdNumber", "LastName", "NationalNumber", "PhotoPath" },
                values: new object[,]
                {
                    { 10, "Mitt", "015-5256893-85", "Romney", "63.98.45-682-63", null },
                    { 14, "Tulsi", "052-5873789-57", "Gabard", "28.23.48-689-63", null },
                    { 13, "Joe", "572-1447629-95", "Biden", "88.98.45-893-63", null },
                    { 12, "Andrew", "082-3861789-08", "Yang", "99.23.64-937-52", null },
                    { 11, "Barack", "512-8454289-95", "Obama", "01.85.45-454-65", null },
                    { 9, "Kamala", "872-5256587-69", "Harris", "55.63.45-856-63", null },
                    { 8, "Bernie", "682-6826789-54", "Sanders", "92.23.58-638-83", null },
                    { 6, "Ted", "862-6386789-65", "Cruz", "86.86.56-463-99", null },
                    { 5, "Sarah", "834-3467289-85", "Palin", "86.58.45-669-45", null },
                    { 4, "Mike", "634-6916789-85", "Pence", "08.23.45-127-89", null },
                    { 3, "Donald", "012-3456789-99", "Trump", "01.23.45-678-99", null },
                    { 2, "Hillary", "983-3456569-80", "Clinton", "12.23.71-678-05", null },
                    { 1, "Nancy", "452-3456789-84", "Pelosi", "05.23.45-768-99", null },
                    { 7, "Elizabeth", "853-5456783-85", "Warren", "37.23.86-578-98", null }
                });

            migrationBuilder.InsertData(
                table: "Processes",
                columns: new[] { "ID", "IsActive", "ProcessName" },
                values: new object[,]
                {
                    { 1, true, "Electro" },
                    { 2, true, "Butt" }
                });

            migrationBuilder.InsertData(
                table: "RegistrationTypes",
                columns: new[] { "ID", "IsActive", "RegistrationTypeName" },
                values: new object[,]
                {
                    { 4, true, "Re-Examination2" },
                    { 3, true, "Re-Examination1" },
                    { 2, true, "Extension" },
                    { 1, true, "Training" }
                });

            migrationBuilder.InsertData(
                table: "UIColors",
                columns: new[] { "ID", "Color", "ExtendableStatus", "HasPassed" },
                values: new object[,]
                {
                    { 1, null, 0, false },
                    { 2, "table-success", 0, true },
                    { 3, null, 1, false },
                    { 4, "table-warning", 1, true },
                    { 5, null, 2, false },
                    { 6, null, 2, true },
                    { 7, "table-danger", 3, false },
                    { 8, "table-danger", 3, true }
                });

            migrationBuilder.InsertData(
                table: "UsersToApprove",
                columns: new[] { "ID", "Birthday", "BusinessAddress", "BusinessAddressCity", "BusinessAddressCountry", "BusinessAddressPostalCode", "BusinessPhone", "CompanyEmail", "CompanyMainPhone", "CompanyName", "Email", "EmailConfirmed", "EmailLanguage", "FirstName", "JobTitle", "LastName", "MobilePhone", "WebPage" },
                values: new object[,]
                {
                    { 2, new DateTime(1985, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rue d'Alice 16", "Brussel", "Belgium", "1000", "+32 2 634 72 81", "info@sibelga.be", "+32 2 856 45 82", "Sibelga Academy", "alice.smith@hotmail.com", true, "en", "Alice", "CEO", "Smith", "+32 482 93 71 09", "academy.sibelga.be" },
                    { 3, new DateTime(1975, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rue de James 60", "Brussel", "Belgium", "1000", "+32 2 456 92 71", "info@technifutur.be", "+32 4 382 45 72", "Technifutur", "james.bond@outlook.com", true, "en", "James", "CEO", "Bond", "+32 457 76 24 82", "technifutur.be" },
                    { 1, new DateTime(1990, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rue de John 10", "Brussel", "Belgium", "1000", "+32 2 165 45 85", "info@v-c-l.be", "+32 2 520 56 58", "VCL", "john.doe@hotmail.com", true, "en", "John", "CEO", "Doe", "+32 495 25 12 37", "v-c-l.be" },
                    { 4, new DateTime(1996, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leopold III-lei 16", "Edegem", "Belgium", "2650", "+32 2 485 73 04", "info@info.be", "+32 3 230 05 28", "Technifutur", "antoine.m1996@hotmail.com", true, "nl", "Antoine", "CEO", "Moenaert", "+32 487 10 73 64", "info.be" }
                });

            migrationBuilder.InsertData(
                table: "AllowedRegistrationTypes",
                columns: new[] { "ID", "AvailableRegistrationTypeID", "ExtendableStatus", "HasPassed", "RegistrationTypeID" },
                values: new object[,]
                {
                    { 25, 1, 2, false, 1 },
                    { 34, 1, 3, true, 1 },
                    { 3, 1, 0, false, 2 },
                    { 8, 1, 1, false, 2 },
                    { 14, 2, 1, true, 1 },
                    { 16, 1, 1, true, 2 },
                    { 26, 1, 2, false, 2 },
                    { 30, 1, 2, true, 2 },
                    { 35, 1, 3, true, 2 },
                    { 4, 1, 0, false, 3 },
                    { 9, 3, 1, false, 2 },
                    { 10, 1, 1, false, 3 },
                    { 15, 3, 1, true, 1 },
                    { 33, 1, 3, null, null },
                    { 17, 3, 1, true, 2 },
                    { 19, 2, 1, true, 3 },
                    { 20, 3, 1, true, 3 },
                    { 27, 1, 2, false, 3 },
                    { 31, 1, 2, true, 3 },
                    { 36, 1, 3, true, 3 },
                    { 5, 1, 0, false, 4 },
                    { 11, 4, 1, false, 3 },
                    { 12, 1, 1, false, 4 },
                    { 21, 1, 1, true, 4 },
                    { 22, 2, 1, true, 4 },
                    { 23, 3, 1, true, 4 },
                    { 28, 1, 2, false, 4 },
                    { 18, 1, 1, true, 3 },
                    { 29, 1, 2, true, 1 },
                    { 37, 1, 3, true, 4 },
                    { 24, 1, 2, null, null },
                    { 13, 1, 1, true, 1 },
                    { 7, 1, 1, false, 1 },
                    { 6, 1, 1, null, null },
                    { 2, 1, 0, false, 1 },
                    { 1, 1, 0, null, null },
                    { 32, 1, 2, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "ID", "AddressID", "CompanyEmail", "CompanyMainPhone", "CompanyName", "WebPage" },
                values: new object[,]
                {
                    { 9, 9, "info@vinçotte.be", "+32 2 364 87 54", "Vinçotte", "vinçotte.be" },
                    { 8, 8, "info@ores.be", "+32 2 683 57 32", "Ores", "ores.be" },
                    { 7, 7, "info@kcbrugge.be", "+32 5 069 63 74", "Kwalificatiecentrum Brugge bvba", "kcbrugge.be" },
                    { 4, 4, "info@sibelga.be", "+32 2 856 45 82", "Sibelga Academy", "academy.sibelga.be" },
                    { 5, 5, "info@technocampus.be", "+32 2 754 83 19", "Technocampus", "technocampus.be" },
                    { 10, 10, "info@denestor.be", "+32 9 375 31 69", "De Nestor", "denestor.be" },
                    { 3, 3, "info@technifutur.be", "+32 4 382 45 72", "Technifutur", "technifutur.be" },
                    { 2, 2, "info@tcz.be", "+32 2 564 52 87", "TCZ", "tcz.be" },
                    { 6, 6, "info@formation-polygone-eau.be", "+32 8 778 93 30", "Polygone de l'eau", "formation-polygone-eau.be" },
                    { 11, 11, "info@lascentrum.be", "+32 2 954 74 85", "Lascentrum", "lascentrum.be" },
                    { 15, 12, "info@verhoeven.be", "+32 2 837 49 27", "Verhoeven", "verhoeven.be" },
                    { 13, 12, "info@fabricom.be", "+32 2 793 98 07", "Fabricom", "fabricom.be" },
                    { 14, 12, "info@ltc.be", "+32 2 951 72 19", "LTC", "ltc.be" },
                    { 16, 12, "info@alkabel.be", "+32 2 864 92 47", "Alkabel", "alkabel.be" },
                    { 17, 12, "info@vindevogel.be", "+32 2 482 24 35", "Vindevogel", "vindevogel.be" },
                    { 18, 12, "info@canalco.be", "+32 2 507 74 19", "Canalco", "canalco.be" },
                    { 19, 12, "info@verschueren.be", "+32 2 864 75 05", "Verschueren", "verschueren.be" },
                    { 20, 12, "info@apc.be", "+32 2 791 43 01", "APC", "apc.be" },
                    { 21, 12, "info@fluvius.be", "+32 2 907 43 67", "Fluvius", "fluvius.be" },
                    { 22, 12, "info@infra.be", "+32 2 703 09 84", "Infra", "infra.be" },
                    { 23, 12, "info@dalcom.be", "+32 2 378 50 04", "Dalcom", "dalcom.be" },
                    { 12, 12, "info@hydrogaz.be", "+32 2 456 81 37", "Hydrogaz", "hydrogaz.be" },
                    { 1, 1, "info@v-c-l.be", "+32 2 520 56 58", "VCL", "v-c-l.be" }
                });

            migrationBuilder.InsertData(
                table: "CompanyContacts",
                columns: new[] { "ID", "AddressID", "BusinessPhone", "CompanyID", "ContactID", "Email", "IdentityUserId", "JobTitle", "MobilePhone" },
                values: new object[,]
                {
                    { 1, 1, "+32 2 520 56 58", 1, 1, "leen.dezillie@v-c-l.be ", null, "Manager", "+32 486 64 45 52" },
                    { 3, 2, "+32 5 050 08 29", 2, 3, "koen@atriumopleidingen.be", null, "Manager", "+32 496 56 87 24" },
                    { 4, null, "+32 2 274 39 09", 4, 4, "academy-pe@sibelga.be", null, "CEO", "+32 486 82 46 82" },
                    { 2, 5, "+32 2 845 89 47", 5, 2, "fabrice.vermeiren@technocampus.be", null, "Manager", "+32 486 64 45 52" }
                });

            migrationBuilder.InsertData(
                table: "ExamCenters",
                columns: new[] { "ID", "CompanyID", "IsActive" },
                values: new object[] { 1, 9, true });

            migrationBuilder.InsertData(
                table: "TrainingCenters",
                columns: new[] { "ID", "CompanyID", "IsActive", "Letter" },
                values: new object[,]
                {
                    { 1, 1, true, "V" },
                    { 2, 2, true, "Z" },
                    { 3, 3, true, "T" },
                    { 4, 5, true, "S" },
                    { 7, 6, true, "P" },
                    { 5, 7, true, "K" },
                    { 6, 10, true, "N" },
                    { 8, 11, true, "L" }
                });

            migrationBuilder.InsertData(
                table: "Examinations",
                columns: new[] { "ID", "ExamCenterID", "ExamDate", "TrainingCenterID" },
                values: new object[,]
                {
                    { 7, 1, new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 8, 1, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, 1, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 4, 1, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 1, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, 1, new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 1, 1, new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, 1, new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 }
                });

            migrationBuilder.InsertData(
                table: "ListExamCenter",
                columns: new[] { "ID", "CompanyContactID", "ExamCenterID" },
                values: new object[] { 1, 4, 1 });

            migrationBuilder.InsertData(
                table: "ListTrainingCenter",
                columns: new[] { "ID", "CompanyContactID", "TrainingCenterID" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "PEPassports",
                columns: new[] { "ID", "AVNumber", "PEWelderID", "TrainingCenterID" },
                values: new object[,]
                {
                    { 2, 470, 2, 4 },
                    { 13, 481, 13, 3 },
                    { 10, 478, 10, 4 },
                    { 7, 475, 7, 5 },
                    { 12, 480, 12, 5 },
                    { 11, 479, 11, 3 },
                    { 8, 476, 8, 3 },
                    { 5, 473, 5, 3 },
                    { 3, 471, 3, 3 },
                    { 9, 477, 9, 1 },
                    { 6, 474, 6, 1 },
                    { 1, 469, 1, 1 },
                    { 14, 482, 14, 3 },
                    { 4, 472, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "ID", "CertificatePath", "CompanyID", "ExaminationID", "ExpiryDate", "HasPassed", "PEPassportID", "PreviousRegistrationID", "ProcessID", "RegistrationTypeID" },
                values: new object[,]
                {
                    { 1, null, 12, 1, new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, 1 },
                    { 2, null, 19, 1, new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, null, 2, 1 },
                    { 3, null, 13, 2, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, 1 },
                    { 5, null, 21, 2, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, null, 2, 1 },
                    { 7, null, 23, 3, new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "ID", "CertificatePath", "CompanyID", "ExaminationID", "ExpiryDate", "HasPassed", "PEPassportID", "PreviousRegistrationID", "ProcessID", "RegistrationTypeID" },
                values: new object[] { 4, null, 13, 3, new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 3, 1, 3 });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "ID", "CertificatePath", "CompanyID", "ExaminationID", "ExpiryDate", "HasPassed", "PEPassportID", "PreviousRegistrationID", "ProcessID", "RegistrationTypeID" },
                values: new object[] { 6, null, 21, 3, new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, 5, 2, 3 });

            migrationBuilder.InsertData(
                table: "Revokes",
                columns: new[] { "ID", "Comment", "CompanyContactID", "RegistrationID", "RevokeDate" },
                values: new object[] { 1, "Inappropriate welding technique.", 4, 5, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_AllowedRegistrationTypes_AvailableRegistrationTypeID",
                table: "AllowedRegistrationTypes",
                column: "AvailableRegistrationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AllowedRegistrationTypes_RegistrationTypeID",
                table: "AllowedRegistrationTypes",
                column: "RegistrationTypeID");

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
                name: "IX_Companies_AddressID",
                table: "Companies",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContacts_AddressID",
                table: "CompanyContacts",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContacts_CompanyID",
                table: "CompanyContacts",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContacts_ContactID",
                table: "CompanyContacts",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContacts_IdentityUserId",
                table: "CompanyContacts",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamCenters_CompanyID",
                table: "ExamCenters",
                column: "CompanyID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_ExamCenterID",
                table: "Examinations",
                column: "ExamCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_TrainingCenterID",
                table: "Examinations",
                column: "TrainingCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_ListExamCenter_CompanyContactID",
                table: "ListExamCenter",
                column: "CompanyContactID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListExamCenter_ExamCenterID",
                table: "ListExamCenter",
                column: "ExamCenterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListTrainingCenter_CompanyContactID",
                table: "ListTrainingCenter",
                column: "CompanyContactID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListTrainingCenter_TrainingCenterID",
                table: "ListTrainingCenter",
                column: "TrainingCenterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PEPassports_PEWelderID",
                table: "PEPassports",
                column: "PEWelderID");

            migrationBuilder.CreateIndex(
                name: "IX_PEPassports_TrainingCenterID",
                table: "PEPassports",
                column: "TrainingCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_CompanyID",
                table: "Registrations",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ExaminationID",
                table: "Registrations",
                column: "ExaminationID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_PEPassportID",
                table: "Registrations",
                column: "PEPassportID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_PreviousRegistrationID",
                table: "Registrations",
                column: "PreviousRegistrationID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ProcessID",
                table: "Registrations",
                column: "ProcessID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_RegistrationTypeID",
                table: "Registrations",
                column: "RegistrationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Revokes_CompanyContactID",
                table: "Revokes",
                column: "CompanyContactID");

            migrationBuilder.CreateIndex(
                name: "IX_Revokes_RegistrationID",
                table: "Revokes",
                column: "RegistrationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCenters_CompanyID",
                table: "TrainingCenters",
                column: "CompanyID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCenters_Letter",
                table: "TrainingCenters",
                column: "Letter",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllowedRegistrationTypes");

            migrationBuilder.DropTable(
                name: "AppSettings");

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
                name: "ListExamCenter");

            migrationBuilder.DropTable(
                name: "ListTrainingCenter");

            migrationBuilder.DropTable(
                name: "Revokes");

            migrationBuilder.DropTable(
                name: "UIColors");

            migrationBuilder.DropTable(
                name: "UsersToApprove");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CompanyContacts");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Examinations");

            migrationBuilder.DropTable(
                name: "PEPassports");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "RegistrationTypes");

            migrationBuilder.DropTable(
                name: "ExamCenters");

            migrationBuilder.DropTable(
                name: "PEWelders");

            migrationBuilder.DropTable(
                name: "TrainingCenters");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
