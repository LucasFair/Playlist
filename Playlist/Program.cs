using Playlist.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
	public class Program
	{
		static void Main(string[] args)
		{
			PlaylistController playCtrl = new PlaylistController();
			playCtrl.Run();
		}
	}
}
