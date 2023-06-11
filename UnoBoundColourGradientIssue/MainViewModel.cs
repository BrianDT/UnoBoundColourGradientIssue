// <copyright file="MainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2023 All rights reserved</copyright>

namespace UnoBoundColourGradientIssue
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The main view model.
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The colour index
        /// </summary>
        private int colourIndex;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the colour index
        /// </summary>
        public int ColourIndex
        {
            get
            {
                return this.colourIndex;
            }

            set
            {
                if (value != this.colourIndex)
                {
                    if (value < 0 || value > 1)
                    {
                        value = 0;
                    }

                    this.colourIndex = value;
                    this.OnPropertyChanged("ColourIndex");
                }
            }
        }

        /// <summary>
        /// Flip the colour inder between 1 and 0.
        /// </summary>
        public void FlipContext()
        {
            this.ColourIndex = this.ColourIndex == 0 ? 1 : 0;
        }

        /// <summary>
        /// Called when a property value has changed
        /// </summary>
        /// <param name="propertyName">The name of the property that changed</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
             this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
