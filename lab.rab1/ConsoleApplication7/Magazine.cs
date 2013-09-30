using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication7
{
    class Magazine:Edition
    {
        private Frequency period;
        private ArrayList List = new ArrayList();
        private Article[] art = new Article[0];
        public Magazine(string str, Frequency fr, DateTime dt, int t)
        {
            period = fr;
            Publication = str;
            Data = dt;
            edition = t;
        }
        public Magazine()
        {
            period =  (Frequency)1;
            Publication = "Star";
            Data = new DateTime(2013, 02, 03);
            edition = 200;
        }
        public ArrayList AR
        { 
            get
        {
            return List;
        }
            set{List=value;}
        }
        public Article[] AL
        {
            get
            {
                return art;
            }
            set
            {
                art = value;
            }
        }
        public Edition EDIT
        {
            get
            {
                Edition E = new Edition();
                E.Public = Public;
                E.Date = new DateTime(Data.Year,Data.Month,Data.Day);
                E.edit = edit;
                return E;
            }
            set
            {
                Edition d = new Edition();
                Public = d.Public;
                Data = d.Date;
                edit = d.edit;
            }
        }
        public double SR
        {
            get
            {
                double ball = 0;
                for (int i = 0; i < art.Length; i++)
                {
                    ball = ball + art[i].Rating;
                }
                ball = ball / art.Length;
                return ball;
            }
        }
        public void AddArticles(params Article[] list)
        {
            Article[] tmp = new Article[art.Length+list.Length];
            for (int i = 0; i < art.Length; i++)
                tmp[i]=art[i];
            tmp[art.Length] = list[0];
            art = tmp;
        }
        public void AddEditors(params Person[] list1)
        {
            for (int i = 0; i < list1.Length; i++)
                List.Add(list1[i]);
        }
        public override string ToString()
        {
            string redact = "";
            string article = "";
            for (int i = 0; i < art.Length; i++)
                redact = redact + art[i].ToString();
            for (int i = 0; i < List.Count; i++)
                article = article + List[i].ToString();
            return  redact + article.ToString();
        }
        public override int GetHashCode()
        {
            return period.GetHashCode() ^ Rating.GetHashCode();
        }
        new public object DeepCopy()
        {
            Magazine a = new Magazine();
            Edition c = new Edition();
            c.Date = Date;
            c.edit = edit;
            c.Public = Public;
            for (int i = 0; i < List.Count; i++)
            {
                a.List.Add(((Article)List[i]).DeepCopy());
            }
            for (int i = 0; i < art.Length; i++)
            {

                a.AddArticles((Edition)c.DeepCopy());
            }
            return (object)a;
        }
        public override bool Equals(object obj)
        {
            Magazine p = (Magazine) obj;
            if ((p.period == this.period) &&
                    (p.List.Equals(this.List)) &&
                        (p.art.Equals(this.art)))
                            return true;
                        else return false;            
        }
        public static bool operator ==(Magazine a, Magazine  b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Magazine a, Magazine b)
        {
            return !(a.Equals(b));
        }
        public virtual string ToShortString()
        {
            return  "Период публикации журнала - "+ period.ToString() + "\n" + "Оценка рейтинга = "+ Rating.ToString();
        }
        }
}
