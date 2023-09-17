using Playlist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.View
{
	/// <summary>
	/// Class <c>PlaylistGUI</c> contains all the visual data for the usee, which is shown in the conosle. 
	/// </summary>
	public class PlaylistGUI
	{
		public void Welcome()
		{
			//Console.WriteLine("Welcome to my playlist!\nThe best of 90s to early 2010s' trash (which I love)!\n");
			Console.WriteLine("Welcome to The Number One Music Player!");
		}
		public void ClearConsole()
		{
			Console.Clear();
		}
		public void AnyKeyToContinue()
		{
			Console.WriteLine("Press any key to continue.");
		}
		public void MainMenu()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("== MAIN MENU ==\n");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Press \"1\" to go to the [Playlist Menu]\nPress \"2\" to go to the [Song List]\nPress \"0\" to [EXIT APPLICATION]\n");
			Console.ResetColor();
		}
		public void PlaylistMenu()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("== PLAYLIST MENU ==\n");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Press \"1\" to [Create Playlist]\nPress \"2\" to [View Playlists]\nPress \"Backspace\" to return to the [Main Menu]\n");
			Console.ResetColor();
		}

		public void EnterNameForPlaylist()
		{
			Console.WriteLine("Please enter the name for your playlist:\n");
		}
		public void PlaylistHasBeenAdded()
		{
			Console.WriteLine("The playlist has been successfully added!");
		}
		public void PlaylistNameIsShort()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Please input a name for your playlist that is longer than zero characters.");
			Console.ResetColor();
		}
		public void PlaylistNameAlreadyExists()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("There already exists a playlist by the same name. Please pick another name.");
			Console.ResetColor();
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

		public void ExitMessage()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Thank you for using The Number One Music Player!\nGood-Bye!\n");
			Console.ResetColor();
		}

		public void TestPrintPlaylist(LinkedList<cPlaylist> PlaylistLists)  // This prints the playlists available
		{
			Console.WriteLine("Available playlists:\n");
			foreach (cPlaylist playlists in PlaylistLists)
			{
				Console.WriteLine($"ID = {playlists.Id} | Name = {playlists.Name}");
			}
		}
		public void TestPrintListContent(List<cTrack> Tracklist)  // This prints the audio tracks
		{
			foreach (cTrack tracks in Tracklist)
			{
				Console.Write($"[{tracks.Index}] {tracks.TrackNum}. {tracks.Artist} - {tracks.Title}\n");
			}
		}
	}
}
