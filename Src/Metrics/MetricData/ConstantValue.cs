﻿
namespace Metrics.MetricData
{
    public static class ConstantValue
    {
        public static MetricValueProvider<T> Provider<T>(T value)
        {
            return new ConstantValueProvider<T>(value);
        }

        private sealed class ConstantValueProvider<T> : MetricValueProvider<T>
        {
            public ConstantValueProvider(T value)
            {
                this.Value = value;
            }

            public T Value { get; private set; }

            public T GetValue(bool resetMetric = false)
            {
                return this.Value;
            }

            public bool Merge(MetricValueProvider<T> other)
            {
                return false;
            }
        }
    }
}
