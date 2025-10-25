using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Funny Cat Videos", "catluver03", 300);
        v1.AddComment(new Comment("Audrey024", "OMG the third cat looks just like mine!"));
        v1.AddComment(new Comment("iL0v3c4ts", "Super cute video!"));
        v1.AddComment(new Comment("sadGurl3", "This is making me miss my cats :("));

        Video v2 = new Video("How to Change a Tire", "YourDad02", 630);
        v2.AddComment(new Comment("Brigham34", "This video helped a lot! Thanks!"));
        v2.AddComment(new Comment("Mckenzie77", "Currently on the side of the road- hope this works!"));
        v2.AddComment(new Comment("Amanda98", "This is such an educational video, thanks!"));

        Video v3 = new Video("Sewing my Fall Wardrobe", "Becca_Sews", 1200);
        v3.AddComment(new Comment("Bridget", "That first dress is so cute!"));
        v3.AddComment(new Comment("SewingFiend34", "I need the pattern for that skirt!"));
        v3.AddComment(new Comment("SuperSewist99", "Super cute! I wish I had a serger :("));

        List<Video> _videos = new List<Video>
        {
            v1,
            v2,
            v3
        };

        foreach (Video v in _videos)
        {
            v.DisplayInfo();
            Console.WriteLine();
        }
    }
}