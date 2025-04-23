using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Computation
{
    public class Measurements
    {
        public string paralellType { get; set; }
        public int dimension { get; set; }
        public int threadsNum { get; set; }
        public int matrixSize { get; set; }
        public float time { get; set; }
        public bool isResearch { get; set; }
    }
}
