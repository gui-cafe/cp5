using UnityEngine;


public class AnimScript : MonoBehaviour
{
    [SerializeField] Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        VerificarToque();

    }

    private void VerificarToque()
    {
        if (Input.touchCount > 0)
        {
            print("verificação 1");
            Touch toque = Input.GetTouch(0);

            if (toque.phase == TouchPhase.Began)
            {
                Debug.Log("A tela foi tocada na posição: " + toque.position);
                animator.SetTrigger("SwitchAnim");
            }

        }
    }

}
