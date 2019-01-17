namespace SoundNodeGraph.Output
{
    [System.Serializable]
    public class OutputMaster : XNode.Node
    {
        [Input(connectionType = ConnectionType.Override, backingValue = ShowBackingValue.Never)] 
        public BaseSoundNode OutputSound;

        protected override void Init()
        {
        }

        public double GetSoundValue(double time)
        {
            double result = 0;

            BaseSoundNode node = GetInputValue<BaseSoundNode>("OutputSound", null);
            if (node != null)
            {
                result = node.GetSoundValue(time);
            }

            return result;
        }
    }
}