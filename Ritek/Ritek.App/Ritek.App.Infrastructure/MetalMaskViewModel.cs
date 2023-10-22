using System.Collections.Generic;
using System.ComponentModel;

namespace Ritek.App.Infrastructure
{
    public class MetalMaskViewModel
    {
        public List<SteelPlateViewModel> SteelPlateViewModels { get; set; }

        public List<ThicknessViewModel> ThicknessViewModel { get; set; }

        public List<DevelopmentViewModel> DevelopmentViewModel { get; set; }

        public List<LDIViewModel> LDIViewModel { get; set; }

    }
}