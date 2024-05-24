using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "CustomMaterialProperties", menuName = "ScriptableObjects/Custom Material Properties")]

public class MaterialsCustom : ScriptableObject
{
    public Color mainColor;
    public Texture2D texture;
    public float brightness;
}
