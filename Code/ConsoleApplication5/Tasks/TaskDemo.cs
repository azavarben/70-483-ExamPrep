using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampPrep.Tasks
{
    /// <summary>
    /// Tasks represent a concurrent operation
    /// May or may not happen on a separate thread
    /// Can be chained and combined
    /// Jeremy Bytes: https://www.youtube.com/watch?v=0qiB3oW_nd8
    /// </summary>
    public class TaskDemo
    {

    }

    public class PersonRepo
    {
        public async Task<List<Person>> Get(CancellationToken cancellationToken = new CancellationToken())
        {
            await Task.Delay(3000); //delay the task by three seconds

            cancellationToken.ThrowIfCancellationRequested();

            //throw new NotImplementedException("Method not implemented");

            return new List<Person>
            {
                new Person
                {
                    Name = "Ben"
                },
                new Person
                {
                    Name = "Tom"
                },
                new Person
                {
                    Name = "DJ"
                }
            };
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
