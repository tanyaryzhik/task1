using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class MyClass : IDisposable
    {
        private bool disposed = false;

        private FileStream file;

        public void ReadFile()
        {
            file = File.OpenRead("C:\\Temp\\UserText.txt");
        }

        public void CloseFile()
        {
            this.file.Close();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                }
                CloseFile();
                disposed = true;
            }
        }

        ~MyClass()
        {
            CloseFile();
           // Dispose(false);
        }
    }
}
