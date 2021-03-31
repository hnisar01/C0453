using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading(" Hassan's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "" +
                "Display All Posts", "Quit"
            };

            bool wantToQuit = false;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: wantToQuit = true; break;

                }
            } while (!wantToQuit);
        }

        private void PostImage()
        {
            Console.WriteLine("Please enter your name");
            String name = Console.ReadLine();
            
            Console.WriteLine("Please enter your filename");
            String filename = Console.ReadLine();
            
            Console.WriteLine("Please enter your caption");
            String caption = Console.ReadLine();
            
            PhotoPost photoPost = new PhotoPost(name, filename, caption);
            news.AddPhotoPost(photoPost);
        }

        private void PostMessage()
        {
            Console.WriteLine("Please enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Please enter your message");
            String message = Console.ReadLine();
            MessagePost messagePost = new MessagePost(name,message);
            news.AddMessagePost(messagePost);
        }

        private void DisplayAll()
        {
            news.Display();
        }
    }
}
