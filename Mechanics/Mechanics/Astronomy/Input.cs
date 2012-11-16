using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AstroPhysics.Astronomy
{
    static class Input
    {
        public static class Mouse
        {
            private static List<MouseButtons> mouseBuffer;//a buffer containing the pressed mouse buttons
            private static Queue<float> deltaBuffer;
            private static Point mousePosition;

            public static void Initialize(Form form)
            {
                mouseBuffer = new List<MouseButtons>();
                deltaBuffer = new Queue<float>();
                mousePosition = new Point();
                //attach mouse events
                form.MouseDown += FormMouseDown;
                form.MouseUp += FormMouseUp;
                form.MouseMove += FormMouseMove;
                form.MouseWheel += FormMouseWheel;
            }

            public static Point Position
            {
                get { return mousePosition; }
            }

            public static float Delta
            {
                get { return (deltaBuffer.Count > 0 ? deltaBuffer.Dequeue() : 0f); }
            }

            public static bool GetButtonState(MouseButtons button)
            {
                foreach (MouseButtons mouseButton in mouseBuffer)
                {
                    if (mouseButton == button)
                    {
                        mouseBuffer.Remove(button);
                        return true;
                    }
                }
                return false;
            }

            #region Mouse Event Handlers
            private static void FormMouseWheel(object sender, MouseEventArgs e)
            {
                deltaBuffer.Enqueue(e.Delta);
            }

            private static void FormMouseMove(object sender, MouseEventArgs e)
            {
                mousePosition = e.Location;
            }

            private static void FormMouseDown(object sender, MouseEventArgs e)
            {
                //if its in the buffer remove it and add it on top
                if (mouseBuffer.Contains(e.Button))
                {
                    mouseBuffer.Remove(e.Button);
                }
                mouseBuffer.Add(e.Button);
            }

            private static void FormMouseUp(object sender, MouseEventArgs e)
            {
                //remove the button if its in the buffer
                if (mouseBuffer.Contains(e.Button))
                {
                    mouseBuffer.Remove(e.Button);
                }
            }
            #endregion
        }
    }
}