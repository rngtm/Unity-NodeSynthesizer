namespace SoundNodeGraph.Math
{
    [System.Serializable]
    public class Multiply : BaseSoundNode
    {
        public double DefaultA = 1f;
        public double DefaultB = 1f;
        [Input(connectionType = ConnectionType.Override, backingValue = ShowBackingValue.Never)] public BaseSoundNode A;
        [Input(connectionType = ConnectionType.Override, backingValue = ShowBackingValue.Never)] public BaseSoundNode B;

        public override double GetSoundValue(double time)
        {
            var inputA = GetInputValue<BaseSoundNode>(nameof(A), null);
            double a = DefaultA;
            if (inputA != null)
            {
                a = inputA.GetSoundValue(time);
            }

            var inputB = GetInputValue<BaseSoundNode>(nameof(B), null);
            double b = DefaultB;
            if (inputB != null)
            {
                b = inputB.GetSoundValue(time);
            }

            return a * b;
        }
    }
}