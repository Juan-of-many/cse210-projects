using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = [];
        Video vid1 = new Video("Example Title 1", "Example Vlogger 1", "123");
        Video vid2 = new Video("How To Prove A Circle Is A Circle", "William Nye", "360");
        Video vid3 = new Video ("A Thousand Years", "Christina Perri", "340");
        Video vid4 = new Video("Donating Kidneys Until Someone Stops Me", "Allen Norm", "404");

        videoList.Add(vid1);
        videoList.Add(vid2);
        videoList.Add(vid3);
        videoList.Add(vid4);

        foreach (Video vid in videoList)
        {
            int j = 0;
            while (j < 3) //repeat thrice
            {
                Comment c = new Comment();
                vid.AppendComments(c);
                j++;
            }

            vid.CountComments();
            Console.WriteLine(vid.AssembleDetails());
            int num = Int32.Parse(vid.GetAmount());

            List<Comment> commentList = vid.GetComments();
            //for i starting at 0, for as long as it is within bounds, do the following and end by incrementing.
            for (int i = 0; i < num; i++)
            {
                commentList[i].DisplayCombinedComment();
            }

            Console.WriteLine();
        }
    }
}