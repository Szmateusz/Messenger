﻿namespace Blog.Models
{
    public class BigView
    {
        public IEnumerable<Message> Messages  { get; set; }

        public IEnumerable<Room> Rooms{ get; set; }

        public IEnumerable<ConnectingToGroups> Connecting { get; set; }

        public IEnumerable<UserModel> Users  { get; set; }

    }
}