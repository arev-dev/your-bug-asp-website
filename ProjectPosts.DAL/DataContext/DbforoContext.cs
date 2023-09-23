using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProjectPosts.EN;
using ProjectPosts.EN.DTO;

namespace ProjectPosts.DAL.DataContext;

public partial class DbforoContext : DbContext
{
    public DbforoContext()
    {
    }

    public DbforoContext(DbContextOptions<DbforoContext> options)
        : base(options)
    {
    }
    //public DbSet<Usuario> Users { get; set; }
    //public DbSet<Comment> Comments { get; set; }
    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Like> Likes { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<StatusPost> StatusPosts { get; set; }

    public virtual DbSet<TypeLike> TypeLikes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CommentReplyDTO>().HasNoKey();
        modelBuilder.Entity<CommentLikesDTO>().HasNoKey();
        modelBuilder.Entity<PostLikesDTO>().HasNoKey();
        modelBuilder.Entity<PostCommentsDTO>().HasNoKey();
        modelBuilder.Entity<PostAllDTO>().HasNoKey();

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comment__3213E83F21972CDF");

            entity.ToTable("Comment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content)
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.IdParentComment).HasColumnName("id_parent_comment");
            entity.Property(e => e.IdPost).HasColumnName("id_post");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdPostNavigation).WithMany(p => p.Comments)
                .HasForeignKey(d => d.IdPost)
                .HasConstraintName("FK__Comment__id_post__45F365D3");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Comments)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Comment__id_usua__46E78A0C");
        });

        modelBuilder.Entity<Like>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Like__3213E83FB2D86BE6");

            entity.ToTable("Like");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdComment).HasColumnName("id_comment");
            entity.Property(e => e.IdPost).HasColumnName("id_post");
            entity.Property(e => e.IdTypelike).HasColumnName("id_typelike");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdCommentNavigation).WithMany(p => p.Likes)
                .HasForeignKey(d => d.IdComment)
                .HasConstraintName("FK__Like__id_comment__4BAC3F29");

            entity.HasOne(d => d.IdPostNavigation).WithMany(p => p.Likes)
                .HasForeignKey(d => d.IdPost)
                .HasConstraintName("FK__Like__id_post__4AB81AF0");

            entity.HasOne(d => d.IdTypelikeNavigation).WithMany(p => p.Likes)
                .HasForeignKey(d => d.IdTypelike)
                .HasConstraintName("FK__Like__id_typelik__4CA06362");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Likes)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Like__id_usuario__49C3F6B7");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Post__3213E83FCDBCA08A");

            entity.ToTable("Post");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content)
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("title");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Posts)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK__Post__id_status__4222D4EF");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Posts)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Post__id_status__412EB0B6");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Report__3213E83FED701760");

            entity.ToTable("Report");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.IdComment).HasColumnName("id_comment");
            entity.Property(e => e.IdPost).HasColumnName("id_post");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdCommentNavigation).WithMany(p => p.Reports)
                .HasForeignKey(d => d.IdComment)
                .HasConstraintName("FK__Report__id_comme__52593CB8");

            entity.HasOne(d => d.IdPostNavigation).WithMany(p => p.Reports)
                .HasForeignKey(d => d.IdPost)
                .HasConstraintName("FK__Report__id_post__5165187F");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Reports)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Report__id_usuar__5070F446");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Role__3213E83FC683A465");

            entity.ToTable("Role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<StatusPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusPo__3213E83FDA4CD864");

            entity.ToTable("StatusPost");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TypeLike>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TypeLike__3213E83FAC3B6A69");

            entity.ToTable("TypeLike");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83F4DCCAF61");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("FK__Usuario__id_role__3D5E1FD2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
