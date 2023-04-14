using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intex2A.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "burialmain",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<double>(nullable: false),
                    squarenorthsouth = table.Column<string>(nullable: true),
                    headdirection = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true),
                    northsouth = table.Column<string>(nullable: true),
                    depth = table.Column<string>(nullable: true),
                    eastwest = table.Column<string>(nullable: true),
                    adultsubadult = table.Column<string>(nullable: true),
                    facebundles = table.Column<string>(nullable: true),
                    southtohead = table.Column<string>(nullable: true),
                    preservation = table.Column<string>(nullable: true),
                    fieldbookpage = table.Column<string>(nullable: true),
                    squareeastwest = table.Column<string>(nullable: true),
                    goods = table.Column<string>(nullable: true),
                    text = table.Column<string>(nullable: true),
                    wrapping = table.Column<string>(nullable: true),
                    haircolor = table.Column<string>(nullable: true),
                    westtohead = table.Column<string>(nullable: true),
                    samplescollected = table.Column<string>(nullable: true),
                    area = table.Column<string>(nullable: true),
                    burialid = table.Column<long>(nullable: true),
                    length = table.Column<string>(nullable: true),
                    burialnumber = table.Column<string>(nullable: true),
                    dataexpertinitials = table.Column<string>(nullable: true),
                    westtofeet = table.Column<string>(nullable: true),
                    ageatdeath = table.Column<string>(nullable: true),
                    southtofeet = table.Column<string>(nullable: true),
                    excavationrecorder = table.Column<string>(nullable: true),
                    photos = table.Column<string>(nullable: true),
                    hair = table.Column<string>(nullable: true),
                    burialmaterials = table.Column<string>(nullable: true),
                    dateofexcavation = table.Column<TimeSpan>(nullable: true),
                    fieldbookexcavationyear = table.Column<string>(nullable: true),
                    clusternumber = table.Column<string>(nullable: true),
                    shaftnumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_burialmain", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "burialmain",
                schema: "public");
        }
    }
}
