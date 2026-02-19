using System;

class Song
{
    public string artist;
    public string title;
    public double duration;

    public Song() : this("Unknown", "Unknown", 0.0)
    {

    }

    public Song(string title, string artist) : this(title, artist, 0.0)
    {
    }

    public Song(string title, string artist, double duration)   
    {
        this.title = string.IsNullOrWhiteSpace(title) ? "Unknown" : title;
        this.artist = string.IsNullOrWhiteSpace(artist) ? "Unknown" : title;
        this.duration = duration;
    }

    public void DisplaySong()
    {
        Console.WriteLine("{0,-20} {1, -17} {2,5:F2}", title, artist, duration);
    }

}

class Program
{
    static void Main()
    {

        Console.Write("Songs to add: ");
        int n = int.Parse(Console.ReadLine());

        Song[] playlist = new Song[n];

        for (int i = 0; i < n; i++)
        {

            Console.WriteLine($"\nSong #{i + 1}");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            string durationInput = Console.ReadLine();

            double duration = 0.0;
            if (!string.IsNullOrWhiteSpace(durationInput))
            {
                double.TryParse(durationInput, out duration);
            }

            playlist[i] = new Song(title, artist, duration);


        }


        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        Console.WriteLine("{0,-20} {1,-17} {2,5}", "Title", "Artist", "Time");
        Console.WriteLine("----------------------------------------------");

        double totalDuration = 0.0;

        for (int i = 0; i < playlist.Length; i++)
        {
            playlist[i].DisplaySong();
            totalDuration += playlist[i].duration;
        }

        double averageDuration = (playlist.Length > 0) ? totalDuration / playlist.Length : 0.0;

        Console.WriteLine($"\nTotal Duration: {totalDuration:F2} mins");
        Console.WriteLine($"Average Duration: {averageDuration:F2} mins");


    }

}