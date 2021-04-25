using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Programkód
{
    class Program
    {
        static void Main(string[] args)
        {
            beolvas();
        }

        private static void beolvas()
        {
            using (StreamWriter sw = new StreamWriter("Pendulum_adat.sql"))
            {
                StreamReader sr = new StreamReader("pendulum.txt");
                sr.ReadLine();
                bool witch = true;
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    if (sor == "[tracks]") witch = false;
                    else
                    {
                        if (witch)
                        {
                            albums album = new albums(sor);
                            sw.WriteLine($"INSERT INTO Albums VALUES('{album.albumId}', '{album.artistName}','{album.albumName}','{album.albumRelase.ToString("yyyy-MM-dd")}')");
                        }
                        else
                        {
                            tracks track = new tracks(sor);
                            sw.WriteLine($"INSERT INTO Tracks VALUES('{track.musicTitle}', '00:{track.musicLength}', '{track.albumTid}','{track.musicUrl}')");
                        }
                    }
                }
                sr.Close();
                sw.WriteLine("GO");
            }
            using (StreamWriter sw = new StreamWriter("Leader Kills.sql"))
            {
                StreamReader sr = new StreamReader("Leader Kills.txt");
                sr.ReadLine();
                bool witch = true;
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    if (sor == "[tracks]") witch = false;
                    else
                    {
                        if (witch)
                        {
                            albums album = new albums(sor);
                            sw.WriteLine($"INSERT INTO Albums VALUES('{album.albumId}', '{album.artistName}','{album.albumName}','{album.albumRelase.ToString("yyyy-MM-dd")}')");
                        }
                        else
                        {
                            tracks track = new tracks(sor);
                            sw.WriteLine($"INSERT INTO Tracks VALUES('{track.musicTitle}', '00:{track.musicLength}', '{track.albumTid}','{track.musicUrl}')");
                        }
                    }
                }
                sr.Close();
                sw.WriteLine("GO");
            }

        }
    }

        class albums
        {
            public string albumId;
            public string artistName;
            public string albumName;
            public DateTime albumRelase;

            public albums(string row)
            {
                string[] tmp = row.Split(';');
                this.albumId = tmp[0];
                this.artistName = tmp[1];
                this.albumName = tmp[2];
                this.albumRelase = DateTime.Parse(tmp[3]);
            }
        }
        class tracks
        {
            public string musicTitle;
            public string musicLength;
            public string albumTid;
            public string musicUrl;

            public tracks(string sor)
            {
                string[] db = sor.Split(';');
                this.musicTitle = db[0];
                this.musicLength = db[1];
                this.albumTid = db[2];
                this.musicUrl = db[3];
            }
        }
    
}
