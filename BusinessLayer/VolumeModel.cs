using CommonLayer;
using DataProcessingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class VolumeModel
    {
        VolumeDataProcessing _VolumeDataProcessing = new VolumeDataProcessing();
       
        public IVoxelData Load(string fileName)
        {
            //Some validations on file name

            //Some more validations on file data

            //Call data processing to process this file and get the output as Volume

            return _VolumeDataProcessing.ProcessVolumeData(fileName);
        }
    }
}
