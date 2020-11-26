using Hamnen.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hamnen.views
{
    class HarbourRegisterViewModel
    {
        public HarbourRegisterViewModel(List<BoatVeiwModel> boats, int nrRejected)
        {
            Boats = boats;
            NrRejected = nrRejected;
        }

        public List<BoatVeiwModel> Boats { get; }
        public int NrRejected { get; }
    }
}
