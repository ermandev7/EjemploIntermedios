# EjemploIntermedios

Este repositorio contiene ejemplos intermedios de programación en **C#**, diseñados para ayudar a los desarrolladores a mejorar sus habilidades y conocimientos en conceptos clave como la sobrecarga de métodos, propiedades, encapsulamiento, constructores, herencia, polimorfismo, interfaz, delegados y eventos.

## Contenidos

- [Instalación](#instalación)
- [Uso](#uso)
- [Temas cubiertos](#temas-cubiertos)
- [Contribuciones](#contribuciones)
- [Licencia](#licencia)

## Instalación

1. Clona el repositorio:

    ```bash
    git clone https://github.com/ermandev7/EjemploIntermedios.git
    ```

2. Navega al directorio del proyecto:

    ```bash
    cd EjemploIntermedios
    ```

## Uso

Este proyecto está construido con .NET MAUI Blazor utilizando el lenguaje de programación C#. Contiene ejemplos de código que son esenciales para adquirir un conocimiento intermedio en programación. Estos ejemplos abarcan una variedad de conceptos clave que ayudarán a los desarrolladores a mejorar sus habilidades y a profundizar en su comprensión de la programación en C#.

## Ejemplo de Código

```csharp
// Clase base
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

// Clase derivada
public class Perro : Animal
{
    public string Raza { get; set; }

    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} está ladrando. ¡Guau, guau!");
    }
}
```
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

## Licencia
MIT License

Copyright (c) [Año] [Tu nombre o el nombre de tu organización]

Por la presente se otorga permiso, sin cargo, a cualquier persona que obtenga una copia de este software y los archivos de documentación asociados (el "Software"), para tratar en el Software sin restricciones, incluidos, entre otros, los derechos de usar, copiar, modificar, fusionar, publicar, distribuir, sublicenciar y/o vender copias del Software, y para permitir a las personas a quienes se les proporcione el Software hacerlo, sujeto a las siguientes condiciones:

El aviso de copyright anterior y este aviso de permiso se incluirán en todas las copias o partes sustanciales del Software.

EL SOFTWARE SE PROPORCIONA "TAL CUAL", SIN GARANTÍA DE NINGÚN TIPO, EXPRESA O IMPLÍCITA, INCLUYENDO PERO NO LIMITADO A LAS GARANTÍAS DE COMERCIABILIDAD, IDONEIDAD PARA UN PROPÓSITO PARTICULAR Y NO INFRACCIÓN. EN NINGÚN CASO LOS AUTORES O TITULARES DEL COPYRIGHT SERÁN RESPONSABLES DE NINGUNA RECLAMACIÓN, DAÑO U OTRA RESPONSABILIDAD, YA SEA EN UNA ACCIÓN DE CONTRATO, AGRAVIO O DE OTRO MODO, QUE SURJA DE, FUERA DE O EN CONEXIÓN CON EL SOFTWARE O EL USO U OTROS TRATOS EN EL SOFTWARE.

