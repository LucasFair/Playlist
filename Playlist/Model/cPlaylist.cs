using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Model
{
	public class cPlaylist
	{
		private byte _id;  // Using a byte since it's for this project, however for a real use case
						   // where you may have more than 255 playlists, as a server, a ushort or int
						   // might be more suitable, depending on the scale.
		private string _name;

		public byte Id
		{
			get { return _id; }
			set { _id = value; }
		}
		public string Name
		{
			get { return _name; }
			private set { _name = value; }
		}

		public cPlaylist()
		{
			_id = 0;
			_name = "";
		}

		private cPlaylist(byte id)
		{
			_id = id;
		}
		public cPlaylist(byte id, string name) : this(id)
		{
			_name = name;
		}

		public override string ToString()
		{
			return string.Format("{1}", Id, Name);
		}
	}
}
