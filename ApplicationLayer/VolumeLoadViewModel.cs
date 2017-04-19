using BusinessLayer;
using CommonLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ApplicationLayer
{
    public class VolumeLoadViewModel
    {
        private readonly ObservableCollection<IVoxelData> _LoadedVolumes = new ObservableCollection<IVoxelData>();
        private readonly ICommand _LoadVolume;

        private readonly ICommand _ModifyVolume;

        //Get this model instance from container in real code !!
        private readonly VolumeModel _VolumeModel = new VolumeModel();

        public VolumeLoadViewModel()
        {
            _LoadedVolumes = new ObservableCollection<IVoxelData>();
            _LoadVolume = new RelayCommand<string>((fileName) =>
                {
                    var volume = _VolumeModel.Load(fileName);
                    _LoadedVolumes.Add(volume);
                });

            _ModifyVolume = new RelayCommand<string>((fileName) =>
            {
                foreach (var volume in _LoadedVolumes)
                {
                    volume.Name = "VolumeNameIsChanged";
                }
            });
        }

        public ObservableCollection<IVoxelData> Volumes
        {
            get { return _LoadedVolumes; }
        }

        public ICommand LoadVolume
        {
            get { return _LoadVolume; }
        }

        public ICommand ModifyVolume
        {
            get { return _ModifyVolume; }
        }
    }
}
