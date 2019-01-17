using System;
using XNode;

namespace SoundNodeGraph.Generator
{
    // [NodeWidth(180)]
    public class SineOsc : BaseSoundNode
    {
        public double DefaultAmp = 1f;
        public double DefaultFreq = 440f;

        [Input(backingValue = ShowBackingValue.Never, connectionType = ConnectionType.Override)] 
        public BaseSoundNode AmpNode;
        [Input(backingValue = ShowBackingValue.Never, connectionType = ConnectionType.Override)] 
        public BaseSoundNode FreqNode;
        
        protected override void Init()
        {
        }

        public override double GetSoundValue(double time)
        {
            BaseSoundNode freqInput = GetInputValue(nameof(FreqNode), FreqNode);
            BaseSoundNode ampInput = GetInputValue(nameof(AmpNode), AmpNode);

            double freq = freqInput != null ? freqInput.GetSoundValue(time) : DefaultFreq;
            double amp = ampInput != null ? ampInput.GetSoundValue(time) : DefaultAmp;

            double phase = (freq * time) % 1.0;
            return (double)(System.Math.Sin(2f * System.Math.PI * (double)phase) * amp);
        }
    }
}