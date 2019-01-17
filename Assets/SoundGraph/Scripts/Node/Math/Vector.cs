namespace SoundNodeGraph.Math
{
    [System.Serializable]
    public class Vector : BaseSoundNode
    {
        public double Volume = -1;
        public override double GetSoundValue(double time)
        {
            return Volume;
        }
    }
}