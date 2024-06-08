using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerColletController : MonoBehaviour
{ 
    void OnCollisionEnter (Collision col) {
        if (col.gameObject.tag == "Player") {
            MainSceneUIController.Instance.ScoreCount++;
            Destroy(gameObject);
        }
    }
}
