using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AstroPhysics.Astronomy
{
    class World : IAstroObject
    {
        private Stack<TreeNode<Planet>> planetStack;
        private Tree<Planet> planetTree;
        private TreeNode<Planet> _currentNode;
        private Rectangle formBounds;
        private Zoomer zoomer;

        public World(Tree<Planet> planetTree)
        {
            planetStack = new Stack<TreeNode<Planet>>();
            this.planetTree = planetTree;
            _currentNode = this.planetTree.Root;
            currentNode = _currentNode;
        }

        private TreeNode<Planet> currentNode
        {
            get
            {
                return _currentNode;
            }
            set
            {
                //the zoom ended
                _currentNode.Value.Enabled = false;
                foreach (TreeNode<Planet> child in _currentNode.Children)
                {
                    child.Value.Enabled = false;
                }

                _currentNode = value;

                _currentNode.Value.Enabled = true;
                foreach (TreeNode<Planet> child in _currentNode.Children)
                {
                    child.Value.Enabled = true;
                    child.Value.ImageScale = 1f;
                }
                _currentNode.Value.DistanceFromSun = 0; //this makes the planet to be in center
                _currentNode.Value.ImageScale = 2f;

                ScalePlanets();
            }
        }

        private IEnumerable<TreeNode<Planet>> EnabledPlanets
        {
            get
            {
                return planetTree.GetEnumeratorBFS().Where(node => node.Value.Enabled);
            }
        }

        private IEnumerable<TreeNode<Planet>> AllPlanets
        {
            get { return planetTree.GetEnumeratorBFS(); }
        }

        public Rectangle Bounds
        {
            get
            {
                return formBounds;
            }
            set
            {
                formBounds = value;
                ScalePlanets();
            }
        }

        public void Tick()
        {
            if (zoomer != null)
            {
                if (zoomer.Go())
                {

                }
                else
                {

                    zoomer = null;
                }
            }
            else
            {
                foreach (TreeNode<Planet> node in AllPlanets)
                {
                    node.Value.Tick();
                }

                CheckMouseInput();
            }
        }

        private void CheckMouseInput()
        {
            CheckMouseClick();
            CheckMouseScroll();
        }

        private void CheckMouseScroll()
        {
            float delta = Input.Mouse.Delta;
            foreach (TreeNode<Planet> node in EnabledPlanets)
            {
                if (delta > 0 && node.Value.IsMouseOver)
                {
                    planetStack.Push(currentNode);
                    currentNode = node;
                    zoomer = new Zoomer(100, new PointF(formBounds.Width / 2f, formBounds.Height / 2f), node.Value.Location);
                }
                else if (delta < 0 && node.Value.IsMouseOver && planetStack.Count > 0)
                {
                    currentNode = planetStack.Pop();
                }
            }
        }

        private void CheckMouseClick()
        {
            bool leftButtonPressed = Input.Mouse.GetButtonState(MouseButtons.Left);
            if (leftButtonPressed)
            {
                foreach (TreeNode<Planet> node in EnabledPlanets)
                {
                    if (node.Value.PlanetInfo.Visible)
                    {
                        node.Value.PlanetInfo.Visible = false;
                    }
                    else if (node.Value.IsMouseOver)
                    {
                        node.Value.PlanetInfo.Visible = true;
                    }
                }
            }
        }

        public void Draw(Graphics g)
        {
            //then the planets that are enabled
            foreach (TreeNode<Planet> node in EnabledPlanets)
            {
                node.Value.Draw(g);
            }

            //and then the visible planet infos 
            foreach (TreeNode<Planet> node in EnabledPlanets)
            {
                if (node.Value.PlanetInfo.Visible)
                {
                    node.Value.PlanetInfo.Draw(g);
                }
            }
        }

        public float SpeedModiffer
        {
            get { return EnabledPlanets.ToArray()[0].Value.SpeedModiffer; }
            set
            {
                foreach (TreeNode<Planet> node in AllPlanets)
                {
                    node.Value.SpeedModiffer = value;
                }
            }
        }

        public void RestartPosition()
        {
            foreach (TreeNode<Planet> node in AllPlanets)
            {
                node.Value.RestartPosition();
            }
        }

        private void ScalePlanets() //clean it
        {
            List<Planet> planets = new List<Planet>();
            planets.Add(currentNode.Value);
            planets.AddRange(currentNode.Children.Select(t => t.Value)); // MAGIC AND ONLY MAGIC
            float distanceFromSun = 0;
            float halfBound = (formBounds.Width < formBounds.Height ? formBounds.Width : formBounds.Height) / 2f; // the half bound witch is smaller used later for calculations
            float distanceFromSunPictures = (planets[0].Image.Width * planets[0].ImageScale) / 2f;
            for (int i = 1; i < planets.Count; i++)
            {
                distanceFromSunPictures += planets[i].Image.Width * planets[i].ImageScale;
            }

            float distanceBetweenPlanets = (halfBound - distanceFromSunPictures) / planets.Count - 1;

            foreach (Planet planet in planets)
            {
                planet.RotationCenter = new PointF(formBounds.Width / 2f, formBounds.Height / 2f);
            }

            for (int i = 1; i < planets.Count; i++)
            {
                distanceFromSun += (planets[i - 1].Image.Width * planets[i - 1].ImageScale) / 2f + distanceBetweenPlanets + (planets[i].Image.Width * planets[i].ImageScale) / 2f;
                planets[i].DistanceFromSun = distanceFromSun;
            }
        }
    }
}
