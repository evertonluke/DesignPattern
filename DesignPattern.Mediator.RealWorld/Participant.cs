using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.RealWorld
{
    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    public class Participant
    {
        Chatroom chatroom;
        string name;

        public Participant(string name)
        {
            this.name = name;
        }

        // Gets participant name
        public string Name
        {
            get { return name; }
        }

        // Gets chatroom
        public Chatroom Chatroom
        {
            get { return chatroom; } 
            set { chatroom = value; }
        }

        // Send message tod given participant
        public void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }

        // Receives message from given participant
        public virtual void Receive(string from, string message) 
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }
}
