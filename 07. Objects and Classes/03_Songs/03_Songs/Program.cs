using System;
using System.Collections.Generic;

namespace _03_Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for(int i=1; i<=numSongs;i++)
            {
                string[] info = Console.ReadLine().Split("_");
                Song song = new Song(info[0], info[1], info[2]);
                songs.Add(song);
            }
            string command = Console.ReadLine();
            foreach(Song x in songs)
            {
                if (command == x.TypeList)
                {
                    Console.WriteLine(x.Name);
                }
                else if(command=="all")
                {
                    Console.WriteLine(x.Name);
                }
            }
            
        }
    }
    class Song
    {
        string typeList, name, time;

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }

    }
}

