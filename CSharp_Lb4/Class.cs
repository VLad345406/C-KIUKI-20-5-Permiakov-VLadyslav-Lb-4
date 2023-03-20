using System;
using System.Collections.Generic;

namespace CSharp_Lb4
{
    class Track
    {
        public string trackName;
        public DateTime trackLenth;
    }
    class Album
    {
        public string albumName;
        public int year;
        public int countTracks;
        public List<String> genres = new List<String>();
        public List<Track> tracks = new List<Track>();
    }
    class Artist
    {
        public string artistName;
        public List<Album> albums = new List<Album>();
    }
}
