using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObj : MonoBehaviour
{

public GameObject enemy;

    public void destroyObject() {
            Destroy(enemy);
        }
    

    public void setInactive(GameObject g) {
        g.SetActive(false);
    }
    public void destroyObjects(string tag) {
    GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);
    foreach(GameObject target in gameObjects) {
        GameObject.Destroy(target);
    }
    }
}
