using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovment : MonoBehaviour
{
    [SerializeField] float backgroundScrollSpeed = 3.5f;
    
    Material gameMaterial;

    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        gameMaterial = GetComponent<Renderer>().material;

        offset = new Vector2(0f, backgroundScrollSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        gameMaterial.mainTextureOffset += offset * Time.deltaTime;
    }
}
