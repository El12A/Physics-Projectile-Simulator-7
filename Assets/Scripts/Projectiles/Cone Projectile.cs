using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeProjectile : projectile
{
    private float radius;
    private float height;
    // Start is called before the first frame update
    void Start()
    {

    }

    public ConeProjectile(string material, float FrictionalCoefficient, float Restitution, float r, float h) : base(material, FrictionalCoefficient, Restitution)
    {
        this.materialName = material;
        density = materials[materialName];
        frictionalCoefficient = FrictionalCoefficient;
        restution = Restitution;
        radius = r;
        height = h;
        CalculateVolume();
        CalculateMass();
    }
    public float CalculateVolume()
    {
        //volume formula for cone: 
        volume = (height / 3) * Mathf.PI * radius * radius;
        return volume;
    }

    public void SetSize()
    {
        transform.localScale = new Vector3((float)radius, (float)height, (float)radius);
    }
}
