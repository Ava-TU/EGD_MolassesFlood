using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MolassesScript : MonoBehaviour
{
    public int molassesCount;
    public TMP_Text molassesText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        molassesCount = 0;
        molassesText.text = "Molasses Collected: " + molassesCount.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Molasses"))
        {
            Destroy(col.gameObject);
            molassesCount++;
            molassesText.text = "Molasses Collected: " + molassesCount.ToString();
        }
    }
}
