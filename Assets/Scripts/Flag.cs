using UnityEngine;

public class Flag : MonoBehaviour
{
    public Sprite flag_open;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = flag_open;
            print("The flag opened!");
        }
    }
}
