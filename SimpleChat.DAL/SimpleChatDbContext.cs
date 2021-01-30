using Microsoft.EntityFrameworkCore;
using SimpleChat.DAL.Entities;

namespace SimpleChat.DAL
{
    public class SimpleChatDbContext:DbContext
    {
        public DbSet<CredentialsEntity> Credentials { get; set; }
        public DbSet<ChannelEntity> Channels { get; set; }
        public DbSet<ChannelUserEntity> ChannelUsers { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        public SimpleChatDbContext()
        {
            
        }

        public SimpleChatDbContext(DbContextOptions<SimpleChatDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChannelUserEntity>().HasKey(sc => new {  sc.UserId, sc.ChannelId});
            modelBuilder.Entity<ChannelUserEntity>()
                .HasOne(sc => sc.User)
                .WithMany(s => s.ListOfChanelUser)
                .HasForeignKey(sc => sc.UserId);
            modelBuilder.Entity<ChannelUserEntity>()
                .HasOne(sc => sc.Channel)
                .WithMany(s => s.ListOfChanelUser)
                .HasForeignKey(sc => sc.ChannelId);
        }
    }
}