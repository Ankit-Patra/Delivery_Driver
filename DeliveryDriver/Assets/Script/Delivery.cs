using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32 (0,0,0,0);

    bool hasPackage = false;
    [SerializeField] float destroyDelay = .5f;

    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && hasPackage==false)
        {
            hasPackage = true;
            Debug.Log("Package Picked");
            spriteRenderer.color=hasPackageColor;
            Destroy(other.gameObject,destroyDelay);
        }
        if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            spriteRenderer.color=noPackageColor;
        }
    }
}
