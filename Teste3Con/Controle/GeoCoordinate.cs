using System;
using System.Collections.Generic;
using System.Text;

namespace Teste3Con.Controle
{
    public class GeoCoordinate : IEquatable<GeoCoordinate>
    {
        private double? latitude;
        private double? longitude;

        public GeoCoordinate(double? latitude, double? longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public bool Equals(GeoCoordinate other)
        {
            throw new NotImplementedException();
        }

        
    }
}
