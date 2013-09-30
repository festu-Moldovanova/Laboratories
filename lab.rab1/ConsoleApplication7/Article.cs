using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Article:IRateAndCopy
    {
        public Person Author
        { get; set;}
        public string Title
        { get; set; }
        public double Rating
        { get; set; }
        public Article(Person a, string t, double r)
        {
            Author=a;
            Title=t;
            Rating=r;
        }
        public Article()
        {
            Author = new Person("Michailov", "Andrei", new DateTime(1980, 03, 22));
            Title = "Information society";
            Rating = 4.5;
        }
        public override string ToString()
        {
            return ("Автор статьи "+ Author+ "\n" + "Название статьи: "+ Title+ "\n" + "Оценка рейтинга: "+ Rating+"\n\n").ToString();

        }
        public virtual object DeepCopy()
        {
            Article art = new Article();
            art.Author = Author;
            art.Title = Title;
            art.Rating = Rating;
            return (object)art;
        }
        public override bool Equals(object obj)
        {
            Article A = (Article)obj;
            if ((A.Author == this.Author) && (A.Title == this.Title) && (A.Rating == this.Rating))
                return true;
            else
                return false;
        }
        public static bool operator ==(Article ar1, Article ar2)
        {
              return ar1.Equals(ar2);
        }
        public static bool operator !=(Article ar1, Article ar2)
        {
                return !ar1.Equals(ar2);
        }
        public override int GetHashCode()
        {
          return Author.GetHashCode() ^ Title.GetHashCode() ^ Rating.GetHashCode();
        }
        
        }
    }

