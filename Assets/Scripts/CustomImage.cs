using UnityEngine;
using UnityEngine.UI;


public class CustomImage : Image
{
    public enum TYPE
    {
        ADDITIVE = 0,
        MULTIPLE = 1,
    }

    [SerializeField] private TYPE _colorType = TYPE.MULTIPLE;

    public override Color color
    {
        get
        {
            return new Color(base.color.r, base.color.g, base.color.b, (base.color.a + (int)_colorType) / 2.0f);
        }
        set { base.color = value; }
    }
}