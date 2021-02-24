using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class treat : MonoBehaviour
{
    public static int happiness;
    public static Text happinessText;

    // Start is called before the first frame update
    void Start()
    {
        happiness = 20;
        happinessText = GameObject.Find("HappinessText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){

            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if(Physics.Raycast (ray, out hit)){
                happiness +=10;
                happinessText.text = "Happiness: "+ happiness;
            }
        }
        
    }
}
