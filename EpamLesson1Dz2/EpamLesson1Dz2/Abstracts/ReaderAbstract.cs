using EpamLesson1Dz2.Interfaces;
using System.Collections.Generic;

namespace EpamLesson1Dz2.Abstracts
{
    abstract class ReaderAbstract<T,W>  : IReader<W> where T:Person where W: IWriter
    {
        // Contains everyone person in story.
        public List<T> People { get; protected set; }

        public abstract void StartReading(W writer);

        protected virtual void _GetExeption()
        {
            throw new PersonExeption("Напали пришельцы.","Все были уничтожены.");
        }
    }
}
