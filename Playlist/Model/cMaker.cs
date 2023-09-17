using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Model
{
	/// <summary>
	/// Class <c>cMaker</c> is the creates the lists and keeps track of the tracks....audio tracks, that is.
	/// </summary>
	public class cMaker
	{
		byte index;
		string playlistName;

		LinkedList<cPlaylist> playlists = new LinkedList<cPlaylist>();
		List<cTrack> tracks = new List<cTrack>();

		public LinkedList<cPlaylist> PlaylistList()
		{ return playlists; }
		public List<cTrack> Tracklist()
		{ return tracks; }


		public void TestList()
		{
			LinkedList<cTrack> testList = new LinkedList<cTrack>();

			testList.AddLast(new cTrack(index++, "In The End", 8, "Alternate Rock", "Linkin Park", "Hybrid Theory", 2000));
			testList.AddLast(new cTrack(index++, "Down With The Sickness", 4, "Nu Metal", "Disturbed", "The Sickness", 2000));
		
			foreach(cTrack elmnt in testList)
			{
				Console.WriteLine(elmnt.Title);
			}
		}


		public int AddPlaylist(int nameCheck)  // This is what generates playlists, and if the name actually contains characters and returns values
											   // which are picked up in the controller, confirming whether or not the list will be created
		{
			byte idCnt = (byte)(1 + playlists.Count);
			byte idNum = (byte)playlists.Count;

			while (true)
			{
				playlistName = Console.ReadLine();
				if (playlistName.Length > 0)
				{
					break;
				}
				return 1;
			}

			if (idNum != idCnt)
			{
				playlists.AddLast(new cPlaylist(idNum, playlistName));
				idNum++;
			}
			return 0;
		}

		public void UserList()
		{

			//playlists.AddLast(new cPlaylist(0, "† My Rock List †"));
		}

		public void SongList()
		{
			tracks.Add(new cTrack(index++, "In The End", 8, "Alternate Rock", "Linkin Park", "Hybrid Theory", 2000));
			tracks.Add(new cTrack(index++, "Down With The Sickness", 4, "Nu Metal", "Disturbed", "The Sickness", 2000));
			tracks.Add(new cTrack(index++, "Prelude", 10, "Rock", "Slaughter", "Fear No Evil", 1995));
			tracks.Add(new cTrack(index++, "Prey", 10, "Rock", "10 Years", "The Autumn Effect", 2005));
			tracks.Add(new cTrack(index++, "From The Inside", 10, "Alternate Rock", "Linkin Park", "Meteora", 2003));
			tracks.Add(new cTrack(index++, "My December", 13, "Soft Rock", "Linkin Park", "Hybrid Theory", 2003));

			tracks.Add(new cTrack(index++, "I Want It That Way", 2, "Pop", "Backstreet Boys", "Millennium", 1999));
			tracks.Add(new cTrack(index++, "Haven't Met You Yet", 5, "Pop", "Michael Bublé", "Crazy Love", 2009));
			tracks.Add(new cTrack(index++, "If You're Not The One", 5, "Pop", "Daniel Bedingfield", "Gotta Get Thru This", 2002));
			tracks.Add(new cTrack(index++, "Wherever You Will Go", 3, "Post-Grunge", "The Calling", "Camino Palmero", 2001));
			tracks.Add(new cTrack(index++, "Show Me The Meaning of Being Lonely", 3, "Pop", "Backstreeet Boys", "Millennium", 1999));
		}
	}
}

