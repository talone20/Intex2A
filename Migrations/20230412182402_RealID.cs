using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intex2A.Migrations
{
    public partial class RealID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "public.analysis",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    analysistype = table.Column<byte[]>(nullable: true),
                    doneby = table.Column<byte[]>(nullable: true),
                    analysisid = table.Column<byte[]>(nullable: true),
                    date = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.analysis_textile",
                columns: table => new
                {
                    mainanalysisid = table.Column<byte[]>(name: "main$analysisid", nullable: true),
                    maintextileid = table.Column<byte[]>(name: "main$textileid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.artifactfagelgamousregister",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    registernum = table.Column<byte[]>(nullable: true),
                    photographed = table.Column<byte[]>(nullable: true),
                    notes = table.Column<byte[]>(nullable: true),
                    coordinateset = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.artifactfagelgamousregister_burialmain",
                columns: table => new
                {
                    mainartifactfagelgamousregisterid = table.Column<byte[]>(name: "main$artifactfagelgamousregisterid", nullable: true),
                    mainburialmainid = table.Column<byte[]>(name: "main$burialmainid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.artifactkomaushimregister",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    provenance = table.Column<byte[]>(nullable: true),
                    description = table.Column<byte[]>(nullable: true),
                    position = table.Column<byte[]>(nullable: true),
                    qualityphotos = table.Column<byte[]>(nullable: true),
                    finder = table.Column<byte[]>(nullable: true),
                    dimensions = table.Column<byte[]>(nullable: true),
                    material = table.Column<byte[]>(nullable: true),
                    rehousedto = table.Column<byte[]>(nullable: true),
                    photos = table.Column<byte[]>(nullable: true),
                    number = table.Column<byte[]>(nullable: true),
                    remarks = table.Column<byte[]>(nullable: true),
                    entrydate = table.Column<byte[]>(nullable: true),
                    currentlocation = table.Column<byte[]>(nullable: true),
                    excavatornum = table.Column<byte[]>(nullable: true),
                    date = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.artifactkomaushimregister_burialmain",
                columns: table => new
                {
                    mainartifactkomaushimregisterid = table.Column<byte[]>(name: "main$artifactkomaushimregisterid", nullable: true),
                    mainburialmainid = table.Column<byte[]>(name: "main$burialmainid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.biological",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    racknumber = table.Column<byte[]>(nullable: true),
                    bagnumber = table.Column<byte[]>(nullable: true),
                    previouslysampled = table.Column<byte[]>(nullable: true),
                    initials = table.Column<byte[]>(nullable: true),
                    clusternumber = table.Column<byte[]>(nullable: true),
                    date = table.Column<byte[]>(nullable: true),
                    notes = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.biological_c14",
                columns: table => new
                {
                    mainbiologicalid = table.Column<byte[]>(name: "main$biologicalid", nullable: true),
                    mainc14id = table.Column<byte[]>(name: "main$c14id", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.bodyanalysischart",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    femur = table.Column<byte[]>(nullable: true),
                    humerusheaddiameter = table.Column<byte[]>(nullable: true),
                    squamossuture = table.Column<byte[]>(nullable: true),
                    caries_periodontal_disease = table.Column<byte[]>(nullable: true),
                    medical_ip_ramus = table.Column<byte[]>(nullable: true),
                    perservationindex = table.Column<byte[]>(nullable: true),
                    gonion = table.Column<byte[]>(nullable: true),
                    humeruslength = table.Column<byte[]>(nullable: true),
                    femurlength = table.Column<byte[]>(nullable: true),
                    lambdoidsuture = table.Column<byte[]>(nullable: true),
                    ventralarc = table.Column<byte[]>(nullable: true),
                    tootheruptionageestimation = table.Column<byte[]>(nullable: true),
                    nuchalcrest = table.Column<byte[]>(nullable: true),
                    estimatestature = table.Column<byte[]>(nullable: true),
                    notes = table.Column<byte[]>(nullable: true),
                    osteophytosis = table.Column<byte[]>(nullable: true),
                    subpubicangle = table.Column<byte[]>(nullable: true),
                    robust = table.Column<byte[]>(nullable: true),
                    femurheaddiameter = table.Column<byte[]>(nullable: true),
                    sciaticnotch = table.Column<byte[]>(nullable: true),
                    supraorbitalridges = table.Column<byte[]>(nullable: true),
                    orbitedge = table.Column<byte[]>(nullable: true),
                    toothattrition = table.Column<byte[]>(nullable: true),
                    sphenooccipitalsynchondrosis = table.Column<byte[]>(nullable: true),
                    parietalblossing = table.Column<byte[]>(nullable: true),
                    observations = table.Column<byte[]>(nullable: true),
                    humerus = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.books",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    description = table.Column<byte[]>(nullable: true),
                    title = table.Column<byte[]>(nullable: true),
                    author = table.Column<byte[]>(nullable: true),
                    link = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.burialmain",
                columns: table => new
                {
                    RealId = table.Column<double>(nullable: false),
                    id = table.Column<double>(nullable: false),
                    squarenorthsouth = table.Column<byte[]>(nullable: true),
                    headdirection = table.Column<byte[]>(nullable: true),
                    sex = table.Column<string>(nullable: true),
                    northsouth = table.Column<byte[]>(nullable: true),
                    depth = table.Column<byte[]>(nullable: true),
                    eastwest = table.Column<byte[]>(nullable: true),
                    adultsubadult = table.Column<byte[]>(nullable: true),
                    facebundles = table.Column<string>(nullable: true),
                    southtohead = table.Column<byte[]>(nullable: true),
                    preservation = table.Column<string>(nullable: true),
                    fieldbookpage = table.Column<byte[]>(nullable: true),
                    squareeastwest = table.Column<byte[]>(nullable: true),
                    goods = table.Column<byte[]>(nullable: true),
                    text = table.Column<string>(nullable: true),
                    wrapping = table.Column<string>(nullable: true),
                    haircolor = table.Column<string>(nullable: true),
                    westtohead = table.Column<byte[]>(nullable: true),
                    samplescollected = table.Column<byte[]>(nullable: true),
                    area = table.Column<byte[]>(nullable: true),
                    burialid = table.Column<byte[]>(nullable: true),
                    length = table.Column<byte[]>(nullable: true),
                    burialnumber = table.Column<byte[]>(nullable: true),
                    dataexpertinitials = table.Column<byte[]>(nullable: true),
                    westtofeet = table.Column<byte[]>(nullable: true),
                    ageatdeath = table.Column<string>(nullable: true),
                    southtofeet = table.Column<byte[]>(nullable: true),
                    excavationrecorder = table.Column<byte[]>(nullable: true),
                    photos = table.Column<byte[]>(nullable: true),
                    hair = table.Column<byte[]>(nullable: true),
                    burialmaterials = table.Column<byte[]>(nullable: true),
                    dateofexcavation = table.Column<byte[]>(nullable: true),
                    fieldbookexcavationyear = table.Column<byte[]>(nullable: true),
                    clusternumber = table.Column<byte[]>(nullable: true),
                    shaftnumber = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.burialmain_biological",
                columns: table => new
                {
                    mainburialmainid = table.Column<byte[]>(name: "main$burialmainid", nullable: true),
                    mainbiologicalid = table.Column<byte[]>(name: "main$biologicalid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.burialmain_bodyanalysischart",
                columns: table => new
                {
                    mainburialmainid = table.Column<byte[]>(name: "main$burialmainid", nullable: true),
                    mainbodyanalysischartid = table.Column<byte[]>(name: "main$bodyanalysischartid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.burialmain_cranium",
                columns: table => new
                {
                    mainburialmainid = table.Column<byte[]>(name: "main$burialmainid", nullable: true),
                    maincraniumid = table.Column<byte[]>(name: "main$craniumid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.burialmain_textile",
                columns: table => new
                {
                    mainburialmainid = table.Column<byte[]>(name: "main$burialmainid", nullable: true),
                    maintextileid = table.Column<byte[]>(name: "main$textileid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.c14",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    description = table.Column<byte[]>(nullable: true),
                    category = table.Column<byte[]>(nullable: true),
                    size = table.Column<byte[]>(nullable: true),
                    agebp = table.Column<byte[]>(nullable: true),
                    calibratedspan = table.Column<byte[]>(nullable: true),
                    tubenumber = table.Column<byte[]>(nullable: true),
                    calibrateddatemin = table.Column<byte[]>(nullable: true),
                    calibrateddateavg = table.Column<byte[]>(nullable: true),
                    foci = table.Column<byte[]>(nullable: true),
                    rack = table.Column<byte[]>(nullable: true),
                    calendardate = table.Column<byte[]>(nullable: true),
                    calibrateddatemax = table.Column<byte[]>(nullable: true),
                    c14lab = table.Column<byte[]>(nullable: true),
                    questions = table.Column<byte[]>(nullable: true),
                    location = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.color",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    value = table.Column<byte[]>(nullable: true),
                    colorid = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.color_textile",
                columns: table => new
                {
                    maincolorid = table.Column<byte[]>(name: "main$colorid", nullable: true),
                    maintextileid = table.Column<byte[]>(name: "main$textileid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.cranium",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    interobital_breadth = table.Column<byte[]>(nullable: true),
                    max_nasal_breadth = table.Column<byte[]>(nullable: true),
                    basion_nasion = table.Column<byte[]>(nullable: true),
                    interorbital_breadth = table.Column<byte[]>(nullable: true),
                    nasion_prosthion_upper = table.Column<byte[]>(nullable: true),
                    naso_alpha__subtense = table.Column<byte[]>(nullable: true),
                    basion_bregma_height = table.Column<byte[]>(nullable: true),
                    maxcraniumlength = table.Column<byte[]>(nullable: true),
                    interorbital_subtense = table.Column<byte[]>(nullable: true),
                    basion_prosthion_length = table.Column<byte[]>(nullable: true),
                    alpha_core = table.Column<byte[]>(nullable: true),
                    mid_orbital_subtense = table.Column<byte[]>(nullable: true),
                    maxcraniumbreadth = table.Column<byte[]>(nullable: true),
                    bizygomatic_diameter = table.Column<byte[]>(nullable: true),
                    mid_orbital_breadth = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.decoration",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    decorationid = table.Column<byte[]>(nullable: true),
                    value = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.decoration_textile",
                columns: table => new
                {
                    maindecorationid = table.Column<byte[]>(name: "main$decorationid", nullable: true),
                    maintextileid = table.Column<byte[]>(name: "main$textileid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.dimension",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    dimensiontype = table.Column<byte[]>(nullable: true),
                    value = table.Column<byte[]>(nullable: true),
                    dimensionid = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.dimension_textile",
                columns: table => new
                {
                    maindimensionid = table.Column<byte[]>(name: "main$dimensionid", nullable: true),
                    maintextileid = table.Column<byte[]>(name: "main$textileid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.newsarticle",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    description = table.Column<byte[]>(nullable: true),
                    author = table.Column<byte[]>(nullable: true),
                    title = table.Column<byte[]>(nullable: true),
                    urltoimage = table.Column<byte[]>(nullable: true),
                    url = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.photodata",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    description = table.Column<byte[]>(nullable: true),
                    filename = table.Column<byte[]>(nullable: true),
                    photodataid = table.Column<byte[]>(nullable: true),
                    date = table.Column<byte[]>(nullable: true),
                    url = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.photodata_textile",
                columns: table => new
                {
                    mainphotodataid = table.Column<byte[]>(name: "main$photodataid", nullable: true),
                    maintextileid = table.Column<byte[]>(name: "main$textileid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.photoform",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    area = table.Column<byte[]>(nullable: true),
                    squarenorthsouth = table.Column<byte[]>(nullable: true),
                    tableassociation = table.Column<byte[]>(nullable: true),
                    filename = table.Column<byte[]>(nullable: true),
                    photographer = table.Column<byte[]>(nullable: true),
                    burialnumber = table.Column<byte[]>(nullable: true),
                    squareeastwest = table.Column<byte[]>(nullable: true),
                    eastwest = table.Column<byte[]>(nullable: true),
                    northsouth = table.Column<byte[]>(nullable: true),
                    photodate = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.structure",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    value = table.Column<byte[]>(nullable: true),
                    structureid = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.structure_textile",
                columns: table => new
                {
                    mainstructureid = table.Column<byte[]>(name: "main$structureid", nullable: true),
                    maintextileid = table.Column<byte[]>(name: "main$textileid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.teammember",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    bio = table.Column<byte[]>(nullable: true),
                    membername = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.textile",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    locale = table.Column<byte[]>(nullable: true),
                    textileid = table.Column<byte[]>(nullable: true),
                    description = table.Column<byte[]>(nullable: true),
                    burialnumber = table.Column<byte[]>(nullable: true),
                    estimatedperiod = table.Column<byte[]>(nullable: true),
                    sampledate = table.Column<byte[]>(nullable: true),
                    photographeddate = table.Column<byte[]>(nullable: true),
                    direction = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.textilefunction",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    value = table.Column<byte[]>(nullable: true),
                    textilefunctionid = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.textilefunction_textile",
                columns: table => new
                {
                    maintextilefunctionid = table.Column<byte[]>(name: "main$textilefunctionid", nullable: true),
                    maintextileid = table.Column<byte[]>(name: "main$textileid", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.yarnmanipulation",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: true),
                    thickness = table.Column<byte[]>(nullable: true),
                    angle = table.Column<byte[]>(nullable: true),
                    manipulation = table.Column<byte[]>(nullable: true),
                    material = table.Column<byte[]>(nullable: true),
                    count = table.Column<byte[]>(nullable: true),
                    component = table.Column<byte[]>(nullable: true),
                    ply = table.Column<byte[]>(nullable: true),
                    yarnmanipulationid = table.Column<byte[]>(nullable: true),
                    direction = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "public.yarnmanipulation_textile",
                columns: table => new
                {
                    mainyarnmanipulationid = table.Column<byte[]>(name: "main$yarnmanipulationid", nullable: true),
                    maintextileid = table.Column<byte[]>(name: "main$textileid", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "public.analysis");

            migrationBuilder.DropTable(
                name: "public.analysis_textile");

            migrationBuilder.DropTable(
                name: "public.artifactfagelgamousregister");

            migrationBuilder.DropTable(
                name: "public.artifactfagelgamousregister_burialmain");

            migrationBuilder.DropTable(
                name: "public.artifactkomaushimregister");

            migrationBuilder.DropTable(
                name: "public.artifactkomaushimregister_burialmain");

            migrationBuilder.DropTable(
                name: "public.biological");

            migrationBuilder.DropTable(
                name: "public.biological_c14");

            migrationBuilder.DropTable(
                name: "public.bodyanalysischart");

            migrationBuilder.DropTable(
                name: "public.books");

            migrationBuilder.DropTable(
                name: "public.burialmain");

            migrationBuilder.DropTable(
                name: "public.burialmain_biological");

            migrationBuilder.DropTable(
                name: "public.burialmain_bodyanalysischart");

            migrationBuilder.DropTable(
                name: "public.burialmain_cranium");

            migrationBuilder.DropTable(
                name: "public.burialmain_textile");

            migrationBuilder.DropTable(
                name: "public.c14");

            migrationBuilder.DropTable(
                name: "public.color");

            migrationBuilder.DropTable(
                name: "public.color_textile");

            migrationBuilder.DropTable(
                name: "public.cranium");

            migrationBuilder.DropTable(
                name: "public.decoration");

            migrationBuilder.DropTable(
                name: "public.decoration_textile");

            migrationBuilder.DropTable(
                name: "public.dimension");

            migrationBuilder.DropTable(
                name: "public.dimension_textile");

            migrationBuilder.DropTable(
                name: "public.newsarticle");

            migrationBuilder.DropTable(
                name: "public.photodata");

            migrationBuilder.DropTable(
                name: "public.photodata_textile");

            migrationBuilder.DropTable(
                name: "public.photoform");

            migrationBuilder.DropTable(
                name: "public.structure");

            migrationBuilder.DropTable(
                name: "public.structure_textile");

            migrationBuilder.DropTable(
                name: "public.teammember");

            migrationBuilder.DropTable(
                name: "public.textile");

            migrationBuilder.DropTable(
                name: "public.textilefunction");

            migrationBuilder.DropTable(
                name: "public.textilefunction_textile");

            migrationBuilder.DropTable(
                name: "public.yarnmanipulation");

            migrationBuilder.DropTable(
                name: "public.yarnmanipulation_textile");
        }
    }
}
