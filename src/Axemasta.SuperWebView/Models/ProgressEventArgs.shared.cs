﻿using System;
namespace Axemasta.SuperWebView
{
    /// <summary>
    /// Progress Event Args
    /// </summary>
    public class ProgressEventArgs : EventArgs
    {
        /// <summary>
        /// Progress Complete Normalized Between 0 & 1
        /// </summary>
        public double NormalisedProgress { get; }

        /// <summary>
        /// Percentage Complete
        /// </summary>
        public double PercentageComplete { get; }

        public ProgressEventArgs(double progress, int maximum)
        {
            NormalisedProgress = progress / maximum * 100;

            PercentageComplete = Math.Round(NormalisedProgress, 2);
        }
    }
}
