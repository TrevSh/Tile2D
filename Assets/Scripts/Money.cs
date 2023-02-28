using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField] int value = 5; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
            Destroy(gameObject);
            Wallet.instance.MakeMoney(value);
        }
    }
}
