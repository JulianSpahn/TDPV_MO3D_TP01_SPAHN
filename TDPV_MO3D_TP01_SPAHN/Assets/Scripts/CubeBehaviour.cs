using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    //creamos las letras que se encargaran de cada eje
    public enum Axis { x, y, z };

    //serializamos (damos acceso manual a) las letras que se encargan de los ejes
    [SerializeField]
    [Tooltip("Ejes que controlan la rotación del cubo")]
    private Axis rotationAxis;
    public Axis RotationAxis { get => rotationAxis; set => rotationAxis = value; }
    
    //serializamos (damos acceso manual a) la velocidad que tomara el cubo
    [SerializeField]
    [Range(-25f, 25f)]
    [Tooltip("Velocidad de rotación del cubo")]
    
    //velocidad de rotacion del cubo
    private float rotationSpeed;
    public float RotationSpeed { get => rotationSpeed; set => rotationSpeed = value; }
    
    //Esta es la velocidad de rotacion inicial del cubo
    private float rotationSpeedInitial;
    public float RotationSpeedInitial { get => rotationSpeedInitial; }
    
    //al inicio seteamos que la velocidad de rotacion inicial es igual a la que manipulamos desde el inspector
    void Start()
    {
        rotationSpeedInitial = rotationSpeed;
    }
    
    //funcion que se encarga de manejar el eje donde se realizara la rotacion, esto lo hace mediante un switch para cada letra
    private void Rotation()
    {
        switch (rotationAxis)
        {
            case Axis.x:
                transform.Rotate(RotationSpeed * Vector3.right * Time.deltaTime);
                break;
            case Axis.y:
                transform.Rotate(RotationSpeed * Vector3.up * Time.deltaTime);
                break;
            case Axis.z:
                transform.Rotate(RotationSpeed * Vector3.forward * Time.deltaTime);
                break;
        }
    }
    
    //aqui se actualizara constantemente la funcion "Rotation"
    void FixedUpdate()
    {
        Rotation();
    }
}
