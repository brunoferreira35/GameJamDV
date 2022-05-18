using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector2 velocity;

    private bool jump, walk, walkLeft, walkRight;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkPlayerInput();

        UpdatePlayerPosition();
    }

    void UpdatePlayerPosition() {

        Vector3 pos = transform.localPosition;

        if (walk) {
            if (walkLeft) {
                pos.x -= velocity.x * Time.deltaTime;
            }

            if (walkRight) {
                pos.x += velocity.x * Time.deltaTime;
            }
        }
        transform.localPosition = pos;

    }

    void checkPlayerInput() {

        bool inputSpace = Input.GetKey(KeyCode.Space);
        bool inputLeft = Input.GetKey(KeyCode.LeftArrow);
        bool inputRight = Input.GetKey(KeyCode.RightArrow);

        walk = inputLeft || inputRight;

        walkLeft = inputLeft && !inputRight;

        walkRight = !inputLeft && inputRight;

        jump = inputSpace;
    }
}

