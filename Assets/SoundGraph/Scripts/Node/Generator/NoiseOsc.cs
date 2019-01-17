using System;

namespace SoundNodeGraph.Generator
{
    [System.Serializable]
    public class NoiseOsc : BaseSoundNode
    {
        public double Interval = 0.1;
        Random _random;
        int _interval = 48000 / 4;
        int _counter = 0;
        double _soundValue = 0.0;
        protected override void Init()
        {
            _random = new Random();
            _soundValue = NoiseValue();
        }

        double NoiseValue()
        {
            return (double)_random.NextDouble() * 2 - 1;
        }

        public override double GetSoundValue(double time)
        {
            _counter++;
            if (_counter / SoundGraphPlayer.fs >= Interval * 2)
            {
                _soundValue = NoiseValue();
                _counter = 0;
            }
            return _soundValue;
        }
    }
}