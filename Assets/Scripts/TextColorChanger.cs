using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class TextColorChanger : MonoBehaviour
{
    public TextMeshPro[] textObjects;
    public Color blackColor;
    public Color purpleColor;
    public Color whiteColor;

    public void ChangeToBlack()
    {
        ChangeColor(blackColor);
    }

    public void ChangeToPurple()
    {
        ChangeColor(purpleColor);
    }

    public void ChangeToWhite()
    {
        ChangeColor(whiteColor);
    }

    private void ChangeColor(Color newColor)
    {
        foreach (TextMeshPro text in textObjects)
        {
            text.faceColor = newColor;
            text.outlineColor = newColor;

            // Force an update to the mesh AND the text object
            text.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);
            text.ForceMeshUpdate();
        }
    }
}