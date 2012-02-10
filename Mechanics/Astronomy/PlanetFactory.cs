using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AstroPhysics.Properties;

namespace AstroPhysics.Astronomy
{
    class PlanetFactory
    {
        private const float STATIC = 0; // for speed = 0
        private const float SCALE = 0.01f;
        private const bool COUNTERCLOCKWISE = false;
        private const bool CLOCKWISE = true;
        #region Sun Moons
        public static Planet MercuryPlanet
        {
            get
            {
                return new Planet(Resources.Mercury_, PlanetInfo.Mercury, 4.0923f, COUNTERCLOCKWISE);
            }
        }
        public static Planet VenusPlanet
        {
            get
            {
                return new Planet(Resources.Venus_, PlanetInfo.Venus, 1.6021f, COUNTERCLOCKWISE);
            }
        }
        public static Planet EarthPlanet
        {
            get
            {
                return new Planet(Resources.Earth_, PlanetInfo.Earth, 0.9856f, COUNTERCLOCKWISE);
            }
        }
        public static Planet MarsPlanet
        {
            get
            {
                return new Planet(Resources.Mars_, PlanetInfo.Mars, 0.5240f, COUNTERCLOCKWISE);
            }
        }
        public static Planet JupiterPlanet
        {
            get
            {
                return new Planet(Resources.Jupiter_, PlanetInfo.Jupiter, 0.0830f, COUNTERCLOCKWISE);
            }
        }
        public static Planet SaturnPlanet
        {
            get
            {
                return new Planet(Resources.Saturn_, PlanetInfo.Saturn, 0.0334f, COUNTERCLOCKWISE);
            }
        }
        public static Planet UranusPlanet
        {
            get
            {
                return new Planet(Resources.Uranus_, PlanetInfo.Uranus, 0.0117f, COUNTERCLOCKWISE);
            }
        }
        public static Planet NeptunePlanet
        {
            get
            {
                return new Planet(Resources.Neptune_, PlanetInfo.Neptune, 0.0059f, COUNTERCLOCKWISE);
            }
        }
        #endregion
        #region Earth moons
        public static Planet MoonPlanet
        {
            get
            {
                return new Planet(Resources.Moon_, PlanetInfo.Moon, 13.186f * SCALE, COUNTERCLOCKWISE);
            }
        }
        #endregion
        #region Mars moons
        public static Planet PhobosPlanet
        {
            get
            {
                return new Planet(Resources.Phobos_, PlanetInfo.Phobos, 12.5786f, COUNTERCLOCKWISE);
            }
        }
        public static Planet DeimosPlanet
        {
            get
            {
                return new Planet(Resources.Deimos_, PlanetInfo.Deimos, 3.1695f, COUNTERCLOCKWISE);
            }
        }
        #endregion
        #region Jupiter moons
        public static Planet IoPlanet
        {
            get
            {
                return new Planet(Resources.Io_, PlanetInfo.Io, 203.5048f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet EuropaPlanet
        {
            get
            {
                return new Planet(Resources.Europa_, PlanetInfo.Europa, 101.3770f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet GanymedePlanet
        {
            get
            {
                return new Planet(Resources.Ganymede_, PlanetInfo.Ganymede, 50.3179f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet CallistroPlanet
        {
            get
            {
                return new Planet(Resources.Callisto_, PlanetInfo.Callisto, 21.5710f * SCALE, COUNTERCLOCKWISE);
            }
        }
        #endregion
        #region Saturn moons
        public static Planet MimasPlanet
        {
            get
            {
                return new Planet(Resources.Mimas_, PlanetInfo.Mimas, 382.1656f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet EnceladusPlanet
        {
            get
            {
                return new Planet(Resources.Enceladus_, PlanetInfo.Enceladus, 262.773f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet TethysPlanet
        {
            get
            {
                return new Planet(Resources.Tethys_, PlanetInfo.Tethys, 190.7790f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet DionePlanet
        {
            get
            {
                return new Planet(Resources.Dione_, PlanetInfo.Dione, 131.53567f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet RheaPlanet
        {
            get
            {
                return new Planet(Resources.Rhea_, PlanetInfo.Rhea, 79.681f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet TitanPlanet
        {
            get
            {
                return new Planet(Resources.Titan_, PlanetInfo.Titan, 22.5776f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet HyperionPlanet
        {
            get
            {
                return new Planet(Resources.Hyperion_, PlanetInfo.Hyperion, 16.9204f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet IapetusPlanet
        {
            get
            {
                return new Planet(Resources.Iapetus_, PlanetInfo.Iapetus, 4.538f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet PhoebePlanet
        {
            get
            {
                return new Planet(Resources.Phoebe_, PlanetInfo.Phoebe, 0.6538f * SCALE, COUNTERCLOCKWISE);
            }
        }
        #endregion
        #region Uranus moons
        //public static Planet PuckPlanet
        //{
        //    get
        //    {
        //        return new Planet("Пък", Resources.Ball, 1, COUNTERCLOCKWISE);
        //    }
        //}
        public static Planet MirandaPlanet
        {
            get
            {
                return new Planet(Resources.Miranda_, PlanetInfo.Miranda, 254.7049f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet ArielPlanet
        {
            get
            {
                return new Planet(Resources.Ariel_, PlanetInfo.Ariel, 142.8361f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet UmbrielPlanet
        {
            get
            {
                return new Planet(Resources.Umbriel_, PlanetInfo.Umbriel, 86.8690f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet TitaniaPlanet
        {
            get
            {
                return new Planet(Resources.Titania_, PlanetInfo.Titania, 41.3514f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet OberonPlanet
        {
            get
            {
                return new Planet(Resources.Oberon_, PlanetInfo.Oberon, 26.7395f * SCALE, COUNTERCLOCKWISE);
            }
        }
        #endregion
        #region Neptune moons
        public static Planet ProteusPlanet
        {
            get
            {
                return new Planet(Resources.Proteus_, PlanetInfo.Proteus, 320.7698f * SCALE, COUNTERCLOCKWISE);
            }
        }
        public static Planet TritonPlanet
        {
            get
            {
                return new Planet(Resources.Triton_, PlanetInfo.Triton, 61.255f * SCALE, CLOCKWISE);
            }
        }
        public static Planet NereidPlanet
        {
            get
            {
                return new Planet(Resources.Nereid_, PlanetInfo.Nereid, 0.9996f * SCALE, COUNTERCLOCKWISE);
            }
        }
        #endregion
        #region Center planets
        public static Planet SunCenter
        {
            get
            {
                return new Planet(Resources.Sun_, PlanetInfo.Sun, STATIC, CLOCKWISE);
            }
        }
        public static Planet MercuryCenter
        {
            get
            {
                return new Planet(Resources.mercury, PlanetInfo.Mercury, STATIC, CLOCKWISE);
            }
        }
        public static Planet VenusCenter
        {
            get
            {
                return new Planet(Resources.venus, PlanetInfo.Venus, STATIC, CLOCKWISE);
            }
        }
        public static Planet EarthCenter
        {
            get
            {
                return new Planet(Resources.earth, PlanetInfo.Earth, STATIC, CLOCKWISE);
            }
        }
        public static Planet MarsCenter
        {
            get
            {
                return new Planet(Resources.mars, PlanetInfo.Mars, STATIC, CLOCKWISE);
            }
        }
        public static Planet JupiterCenter
        {
            get
            {
                return new Planet(Resources.jupiter, PlanetInfo.Jupiter, STATIC, CLOCKWISE);
            }
        }
        public static Planet SaturnCenter
        {
            get
            {
                return new Planet(Resources.saturn, PlanetInfo.Saturn, STATIC, CLOCKWISE);
            }
        }
        public static Planet UranusCenter
        {
            get
            {
                return new Planet(Resources.uranus, PlanetInfo.Uranus, STATIC, CLOCKWISE);
            }
        }
        public static Planet NeptuneCneter
        {
            get
            {
                return new Planet(Resources.neptune, PlanetInfo.Neptune, STATIC, CLOCKWISE);
            }
        }
        #endregion
    }
}
