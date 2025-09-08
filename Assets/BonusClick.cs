using UnityEngine;

public class BonusClick : MonoBehaviour
{
    public static int points;
    AudioSource bonusSound;
    Renderer objRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bonusSound = GetComponent<AudioSource>();
        objRenderer = GetComponent<Renderer>();
        Debug.Log("ImposterClick Open!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                objRenderer.enabled = false; 
                bonusSound.Play();
                points += 10;
                Debug.Log("Bonus clicked!" + " " + points);
                if (bonusSound.clip != null)
                {
                    Destroy(gameObject, bonusSound.clip.length);
                }
            }

        }
    }
}
