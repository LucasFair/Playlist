using Playlist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.View
{
	public class PlaylistGUI
	{
		public void Welcome()
		{
            //Console.WriteLine("Welcome to my playlist!\nThe best of 90s to early 2010s' trash (which I love)!\n");
            Console.WriteLine("Welcome to The Number One Music Player!");
            Console.WriteLine("Press any key to continue.");
        }
		public void ClearConsole()
		{
			Console.Clear();
		}

		public void EnterNameForPlaylist()
		{
            Console.WriteLine("Please enter the name for your playlist:\n");
        }
		public void AddAnotherPlaylistPrompt()
		{
            Console.WriteLine("Would you like to add another playlist?\n\nPress \"Y\" to create a new playlist.\n" +
				"Press \"N\" to return to the main menu.");
        }
		public void TestPrintPlaylistName()
		{
            Console.WriteLine("This is playlist: ");
        }
		public void TestPrintPlaylist(LinkedList<cPlaylist> PlaylistLists) 
		{
			foreach (cPlaylist playlists in PlaylistLists)
			{
                Console.WriteLine($"ID = {playlists.Id} | Name = {playlists.Name}");
            }
		}
		public void TestPrintListContent(LinkedList<cTrack> Tracklist)
		{	
			foreach (cTrack tracks in Tracklist)
			{
				Console.Write($"[{tracks.TrackNum}] {tracks.Artist} - {tracks.Title}\n");
            }
		}
		public ConsoleKey WaitForInput()
		{
			var key = Console.ReadKey(true).Key;
			return key;
		}

	}
}
