using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
