using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_ChatLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chats = new List<string>();
            string command;
            while((command=Console.ReadLine())!="end")
            {
                string[] segments = command.Split();
                if (segments[0]=="Chat")
                {
                    string message = segments[1];
                    chats.Add(message);
                }
                else if (segments[0]=="Delete")
                {
                    string message = segments[1];
                    if(chats.Contains(message))
                    {
                        chats.Remove(message);
                    }
                }
                else if (segments[0]=="Edit")
                {
                    string message = segments[1];
                    string editedVersion = segments[2];
                    for(int i=0; i<chats.Count;i++)
                    {
                        if (chats[i]==message)
                        {
                            chats[i] = editedVersion;
                        }
                    }
                }
                else if (segments[0]=="Pin")
                {
                    string message = segments[1];
                    if(chats.Contains(message))
                    {
                        chats.Remove(message);
                        chats.Add(message);
                    }
                }
                else if (segments[0]=="Spam")
                {
                    for(int i=1; i < segments.Length;i++)
                    {
                        chats.Add(segments[i]);
                    }
                }
            }
            foreach(string x in chats)
            {
                Console.WriteLine(x);
            }
        }
    }
}

