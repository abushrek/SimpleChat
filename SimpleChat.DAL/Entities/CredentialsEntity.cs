﻿namespace SimpleChat.DAL.Entities
{
    public class CredentialsEntity:BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}