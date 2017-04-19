using CommonLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessingLayer
{
    public class VolumeDataProcessing
    {
        public IVoxelData ProcessVolumeData(string fileName)
        {
            //Some processing with the file name
            //read volume data, convert if required, or not !!! :)

            return new Volume() { Name = "Volume", Width = 100, Height = 200, Depth = 400, Density = 1.0 };
        }
    }
}
