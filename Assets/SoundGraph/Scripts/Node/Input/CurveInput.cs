namespace SoundNodeGraph.Input
{
    [System.Serializable]
    public class CurveInput : BaseSoundNode
    {
        public UnityEngine.AnimationCurve Curve = new UnityEngine.AnimationCurve(
            new UnityEngine.Keyframe(0f, 0f),
            new UnityEngine.Keyframe(1f, 1f)
        );
        
        public override double GetSoundValue(double time)
        {
            float t1 = Curve[0].time;
            float t2 = Curve[Curve.length - 1].time;
            time -= t1;
            time %= t2 - t1;
            time += t1;
            return Curve.Evaluate((float)time);
        }
    }
}