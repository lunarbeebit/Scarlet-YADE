namespace Scarlet.Drawing.PaletteCodecs;

internal static class PaletteCodecFactory
{
    /// <summary>
    ///     Returns a palette codec for the specified format.
    /// </summary>
    /// <param name="format"></param>
    /// <returns>The palette codec, or <see langword="null" /> if one does not exist.</returns>
    public static PaletteCodec? Create(PixelDataFormat format)
    {
        return format switch
        {
            PixelDataFormat.FormatRgb565 => new Rgb565PaletteCodec(),
            PixelDataFormat.FormatAbgr1555 => new Rgba5551PaletteCodec(),
            PixelDataFormat.FormatAbgr4444 => new Rgba4444PaletteCodec(),
            PixelDataFormat.FormatArgb8888 => new Rgba8888PaletteCodec(),
            _ => null
        };
    }
}