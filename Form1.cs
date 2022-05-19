using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haversine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            //position 1 is the center of the circle - i.e. geofence center
            Position pos1 = new Position();
            pos1.Latitude = double.Parse(txtLat.Text);
            pos1.Longitude = double.Parse(txtLong.Text);

            Position pos2 = new Position();
            pos2.Latitude = double.Parse(txtQLat.Text);
            pos2.Longitude = double.Parse(txtQLong.Text); ;

            Haversine hv = new Haversine();
            double result = hv.Distance(pos1, pos2, DistanceType.Kilometers);

            //of the distance is higher than the radius - the point is outside of the geofence
            double redius = double.Parse(txtR.Text);
            if (result > redius)
            {
                lblResults.Text = "The query lat long are INSIDE the circular gefence";
                lblResults.ForeColor = Color.Green;
            }
            else
            {
                lblResults.Text = "The query lat long are OUTSIDE the circular gefence";
                lblResults.ForeColor = Color.Red;
            }

        }


    }

    /// <summary>
    /// The distance type to return the results in.
    /// </summary>
    public enum DistanceType { Miles, Kilometers, meters };
    /// <summary>
    /// Specifies a Latitude / Longitude point.
    /// </summary>
    public struct Position
    {
        public double Latitude;
        public double Longitude;
    }
    class Haversine
    {
        //read more here - https://en.wikipedia.org/wiki/Haversine_formula
        /// <summary>
        /// Returns the distance in miles or kilometers of any two
        /// latitude / longitude points.
        /// </summary>
        /// <param name=”pos1″></param>
        /// <param name=”pos2″></param>
        /// <param name=”type”></param>
        /// <returns></returns>
        public double Distance(Position pos1, Position pos2, DistanceType type)
        {
            double R = (type == DistanceType.Miles) ? 3960 : 6371;
            double dLat = this.toRadian(pos2.Latitude - pos1.Latitude);
            double dLon = this.toRadian(pos2.Longitude - pos1.Longitude);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(this.toRadian(pos1.Latitude)) * Math.Cos(this.toRadian(pos2.Latitude)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
            double d = R * c;
            return d;
        }
        /// <summary>
        /// Convert to Radians.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private double toRadian(double val)
        {
            return (Math.PI / 180) * val;
        }
    }


}
