using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex2A.Models
{
    public partial class dataContext : DbContext
    {
        public dataContext()
        {
        }

        public dataContext(DbContextOptions<dataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PublicAnalysis> PublicAnalysis { get; set; }
        public virtual DbSet<PublicAnalysisTextile> PublicAnalysisTextile { get; set; }
        public virtual DbSet<PublicArtifactfagelgamousregister> PublicArtifactfagelgamousregister { get; set; }
        public virtual DbSet<PublicArtifactfagelgamousregisterBurialmain> PublicArtifactfagelgamousregisterBurialmain { get; set; }
        public virtual DbSet<PublicArtifactkomaushimregister> PublicArtifactkomaushimregister { get; set; }
        public virtual DbSet<PublicArtifactkomaushimregisterBurialmain> PublicArtifactkomaushimregisterBurialmain { get; set; }
        public virtual DbSet<PublicBiological> PublicBiological { get; set; }
        public virtual DbSet<PublicBiologicalC14> PublicBiologicalC14 { get; set; }
        public virtual DbSet<PublicBodyanalysischart> PublicBodyanalysischart { get; set; }
        public virtual DbSet<PublicBooks> PublicBooks { get; set; }
        public virtual DbSet<PublicBurialmain> PublicBurialmain { get; set; }
        public virtual DbSet<PublicBurialmainBiological> PublicBurialmainBiological { get; set; }
        public virtual DbSet<PublicBurialmainBodyanalysischart> PublicBurialmainBodyanalysischart { get; set; }
        public virtual DbSet<PublicBurialmainCranium> PublicBurialmainCranium { get; set; }
        public virtual DbSet<PublicBurialmainTextile> PublicBurialmainTextile { get; set; }
        public virtual DbSet<PublicC14> PublicC14 { get; set; }
        public virtual DbSet<PublicColor> PublicColor { get; set; }
        public virtual DbSet<PublicColorTextile> PublicColorTextile { get; set; }
        public virtual DbSet<PublicCranium> PublicCranium { get; set; }
        public virtual DbSet<PublicDecoration> PublicDecoration { get; set; }
        public virtual DbSet<PublicDecorationTextile> PublicDecorationTextile { get; set; }
        public virtual DbSet<PublicDimension> PublicDimension { get; set; }
        public virtual DbSet<PublicDimensionTextile> PublicDimensionTextile { get; set; }
        public virtual DbSet<PublicNewsarticle> PublicNewsarticle { get; set; }
        public virtual DbSet<PublicPhotodata> PublicPhotodata { get; set; }
        public virtual DbSet<PublicPhotodataTextile> PublicPhotodataTextile { get; set; }
        public virtual DbSet<PublicPhotoform> PublicPhotoform { get; set; }
        public virtual DbSet<PublicStructure> PublicStructure { get; set; }
        public virtual DbSet<PublicStructureTextile> PublicStructureTextile { get; set; }
        public virtual DbSet<PublicTeammember> PublicTeammember { get; set; }
        public virtual DbSet<PublicTextile> PublicTextile { get; set; }
        public virtual DbSet<PublicTextilefunction> PublicTextilefunction { get; set; }
        public virtual DbSet<PublicTextilefunctionTextile> PublicTextilefunctionTextile { get; set; }
        public virtual DbSet<PublicYarnmanipulation> PublicYarnmanipulation { get; set; }
        public virtual DbSet<PublicYarnmanipulationTextile> PublicYarnmanipulationTextile { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Data Source = data.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PublicAnalysis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.analysis");

                entity.Property(e => e.Analysisid).HasColumnName("analysisid");

                entity.Property(e => e.Analysistype).HasColumnName("analysistype");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Doneby).HasColumnName("doneby");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<PublicAnalysisTextile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.analysis_textile");

                entity.Property(e => e.MainAnalysisid).HasColumnName("main$analysisid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<PublicArtifactfagelgamousregister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.artifactfagelgamousregister");

                entity.Property(e => e.Coordinateset).HasColumnName("coordinateset");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Photographed).HasColumnName("photographed");

                entity.Property(e => e.Registernum).HasColumnName("registernum");
            });

            modelBuilder.Entity<PublicArtifactfagelgamousregisterBurialmain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.artifactfagelgamousregister_burialmain");

                entity.Property(e => e.MainArtifactfagelgamousregisterid).HasColumnName("main$artifactfagelgamousregisterid");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");
            });

            modelBuilder.Entity<PublicArtifactkomaushimregister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.artifactkomaushimregister");

                entity.Property(e => e.Currentlocation).HasColumnName("currentlocation");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Dimensions).HasColumnName("dimensions");

                entity.Property(e => e.Entrydate).HasColumnName("entrydate");

                entity.Property(e => e.Excavatornum).HasColumnName("excavatornum");

                entity.Property(e => e.Finder).HasColumnName("finder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Material).HasColumnName("material");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Photos).HasColumnName("photos");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Provenance).HasColumnName("provenance");

                entity.Property(e => e.Qualityphotos).HasColumnName("qualityphotos");

                entity.Property(e => e.Rehousedto).HasColumnName("rehousedto");

                entity.Property(e => e.Remarks).HasColumnName("remarks");
            });

            modelBuilder.Entity<PublicArtifactkomaushimregisterBurialmain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.artifactkomaushimregister_burialmain");

                entity.Property(e => e.MainArtifactkomaushimregisterid).HasColumnName("main$artifactkomaushimregisterid");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");
            });

            modelBuilder.Entity<PublicBiological>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.biological");

                entity.Property(e => e.Bagnumber).HasColumnName("bagnumber");

                entity.Property(e => e.Clusternumber).HasColumnName("clusternumber");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Initials).HasColumnName("initials");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Previouslysampled).HasColumnName("previouslysampled");

                entity.Property(e => e.Racknumber).HasColumnName("racknumber");
            });

            modelBuilder.Entity<PublicBiologicalC14>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.biological_c14");

                entity.Property(e => e.MainBiologicalid).HasColumnName("main$biologicalid");

                entity.Property(e => e.MainC14id).HasColumnName("main$c14id");
            });

            modelBuilder.Entity<PublicBodyanalysischart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.bodyanalysischart");

                entity.Property(e => e.CariesPeriodontalDisease).HasColumnName("caries_periodontal_disease");

                entity.Property(e => e.Estimatestature).HasColumnName("estimatestature");

                entity.Property(e => e.Femur).HasColumnName("femur");

                entity.Property(e => e.Femurheaddiameter).HasColumnName("femurheaddiameter");

                entity.Property(e => e.Femurlength).HasColumnName("femurlength");

                entity.Property(e => e.Gonion).HasColumnName("gonion");

                entity.Property(e => e.Humerus).HasColumnName("humerus");

                entity.Property(e => e.Humerusheaddiameter).HasColumnName("humerusheaddiameter");

                entity.Property(e => e.Humeruslength).HasColumnName("humeruslength");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lambdoidsuture).HasColumnName("lambdoidsuture");

                entity.Property(e => e.MedicalIpRamus).HasColumnName("medical_ip_ramus");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Nuchalcrest).HasColumnName("nuchalcrest");

                entity.Property(e => e.Observations).HasColumnName("observations");

                entity.Property(e => e.Orbitedge).HasColumnName("orbitedge");

                entity.Property(e => e.Osteophytosis).HasColumnName("osteophytosis");

                entity.Property(e => e.Parietalblossing).HasColumnName("parietalblossing");

                entity.Property(e => e.Perservationindex).HasColumnName("perservationindex");

                entity.Property(e => e.Robust).HasColumnName("robust");

                entity.Property(e => e.Sciaticnotch).HasColumnName("sciaticnotch");

                entity.Property(e => e.Sphenooccipitalsynchondrosis).HasColumnName("sphenooccipitalsynchondrosis");

                entity.Property(e => e.Squamossuture).HasColumnName("squamossuture");

                entity.Property(e => e.Subpubicangle).HasColumnName("subpubicangle");

                entity.Property(e => e.Supraorbitalridges).HasColumnName("supraorbitalridges");

                entity.Property(e => e.Toothattrition).HasColumnName("toothattrition");

                entity.Property(e => e.Tootheruptionageestimation).HasColumnName("tootheruptionageestimation");

                entity.Property(e => e.Ventralarc).HasColumnName("ventralarc");
            });

            modelBuilder.Entity<PublicBooks>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.books");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Link).HasColumnName("link");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<PublicBurialmain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.burialmain");

                entity.Property(e => e.Adultsubadult).HasColumnName("adultsubadult");

                entity.Property(e => e.Ageatdeath).HasColumnName("ageatdeath");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Burialid).HasColumnName("burialid");

                entity.Property(e => e.Burialmaterials).HasColumnName("burialmaterials");

                entity.Property(e => e.Burialnumber).HasColumnName("burialnumber");

                entity.Property(e => e.Clusternumber).HasColumnName("clusternumber");

                entity.Property(e => e.Dataexpertinitials).HasColumnName("dataexpertinitials");

                entity.Property(e => e.Dateofexcavation).HasColumnName("dateofexcavation");

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.Eastwest).HasColumnName("eastwest");

                entity.Property(e => e.Excavationrecorder).HasColumnName("excavationrecorder");

                entity.Property(e => e.Facebundles).HasColumnName("facebundles");

                entity.Property(e => e.Fieldbookexcavationyear).HasColumnName("fieldbookexcavationyear");

                entity.Property(e => e.Fieldbookpage).HasColumnName("fieldbookpage");

                entity.Property(e => e.Goods).HasColumnName("goods");

                entity.Property(e => e.Hair).HasColumnName("hair");

                entity.Property(e => e.Haircolor).HasColumnName("haircolor");

                entity.Property(e => e.Headdirection).HasColumnName("headdirection");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Northsouth).HasColumnName("northsouth");

                entity.Property(e => e.Photos).HasColumnName("photos");

                entity.Property(e => e.Preservation).HasColumnName("preservation");

                entity.Property(e => e.Samplescollected).HasColumnName("samplescollected");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Shaftnumber).HasColumnName("shaftnumber");

                entity.Property(e => e.Southtofeet).HasColumnName("southtofeet");

                entity.Property(e => e.Southtohead).HasColumnName("southtohead");

                entity.Property(e => e.Squareeastwest).HasColumnName("squareeastwest");

                entity.Property(e => e.Squarenorthsouth).HasColumnName("squarenorthsouth");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Westtofeet).HasColumnName("westtofeet");

                entity.Property(e => e.Westtohead).HasColumnName("westtohead");

                entity.Property(e => e.Wrapping).HasColumnName("wrapping");
            });

            modelBuilder.Entity<PublicBurialmainBiological>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.burialmain_biological");

                entity.Property(e => e.MainBiologicalid).HasColumnName("main$biologicalid");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");
            });

            modelBuilder.Entity<PublicBurialmainBodyanalysischart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.burialmain_bodyanalysischart");

                entity.Property(e => e.MainBodyanalysischartid).HasColumnName("main$bodyanalysischartid");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");
            });

            modelBuilder.Entity<PublicBurialmainCranium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.burialmain_cranium");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");

                entity.Property(e => e.MainCraniumid).HasColumnName("main$craniumid");
            });

            modelBuilder.Entity<PublicBurialmainTextile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.burialmain_textile");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<PublicC14>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.c14");

                entity.Property(e => e.Agebp).HasColumnName("agebp");

                entity.Property(e => e.C14lab).HasColumnName("c14lab");

                entity.Property(e => e.Calendardate).HasColumnName("calendardate");

                entity.Property(e => e.Calibrateddateavg).HasColumnName("calibrateddateavg");

                entity.Property(e => e.Calibrateddatemax).HasColumnName("calibrateddatemax");

                entity.Property(e => e.Calibrateddatemin).HasColumnName("calibrateddatemin");

                entity.Property(e => e.Calibratedspan).HasColumnName("calibratedspan");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Foci).HasColumnName("foci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.Questions).HasColumnName("questions");

                entity.Property(e => e.Rack).HasColumnName("rack");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Tubenumber).HasColumnName("tubenumber");
            });

            modelBuilder.Entity<PublicColor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.color");

                entity.Property(e => e.Colorid).HasColumnName("colorid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<PublicColorTextile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.color_textile");

                entity.Property(e => e.MainColorid).HasColumnName("main$colorid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<PublicCranium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.cranium");

                entity.Property(e => e.AlphaCore).HasColumnName("alpha_core");

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("basion_bregma_height");

                entity.Property(e => e.BasionNasion).HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BizygomaticDiameter).HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InterobitalBreadth).HasColumnName("interobital_breadth");

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("interorbital_breadth");

                entity.Property(e => e.InterorbitalSubtense).HasColumnName("interorbital_subtense");

                entity.Property(e => e.MaxNasalBreadth).HasColumnName("max_nasal_breadth");

                entity.Property(e => e.Maxcraniumbreadth).HasColumnName("maxcraniumbreadth");

                entity.Property(e => e.Maxcraniumlength).HasColumnName("maxcraniumlength");

                entity.Property(e => e.MidOrbitalBreadth).HasColumnName("mid_orbital_breadth");

                entity.Property(e => e.MidOrbitalSubtense).HasColumnName("mid_orbital_subtense");

                entity.Property(e => e.NasionProsthionUpper).HasColumnName("nasion_prosthion_upper");

                entity.Property(e => e.NasoAlphaSubtense).HasColumnName("naso_alpha__subtense");
            });

            modelBuilder.Entity<PublicDecoration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.decoration");

                entity.Property(e => e.Decorationid).HasColumnName("decorationid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<PublicDecorationTextile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.decoration_textile");

                entity.Property(e => e.MainDecorationid).HasColumnName("main$decorationid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<PublicDimension>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.dimension");

                entity.Property(e => e.Dimensionid).HasColumnName("dimensionid");

                entity.Property(e => e.Dimensiontype).HasColumnName("dimensiontype");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<PublicDimensionTextile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.dimension_textile");

                entity.Property(e => e.MainDimensionid).HasColumnName("main$dimensionid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<PublicNewsarticle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.newsarticle");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.Urltoimage).HasColumnName("urltoimage");
            });

            modelBuilder.Entity<PublicPhotodata>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.photodata");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Filename).HasColumnName("filename");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Photodataid).HasColumnName("photodataid");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<PublicPhotodataTextile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.photodata_textile");

                entity.Property(e => e.MainPhotodataid).HasColumnName("main$photodataid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<PublicPhotoform>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.photoform");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Burialnumber).HasColumnName("burialnumber");

                entity.Property(e => e.Eastwest).HasColumnName("eastwest");

                entity.Property(e => e.Filename).HasColumnName("filename");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Northsouth).HasColumnName("northsouth");

                entity.Property(e => e.Photodate).HasColumnName("photodate");

                entity.Property(e => e.Photographer).HasColumnName("photographer");

                entity.Property(e => e.Squareeastwest).HasColumnName("squareeastwest");

                entity.Property(e => e.Squarenorthsouth).HasColumnName("squarenorthsouth");

                entity.Property(e => e.Tableassociation).HasColumnName("tableassociation");
            });

            modelBuilder.Entity<PublicStructure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.structure");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Structureid).HasColumnName("structureid");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<PublicStructureTextile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.structure_textile");

                entity.Property(e => e.MainStructureid).HasColumnName("main$structureid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<PublicTeammember>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.teammember");

                entity.Property(e => e.Bio).HasColumnName("bio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Membername).HasColumnName("membername");
            });

            modelBuilder.Entity<PublicTextile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.textile");

                entity.Property(e => e.Burialnumber).HasColumnName("burialnumber");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Estimatedperiod).HasColumnName("estimatedperiod");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Locale).HasColumnName("locale");

                entity.Property(e => e.Photographeddate).HasColumnName("photographeddate");

                entity.Property(e => e.Sampledate).HasColumnName("sampledate");

                entity.Property(e => e.Textileid).HasColumnName("textileid");
            });

            modelBuilder.Entity<PublicTextilefunction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.textilefunction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Textilefunctionid).HasColumnName("textilefunctionid");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<PublicTextilefunctionTextile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.textilefunction_textile");

                entity.Property(e => e.MainTextilefunctionid).HasColumnName("main$textilefunctionid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<PublicYarnmanipulation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.yarnmanipulation");

                entity.Property(e => e.Angle).HasColumnName("angle");

                entity.Property(e => e.Component).HasColumnName("component");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Manipulation).HasColumnName("manipulation");

                entity.Property(e => e.Material).HasColumnName("material");

                entity.Property(e => e.Ply).HasColumnName("ply");

                entity.Property(e => e.Thickness).HasColumnName("thickness");

                entity.Property(e => e.Yarnmanipulationid).HasColumnName("yarnmanipulationid");
            });

            modelBuilder.Entity<PublicYarnmanipulationTextile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("public.yarnmanipulation_textile");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");

                entity.Property(e => e.MainYarnmanipulationid).HasColumnName("main$yarnmanipulationid");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
