using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using AstroPhysics.Properties;

namespace AstroPhysics.Astronomy
{
    partial class StarSystem
    {
        private static readonly Image BACKGROUND = Resources.Space;

        public static Stack<StarSystem> SystemsStack = new Stack<StarSystem>();

        public static StarSystem MercurySystem = new StarSystem("Mercury System", PlanetFactory.MercuryCenter, BACKGROUND);

        public static StarSystem VenusSystem = new StarSystem("Venus System", PlanetFactory.VenusCenter, BACKGROUND);

        public static StarSystem EarthSystem = new StarSystem("Earth System", PlanetFactory.EarthCenter, BACKGROUND)
            .AddPlanet(
            PlanetFactory.MoonPlanet
            );

        public static StarSystem MarsSystem = new StarSystem("Mars System", PlanetFactory.MarsCenter, BACKGROUND)
            .AddPlanet(
            PlanetFactory.PhobosPlanet,
            PlanetFactory.DeimosPlanet
            );

        public static StarSystem JupiterSystem = new StarSystem("Jupiter System", PlanetFactory.JupiterCenter, BACKGROUND)
            .AddPlanet(
            PlanetFactory.IoPlanet,
            PlanetFactory.EuropaPlanet,
            PlanetFactory.GanymedePlanet,
            PlanetFactory.CallistroPlanet
            );

        public static StarSystem SaturnSystem = new StarSystem("Saturn System", PlanetFactory.SaturnCenter, BACKGROUND)
            .AddPlanet(
            PlanetFactory.MimasPlanet,
            PlanetFactory.EnceladusPlanet,
            PlanetFactory.TethysPlanet,
            PlanetFactory.DionePlanet,
            PlanetFactory.RheaPlanet,
            PlanetFactory.TitanPlanet,
            PlanetFactory.HyperionPlanet,
            PlanetFactory.IapetusPlanet,
            PlanetFactory.PhoebePlanet
            );

        public static StarSystem UranusSystem = new StarSystem("Uranus System", PlanetFactory.UranusCenter, BACKGROUND)
            .AddPlanet(
            //PlanetFactory.PuckPlanet,
            PlanetFactory.MirandaPlanet,
            PlanetFactory.ArielPlanet,
            PlanetFactory.UmbrielPlanet,
            PlanetFactory.TitaniaPlanet,
            PlanetFactory.OberonPlanet
            );

        public static StarSystem NeptuneSystem = new StarSystem("Neptune System", PlanetFactory.NeptuneCneter, BACKGROUND)
            .AddPlanet(
            PlanetFactory.ProteusPlanet,
            PlanetFactory.TritonPlanet,
            PlanetFactory.NereidPlanet
            );

        public static StarSystem SunSolarSystem = new StarSystem("Solar System", PlanetFactory.SunCenter, BACKGROUND)
            .AddPlanet(
            PlanetFactory.MercuryPlanet.SetChild(MercurySystem),
            PlanetFactory.VenusPlanet.SetChild(VenusSystem),
            PlanetFactory.EarthPlanet.SetChild(EarthSystem),
            PlanetFactory.MarsPlanet.SetChild(MarsSystem),
            PlanetFactory.JupiterPlanet.SetChild(JupiterSystem),
            PlanetFactory.SaturnPlanet.SetChild(SaturnSystem),
            PlanetFactory.UranusPlanet.SetChild(UranusSystem),
            PlanetFactory.NeptunePlanet.SetChild(NeptuneSystem)
            );
    }
}
