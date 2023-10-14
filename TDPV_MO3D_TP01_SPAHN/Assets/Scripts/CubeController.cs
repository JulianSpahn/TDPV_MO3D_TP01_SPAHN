using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private CubeBehaviour cubeBehaviour;


    // Instanciamos el comportamiento del cubo traido del script "cubeBehaviour"
    void Start()
    {
        cubeBehaviour = GetComponent<CubeBehaviour>();
    }

    // Aqui estan las teclas que se encargan de todas las acciones que se usaran en el cubo
    void Update()
    {
        // Teclas encargadas de controlar el eje de rotación del cubo
        if (Input.GetKeyDown(KeyCode.X))
        {
            cubeBehaviour.RotationAxis = CubeBehaviour.Axis.x;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            cubeBehaviour.RotationAxis = CubeBehaviour.Axis.y;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            cubeBehaviour.RotationAxis = CubeBehaviour.Axis.z;
        }
        // Teclas encargadas de dar el sentido en el que girara el cubo, en sentido horario y anti-horario respectivamente
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rotate();
            cubeBehaviour.RotationSpeed = -cubeBehaviour.RotationSpeedInitial;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rotate();
            cubeBehaviour.RotationSpeed = cubeBehaviour.RotationSpeedInitial;
        }
        // Tecla encargada de pausar la rotacion del cubo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubeBehaviour.RotationSpeed = 0f;
        }
    }

    // Funcion que se encarga dela rotacion del cubo
    private void Rotate()
    {
        if (cubeBehaviour.RotationSpeed == 0f)
        {
            cubeBehaviour.RotationSpeed = cubeBehaviour.RotationSpeedInitial;
        }
    }
}
