using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthDisplay : MonoBehaviour
{
    Car_Player Player;
    Text healthDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        healthDisplay = GetComponent<Text>();
        Player = FindObjectOfType<Car_Player>();

    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = Player.GetHealth().ToString();
    }

}
