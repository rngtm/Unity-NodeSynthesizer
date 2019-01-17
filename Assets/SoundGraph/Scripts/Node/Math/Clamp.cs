namespace SoundNodeGraph.Math
{
    [System.Serializable]
    public class Clamp : BaseSoundNode
    {
        [Input(connectionType = ConnectionType.Override, backingValue = ShowBackingValue.Never)] 
        public BaseSoundNode In;
        public double InMin = -1f;
        public double InMax =  1f;
        
        public override double GetSoundValue(double time)
        {
            double inputValue = 0.0;
            BaseSoundNode input = GetInputValue<BaseSoundNode>(nameof(In), null);
            if (input != null)
            {
                inputValue = input.GetSoundValue(time);
            }
            if (inputValue < InMin)
            {
                return InMin;
            }
            else
            if (inputValue > InMax)
            {
                return InMax;
            }
            else
            {
                return inputValue;
            }
        }
    }
}