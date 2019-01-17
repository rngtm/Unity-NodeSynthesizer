namespace SoundNodeGraph.Math
{
    [System.Serializable]
    public class Remap : BaseSoundNode
    {
        [Input(connectionType = ConnectionType.Override, backingValue = ShowBackingValue.Never)] 
        public BaseSoundNode In;

        public double InMin = -1f;
        public double InMax =  1f;
        public double OutMin = 0f;
        public double OutMax = 1f;
        public override double GetSoundValue(double time)
        {
            BaseSoundNode input = GetInputValue<BaseSoundNode>(nameof(In), null);
            if (input == null)
            {
                return 0.0;
            }
            return (double)((input.GetSoundValue(time) - InMin) * (OutMax - OutMin) / (InMax - InMin) + OutMin);
        }
    }
}