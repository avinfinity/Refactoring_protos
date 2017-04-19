using CommonLayer;
using DataProcessingLayer;

namespace BusinessLayer
{
    public class VolumeModel
    {
        private VolumeDataProcessing _VolumeDataProcessing = new VolumeDataProcessing();

        public IVoxelData Load(string fileName)
        {
            //Some validations on file name

            //Some more validations on file data

            //Call data processing to process this file and get the output as Volume

            return _VolumeDataProcessing.ProcessVolumeData(fileName);
        }
    }
}