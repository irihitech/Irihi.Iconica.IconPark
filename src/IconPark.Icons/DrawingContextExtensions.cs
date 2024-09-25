using Avalonia;
using Avalonia.Media;

namespace IconPark.Icons;

public static class DrawingContextExtensions
{
    public static void DrawPathElement(this DrawingContext context, PathDrawingElement element, IBrush? brush, IPen? pen)
    {
        if (element.Data is null)
        {
            return;
        }

        if (element.Transform is not null)
        {
            using (context.PushTransform(element.Transform.Value))
            {
                context.DrawGeometry(brush, pen, element.Data);
            }
        }
        else
        {
            context.DrawGeometry(brush, pen, element.Data);
        }
    }
    
    public static void DrawEllipseElement(this DrawingContext context, EllipseDrawingElement element, IBrush? brush, IPen? pen)
    {
        if(element.Transform is not null)
        {
            using (context.PushTransform(element.Transform.Value))
            {
                context.DrawEllipse(brush, pen, new Avalonia.Point(element.X, element.Y), element.RadiusX, element.RadiusY);
            }
        }
        else
        {
            context.DrawEllipse(brush, pen, new Avalonia.Point(element.X, element.Y), element.RadiusX, element.RadiusY);
        }
    }
    
    public static void DrawLineElement(this DrawingContext context, LineDrawingElement element, IPen pen)
    {
        if (element.Transform is not null)
        {
            using (context.PushTransform(element.Transform.Value))
            {
                context.DrawLine(pen, new Avalonia.Point(element.X1, element.Y1), new Avalonia.Point(element.X2, element.Y2));
            }
        }
        else
        {
            context.DrawLine(pen, new Avalonia.Point(element.X1, element.Y1), new Avalonia.Point(element.X2, element.Y2));
        }
    }
    
    public static void DrawRectElement(this DrawingContext context, RectDrawingElement element, IBrush? brush, IPen? pen)
    {
        var rect = new Rect(element.X, element.Y, element.Width, element.Height);
        if (element.Transform is not null)
        {
            using (context.PushTransform(element.Transform.Value))
            {
                context.DrawRectangle(brush, pen, rect, element.Rx ?? 0, element.Ry ?? 0);
            }
        }
        else
        {
            context.DrawRectangle(brush, pen, rect, element.Rx ?? 0, element.Ry ?? 0);
        }
    }
}