using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public ItemInfo ItemInfo;
    public GameObject itemGameObject;

    public abstract void Use();
}
