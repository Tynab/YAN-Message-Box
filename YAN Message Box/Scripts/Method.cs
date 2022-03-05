using System.Drawing;
using System.Windows.Forms;

namespace YAN_Message_Box.Scripts
{
    internal class Method
    {
        #region Form Move
        //fields
        private static bool _moveFrm;
        private static Point _lastLoc;

        /// <summary>
        /// Focus control dùng để di chuyển form.
        /// </summary>
        internal static void MoveFrm_MouseDown(object sender, MouseEventArgs e)
        {
            _moveFrm = true;
            _lastLoc = e.Location;
        }

        /// <summary>
        /// Di chuyển control.
        /// </summary>
        internal static void MoveFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_moveFrm)
            {
                var frm = ((Control)sender).FindForm();
                frm.Location = new Point(frm.Location.X - _lastLoc.X + e.X, frm.Location.Y - _lastLoc.Y + e.Y);
                frm.Update();
            }
        }

        /// <summary>
        /// Kết thúc di chyển.
        /// </summary>
        internal static void MoveFrm_MouseUp(object sender, MouseEventArgs e) => _moveFrm = false;
        #endregion

        #region Common
        /// <summary>
        /// Tìm giá trị nhỏ nhất.
        /// </summary>
        /// <param name="list">Chuỗi dữ liệu so sánh.</param>
        /// <returns>Giá trị nhỏ nhất.</returns>
        internal static T Miner<T>(params T[] list)
        {
            dynamic res = list[0];
            foreach (var item in list)
            {
                if (item < res)
                {
                    res = item;
                }
            }
            return res;
        }

        /// <summary>
        /// Tìm giá trị lớn nhất.
        /// </summary>
        /// <param name="list">Chuỗi dữ liệu so sánh.</param>
        /// <returns>Giá trị lớn nhất.</returns>
        internal static T Maxer<T>(params T[] list)
        {
            dynamic res = list[0];
            foreach (var item in list)
            {
                if (item > res)
                {
                    res = item;
                }
            }
            return res;
        }
        #endregion
    }
}
