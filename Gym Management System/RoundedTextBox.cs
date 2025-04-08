using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBox : TextBox
{
    public int BorderRadius { get; set; } = 20; // Set default border radius

    public RoundedTextBox()
    {
        // Set default border radius here or customize it later
        BorderRadius = 20;
        this.BorderStyle = BorderStyle.None; // Remove default border
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
            gp.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            gp.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            gp.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            gp.AddArc(0, this.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            gp.CloseFigure();

            this.Region = new Region(gp); // Set the region to round the edges
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // Optional: Draw border with a custom color
        using (Pen pen = new Pen(Color.Gray))
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, new GraphicsPath()); // Optional: Draw border for the rounded TextBox
        }
    }
}
