﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBPMFinder
{
    public class MaxDifferenceFTDeltaCalculator : AbstractFTDeltaCalculator
    {

        public MaxDifferenceFTDeltaCalculator(int minimumFrequency, int maximumFrequency, bool correctFrequencies)
            : base(minimumFrequency, maximumFrequency, correctFrequencies)
        {
            this.correctFrequencies = correctFrequencies;
        }

        protected override float deltaInternal(float a, float b, float acc, int frequency)
        {
            float value = b - a;
            if (value > acc)
                return value;

            return acc;
        }
    }
}
