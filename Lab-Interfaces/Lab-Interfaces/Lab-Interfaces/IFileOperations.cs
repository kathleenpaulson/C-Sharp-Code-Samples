using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces
{
    public interface IFileOperations
    {
        void Open(string filename);
        void Save();
    }
}
