using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Funny Cat Videos", "catluver03", 300);
        v1.AddComment(new Comment("Audrey", "OMG the third cat looks just like mine!"));
    }
}