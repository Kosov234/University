using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] SongsList = new string[5] { "Highway To Hell", "Oldtown road", "Haunted", "Big Bad Wolf", "Ugly Boy" };
			IPlayer[] Array = new IPlayer[2];
			Array[0] = new MusicPlayer(SongsList);
			Array[1] = new VideoPlayer("Irishman");

			foreach (var Player in Array)
			{
				Player.Play();
				Player.Next();
				Player.Next();
				Player.Next();
				Player.Next();
				Player.Next();

			}

		}
	}
}
