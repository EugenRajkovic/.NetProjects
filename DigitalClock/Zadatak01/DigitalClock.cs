using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak01
{
    public partial class DigitalClock : UserControl
    {
        public bool ShowHundreds { get; set; }

        private Color backgroundColor;
        public Color BackgroundColor {
            get
            {
                return this.backgroundColor;
            }
            set
            {
                this.BackColor = value;
                this.backgroundColor = value;
            }
        }


        private Color numbersColor;
        private const string PUNO_VRIJEME = "{0}:{1}:{2}:{3}";
        private const string SKRACENO_VRIJEME = "{0}:{1}:{2}";

        public Color NumbersColor
        {
            get
            {
                return this.lblClock.ForeColor;
            }
            set
            {
                lblClock.ForeColor = value;
                this.numbersColor = value;
            }
        }


        public DigitalClock()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var hours = DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour : DateTime.Now.Hour.ToString();
            var minutes = DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute : DateTime.Now.Minute.ToString();
            var seconds = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second : DateTime.Now.Second.ToString();

            if (ShowHundreds)
            {
                var hundreds = DateTime.Now.Millisecond/10 < 10 ? "0" + DateTime.Now.Millisecond / 10 : (DateTime.Now.Millisecond / 10).ToString();

                lblClock.Text = string.Format(PUNO_VRIJEME, hours, minutes, seconds, hundreds);
            }

            else
            {
                lblClock.Text = string.Format(SKRACENO_VRIJEME, hours, minutes, seconds);
            }
        }
    }
}
