using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolumeProcessing;
using VolumeProcessing.DataStructures;

namespace Proto_Application
{
    public class SliceReader : IVolumeReader<SliceReadOutput>
    {
        public SliceReadOutput Read()
        {
            return new SliceReadOutput();
        }
    }
}