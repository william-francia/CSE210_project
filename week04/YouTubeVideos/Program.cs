using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Mama Song", "Bensone Bone", 3.25);
        Video video2 = new Video("Who says", "Selena Gomes", 3.25);
        Video video3 = new Video("Silence", "Marshmello", 3.20);
        Video video4 = new Video("Beautiful Things", "Bensone Bone", 3.25);

        Comment c1 = new Comment("William Francia", "this is fantastic, I really love it!");
        Comment c2 = new Comment("Ana", "Me encantó la canción.");
        Comment c3 = new Comment("Pedro", "La escucho todos los días!");

        video1.AddComment(c1);
        video1.AddComment(c2);
        video1.AddComment(c3);

        Comment c4 = new Comment("Luis", "Clásico total.");
        Comment c5 = new Comment("Marta", "La voz de Selena es increíble.");

        video2.AddComment(c4);
        video2.AddComment(c5);

        Comment c6 = new Comment("Julia", "Temazo de Marshmello.");
        Comment c7 = new Comment("Sofía", "THe lyrics are so beautiful");

        video3.AddComment(c6);
        video3.AddComment(c7);


        List<Video> ListaDeVideos = new List<Video>();

        ListaDeVideos.Add(video1);
        ListaDeVideos.Add(video2);
        ListaDeVideos.Add(video3);
        ListaDeVideos.Add(video4);

        foreach (Video video in ListaDeVideos)
        {
            Console.WriteLine("Título: " + video.GetTitle());
            Console.WriteLine("Autor: " + video.GetAuthor());
            Console.WriteLine("Duración: " + video.GetDuration() + " minutos");
            Console.WriteLine("Número de comentarios: " + video.NumberOfComment());
            Console.WriteLine("Comentarios:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("  - " + comment.GetAuthor() + ": " + comment.GetCommentText());
            }
        }


    }



}