using System;
using System.Drawing;

namespace AstroPhysics.Astronomy
{
    class DateCounter : ITickable
    {
        private static readonly DateTime StartingTime = new DateTime(2000, 1, 1, 1, 1, 1, 1); //this is the inital date from where we start
        private TimeSpan timeAdded; //the increase of time every tick
        private DateTime date;
        private IAstroObject tickableObject;

        public event EventHandler DateChanged;

        private void OnDateChanged(EventArgs e)
        {
            EventHandler datechanged = DateChanged;
            if (datechanged != null)
                datechanged(this, e);
        }

        public DateCounter(TimeSpan timeAdded, IAstroObject tickableObject)
        {
            this.SpeedModiffer = 1f;
            this.timeAdded = timeAdded;
            this.tickableObject = tickableObject;
            this.date = StartingTime; //first we set the backing field
            this.Date = DateTime.Now; //then we set it again so we can change our object's position
        }

        public float SpeedModiffer { get; set; }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                SynchronizeTickableObject(value);
                this.date = value;
                OnDateChanged(EventArgs.Empty);
            }
        }

        public void Tick()
        {
            TimeSpan finalTimeAdded = new TimeSpan((long)(timeAdded.Ticks * SpeedModiffer));
            Date += finalTimeAdded;
        }

        public void Draw(Graphics g)
        {
            using (Font font = new Font("Comic Sans MS", 14f))
            using (SolidBrush brush = new SolidBrush(Color.WhiteSmoke))
            {
                g.DrawString(ToString(), font, brush, 16, 16);
            }
        }

        public override string ToString()
        {
            return Date.ToString("dd/MM/yyyy г.");
        }

        private void SynchronizeTickableObject(DateTime newDate)
        {
            DateTime oldDate = this.Date;  //first we save the old date
            DateTime currentTime = oldDate; //we have another datetime object witch we will change later on and use
            float objSpeedModiffer = tickableObject.SpeedModiffer; //we save the old speed modifer so we can change it back to normal later on

            if (newDate > oldDate) //if we go foreward in time
            {
                tickableObject.SpeedModiffer = 1; //set the speed modifer to normal
                do
                {
                    tickableObject.Tick();         //change object's position with Tick()
                    currentTime += timeAdded;      //change the counter
                } while (currentTime < newDate);   //untill we reach the destination date
            }
            else if (newDate < oldDate)
            {
                tickableObject.SpeedModiffer = -1;
                do
                {
                    tickableObject.Tick();
                    currentTime -= timeAdded;
                } while (currentTime > newDate);
            }
            tickableObject.SpeedModiffer = objSpeedModiffer; //we restore the speed modiffer
        }
    }
}
