using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8
{
	class VideoPlayer : IPlayer
	{
		public string FilmName { get; private set; }
		public VideoPlayer(string nameOfFilm)
		{
			FilmName = nameOfFilm;
		}

		public void Play()
		{
			Console.WriteLine($"Playing film: {FilmName}");
		}

		public void Stop()
		{
			Console.WriteLine($"Stopping film: {FilmName}");
		}

		public void Next()
		{
			Console.WriteLine($"Playing Next Film: {FilmName}"); ;
		}
	}
}
