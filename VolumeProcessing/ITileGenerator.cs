using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolumeProcessing.DataStructures;

namespace VolumeProcessing
{
    public interface ITileGenerator<TReadInput> where TReadInput : ReadOutput
    {
        void Generate(TReadInput input) ;
    }
}
