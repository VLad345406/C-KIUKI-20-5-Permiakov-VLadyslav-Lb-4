using System;
using System.Collections.Generic;

namespace CSharp_Lb4
{
    class Track
    {
        public string trackName { get; set; } = String.Empty;
        public DateTime trackLenth { get; set; } = DateTime.Now;
    }
    class Album
    {
        public string albumName { get; set; } = String.Empty;
        public int year { get; set; } = 0;
        public int countTracks { get; set; } = 0;
        public List<String> genres { get; set; } = new List<String>();
        public List<Track> tracks { get; set; } = new List<Track>();
    }
    class Artist
    {
        public string artistName { get; set; } = String.Empty;
        public List<Album> albums { get; set; } = new List<Album>();
    }
}
