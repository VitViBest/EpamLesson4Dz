
using EpamLesson1Dz2.Interfaces;
using System;

namespace EpamLesson1Dz2.Abstracts
{
    abstract class Person: IPerson
    {
        public string Name { get; private set; }

        public Person(string name)
        {
            Name = name;
        }

        public delegate string GetAction();

        public delegate string GetEnter(int id);

        public event GetEnter Entered;
        // Person go to home.
        public string Move(GetAction getAct)
        {
            return getAct.Invoke();
        }

        // Person stoped hear a home.
        public abstract string Stop();

        // Person enter in home.
        public string Enter() {
            if (Entered != null)
               return Entered(new Random().Next(0,100));
            return null;
        }

        // Person can crash a home.
        public virtual bool Crashed()
        {
            return false;
        }
    }
}
