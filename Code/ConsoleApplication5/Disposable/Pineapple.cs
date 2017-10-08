using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5.Disposable
{
    class Pineapple : IDisposable
    {

        public void DoShit()
        {
            var stream = File.OpenRead("test.txt");


        }

        public void Dispose()
        {
            Dispose(true);


            //tells the GC to not run the finalizer 
            //method on this object, which would basically rerun everything
            GC.SuppressFinalize(this); 

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //release managed resources
            }

            //release unmanaged resources
        }

        //finalizer
        ~Pineapple()
        {
            //GC will only run if we dont have references to other objects that are alive
            //so we dont need to dispose of managed resources in this scenario, hence the falce param value
            Dispose(false);
        }
    }
}
