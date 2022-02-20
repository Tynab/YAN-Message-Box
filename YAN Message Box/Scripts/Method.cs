using System.Drawing;
using System.Windows.Forms;

namespace YAN_Message_Box.Scripts
{
    internal class Method
    {
        #region Form Move
        //fields
        private static bool _moveFrm;
        private static Point _lastLocation;

        /// <summary>
        /// Focus the control used move form.
        /// </summary>
        internal static void MoveFrm_MouseDown(object sender, MouseEventArgs e)
        {
            _moveFrm = true;
            _lastLocation = e.Location;
        }

        /// <summary>
        /// Moving the control.
        /// </summary>
        internal static void MoveFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_moveFrm)
            {
                var frm = ((Control)sender).FindForm();
                frm.Location = new Point(frm.Location.X - _lastLocation.X + e.X, frm.Location.Y - _lastLocation.Y + e.Y);
                frm.Update();
            }
        }

        /// <summary>
        /// Finish move.
        /// </summary>
        internal static void MoveFrm_MouseUp(object sender, MouseEventArgs e) => _moveFrm = false;
        #endregion

        #region Common
        /// <summary>
        /// Find min value.
        /// </summary>
        /// <param name="val">Current value.</param>
        /// <param name="lim">Check value.</param>
        internal static void Miner(ref int val, int lim)
        {
            if (val > lim)
            {
                val = lim;
            }
        }

        /// <summary>
        /// Find max value.
        /// </summary>
        /// <param name="val">Current value.</param>
        /// <param name="lim">Check value.</param>
        internal static void Maxer(ref int val, int lim)
        {
            if (val < lim)
            {
                val = lim;
            }
        }
        #endregion
    }
}
