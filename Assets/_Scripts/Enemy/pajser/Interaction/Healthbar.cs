using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Image healthbarSprite;
    private Camera cam;

    void Start(){
        cam = Camera.main;
    }

    public void UpdateHealthbar(float currentHp, float maxHp){
        healthbarSprite.fillAmount = currentHp / maxHp;
        Debug.Log(currentHp);
    }

    void Update(){
        transform.rotation = Quaternion.LookRotation(transform.position - cam.transform.position);
    }

}
