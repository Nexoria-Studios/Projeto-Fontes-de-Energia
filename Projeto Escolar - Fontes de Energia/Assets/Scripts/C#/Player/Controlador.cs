using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Controlador : MonoBehaviour
{
    public Camera cameraDoJogador;
    public float velocidadeDeAndar = 6f;
    public float velocidadeDeCorrer = 12f;
    public float forcaDoPulo = 7f;
    public float gravidade = 10f;

    public float sensibilidadeDaCamera = 2f;
    public float limiteDirecaoX = 45f;

    Vector3 direcaoDeMovimento = Vector3.zero;
    float rotacaoX = 0;

    public bool podeMover = true;

    CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool estaCorrendo = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = podeMover ? (estaCorrendo ? velocidadeDeCorrer : velocidadeDeAndar) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = podeMover ? (estaCorrendo ? velocidadeDeCorrer : velocidadeDeAndar) * Input.GetAxis("Horizontal") : 0;
        float movementDirecitonY = direcaoDeMovimento.y;
        direcaoDeMovimento = (forward * curSpeedX) + (right * curSpeedY);

        if (Input.GetButton("Jump") && podeMover && characterController.isGrounded)
        {
            direcaoDeMovimento.y = forcaDoPulo;
        }
        else
        {
            
        }

        if (!characterController.isGrounded)
        {
            direcaoDeMovimento.y -= gravidade * Time.deltaTime;
        }

        characterController.Move(direcaoDeMovimento * Time.deltaTime);

        if (podeMover)
        {
            rotacaoX += -Input.GetAxis("Mouse Y") * sensibilidadeDaCamera;
            rotacaoX = Mathf.Clamp(rotacaoX, -limiteDirecaoX, limiteDirecaoX);
            cameraDoJogador.transform.localRotation = Quaternion.Euler(rotacaoX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * sensibilidadeDaCamera, 0);
        }
    }
}
