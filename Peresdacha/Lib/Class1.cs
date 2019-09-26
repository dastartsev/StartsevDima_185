using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Folder:  File, IEnumerable<File>
    {
        public Folder(string name) : base(0, name)
        {
        }

        public List<File> files { get; }

        public File GetLF()
        {
            File longest = null;
            if (files.Count > 0)
                longest = files[0];
            for (int i = 1; i < files.Count; ++i)
                if (files[i].size > longest.size)
                    longest = files[i];
            return longest;
        }

        new long size
        {
            get{ return files.Sum((a) => a.size); }       
        }


        public IEnumerator<File> GetEnumerator()
        {
            return files.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class File : IComparable<File>
    {
        public File(long size, string name)
        {
            this.size = size;
            Name = name;
        }

        public long size {
            get { return size; }
            set
            {
                if (value < 0)
                {
                    throw new MyFileException("Число должно быть больше 0");
                }
                size = value;

            }
        }

        public string Name
        {
            get { return Name; }
            set
            {
                if (value.Length < 5 || value.Length > 20)
                {
                    throw new MyFileException("Строка должна быть от 5 до 20 символов и включать в себя латиницу и цифры");
                } else
                {
                    for (int i = 0; i < value.Length; ++i)
                    {
                        if (!(value[i] > 'a' && value[i] < 'z' || value[i] > 'A' && value[i] < 'Z' || value[i] > '0' && value[i] < '9'))
                        {
                            throw new MyFileException("Строка должна быть от 5 до 20 символов и включать в себя латиницу и цифры");
                        }
                    }
                }
                Name = value;
            }
        }


        public int CompareTo(File other)
        {
            if (size > other.size)
            {
                return 1;
            } else if (size == other.size)
            {
                return 0;
            } else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"Name is {Name}, size is {size}";
        }
    }
    

    class MyFileException : Exception
    {
        public MyFileException(string str) : base(str)
        {

        }
    }
}
