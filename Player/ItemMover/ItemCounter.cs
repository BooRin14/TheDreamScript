using UnityEngine;
using UnityEngine.UI;

public class ItemCounter : MonoBehaviour
{
    public Text itemCountText;

    void Update()
    {
        itemCountText.text = "Shard Collected: " + ItemCollect.instance.collectedItems;
    }
}