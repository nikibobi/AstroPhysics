using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using AstroPhysics.Properties;

namespace AstroPhysics.ObjectEnergy
{
    /// <summary>
    /// Физичен материал/вещество
    /// </summary>
    class Material
    {
        //add materials here
        /// <summary>
        /// Злато
        /// </summary>
        public static Material Gold;
        /// <summary>
        /// Желязо
        /// </summary>
        public static Material Iron;
        /// <summary>
        /// Мед
        /// </summary>
        public static Material Copper;
        /// <summary>
        /// Сребро
        /// </summary>
        public static Material Silver;
        /// <summary>
        /// Олово
        /// </summary>
        public static Material Lead;

        private static List<Material> materials;

        //returns a random material
        public static Material GetRandom(Random random)
        {
            return materials[random.Next(materials.Count)];
        }

        static Material()
        {
            Gold = new Material(0.1932f, Color.FromArgb(255, 215, 101));
            Iron = new Material(0.0787f, Color.FromArgb(96, 96, 94));
            Copper = new Material(0.0896f, Color.FromArgb(213, 152, 121));
            Silver = new Material(0.1049f, Color.FromArgb(189, 189, 189));
            Lead = new Material(0.1136f, Color.FromArgb(109, 128, 134));
            materials = new List<Material>();
            materials.Add(Gold);
            materials.Add(Iron);
            materials.Add(Copper);
            materials.Add(Silver);
            materials.Add(Lead);
        }

        //maybe add image to it
        /// <summary>
        /// Създава материал
        /// </summary>
        /// <param name="density">Плътността на материала</param>
        /// <param name="color">Цвета синволиращ материала</param>
        public Material(float density, Color color)
        {
            this.Density = density;
            this.SolidBrush = new SolidBrush(color);
        }

        /// <summary>
        /// Плътността на този материал
        /// </summary>
        public float Density { get; private set; }
        /// <summary>
        /// Четка със цвят която може да се използва за рисуването на материала
        /// </summary>
        public SolidBrush SolidBrush { get; private set; }
    }
}
