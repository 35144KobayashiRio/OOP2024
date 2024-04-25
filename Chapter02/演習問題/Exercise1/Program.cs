using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    internal class Proguram {
        static void Main(string[] args) {
            var songs = new Song[] {
                new Song("Let it be","The Beatles",243),
                new Song("Bridge Over Troubled","Simon&Garhunkel",293),
                new Song("Close To You","Carpenters",276),
                new Song("Honesty","Billy joel",231),
                new Song("I Will Always Love You","Whitney Houston",273),
            };

            PrintSongs(songs);
        }

        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine(@"{0},{1},{2:mm\:ss}", song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}