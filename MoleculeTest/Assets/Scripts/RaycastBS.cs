using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.Dialogs;

public class RaycastBS : MonoBehaviour
{


    public GameObject handler;
    
    public RaycastBS()
    {
    }

    void Start()
    {
       

    }

    void Update()
    {
        // The version for touching shit on the app
        
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider != null)
                {
                    // Setting up the outline effect
                    Color newColor = new Color(0.972f, 1.0f, 0.137f);
                    Material[] mats = hit.collider.GetComponent<Renderer>().materials;
                    Color[] originalMats = new Color[mats.Length];
                    for(int i =0;i < mats.Length;i++)
                    {
                        //originalMats[i] = mats[i].color;
                        mats[i].color = newColor;
                    }
                    hit.collider.GetComponent<Renderer>().materials = mats;
                    //Material m = hit.collider.GetComponent<Renderer>().material;
                    //m.SetFloat("_Smooth", 0.0f);
                    Debug.Log("The tapped object is: " + hit.collider.name);
                    string name = hit.collider.name;
                    if (name == "Cube")
                    {
                        Debug.Log("A cube is a very basic and common 3 dimensional shape");
                    }
                    // show the popup window
                    DialogUI.Instance
                        .SetTitle("Cube")
                        .SetInfo("A cube is a very basic 3-D shape")
                        .pop(hit);
                }
            }
        }
        

#if UNITY_EDITOR
        // The version for desktop testing (becasue I own a shitty iphone and xcode is screwing me)
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    // Setting up the outline effect
                    Color newColor = new Color(0.972f, 1.0f, 0.137f);
                    Material[] mats = hit.collider.GetComponent<Renderer>().materials;
                    Color[] originalMats = new Color[mats.Length];
                    for (int i = 0; i < mats.Length; i++)
                    {
                        //originalMats[i] = mats[i].color;
                        mats[i].color = newColor;
                    }
                    hit.collider.GetComponent<Renderer>().materials = mats;
                    Debug.Log("The tapped object is: " + hit.collider.name);
                    string name = hit.collider.name;
                    if(name == "Cube")
                    {
                        Debug.Log("A cube is a very basic and common 3 dimensional shape");
                    }
                    // show the popup window
                    DialogUI.Instance
                        .SetTitle("Cube")
                        .SetInfo("A cube is a very basic 3-D shape A cube is a very basic 3-D shape A cube is a very basic 3-D shape A cube is a very basic 3-D shape A cube is a very basic 3-D shape")
                        .pop(hit);
                  
                }
            }
        }
        
#endif
    }
}
