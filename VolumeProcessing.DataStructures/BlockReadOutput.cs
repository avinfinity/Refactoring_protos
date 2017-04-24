using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeProcessing.DataStructures
{
    public class BlockReadOutput : ReadOutput
    {
        public Tuple<double, double> BlockRange
        {
            get;
            set;
        }

        //blah blah some more data properties :) :)
    }
}
