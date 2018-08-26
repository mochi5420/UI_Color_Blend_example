using UnityEngine;
using UnityEngine.UI;


public class CustomImage : Image
{
    public enum TYPE
    {
        ADDITIVE = 0,
        MULTIPLY = 1,
    }

    [SerializeField] private TYPE _blendType = TYPE.MULTIPLY;

    public override Color color
    {
        get
        {
            return new Color(base.color.r, base.color.g, base.color.b, (base.color.a + (int)_blendType) / 2.0f);
        }
        set { base.color = value; }
    }
}