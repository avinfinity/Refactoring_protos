using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolumeProcessing.DataStructures;

namespace VolumeProcessing
{
    public interface IVolumeReader<Toutput> where Toutput : ReadOutput
    {
        Toutput Read();
    }
}