using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float xSpeed;
    public float ySpeed;
    public Texture2D texture;
    private float xOffset = 0;
    private float yOffset = 0;
    private Material material;

    void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        List<Material> materials = new List<Material>();
        meshRenderer.GetMaterials(materials);
        material = materials[0];
        material.SetTexture("_texture",texture);
    }

    // Update is called once per frame
    void Update()
    {
        xOffset += Time.deltaTime* xSpeed;
        yOffset += Time.deltaTime* ySpeed;

        material.SetFloat("_xSpeed", xOffset);
        material.SetFloat("_ySpeed", yOffset);
    }
}
