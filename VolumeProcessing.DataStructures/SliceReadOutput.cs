using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;

namespace VolumeProcessing.DataStructures
{
    public class SliceReadOutput : ReadOutput
    {
        public double SlicePosition
        {
            get;
            set;
        }

        public double SliceDirection
        {
            get;
            set;
        }

        //blah blah some more data properties :) :)
    }
}