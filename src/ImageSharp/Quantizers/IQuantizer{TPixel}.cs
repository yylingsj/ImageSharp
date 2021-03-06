﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.Dithering;
using SixLabors.ImageSharp.PixelFormats;

namespace SixLabors.ImageSharp.Quantizers
{
    /// <summary>
    /// Provides methods for for allowing quantization of images pixels with configurable dithering.
    /// </summary>
    /// <typeparam name="TPixel">The pixel format.</typeparam>
    public interface IQuantizer<TPixel> : IQuantizer
        where TPixel : struct, IPixel<TPixel>
    {
        /// <summary>
        /// Quantize an image and return the resulting output pixels.
        /// </summary>
        /// <param name="image">The image to quantize.</param>
        /// <param name="maxColors">The maximum number of colors to return.</param>
        /// <returns>
        /// A <see cref="T:QuantizedImage"/> representing a quantized version of the image pixels.
        /// </returns>
        QuantizedImage<TPixel> Quantize(ImageFrame<TPixel> image, int maxColors);
    }

    /// <summary>
    /// Provides methods for allowing quantization of images pixels with configurable dithering.
    /// </summary>
    public interface IQuantizer
    {
        /// <summary>
        /// Gets or sets a value indicating whether to apply dithering to the output image.
        /// </summary>
        bool Dither { get; set; }

        /// <summary>
        /// Gets or sets the dithering algorithm to apply to the output image.
        /// </summary>
        IErrorDiffuser DitherType { get; set; }
    }
}
