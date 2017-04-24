using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolumeProcessing.DataStructures;
using VolumeProcessing;

namespace Proto_Application
{
    class ApplicationLayer
    {
        //IDictionary<IVolumeReader, ITileGenerator> _AIDictionary = new Dictionary<IVolumeReader, ITileGenerator>();
        //VolumeProcessing.VolumeProcessing _Processing = new VolumeProcessing.VolumeProcessing();

        public ApplicationLayer()
        {
            ////Use MEF or our exports builder concepts to populate this
            //_AIDictionary.Add(new SliceReader(), new SliceTileGenerator());
            //_AIDictionary.Add(new BlockReader(), new BlockTileGenerator());
        }

        public void ProcessSliceWise()
        {
            //These instances would come from configurations/containers !!
            //As of now they are craeted here just to make code more clear
            var sliceReader = new SliceReader();
            var generator = new SliceTileGenerator();

            GenericVolumeProcessor.Process(sliceReader, generator);

            Console.WriteLine("Processed volume with Slice reader and tile generator");
        }

        public void ProcessBlockWise()
        {
            //These instances would come from configurations/containers !!
            //As of now they are craeted here just to make code more clear
            var blockReader = new BlockReader();
            var generator = new BlockTileGenerator();

            GenericVolumeProcessor.Process(blockReader, generator);

            Console.WriteLine("Processed volume with block reader and tile generator");

        }

        static void Main()
        {
            ApplicationLayer aAI = new ApplicationLayer();

            while(true)
            {
                Console.WriteLine("Write 'Slice' or 'Block' for processing to start");
                Console.WriteLine("Press 'space' to terminate the program");

                var input  = Console.ReadLine();

                if(input.Trim() == string.Empty)
                {
                    return;
                }

                if(input.Equals("Slice", StringComparison.OrdinalIgnoreCase))
                {
                    aAI.ProcessSliceWise();
                }

                else if (input.Equals("Block", StringComparison.OrdinalIgnoreCase))
                {
                    aAI.ProcessBlockWise();
                }
            }
        }
    }
}