using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleChat.Entities
{
    public class Seeder
    {
        public static void Seed(SimpleChatDbContext context)
        {
            if (context.Users.Any())
                return; //users exists
            CredentialsEntity credentials = new CredentialsEntity
            {
                Id = new Guid("df935095-8709-4040-a2bb-b6f97cb416d0"),
                Email = "aaa@seznam.cz",
                Password = "123456"
            };
            context.Credentials.Add(credentials);
            context.SaveChanges();
            UserEntity user = new UserEntity()
            {
                Id = new Guid("df935095-8709-4040-a2bb-b6f97cb416d1"),
                FirstName = "First1",
                LastName = "Last1",
                Credentials = credentials,
            };
            context.Users.Add(user);
            context.SaveChanges();
            List<MessageEntity> lstOfMessages = new List<MessageEntity>()
            {
                new MessageEntity(){Id= new Guid("df935095-8709-4040-a2bb-b6f97cb416d2"), Title = "Title of message"
                    ,Content = "Content", Date = DateTime.Now,Owner = user}
            };
            context.Messages.AddRange(lstOfMessages);
            context.SaveChanges();
            ChannelEntity channel = new ChannelEntity() { Id = new Guid("df935095-8709-4040-a2bb-b6f97cb416d3"), 
                ListOfMessages = lstOfMessages,Name = "Name of channel", Owner = user};
            List<ChannelUserEntity> lstChanelUser = new List<ChannelUserEntity>()
            {
                new ChannelUserEntity(){Id= new Guid("df935095-8709-4040-a2bb-b6f97cb416d4"), ChannelId = channel.Id, UserId = user.Id}
            };
            channel.ListOfChanelUser = lstChanelUser;
            user.ListOfChanelUser = lstChanelUser;
            context.Channels.Add(channel);
            context.SaveChanges();
            context.ChannelUsers.AddRange(lstChanelUser);
            context.SaveChanges();
        }
    }
}