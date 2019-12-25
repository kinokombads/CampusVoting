using System;
using System.Drawing;
using System.Globalization;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace CampusVoting.PageHelpers
{
    public static class GridControlOption
    {
        public static void CustomDrawRowIndicator(GridControl gridControl, GridView gridView)
        {
            gridView.IndicatorWidth = 75;
            gridView.CustomDrawRowIndicator += (s, e) =>
            {
                if (!e.Info.IsRowIndicator) return;

                e.Appearance.Font = new Font("Tahoma", 11.75f, FontStyle.Regular);
                int argb = Int32.Parse("00F3F3F3", NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);
                e.Appearance.ForeColor = clr;

                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (Convert.ToInt32(e.RowHandle.ToString()) + 1).ToString();
                }

                //if u want colored
                //GridView view = s as GridView;
                //e.Handled = true;

                //e.Appearance.BackColor = view.FocusedRowHandle == e.RowHandle ? Color.Chocolate : Color.MediumSpringGreen;
                //e.Appearance.FillRectangle(e.Cache, new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 4, e.Bounds.Y - 4));
                //if (e.Info.ImageIndex < 0) return;
                //ImageCollection ic = e.Info.ImageCollection as ImageCollection;
                //Image indicator = ic.Images[e.Info.ImageIndex];
                //e.Cache.Paint.DrawImage(e.Cache.Graphics, indicator, new Rectangle(e.Bounds.X + 20, e.Bounds.Y + 6, indicator.Width, indicator.Height));

                //Graphics vvv = e.Cache.Graphics;

                //var rect = new Rectangle(e.Bounds.X + 20, e.Bounds.Y + 6, indicator.Width, indicator.Height);

                //e.Cache.Paint.DrawImage(vvv, indicator, rect);
            };
        }
    }
}
