using Playlist.Model;
using Playlist.View;
using System;
using System.Collections.Generic;

namespace Playlist.Controller
{
	/// <summary>
	/// Class <c>PlaylistController</c> communicates with the model and view, as well as contains the input data.
	/// </summary>
	public class PlaylistController
	{
		//PlaylistInput In = new PlaylistInput();
		PlaylistGUI GUI = new PlaylistGUI();
		Model.cMaker pList = new Model.cMaker();

		public void Run()
		{
			//pList.SongList();

			
			pList.TestList();
			WaitForInput();
			Environment.Exit(0); 
			



			GUI.Welcome();
			GUI.AnyKeyToContinue();
			WaitForInput();
			GUI.ClearConsole();

			GUI.MainMenu();
			MainMenuSelection();
		}

		public ConsoleKey WaitForInput()
		{
			var key = Console.ReadKey(true).Key;
			return key;
		}

		public void CreateAnotherPlaylist()
		{
			while (true)
			{
				int nameCheck = 0;
				var selectIn = Console.ReadKey(true).Key;
				switch (selectIn)
				{

					case ConsoleKey.Y:
						GUI.ClearConsole();
						GUI.EnterNameForPlaylist();

						if (pList.AddPlaylist(nameCheck) == 0)
						{
							GUI.PlaylistHasBeenAdded();
							pList.AddPlaylist(0);
							GUI.ClearConsole();
						}
						else
						{
							GUI.PlaylistNameIsShort();
							pList.AddPlaylist(1);
							GUI.ClearConsole();
						}

						GUI.TestPrintPlaylist(pList.PlaylistList());
						GUI.AnyKeyToContinue();
						WaitForInput();
						GUI.ClearConsole();
						GUI.AddAnotherPlaylistPrompt();
						CreateAnotherPlaylist();
						break;
					case ConsoleKey.N:
						GUI.ClearConsole();
						GUI.MainMenu();
						MainMenuSelection();
						break;
					default:
						break;
				}
			}
		}

		public void MainMenuSelection()
		{
			while (true)
			{
				var selectIn = Console.ReadKey(true).Key;
				switch (selectIn)
				{
					case ConsoleKey.D1:
						GUI.ClearConsole();
						GUI.PlaylistMenu();
						PlaylistMenuSelection();
						break;
					case ConsoleKey.D2:
						GUI.ClearConsole();
						GUI.TestPrintListContent(pList.Tracklist());
						GUI.AnyKeyToContinue();
						WaitForInput();
						GUI.ClearConsole();
						GUI.MainMenu();
						MainMenuSelection();
						break;
					case ConsoleKey.D0:
						GUI.ExitMessage();
						Environment.Exit(0);
						break;
					default:
						break;
				}
			}
		}
		public void PlaylistMenuSelection()
		{
			while (true)
			{
				int nameCheck = 0;
				var selectIn = Console.ReadKey(true).Key;
				switch (selectIn)
				{
					case ConsoleKey.D1:
						GUI.ClearConsole();
						GUI.EnterNameForPlaylist();

						if (pList.AddPlaylist(nameCheck) == 0)
						{
							GUI.ClearConsole();
							GUI.PlaylistHasBeenAdded();
							pList.AddPlaylist(0);
							GUI.ClearConsole();
						}
						else
						{
							GUI.ClearConsole();
							GUI.PlaylistNameIsShort();
							pList.AddPlaylist(1);
							GUI.ClearConsole();
						}

						GUI.TestPrintPlaylist(pList.PlaylistList());
						GUI.AnyKeyToContinue();
						WaitForInput();
						GUI.ClearConsole();
						GUI.AddAnotherPlaylistPrompt();
						CreateAnotherPlaylist();
						break;
					case ConsoleKey.D2:
						GUI.ClearConsole();
						GUI.TestPrintPlaylist(pList.PlaylistList());
						GUI.AnyKeyToContinue();
						WaitForInput();
						GUI.ClearConsole();
						GUI.PlaylistMenu();
						PlaylistMenuSelection();
						break;
					case ConsoleKey.Backspace:
						GUI.ClearConsole();
						GUI.MainMenu();
						MainMenuSelection();
						break;
					default:
						break;
				}
			}
		}
	}
}
