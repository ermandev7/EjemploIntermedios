# EjemploIntermedios

Este repositorio contiene ejemplos intermedios de programación en [lenguaje de programación], diseñados para ayudar a los desarrolladores a mejorar sus habilidades y conocimientos en conceptos clave como la sobrecarga de métodos, propiedades, encapsulamiento, constructores, herencia, polimorfismo, interfaz, delegados y eventos.

## Contenidos

- [Instalación](#instalación)
- [Uso](#uso)
- [Temas cubiertos](#temas-cubiertos)
- [Contribuciones](#contribuciones)
- [Licencia](#licencia)

## Instalación

1. Clona el repositorio:

```bash
git clone https://github.com/ermandev7/EjemploIntermedios.git.

# ejemplo de código de herencia:
public class Animal
{
    public string Nombre { get; set; }
    
    public void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }

    public void Dormir()
    {
        Console.WriteLine($"{Nombre} está durmiendo.");
    }
}
public class Perro : Animal
{
    public string Raza { get; set; }

    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} está ladrando. ¡Guau, guau!");
    }
}
## captura de la aplicacion 
![image](https://github.com/user-attachments/assets/354e7e80-d7fb-478d-9093-504cdc68a07e)

## Temas cubiertos

Este proyecto abarca los siguientes conceptos intermedios:

1. **Sobrecarga de Métodos**: Ejemplos de cómo definir múltiples métodos con el mismo nombre pero diferentes parámetros.

2. **Propiedades**: Cómo utilizar propiedades para encapsular datos y proporcionar acceso controlado.

3. **Encapsulamiento**: Ejemplos de cómo ocultar detalles internos de una clase y exponer solo lo necesario.

4. **Constructores**: Cómo utilizar constructores para inicializar objetos.

5. **Herencia**: Ejemplos de cómo derivar una clase de otra y reutilizar código.

6. **Polimorfismo**: Cómo utilizar polimorfismo para permitir que una interfaz única controle múltiples tipos de datos.

7. **Interfaz**: Definición y uso de interfaces en la programación.

8. **Delegados**: Ejemplos de cómo utilizar delegados para pasar métodos como parámetros.

9. **Eventos**: Cómo definir y manejar eventos en la programación.

