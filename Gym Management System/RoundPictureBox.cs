using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPictureBox : PictureBox
{
    public int BorderRadius { get; set; } = 20;

    public RoundedPictureBox()
    {
        // Set the default border radius here or leave it for customization later
        BorderRadius = 80; // For example, increase the radius to make it more rounded
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        UpdateRegion();
    }

    private void UpdateRegion()
    {
        using (GraphicsPath gp = new GraphicsPath())
        {
            int radius = BorderRadius;
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            gp.CloseFigure();
            this.Region = new Region(gp);
        }
    }
}
