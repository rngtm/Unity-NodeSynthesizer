using System;
using XNode;

namespace SoundNodeGraph.Generator
{
    /// <summary>
    /// sine wave oscillator
    /// </summary>
    public class SineOsc : BaseSoundNode
    {
        public double DefaultAmp = 1;
        public double DefaultFreq = 440;
        public double DefaultPhase = 0;

        [Input(backingValue = ShowBackingValue.Never, connectionType = ConnectionType.Override)] 
        public BaseSoundNode AmpNode;
        [Input(backingValue = ShowBackingValue.Never, connectionType = ConnectionType.Override)] 
        public BaseSoundNode FreqNode;
        [Input(backingValue = ShowBackingValue.Never, connectionType = ConnectionType.Override)] 
        public BaseSoundNode PhaseNode;

        public override double GetSoundValue(double time)
        {
            BaseSoundNode freqInput = GetInputValue<BaseSoundNode>(nameof(FreqNode), null);
            BaseSoundNode ampInput = GetInputValue<BaseSoundNode>(nameof(AmpNode), null);
            BaseSoundNode phaseInput = GetInputValue<BaseSoundNode>(nameof(PhaseNode), null);
            double freq = DefaultFreq;
            double amp = DefaultAmp;
            double phase = DefaultPhase;

            if (freqInput != null)
                freq = freqInput.GetSoundValue(time);
            if (ampInput != null)
                amp = ampInput.GetSoundValue(time);
            if (phaseInput != null)
                phase = phaseInput.GetSoundValue(time);

            return System.Math.Sin(2f * System.Math.PI * freq * time + phase) * amp;
        }
    }
}