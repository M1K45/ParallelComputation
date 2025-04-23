using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Computation
{
    internal class Data
    {
        float time {get; set; }
        int sizeMatricies {get; set; }
        int numberOfThreads { get; set; }

       public Data(float time, int sizeMatricies, int numberOfThreads)
        {
            this.time = time;
            this.sizeMatricies = sizeMatricies;
          
            this.numberOfThreads = numberOfThreads;
        }
        public override string ToString()
        {
            return $"Number of threads: {numberOfThreads} | Size of matricies: {sizeMatricies} | Time: {time} ms";
        }
    }
}
