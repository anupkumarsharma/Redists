﻿using Redists.Configuration;
using System;
using Xunit;

namespace Redists.Test.Configuration
{
    public class TimeSeriesOptionsTests
    {
        [Fact]
        public void Ctor_BadArgs_ShouldThrowException()
        {
            // key factor vs dataPoint factor 
            Assert.Throws<InvalidOperationException>(() => { TimeSeriesOptions options = new TimeSeriesOptions(100, 200, false, TimeSpan.MaxValue); });

            // ttl value vs key factor 
            Assert.Throws<InvalidOperationException>(() => { TimeSeriesOptions options = new TimeSeriesOptions(200, 100, false, TimeSpan.MinValue); });
        }

        [Fact]
        public void Ctor_ShouldPass()
        {
            TimeSeriesOptions options = new TimeSeriesOptions(200, 100, false, TimeSpan.MaxValue);
        }
    }
}