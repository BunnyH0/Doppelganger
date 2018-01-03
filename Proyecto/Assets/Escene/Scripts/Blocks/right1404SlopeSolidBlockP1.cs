﻿using UnityEngine;

public class right1404SlopeSolidBlockP1 : solidSlopeBlock
{
    public right1404SlopeSolidBlockP1() : base(0.25f, 0, 8, 14.04f)
    {
        color = new Color32(224, 0, 0, 128);
        blockName = "Solid Block Right Slope 14.04 degrees Part 1";
        vertices = new Vector3[4];
        vertices[0] = new Vector3(-8, -8, 0);
        vertices[1] = new Vector3(-8, 0, 0);
        vertices[2] = new Vector3(8, 4, 0);
        vertices[3] = new Vector3(8, -8, 0);
    }
}
