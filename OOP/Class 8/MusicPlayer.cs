using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8
{
	class MusicPlayer : IPlayer
	{
		private int _counter;
		private List<string> songsList = new List<string>();
		public MusicPlayer(string[] namesOfSongs)
		{
			for (int i = 0; i < namesOfSongs.Length; i++)
			{
				songsList.Add(namesOfSongs[i]);
			}
		}

		public void Play()
		{
			Console.WriteLine($"Playing song: {songsList[_counter]}");
		}

		public void Stop()
		{
			Console.WriteLine($"Stopping song: {songsList[_counter]}");
		}

		public void Next()
		{
			{
				if (_counter >= songsList.Count - 1)
				{
					_counter = 0;
				}
				else
				{
					_counter++;
				}
			}
			Console.WriteLine($"Playing Next Song: {songsList[_counter]}");
		}
	}
}
