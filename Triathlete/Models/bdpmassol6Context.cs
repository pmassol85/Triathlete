using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Triathlete.Models
{
    public partial class bdpmassol6Context : DbContext
    {
        public bdpmassol6Context()
        {
        }

        public bdpmassol6Context(DbContextOptions<bdpmassol6Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Controler> Controlers { get; set; }
        public virtual DbSet<Inscription> Inscriptions { get; set; }
        public virtual DbSet<Licence> Licences { get; set; }
        public virtual DbSet<LicenceClub> LicenceClubs { get; set; }
        public virtual DbSet<ProduitDopant> ProduitDopants { get; set; }
        public virtual DbSet<Triathlon> Triathlons { get; set; }
        public virtual DbSet<TypeTriathlon> TypeTriathlons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=192.168.4.1;port=3306;user=sqlpmassol;password=savary;database=bdpmassol6;sslmode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PRIMARY");

                entity.ToTable("categorie");

                entity.Property(e => e.CatId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cat_id");

                entity.Property(e => e.CatAgeDébut)
                    .HasColumnType("int(11)")
                    .HasColumnName("cat_age_début")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CatAgeFin)
                    .HasColumnType("int(11)")
                    .HasColumnName("cat_age_fin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CatLibelle)
                    .HasMaxLength(128)
                    .HasColumnName("cat_libelle")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Club>(entity =>
            {
                entity.ToTable("club");

                entity.Property(e => e.ClubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("club_id");

                entity.Property(e => e.ClubCp)
                    .HasMaxLength(5)
                    .HasColumnName("club_cp")
                    .HasDefaultValueSql("'NULL'")
                    .IsFixedLength(true);

                entity.Property(e => e.ClubNom)
                    .HasMaxLength(128)
                    .HasColumnName("club_nom")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClubRue)
                    .HasMaxLength(128)
                    .HasColumnName("club_rue")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClubTel)
                    .HasMaxLength(32)
                    .HasColumnName("club_tel")
                    .HasDefaultValueSql("'NULL'")
                    .IsFixedLength(true);

                entity.Property(e => e.ClubVille)
                    .HasMaxLength(128)
                    .HasColumnName("club_ville")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Controler>(entity =>
            {
                entity.HasKey(e => new { e.TriId, e.InscDossard, e.DopId })
                    .HasName("PRIMARY");

                entity.ToTable("controler");

                entity.HasIndex(e => e.DopId, "fk_controler_produit_dopant");

                entity.Property(e => e.TriId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tri_id");

                entity.Property(e => e.InscDossard)
                    .HasColumnType("int(11)")
                    .HasColumnName("insc_dossard");

                entity.Property(e => e.DopId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dop_id");

                entity.Property(e => e.ControleRésultat)
                    .HasColumnType("decimal(10,2)")
                    .HasColumnName("controle_résultat")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.Dop)
                    .WithMany(p => p.Controlers)
                    .HasForeignKey(d => d.DopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_controler_produit_dopant");

                entity.HasOne(d => d.Inscription)
                    .WithMany(p => p.Controlers)
                    .HasForeignKey(d => new { d.TriId, d.InscDossard })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_controler_inscription");
            });

            modelBuilder.Entity<Inscription>(entity =>
            {
                entity.HasKey(e => new { e.TriId, e.InscDossard })
                    .HasName("PRIMARY");

                entity.ToTable("inscription");

                entity.HasIndex(e => e.LicId, "fk_inscription_licence");

                entity.Property(e => e.TriId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tri_id");

                entity.Property(e => e.InscDossard)
                    .HasColumnType("int(11)")
                    .HasColumnName("insc_dossard");

                entity.Property(e => e.InscClassement)
                    .HasColumnType("int(11)")
                    .HasColumnName("insc_classement")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InscDateInscription)
                    .HasColumnType("date")
                    .HasColumnName("insc_date_inscription")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InscForfait)
                    .HasColumnName("insc_forfait")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InscTempsCourse)
                    .HasColumnType("decimal(10,2)")
                    .HasColumnName("insc_temps_course")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InscTempsNatation)
                    .HasColumnType("decimal(10,2)")
                    .HasColumnName("insc_temps_natation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InscTempsVelo)
                    .HasColumnType("decimal(10,2)")
                    .HasColumnName("insc_temps_velo")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("lic_id");

                entity.HasOne(d => d.Lic)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.LicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inscription_licence");

                entity.HasOne(d => d.Tri)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.TriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inscription_triathlon");
            });

            modelBuilder.Entity<Licence>(entity =>
            {
                entity.HasKey(e => e.LicId)
                    .HasName("PRIMARY");

                entity.ToTable("licence");

                entity.HasIndex(e => e.CatId, "fk_licence_categorie");

                entity.Property(e => e.LicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("lic_id");

                entity.Property(e => e.CatId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cat_id");

                entity.Property(e => e.LicCodePostal)
                    .HasMaxLength(32)
                    .HasColumnName("lic_code_postal")
                    .HasDefaultValueSql("'NULL'")
                    .IsFixedLength(true);

                entity.Property(e => e.LicDateNaissance)
                    .HasColumnType("date")
                    .HasColumnName("lic_date_naissance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicEmail)
                    .HasMaxLength(128)
                    .HasColumnName("lic_email")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicNom)
                    .HasMaxLength(128)
                    .HasColumnName("lic_nom")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicPhoto)
                    .HasColumnType("longblob")
                    .HasColumnName("lic_photo")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicPrenom)
                    .HasMaxLength(128)
                    .HasColumnName("lic_prenom")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicRue)
                    .HasMaxLength(128)
                    .HasColumnName("lic_rue")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicSexe)
                    .HasMaxLength(128)
                    .HasColumnName("lic_sexe")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicVille)
                    .HasMaxLength(128)
                    .HasColumnName("lic_ville")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Licences)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_licence_categorie");
            });

            modelBuilder.Entity<LicenceClub>(entity =>
            {
                entity.HasKey(e => e.LicId)
                    .HasName("PRIMARY");

                entity.ToTable("licence_club");

                entity.HasIndex(e => e.ClubIdEntrainer, "fk_licence_club_club");

                entity.HasIndex(e => e.ClubIdAdherer, "fk_licence_club_club1");

                entity.Property(e => e.LicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("lic_id");

                entity.Property(e => e.ClubIdAdherer)
                    .HasColumnType("int(11)")
                    .HasColumnName("club_id_adherer");

                entity.Property(e => e.ClubIdEntrainer)
                    .HasColumnType("int(11)")
                    .HasColumnName("club_id_entrainer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicDatePremiereLice)
                    .HasColumnType("date")
                    .HasColumnName("lic_date_premiere_lice")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.ClubIdAdhererNavigation)
                    .WithMany(p => p.LicenceClubClubIdAdhererNavigations)
                    .HasForeignKey(d => d.ClubIdAdherer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_licence_club_club1");

                entity.HasOne(d => d.ClubIdEntrainerNavigation)
                    .WithMany(p => p.LicenceClubClubIdEntrainerNavigations)
                    .HasForeignKey(d => d.ClubIdEntrainer)
                    .HasConstraintName("fk_licence_club_club");

                entity.HasOne(d => d.Lic)
                    .WithOne(p => p.LicenceClub)
                    .HasForeignKey<LicenceClub>(d => d.LicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_licence_club_licence");
            });

            modelBuilder.Entity<ProduitDopant>(entity =>
            {
                entity.HasKey(e => e.DopId)
                    .HasName("PRIMARY");

                entity.ToTable("produit_dopant");

                entity.Property(e => e.DopId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dop_id");

                entity.Property(e => e.DopLibelle)
                    .HasMaxLength(128)
                    .HasColumnName("dop_libelle")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DopTauxMax)
                    .HasColumnType("decimal(10,2)")
                    .HasColumnName("dop_taux_max")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Triathlon>(entity =>
            {
                entity.HasKey(e => e.TriId)
                    .HasName("PRIMARY");

                entity.ToTable("triathlon");

                entity.HasIndex(e => e.TypeId, "fk_triathlon_type_triathlon");

                entity.Property(e => e.TriId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tri_id");

                entity.Property(e => e.TriCp)
                    .HasMaxLength(32)
                    .HasColumnName("tri_cp")
                    .HasDefaultValueSql("'NULL'")
                    .IsFixedLength(true);

                entity.Property(e => e.TriDate)
                    .HasColumnType("date")
                    .HasColumnName("tri_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TriLieu)
                    .HasMaxLength(128)
                    .HasColumnName("tri_lieu")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TriNom)
                    .HasMaxLength(128)
                    .HasColumnName("tri_nom")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TriVille)
                    .HasMaxLength(128)
                    .HasColumnName("tri_ville")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Triathlons)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_triathlon_type_triathlon");
            });

            modelBuilder.Entity<TypeTriathlon>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_triathlon");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id");

                entity.Property(e => e.TypeDistanceCourse)
                    .HasColumnType("decimal(10,2)")
                    .HasColumnName("type_distance_course")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeDistanceNatation)
                    .HasColumnType("decimal(10,2)")
                    .HasColumnName("type_distance_natation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeDistanceVelo)
                    .HasColumnType("decimal(10,2)")
                    .HasColumnName("type_distance_velo")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeLibelle)
                    .HasMaxLength(128)
                    .HasColumnName("type_libelle")
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
