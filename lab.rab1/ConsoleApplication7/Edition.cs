using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Edition:Article
    {
        protected Frequency FC;
        protected string Publication;
        protected DateTime Data;
        protected int edition;
        public Edition(string P, DateTime D, int e)
        {
            Publication = P;
            Data = D;
            edition = e;
        }
        public Edition(string p, DateTime DT, int et, Frequency fr)
        {
            Publication = p;
            Data = DT;
            edition = et;
            FC = fr;
        }
        public Edition()
        {
            Publication = "Аврора";
            Data = new DateTime(2013, 10, 10);
            edition = 2500;
            FC = 0;
        }
        public string Public
        {
            get
            {
                return Publication;
            }
            set
            {
                Publication = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return Data;
            }
            set
            {
                Data = value;
            }
        }
        public int edit
        {
            get
            {
                return edition;
            }
            set
            {
                if (value < 0)
                    throw new System.FormatException("Тираж не может иметь данный формат, значения свойства должны быть положительны");
                else edition = value;
            }
        }
       new public virtual object DeepCopy()
        {
           Edition ed= new Edition();
           ed.Publication = Publication;
           ed.Data = new DateTime(Data.Year, Data.Month, Data.Day);
           ed.edition = edition;
            return (object)ed;
        }
        public override bool Equals(object obj)
        {
            Edition ED = (Edition)obj;
            if ((ED.Publication == this.Publication) && (ED.edition == this.edition) && (ED.Data == this.Data))
                return true;
            else
                return false;
        }
        public static bool operator ==(Edition e1, Edition e2)
        {
                return e1.Equals(e2);
        }
        public static bool operator !=(Edition e1, Edition e2)
        {
                return !e1.Equals(e2);
        }
        public override int GetHashCode()
        {
                return (int)Publication.GetHashCode() ^ edition.GetHashCode() ^ Data.GetHashCode();
        }
        public override string ToString()
        {
            return ("Издание: "+ Publication + "\n" + "Тираж издания - "+ edition + " шт" + "\n"+ "Дата выхода издания:"+ Data).ToString();
        }
        
    }
}
