using System;

namespace CommonLayer
{
    public interface IVoxelData
    {
        string Name { get; set; }

        double Height { get; }

        double Width { get; }

        double Depth { get; }

        double Density { get; set; }

        IntPtr DataPointer { get; }
    }
}