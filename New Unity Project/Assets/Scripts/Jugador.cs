using UnityEngine;

public class Jugador : MonoBehaviour {

    public float velocidad = 0.1f;
	
	void FixedUpdate () {

        //Capturo el movimiento en los ejes
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        //Genero el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoH, 0, movimientoV);

        //Muevo el jugador
        transform.position += -movimiento * velocidad;
		
	}
}
