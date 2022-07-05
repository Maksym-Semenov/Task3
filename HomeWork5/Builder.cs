using System;

namespace HomeWork5
{
    internal class Builder : IDeveloper
    {
        //Part 1.2 - Create two classes Programmer and Builder, which implement interface IDeveloper
        string language;
        public string Tool { get { return language; } set { language = value; } }
        public Builder(string language)
        {
            this.language = language;
        }
        public void Create()
        {
            Console.WriteLine("Builder create new program");
        }
        public void Destroy()
        {
            Console.WriteLine("Builder destroy new program"); ;
        }
        public int CompareTo(IDeveloper other)
        {
            return string.Compare(this.Tool, other.Tool);
        }
    }
}
