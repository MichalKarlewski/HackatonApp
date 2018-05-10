using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HackatonData.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Debitor",
                columns: table => new
                {
                    Debitor_Nr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Debitor_Adresse1 = table.Column<string>(nullable: true),
                    Debitor_Adresse2 = table.Column<string>(nullable: true),
                    Debitor_EPost = table.Column<string>(nullable: true),
                    Debitor_Fodselsdato = table.Column<string>(nullable: true),
                    Debitor_Ident = table.Column<string>(nullable: true),
                    Debitor_Kategori = table.Column<string>(nullable: true),
                    Debitor_Kontakt = table.Column<string>(nullable: true),
                    Debitor_KontoNr = table.Column<string>(nullable: true),
                    Debitor_LandKode = table.Column<string>(nullable: true),
                    Debitor_Navn1 = table.Column<string>(nullable: true),
                    Debitor_Navn2 = table.Column<string>(nullable: true),
                    Debitor_Postnr = table.Column<string>(nullable: true),
                    Debitor_Sprak = table.Column<string>(nullable: true),
                    Debitor_Sted = table.Column<string>(nullable: true),
                    Unik = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debitor", x => x.Debitor_Nr);
                });

            migrationBuilder.CreateTable(
                name: "Kreditor",
                columns: table => new
                {
                    Kreditor_Nr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BaseCurrency = table.Column<string>(nullable: true),
                    DefaultProduct = table.Column<int>(nullable: false),
                    Kreditor_Adress1 = table.Column<string>(nullable: true),
                    Kreditor_Adress2 = table.Column<string>(nullable: true),
                    Kreditor_AvrIntervall = table.Column<int>(nullable: false),
                    Kreditor_Avsluttet = table.Column<string>(nullable: true),
                    Kreditor_CRMRef1 = table.Column<string>(nullable: true),
                    Kreditor_CRMRef2 = table.Column<string>(nullable: true),
                    Kreditor_EPost = table.Column<string>(nullable: true),
                    Kreditor_Identitet = table.Column<string>(nullable: true),
                    Kreditor_Kategori = table.Column<string>(nullable: true),
                    Kreditor_Kontakt = table.Column<string>(nullable: true),
                    Kreditor_KundeNr = table.Column<int>(nullable: false),
                    Kreditor_LandKode = table.Column<string>(nullable: true),
                    Kreditor_Mobil = table.Column<string>(nullable: true),
                    Kreditor_Namn1 = table.Column<string>(nullable: true),
                    Kreditor_Namn2 = table.Column<string>(nullable: true),
                    Kreditor_NesteAvrDato = table.Column<string>(nullable: true),
                    Kreditor_Postnr = table.Column<string>(nullable: true),
                    Kreditor_SisteFakturaNr = table.Column<int>(nullable: false),
                    Kreditor_Sprak = table.Column<string>(nullable: true),
                    Kreditor_Sted = table.Column<string>(nullable: true),
                    Unik = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kreditor", x => x.Kreditor_Nr);
                });

            migrationBuilder.CreateTable(
                name: "Sreg",
                columns: table => new
                {
                    Sak_Nr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sak_AvsluttDato = table.Column<string>(nullable: true),
                    Sak_BrukerID = table.Column<string>(nullable: true),
                    Sak_BrukesIkke10 = table.Column<double>(nullable: false),
                    Sak_Dato = table.Column<string>(nullable: true),
                    Sak_DebNr = table.Column<int>(nullable: true),
                    Sak_KredNr = table.Column<int>(nullable: true),
                    Sak_Ref2 = table.Column<string>(nullable: true),
                    Sak_Referanse = table.Column<string>(nullable: true),
                    Sak_Rentegrunnlag = table.Column<double>(nullable: false),
                    Sak_SaldoHovedstol = table.Column<double>(nullable: false),
                    Sak_Status = table.Column<string>(nullable: true),
                    Sak_StatusTekst = table.Column<string>(nullable: true),
                    Sak_Sum = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sreg", x => x.Sak_Nr);
                    table.ForeignKey(
                        name: "FK_Sreg_Debitor_Sak_DebNr",
                        column: x => x.Sak_DebNr,
                        principalTable: "Debitor",
                        principalColumn: "Debitor_Nr",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sreg_Kreditor_Sak_KredNr",
                        column: x => x.Sak_KredNr,
                        principalTable: "Kreditor",
                        principalColumn: "Kreditor_Nr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Status_SakNr = table.Column<int>(nullable: false),
                    Status_LinjeNr = table.Column<int>(nullable: false),
                    Changed = table.Column<DateTime>(nullable: false),
                    Status_Dato = table.Column<string>(nullable: true),
                    Status_Kode = table.Column<string>(nullable: true),
                    Status_RegDato = table.Column<string>(nullable: true),
                    Status_Saldo = table.Column<double>(nullable: false),
                    Status_Tekst = table.Column<string>(nullable: true),
                    Unik = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => new { x.Status_SakNr, x.Status_LinjeNr });
                    table.ForeignKey(
                        name: "FK_Status_Sreg_Status_SakNr",
                        column: x => x.Status_SakNr,
                        principalTable: "Sreg",
                        principalColumn: "Sak_Nr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sreg_Sak_DebNr",
                table: "Sreg",
                column: "Sak_DebNr");

            migrationBuilder.CreateIndex(
                name: "IX_Sreg_Sak_KredNr",
                table: "Sreg",
                column: "Sak_KredNr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Sreg");

            migrationBuilder.DropTable(
                name: "Debitor");

            migrationBuilder.DropTable(
                name: "Kreditor");
        }
    }
}
