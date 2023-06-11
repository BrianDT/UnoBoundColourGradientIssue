// <copyright file="ColourConverter.cs" company="Visual Software Systems Ltd.">Copyright (c) 2016 - 2023 All rights reserved</copyright>

namespace UnoBoundColourGradientIssue.Converters
{
    using System;

    using Microsoft.UI.Xaml;
    using Microsoft.UI.Xaml.Data;

    /// <summary>
    /// Value converter that translates an integer index into a colour
    /// </summary>
    public class ColourConverter : IValueConverter
    {
        /// <summary>
        /// Converts boolean to Visibility
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="targetType">The target type of the conversion</param>
        /// <param name="parameter">Any optional parameter</param>
        /// <param name="language">The language</param>
        /// <returns>The converted value</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string mode = null;
            if (parameter != null)
            {
                mode = parameter as string;
            }

            int inputValue = 0;
            if (value is int)
            {
                inputValue = (int)value;
            }

            string hexValueAsTstring = "#FF11DD11";
            switch (inputValue)
            {
                default:
                case 0:
                    switch (mode)
                    {
                        default:
                        case "B":
                            break;

                        case "C":
                            hexValueAsTstring = "#FF113311";
                            break;
                    }

                    break;

                case 1:
                    switch (mode)
                    {
                        default:
                        case "B":
                            hexValueAsTstring = "#FFDD1111";
                            break;

                        case "C":
                            hexValueAsTstring = "#FF331111";
                            break;
                    }

                    break;
            }

            return ColorHelpers.GetColorFromHexa(hexValueAsTstring);
        }

        /// <summary>
        /// Converts Visibility to boolean
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="targetType">The target type of the conversion</param>
        /// <param name="parameter">Any optional parameter</param>
        /// <param name="language">The language</param>
        /// <returns>The converted value</returns>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
