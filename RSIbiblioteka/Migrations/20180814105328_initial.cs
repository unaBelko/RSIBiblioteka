using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RSIbiblioteka.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Knjige",
                columns: table => new
                {
                    KnjigaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knjige", x => x.KnjigaId);
                });

            migrationBuilder.CreateTable(
                name: "Spolovi",
                columns: table => new
                {
                    SpolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spolovi", x => x.SpolId);
                });

            migrationBuilder.CreateTable(
                name: "Autori",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autori", x => x.AutorId);
                    table.ForeignKey(
                        name: "FK_Autori_Spolovi_SpolId",
                        column: x => x.SpolId,
                        principalTable: "Spolovi",
                        principalColumn: "SpolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bibliotekari",
                columns: table => new
                {
                    BibliotekarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PocetakRada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotekari", x => x.BibliotekarId);
                    table.ForeignKey(
                        name: "FK_Bibliotekari_Spolovi_SpolId",
                        column: x => x.SpolId,
                        principalTable: "Spolovi",
                        principalColumn: "SpolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clanovi",
                columns: table => new
                {
                    ClanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClanskiBroj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clanovi", x => x.ClanId);
                    table.ForeignKey(
                        name: "FK_Clanovi_Spolovi_SpolId",
                        column: x => x.SpolId,
                        principalTable: "Spolovi",
                        principalColumn: "SpolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutoriKnjige",
                columns: table => new
                {
                    AutorKnjigaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    KnjigaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoriKnjige", x => x.AutorKnjigaId);
                    table.ForeignKey(
                        name: "FK_AutoriKnjige_Autori_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autori",
                        principalColumn: "AutorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoriKnjige_Knjige_KnjigaId",
                        column: x => x.KnjigaId,
                        principalTable: "Knjige",
                        principalColumn: "KnjigaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IzdavanjeKnjiga",
                columns: table => new
                {
                    IzdavanjeKnjigeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BibliotekarId = table.Column<int>(type: "int", nullable: false),
                    BrojDana = table.Column<int>(type: "int", nullable: false),
                    ClanId = table.Column<int>(type: "int", nullable: false),
                    DatumIzdavanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KnjigaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzdavanjeKnjiga", x => x.IzdavanjeKnjigeId);
                    table.ForeignKey(
                        name: "FK_IzdavanjeKnjiga_Bibliotekari_BibliotekarId",
                        column: x => x.BibliotekarId,
                        principalTable: "Bibliotekari",
                        principalColumn: "BibliotekarId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_IzdavanjeKnjiga_Clanovi_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clanovi",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_IzdavanjeKnjiga_Knjige_KnjigaId",
                        column: x => x.KnjigaId,
                        principalTable: "Knjige",
                        principalColumn: "KnjigaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autori_SpolId",
                table: "Autori",
                column: "SpolId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoriKnjige_AutorId",
                table: "AutoriKnjige",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoriKnjige_KnjigaId",
                table: "AutoriKnjige",
                column: "KnjigaId");

            migrationBuilder.CreateIndex(
                name: "IX_Bibliotekari_SpolId",
                table: "Bibliotekari",
                column: "SpolId");

            migrationBuilder.CreateIndex(
                name: "IX_Clanovi_SpolId",
                table: "Clanovi",
                column: "SpolId");

            migrationBuilder.CreateIndex(
                name: "IX_IzdavanjeKnjiga_BibliotekarId",
                table: "IzdavanjeKnjiga",
                column: "BibliotekarId");

            migrationBuilder.CreateIndex(
                name: "IX_IzdavanjeKnjiga_ClanId",
                table: "IzdavanjeKnjiga",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_IzdavanjeKnjiga_KnjigaId",
                table: "IzdavanjeKnjiga",
                column: "KnjigaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoriKnjige");

            migrationBuilder.DropTable(
                name: "IzdavanjeKnjiga");

            migrationBuilder.DropTable(
                name: "Autori");

            migrationBuilder.DropTable(
                name: "Bibliotekari");

            migrationBuilder.DropTable(
                name: "Clanovi");

            migrationBuilder.DropTable(
                name: "Knjige");

            migrationBuilder.DropTable(
                name: "Spolovi");
        }
    }
}
