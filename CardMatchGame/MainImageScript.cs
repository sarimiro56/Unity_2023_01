using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainImageScript : MonoBehaviour
{
    [SerializeField] private GameObject image_unknown;
    [SerializeField] private GameControllerScript gameController;
    [SerializeField] private GameControllerScript2 gameController2;

    public void OnMouseDown()
    {
        if (image_unknown.activeSelf)
        {
            if (gameController != null && gameController.canOpen)
            {
                image_unknown.SetActive(false);
                gameController.imageOpened(this);
                GetComponent<AudioSource>().Play();
            }

            if (gameController2 != null && gameController2.canOpen)
            {
                image_unknown.SetActive(false);
                gameController2.imageOpened(this);
                GetComponent<AudioSource>().Play();
            }
        }
    }


    private int _spriteId;
    public int spriteId
    {
        get { return _spriteId; }
    }

    public void ChangeSprite(int id, Sprite image)
    {
        _spriteId = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void Close()
    {
        image_unknown.SetActive(true);
    }
}
