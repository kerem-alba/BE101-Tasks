using Gorev8.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gorev8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // Boş olsa dahi constructor gereklidir, veritabanı bağlantısını ve diğer ayarları yapılandırmak için kullanılır.
        }

        // DbSet, her bir veritabanı tablosunu için yazılmalı.
        public DbSet<StudentEntity> Students { get; set; }

        // Assembly deki (entitylerde yazılan) tüm konfigürasyonları çek fakat burada konfigürasyon yok. (Sadece ensure creating de çalışır)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentEntityConfiguration());
        }
    }
}
