using Playlist.Model;
using Playlist.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Controller
{
	public class PlaylistController
	{
		PlaylistGUI GUI = new PlaylistGUI();
		Model.cMaker pList = new Model.cMaker();
		public void Run()
		{
			pList.SongList();

			GUI.Welcome();
			GUI.EnterNameForPlaylist();
			pList.AddPlaylist();

			GUI.TestPrintPlaylist(pList.PlaylistList());

			GUI.AddAnotherPlaylistPrompt();
			GUI.EnterNameForPlaylist();
			pList.AddPlaylist();

			GUI.TestPrintPlaylist(pList.PlaylistList());
			//GUI.TestPrintListContent(pList.Tracklist());
		}
	}
}
