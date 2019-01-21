using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoundNodeGraph
{
    [RequireComponent(typeof(AudioSource))]
    public class SoundGraphPlayer : MonoBehaviour
    {
        [SerializeField] SoundGraph _graph;
        const int maxAudioPos = 48000 * 120;
        int audioPos = 0;
        public const double fs = 48000; // sample frequency
        System.Random rand;
        [SerializeField] double previewValue;

        void Start()
        {
            rand = new System.Random();
        }

        void OnAudioFilterRead(float[] data, int channels)
        {
            int dst = 0;
            while (dst < data.Length)
            {
                double audioTime = audioPos / fs;
                audioPos++;
                float sound = (float)_graph.GetSoundValue(audioTime);
                for (int i = 0; i < channels; i++)
                {
                    data[dst++] = sound;
                }
                previewValue = sound;
            }

            if (audioPos >= maxAudioPos)
            {
                audioPos -= maxAudioPos;
            }
        }
    }
}

