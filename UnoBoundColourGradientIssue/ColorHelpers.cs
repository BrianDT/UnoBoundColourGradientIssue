// <copyright file="ColorHelpers.cs" company="Visual Software Systems Ltd.">Copyright (c) 2016 All rights reserved</copyright>

namespace UnoBoundColourGradientIssue.Converters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Windows.UI;

#if WINDOWS_UWP || PORTABLE
    using Windows.UI.Xaml.Media;
#elif HAS_UNO || NET6_0 || NET7_0
    using Microsoft.UI.Xaml.Media;
#elif XAMARIN
    using Xamarin.Forms;
#endif

    public static class ColorHelpers
    {
        /// <summary>
        /// Converts a hex string to a color brush
        /// </summary>
        /// <param name="hexaColor">The hex string</param>
        /// <returns>The brush</returns>
        public static SolidColorBrush GetBrushFromHexa(string hexaColor)
        {
            return new SolidColorBrush(GetColorFromHexa(hexaColor));
        }

        /// <summary>
        /// Converts a hex string to a color brush
        /// </summary>
        /// <param name="hexaColor">The hex string</param>
        /// <returns>The brush</returns>
        public static Color GetColorFromHexa(string hexaColor)
        {
            return Color.FromArgb(
                System.Convert.ToByte(hexaColor.Substring(1, 2), 16),
                System.Convert.ToByte(hexaColor.Substring(3, 2), 16),
                System.Convert.ToByte(hexaColor.Substring(5, 2), 16),
                System.Convert.ToByte(hexaColor.Substring(7, 2), 16));
        }
    }
}
