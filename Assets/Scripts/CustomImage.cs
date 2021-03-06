﻿using UnityEngine;
using UnityEngine.UI;


public class CustomImage : Image
{
    public enum BlendType
    {
        ADDITIVE = 0,
        MULTIPLY = 1,
    }

    [SerializeField] private BlendType _blendType = BlendType.MULTIPLY;

    public override Color color
    {
        get
        {
            // 加算の場合はアルファ値を0.0 ~ 0.5, 乗算の場合は0.5 ~ 1.0になるように変換をかける
            return new Color(base.color.r, base.color.g, base.color.b, (base.color.a + (int)_blendType) / 2.0f);
        }
        set { base.color = value; }
    }
}