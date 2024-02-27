using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeProjectile : projectile
{
    private float length;
    private float width;
    private float height;
    // Start is called before the first frame update
    void Start()
    {

    }

    public CubeProjectile(string material, float FrictionalCoefficient, float Restitution, float l, float w, float h) : base(material, FrictionalCoefficient, Restitution)
    {
        this.materialName = material;
        density = materials[materialName];
        frictionalCoefficient = FrictionalCoefficient;
        restution = Restitution;
        length = Mathf.Min(0.1f, l);
        width = Mathf.Min(0.1f, w);
        height = Mathf.Min(0.1f, h);
        Debug.Log(length + width + height);
        CalculateVolume();
        CalculateMass();
    }
    public float CalculateVolume()
    {
        //volume formula for cube
        volume = length * width * height;
        return volume;
    }

    public void SetSize()
    {
        Vector3 transformVector = new Vector3(width, height, length);
        Debug.Log(transformVector);
        transform.localScale = transformVector;
    }
}
