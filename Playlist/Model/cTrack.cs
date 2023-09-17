using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist.Model
{
	/// <summary>
	/// Class <c>cTrack</c> is the template for the track, containing meta-data, properties, for it and scaffolding.
	/// </summary>
	public class cTrack
	{
		private byte _index;
		private string _title;
		private byte _trackNum;
		private string _artist;
		private string _genre;
		private string _album;
		private ushort _year;

		public byte Index
		{
			get { return _index; }
			private set { _index = value; }
		}
		public string Title
		{
			get { return _title; }
			private set { _title = value; }
		}
		public byte TrackNum
		{
			get { return _trackNum; }
			private set { _trackNum = value; }
		}
		public string Artist
		{
			get { return _artist; }
			private set { _artist = value; }
		}
		public string Genre
		{
			get { return _genre; }
			private set { _genre = value; }
		}
		public string Album
		{
			get { return _album; }
			private set { _album = value; }
		}
		public ushort Year
		{
			get { return _year; }
			private set { _year = value; }
		}

		public cTrack()
		{
			_index = 0;
			_title = "";
			_trackNum = 0;
			_artist = "";
			_genre = "";
			_album = "";
			_year = 0;
		}

		public cTrack(byte index) : this()
		{
			_index = index;
		}
		public cTrack(byte index, string title, byte trackNum, string genre) : this(index)
		{
			_title = title;
			_trackNum = trackNum;
			_genre = genre;
		}
		public cTrack(byte index, string title, byte trackNum, string genre, string artist) : this(index, title, trackNum, genre)
		{
			_artist = artist;
		}
		public cTrack(byte index, string title, byte trackNum, string genre, string artist, string album, ushort year) : this (index, title, trackNum, genre, artist)
		{
			_album = album;
			_year = year;
		}

	}
}
