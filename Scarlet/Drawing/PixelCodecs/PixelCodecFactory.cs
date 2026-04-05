#nullable enable
namespace Scarlet.Drawing.PixelCodecs;

internal static class PixelCodecFactory
{
    /// <summary>
    ///     Returns a pixel codec for the specified format.
    /// </summary>
    /// <param name="format"></param>
    /// <returns>The pixel codec, or <see langword="null" /> if one does not exist.</returns>
    public static PixelCodec? Create(PixelDataFormat format)
    {
        return format switch
        {
            PixelDataFormat.FormatRgb565 => new Rgb565PixelCodec(),
            PixelDataFormat.FormatRgba5551 => new Rgba5551PixelCodec(),
            PixelDataFormat.FormatRgba4444 => new Rgba4444PixelCodec(),
            PixelDataFormat.FormatArgb8888 => new Rgba8888PixelCodec(),
            PixelDataFormat.FormatIndexed4 => new Index4PixelCodec(),
            PixelDataFormat.FormatIndexed8 => new Index8PixelCodec(),
            PixelDataFormat.FormatDXT1Rgba or PixelDataFormat.SpecialFormatDXT1 => new Dxt1PixelCodec(),
            PixelDataFormat.FormatDXT3 or PixelDataFormat.SpecialFormatDXT3 => new Dxt3PixelCodec(),
            PixelDataFormat.FormatDXT5 or PixelDataFormat.SpecialFormatDXT5 => new Dxt5PixelCodec(),
            _ => null
        };
    }
}