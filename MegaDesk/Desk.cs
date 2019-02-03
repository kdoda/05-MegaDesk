using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    {
        /// <summary>
        /// An enumm that holds the surface material and the price
        /// </summary>
        public enum SurfaceMaterial
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        };

        public int Width  { get; set; }
        public int Depth  { get; set; }
        public int NrDrawers { get; set; }
        public SurfaceMaterial Material { get; set; }
        public int SurfaceMaterialPrice => (int)Material;
        public int SurfaceArea => Width * Depth;

        public static string CSVHeader()
        {
            return "Width,Depth,NrDrawers,Material";
        }

        public override string ToString()
        {
            return $"{Width},{Depth},{NrDrawers},{Material.ToString()}";
        }
    }
}
