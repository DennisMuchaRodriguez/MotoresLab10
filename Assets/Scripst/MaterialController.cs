using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MaterialController : MonoBehaviour
{
    private Rigidbody _comprigidbody3D;
    public float speedX;
    public float _MovementX;
    public float _MovementZ;

    public MaterialsCustom customMaterial;

    private Renderer _renderer;

    private void Awake()
    {
        _comprigidbody3D = GetComponent<Rigidbody>();

    }

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.material.color = customMaterial.mainColor;
        _renderer.material.mainTexture = customMaterial.texture;
        _renderer.material.SetFloat("_Glossiness", customMaterial.brightness);
    }
    void FixedUpdate()
    {
        Move();
      

    }
    public void Move()
    {
        _comprigidbody3D.velocity = new Vector3(_MovementX * speedX, _comprigidbody3D.velocity.y, _MovementZ * speedX);
    }
    public void OnMovementX(InputAction.CallbackContext context)
    {
        _MovementX = context.ReadValue<float>();
    }
    public void OnMovementZ(InputAction.CallbackContext context)
    {
        _MovementZ = context.ReadValue<float>();
    }
}
