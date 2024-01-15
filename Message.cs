﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SetDz2
{
    internal class Message
    {
        public string UserName { get; set; }
        public string Text { get; set; }

        public DateTime DateTime { get; set; }
        public Message(string u, string text)
        {
            UserName = u;
            Text = text;
            DateTime = DateTime.Now;
        }
        public Message() { }

        public string toJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public static Message? fromJson(string jsonData)
        {
            return JsonSerializer.Deserialize<Message>(jsonData);

        }
        public override string ToString()
        {
            return String.Format($"{this.DateTime.ToString()} - {this.UserName}:{this.Text}");
        }
    }
}
