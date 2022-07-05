using System;

namespace HomeWork5
{
    internal class Programmer : IDeveloper
    {
        //Part 1.2 - Create two classes Programmer and Builder, which implement interface IDeveloper
        string language;
        public string Tool { get { return language; } set { language = value; } }
        public Programmer(string language)
        {
            this.language = language;
        }
        public void Create()
        {
            Console.WriteLine("Programmer create new program"); ;
        }
        public void Destroy()
        {
            Console.WriteLine("Programmer destroy old program"); ;
        }
        public int CompareTo(IDeveloper other)
        {
            return Tool.CompareTo(other.Tool);
        }
    }
}
