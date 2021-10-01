using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Gionet.blazor.Models
{
    public partial class u598002034_fnZfTContext : DbContext
    {
        public u598002034_fnZfTContext()
        {
        }

        public u598002034_fnZfTContext(DbContextOptions<u598002034_fnZfTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Contacto> Contactos { get; set; }
        public virtual DbSet<Crm> Crms { get; set; }
        public virtual DbSet<Detparte> Detpartes { get; set; }
        public virtual DbSet<Especialidad> Especialidads { get; set; }
        public virtual DbSet<FailedJob> FailedJobs { get; set; }
        public virtual DbSet<Hoja1> Hoja1s { get; set; }
        public virtual DbSet<Infparte> Infpartes { get; set; }
        public virtual DbSet<Inkpresup> Inkpresups { get; set; }
        public virtual DbSet<Loging> Logings { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Migration> Migrations { get; set; }
        public virtual DbSet<Npresup> Npresups { get; set; }
        public virtual DbSet<Oc> Ocs { get; set; }
        public virtual DbSet<Parte> Partes { get; set; }
        public virtual DbSet<PasswordReset> PasswordResets { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<PersonalAccessToken> PersonalAccessTokens { get; set; }
        public virtual DbSet<Presupuesto> Presupuestos { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Resp> Resps { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Rubro> Rubros { get; set; }
        public virtual DbSet<Semana> Semanas { get; set; }
        public virtual DbSet<Tarea> Tareas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=31.170.161.85;user=u598002034_TkvUc;password=Puertas3489*;database=u598002034_fnZfT", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.5.12-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_unicode_ci");

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.ToTable("categoria");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Categoria, "id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Cliente1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cliente");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("direccion");

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("provincia");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(22);
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.ToTable("contactos");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cliente");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Posicion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("provincia");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Crm>(entity =>
            {
                entity.ToTable("CRM");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("contacto");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Semana)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("semana");
            });

            modelBuilder.Entity<Detparte>(entity =>
            {
                entity.ToTable("detparte");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Desde)
                    .HasColumnType("time")
                    .HasColumnName("desde");

                entity.Property(e => e.Dni)
                    .HasColumnType("int(11)")
                    .HasColumnName("dni");

                entity.Property(e => e.Hasta)
                    .HasColumnType("time")
                    .HasColumnName("hasta");

                entity.Property(e => e.Parte)
                    .HasColumnType("int(11)")
                    .HasColumnName("parte");
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.ToTable("especialidad");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Especialidad1)
                    .HasMaxLength(255)
                    .HasColumnName("especialidad");
            });

            modelBuilder.Entity<FailedJob>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.HasIndex(e => e.Uuid, "failed_jobs_uuid_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Connection)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("connection");

                entity.Property(e => e.Exception)
                    .IsRequired()
                    .HasColumnName("exception");

                entity.Property(e => e.FailedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("failed_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Payload)
                    .IsRequired()
                    .HasColumnName("payload");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("queue");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("uuid");
            });

            modelBuilder.Entity<Hoja1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Hoja1");

                entity.Property(e => e.Campo1).HasMaxLength(255);

                entity.Property(e => e.Campo10).HasMaxLength(255);

                entity.Property(e => e.Campo11).HasMaxLength(255);

                entity.Property(e => e.Campo12).HasMaxLength(255);

                entity.Property(e => e.Campo13).HasMaxLength(255);

                entity.Property(e => e.Campo14).HasMaxLength(255);

                entity.Property(e => e.Campo15).HasMaxLength(255);

                entity.Property(e => e.Campo16).HasMaxLength(255);

                entity.Property(e => e.Campo17).HasMaxLength(255);

                entity.Property(e => e.Campo18).HasMaxLength(255);

                entity.Property(e => e.Campo19).HasMaxLength(255);

                entity.Property(e => e.Campo20).HasMaxLength(255);

                entity.Property(e => e.Campo21).HasMaxLength(255);

                entity.Property(e => e.Campo22).HasMaxLength(255);

                entity.Property(e => e.Campo23).HasMaxLength(255);

                entity.Property(e => e.Campo24).HasMaxLength(255);

                entity.Property(e => e.Campo25).HasMaxLength(255);

                entity.Property(e => e.Campo26).HasMaxLength(255);

                entity.Property(e => e.Campo27).HasMaxLength(255);

                entity.Property(e => e.Campo28).HasMaxLength(255);

                entity.Property(e => e.Campo29).HasMaxLength(255);

                entity.Property(e => e.Campo3).HasMaxLength(255);

                entity.Property(e => e.Campo30).HasMaxLength(255);

                entity.Property(e => e.Campo31).HasMaxLength(255);

                entity.Property(e => e.Campo32).HasMaxLength(255);

                entity.Property(e => e.Campo33).HasMaxLength(255);

                entity.Property(e => e.Campo34).HasMaxLength(255);

                entity.Property(e => e.Campo35).HasMaxLength(255);

                entity.Property(e => e.Campo36).HasMaxLength(255);

                entity.Property(e => e.Campo37).HasMaxLength(255);

                entity.Property(e => e.Campo38).HasMaxLength(255);

                entity.Property(e => e.Campo39).HasMaxLength(255);

                entity.Property(e => e.Campo4).HasMaxLength(255);

                entity.Property(e => e.Campo40).HasMaxLength(255);

                entity.Property(e => e.Campo41).HasMaxLength(255);

                entity.Property(e => e.Campo42).HasMaxLength(255);

                entity.Property(e => e.Campo43).HasMaxLength(255);

                entity.Property(e => e.Campo44).HasMaxLength(255);

                entity.Property(e => e.Campo45).HasMaxLength(255);

                entity.Property(e => e.Campo46).HasMaxLength(255);

                entity.Property(e => e.Campo47).HasMaxLength(255);

                entity.Property(e => e.Campo48).HasMaxLength(255);

                entity.Property(e => e.Campo49).HasMaxLength(255);

                entity.Property(e => e.Campo5).HasMaxLength(255);

                entity.Property(e => e.Campo50).HasMaxLength(255);

                entity.Property(e => e.Campo51).HasMaxLength(255);

                entity.Property(e => e.Campo52).HasMaxLength(255);

                entity.Property(e => e.Campo53).HasMaxLength(255);

                entity.Property(e => e.Campo54).HasMaxLength(255);

                entity.Property(e => e.Campo55).HasMaxLength(255);

                entity.Property(e => e.Campo56).HasMaxLength(255);

                entity.Property(e => e.Campo6).HasMaxLength(255);

                entity.Property(e => e.Campo7).HasMaxLength(255);

                entity.Property(e => e.Campo8).HasMaxLength(255);

                entity.Property(e => e.Campo9).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Infparte>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("INFparte");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(255)
                    .HasColumnName("categoria")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Desde)
                    .HasColumnType("time")
                    .HasColumnName("desde");

                entity.Property(e => e.Detalle)
                    .HasColumnType("mediumtext")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Dni)
                    .HasColumnType("int(11)")
                    .HasColumnName("dni");

                entity.Property(e => e.Especialidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Hasta)
                    .HasColumnType("time")
                    .HasColumnName("hasta");

                entity.Property(e => e.Oc)
                    .HasMaxLength(255)
                    .HasColumnName("oc")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Tarea)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tarea");
            });

            modelBuilder.Entity<Inkpresup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("INKpresup");

                entity.Property(e => e.Descrip)
                    .HasMaxLength(100)
                    .HasColumnName("descrip");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fechaent)
                    .HasColumnType("date")
                    .HasColumnName("fechaent");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Numpresup)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Oc)
                    .HasColumnType("int(11)")
                    .HasColumnName("OC");

                entity.Property(e => e.Resp)
                    .HasMaxLength(30)
                    .HasColumnName("resp");
            });

            modelBuilder.Entity<Loging>(entity =>
            {
                entity.ToTable("loging");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("clave");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Idrol)
                    .HasColumnType("int(11)")
                    .HasColumnName("idrol");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Desrip)
                    .HasColumnType("int(10)")
                    .HasColumnName("desrip");

                entity.Property(e => e.Itemenu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("itemenu");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.ToTable("migrations");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Batch)
                    .HasColumnType("int(11)")
                    .HasColumnName("batch");

                entity.Property(e => e.Migration1)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("migration");
            });

            modelBuilder.Entity<Npresup>(entity =>
            {
                entity.ToTable("npresup");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cliente");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("contacto");

                entity.Property(e => e.Ganado).HasColumnName("ganado");

                entity.Property(e => e.Montod).HasColumnName("montod");

                entity.Property(e => e.Montop).HasColumnName("montop");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Presup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("presup");
            });

            modelBuilder.Entity<Oc>(entity =>
            {
                entity.ToTable("oc");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(50)
                    .HasColumnName("cliente");

                entity.Property(e => e.Desde)
                    .HasColumnType("datetime")
                    .HasColumnName("desde");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Hasta)
                    .HasColumnType("datetime")
                    .HasColumnName("hasta");

                entity.Property(e => e.Montod).HasColumnName("montod");

                entity.Property(e => e.Montop).HasColumnName("montop");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .HasColumnName("nombre");

                entity.Property(e => e.Oc1)
                    .HasMaxLength(255)
                    .HasColumnName("oc");

                entity.Property(e => e.Ocp)
                    .HasColumnType("int(11)")
                    .HasColumnName("ocp");

                entity.Property(e => e.Presupuesto).HasMaxLength(255);

                entity.Property(e => e.Solicita)
                    .HasMaxLength(50)
                    .HasColumnName("solicita");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(255)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<Parte>(entity =>
            {
                entity.ToTable("parte");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Detalle).HasColumnType("mediumtext");

                entity.Property(e => e.Especialidad)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Oc)
                    .HasColumnType("int(11)")
                    .HasColumnName("OC");

                entity.Property(e => e.Tarea).HasColumnType("int(11)");
            });

            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password_resets");

                entity.HasIndex(e => e.Email, "password_resets_email_index");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("token");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.Dni)
                    .HasName("PRIMARY");

                entity.ToTable("personal");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Dni)
                    .HasColumnType("int(11)")
                    .HasColumnName("dni");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(255)
                    .HasColumnName("categoria");

                entity.Property(e => e.Imagen).HasColumnName("imagen");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.Tipoc).HasMaxLength(50);
            });

            modelBuilder.Entity<PersonalAccessToken>(entity =>
            {
                entity.ToTable("personal_access_tokens");

                entity.HasIndex(e => e.Token, "personal_access_tokens_token_unique")
                    .IsUnique();

                entity.HasIndex(e => new { e.TokenableType, e.TokenableId }, "personal_access_tokens_tokenable_type_tokenable_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Abilities)
                    .HasColumnType("text")
                    .HasColumnName("abilities");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.LastUsedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("last_used_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("token");

                entity.Property(e => e.TokenableId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("tokenable_id");

                entity.Property(e => e.TokenableType)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("tokenable_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Presupuesto>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Adjuntar).HasColumnType("tinyblob");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("cliente");

                entity.Property(e => e.Descrip)
                    .HasMaxLength(100)
                    .HasColumnName("descrip");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fechaent)
                    .HasColumnType("date")
                    .HasColumnName("fechaent");

                entity.Property(e => e.Montod).HasColumnName("montod");

                entity.Property(e => e.Numpresup)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Oc)
                    .HasColumnType("int(11)")
                    .HasColumnName("OC");

                entity.Property(e => e.Resp)
                    .HasMaxLength(30)
                    .HasColumnName("resp");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.ToTable("provincias");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idp)
                    .HasMaxLength(60)
                    .HasColumnName("idp");

                entity.Property(e => e.IsoId)
                    .HasMaxLength(60)
                    .HasColumnName("iso_id");

                entity.Property(e => e.Lat).HasColumnName("LAT");

                entity.Property(e => e.Lon).HasColumnName("LON");

                entity.Property(e => e.Provincia1)
                    .HasMaxLength(60)
                    .HasColumnName("provincia");
            });

            modelBuilder.Entity<Resp>(entity =>
            {
                entity.ToTable("Resp");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasColumnName("imagen");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("rol");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Rol1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("rol");
            });

            modelBuilder.Entity<Rubro>(entity =>
            {
                entity.ToTable("rubro");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Rubro1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("rubro");
            });

            modelBuilder.Entity<Semana>(entity =>
            {
                entity.ToTable("semanas");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Dias)
                    .HasMaxLength(255)
                    .HasColumnName("dias");

                entity.Property(e => e.Semana1)
                    .HasMaxLength(255)
                    .HasColumnName("Semana");
            });

            modelBuilder.Entity<Tarea>(entity =>
            {
                entity.ToTable("tarea");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Avance).HasColumnType("int(11)");

                entity.Property(e => e.Dependencia).HasColumnType("int(10)");

                entity.Property(e => e.Desde)
                    .HasColumnType("date")
                    .HasColumnName("desde");

                entity.Property(e => e.Duracion).HasColumnType("int(10)");

                entity.Property(e => e.Especialidad)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("especialidad");

                entity.Property(e => e.Hasta)
                    .HasColumnType("date")
                    .HasColumnName("hasta");

                entity.Property(e => e.Hhprev)
                    .HasPrecision(10)
                    .HasColumnName("HHprev");

                entity.Property(e => e.IdTarea)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_tarea");

                entity.Property(e => e.Oc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("oc");

                entity.Property(e => e.Tarea1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tarea");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
