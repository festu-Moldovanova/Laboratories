using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ConsoleApplication7
{
    enum Frequency
    { Weekly, Monthly, Yearly }
    interface IRateAndCopy
    {
        object DeepCopy();
        double Rating { get; set; }
    }
    class Person:IRateAndCopy
    {
        public string Family;
        public string Name;
        private DateTime born;
        private double R;
        public Person(string F, string N, DateTime b)
        {
            Family = F;
            Name = N;
            born = b;
        }
        public Person()
        {
            Family = "Молдованова";
            Name = "Лариса";
            born = new DateTime(1993,11,22);
        }
        public double Rating
        {
            get
            {
                return R;
            }
            set
            {
                R = value;
            }
        }
        public string Fam
        {
            get
            {
                return Family;
            }
            set { Family = value; }
        }
        public string Nam
        {
            get 
            {
                return Name;
            }
            set { Name = value; }

        }
        public DateTime Date
        {
            get 
            { 
                return born;
            }
            set { born = value; }
        }
        public int DataRoz
        {
            get
            {
                return born.Year;
            }
            set
            {
                born = new DateTime(value,born.Month,born.Day) ;
            }
        }
        public virtual string ToShortString()
        {
            return Name + Family+"\n";
        }
        public override string ToString()
        {
            return ("\n\n"+ "Имя: "+ Name +"\n"+"Фамилия: "+Family +"\n" +"Дата рождения: "+born).ToString();
        }
        public override bool Equals(object obj)
        {
            Person per = (Person)obj;
            if ((per.Family == this.Family) && (per.Name == this.Name) && (per.born == this.born))
                return true;
            else
                return false;
        }
        public static bool operator ==(Person per1, Person per2)
        {
              return per1.Equals(per2);
        }
        public static bool operator !=(Person per1, Person per2)
        {
                return !per1.Equals(per2);
        }
        public override int GetHashCode()
        {
          return Name.GetHashCode() ^ Family.GetHashCode() ^ born.GetHashCode();
        }
        public object DeepCopy()
        {
            Person p = new Person();
            p.Name = Name;
            p.Family = Family;
            p.born = new DateTime(born.Year, born.Month, born.Day);
            return (object)p;
        }
        }
}

