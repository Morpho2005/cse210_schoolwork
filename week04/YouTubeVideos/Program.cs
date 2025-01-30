using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video = new Video("Ham Cooking recipe","abraHam", 600);
        Video video2 = new Video("History of chickens", "rooster gold", 1852);
        Video video3 = new Video("SSSSNNNAAAAKKKEEESSSSS", "Snaek", 60);
        video.AddComment("micheal_devino", "FIRST!");
        video.AddComment("cooking companion", "Nice recipe");
        video.AddComment("why-am-i-here", "0:30 I disagree");
        video.AddComment("guy-who-say-hello", "hello");
        video2.AddComment("buck-wild-bake", "that is a lot of chickens");
        video2.AddComment("babybay", "2:46 baby chicks spotted, so cute");
        video2.AddComment("guy-who-say-hello", "hello");
        video2.AddComment("pulltry-hater", "I hate everything in this video");
        video3.AddComment("serSpent", "SNAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKES");
        video3.AddComment("why-am-i-here", "cute little danger noodles");
        video3.AddComment("guy-who-says-hello", "hello");
        videos.Add(video);
        videos.Add(video2);
        videos.Add(video3);
        for (int i=0;i<videos.Count;i++){
            Console.WriteLine(videos[i].GetVideoStats());
            videos[i].DisplayComments();
        }
    }
}