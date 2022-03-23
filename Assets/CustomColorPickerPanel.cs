// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;
using UnityEngine;
    /// <summary>
    /// Example script to demonstrate adding buttons, sliders and a touchable gradient to control material values at runtime.
    /// </summary>
public class ColorPicker : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Any mesh within the ColorPicker UI that receives color changes")]
    private MeshRenderer[] PickerUIMeshes = null;

    private MeshRenderer targetObjectMesh = null;
    public MeshRenderer TargetObjectMesh
    {
        get => targetObjectMesh;
        set => targetObjectMesh = value;
    }
    private SpriteRenderer targetObjectSprite = null;
    public SpriteRenderer TargetObjectSprite
    {
        get => targetObjectSprite;
        set => targetObjectSprite = value;
    }
    private void Start()
    {
        this.gameObject.SetActive(false);
    }
}
