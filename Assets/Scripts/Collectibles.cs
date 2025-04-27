using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Collectibles : MonoBehaviour
{
    public int totalItems = 16;
    private int collectedItems = 0;
    public Vector2 pos;

    public TMP_Text itemText;

    private void Start()
    {
        UpdateUI();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Items"))
        {
            Destroy(collision.gameObject);
            collectedItems++;
            UpdateUI();
        }

        if (collectedItems == 16)
        {
            if (collision.CompareTag("Trophy"))
            {
                SceneManager.LoadScene(2);
            }

        }
    }

    private void UpdateUI()
    {
        itemText.text = collectedItems + "/" + totalItems;
    }
}
