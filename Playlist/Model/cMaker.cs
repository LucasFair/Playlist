using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Model
{
	public class cMaker
	{
		string playlistName;

		LinkedList<cPlaylist> playlists = new LinkedList<cPlaylist>();
		LinkedList<cTrack> tracks = new LinkedList<cTrack>();

		public LinkedList<cPlaylist> PlaylistList()
		{ return playlists; }
		public LinkedList<cTrack> Tracklist()
		{ return tracks; }

		public void AddPlaylist()
		{
			byte idCnt = (byte)(1 + playlists.Count);
			byte idNum = (byte)playlists.Count;
			playlistName = Console.ReadLine();
			/*
			for (byte idCnt = 0; idCnt < idNum; idCnt++)
			{
				playlists.AddLast(new cPlaylist(idNum, playlistName));
				idNum++;
			}
			*/
			if (idNum != idCnt)
			{
				playlists.AddLast(new cPlaylist(idNum, playlistName));
				idNum++;
			}
		}
			
		public void UserList()
		{

			//playlists.AddLast(new cPlaylist(0, "† My Rock List †"));
		}

		public void SongList()
		{
			tracks.AddFirst(new cTrack("In The End", 8, "Alternate Rock", "Linkin Park", "Hybrid Theory", 2000));
			tracks.AddFirst(new cTrack("Down With The Sickness", 4, "Nu Metal", "Disturbed", "The Sickness", 2000));
			tracks.AddFirst(new cTrack("Prelude", 10, "Rock", "Slaughter", "Fear No Evil", 1995));
			tracks.AddFirst(new cTrack("Prey", 10, "Rock", "10 Years", "The Autumn Effect", 2005));
			tracks.AddFirst(new cTrack("From The Inside", 10, "Alternate Rock", "Linkin Park", "Meteora", 2003));
			tracks.AddFirst(new cTrack("My December", 13, "Soft Rock", "Linkin Park", "Hybrid Theory", 2003));

			tracks.AddFirst(new cTrack("I Want It That Way", 2, "Pop", "Backstreet Boys", "Millennium", 1999));
			tracks.AddFirst(new cTrack("Haven't Met You Yet", 5, "Pop", "Michael Bublé", "Crazy Love", 2009));
			tracks.AddFirst(new cTrack("If You're Not The One", 5, "Pop", "Daniel Bedingfield", "Gotta Get Thru This", 2002));
			tracks.AddFirst(new cTrack("Wherever You Will Go", 3, "Post-Grunge", "The Calling", "Camino Palmero", 2001));
			tracks.AddFirst(new cTrack("Show Me The Meaning of Being Lonely", 3, "Pop", "Backstreeet Boys", "Millennium", 1999));
		}
	}
}
