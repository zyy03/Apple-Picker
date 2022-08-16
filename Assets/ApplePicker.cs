using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Set In Inspector")]
    public GameObject basketPrefab;
    public int numBasket = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

    public List<GameObject> baskets;

    void Start()
    {
        baskets = new List<GameObject>();
        for (int i = 0; i < numBasket; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            baskets.Add(tBasketGO);
        }
    }

    void Update()
    {

    }

    public void decreaseBasket()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject item in tAppleArray)
        {
            Destroy(item);
        }
        int basketIndex = baskets.Count - 1;
        GameObject basketGO = baskets[basketIndex];
        baskets.RemoveAt(basketIndex);
        Destroy(basketGO);

        if (baskets.Count == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
