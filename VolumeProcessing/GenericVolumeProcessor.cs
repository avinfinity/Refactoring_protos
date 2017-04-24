using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolumeProcessing.DataStructures;

namespace VolumeProcessing
{
    public static class GenericVolumeProcessor
    {
        public static void Process<TReadOutput>(IVolumeReader<TReadOutput> reader, ITileGenerator<TReadOutput> tilegenerator) where TReadOutput : ReadOutput
        {
            tilegenerator.Generate(reader.Read());
            // plus some logic :) 
        }
    }
}