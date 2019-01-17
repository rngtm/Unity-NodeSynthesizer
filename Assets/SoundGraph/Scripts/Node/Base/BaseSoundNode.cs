using System;
using XNode;

namespace SoundNodeGraph
{
    [System.Serializable]
    public abstract class BaseSoundNode : XNode.Node
    {
        [Output] public BaseSoundNode OutputNode;

        public virtual double GetSoundValue(double time)
        {
            return -1;
        }

        // GetValue should be overridden to return a value for any specified output port
        public override object GetValue(XNode.NodePort port)
        {
            return this;
        }
    }
}