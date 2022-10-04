using ItBrains.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<About1> Abouts1 { get; set; }
        public DbSet<About2> Abouts2 { get; set; }
        public DbSet<About3> Abouts3 { get; set; }
        public DbSet<GraduatedOpinion> GraduatedOpinions { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<VideoLesson> VideoLessons { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Success> Successes { get; set; }
        public DbSet<Famous> Famouses { get; set; }
        public DbSet<Persone> Persones { get; set; }
        public DbSet<Miq> Miqs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Bio>().HasData(
                new Bio { Id = 1 ,Mobile= "+994507662000" ,Email= "info@itbrains.az",Telegram= "https://t.me/joinchat/TMKzDKQwRU1tqR_6",Youtube= "https://www.youtube.com/c/ITBrains",Instagram= "https://www.instagram.com/proqramci_ol/",Linkedin= "https://www.linkedin.com/company/it-brains-training-center/about/", Facebook= "https://www.facebook.com/itbrainacademy/" });
            builder.Entity<Miq>().HasData(
               new Miq { Id = 1, Link="https ile link olmalidir burda" });
            builder.Entity<About>().HasData(
                new About { Id = 1, AzDescription = "", EnDescription = "", RuDescription = "", Image = "about.png" });
        }
    }
}
