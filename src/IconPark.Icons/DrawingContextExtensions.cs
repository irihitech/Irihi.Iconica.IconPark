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
}