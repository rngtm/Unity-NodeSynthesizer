using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
using SoundNodeGraph.Output;

namespace SoundNodeGraph
{
    [CreateAssetMenu]
    public class SoundGraph : NodeGraph
    {
        public double GetSoundValue(double time)
        {
            double value = 0;
            var outputNode = GetOutputNode();
            if (outputNode != null)
            {
                value = outputNode.GetSoundValue(time);
            }
            return value;
        }

        private OutputMaster GetOutputNode()
        {
            OutputMaster result = null;
            foreach (var node in nodes)
            {
                result = node as OutputMaster;
                if (result != null)
                {
                    break;
                }
            }
            return result;
        }
    }
}