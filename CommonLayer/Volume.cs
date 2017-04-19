using PropertyChanged;
using System;
using System.Runtime.Serialization;

namespace CommonLayer
{
    [DataContract]
    [ImplementPropertyChanged]
    public class Volume : IVoxelData
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public double Width { get; set; }

        [DataMember]
        public double Height { get; set; }

        [DataMember]
        public double Depth { get; set; }

        [DataMember]
        public double Density { get; set; }

        [DataMember]
        public IntPtr DataPointer { get; set; }
    }
}