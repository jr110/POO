# Tarea 1
Tarea para la materia de Programación Orientada a Objetos.
## 1.Paradigma
La palabra **Paradigma** tiene múltiples definiciones dependiendo el contexto en el que se use, pero la definición mas general seria
En la que se conoce como las instrucciones o el modelo a seguir para resolver un determinado problema.
## 2.Abstraccion
Entiendo por **Abstracción** que consiste en el enfocarse en las propiedades de un objeto, separándolas y seleccionando una, e ignorar todas lo demás.
### Ejemplos:
+ Desarmar una computadora y tratar de averiguar el cómo funciona alguna de sus partes internas.
+ Tratar de comprender el funcionamiento de un auto, analizando alguna pieza de este.
## 3. ¿Por qué decimos que la Clase es el mecanismo de abstracción de los lenguajes OO? 
Por qué es la que se encarga de definir los atributos de cada objeto.
## 4.Explica el concepto de encapsulamiento, busca dos imágenes que te ayuden a describir el concepto, una que tenga algún sistema sin encapsulamiento y otra donde si lo tenga. Menciona porque es importante y que problemas puede evitar.
El Encapsulamiento nos sirve para proteger los componentes o implementaciones más complejas de un objeto para que el usuario final solo pueda manipularlo por medio de una interfaz más sencilla. Es muy importante porque así prevenimos el uso erróneo que el usuario pueda hacer de dicho objeto y puede evitar que el objeto deje de funcionar apropiadamente.

### Aqui podemos ver a un automovil (Encapsulado).
![Encaptulado](https://github.com/jr110/POO/blob/master/POO%20Imagenes/Encapsulado%201.gif)

### Micro computadora (no encapsulado).
![NoEncapsulado](https://github.com/jr110/POO/blob/master/POO%20Imagenes/Encapsulado3.jpg)


## 5. Describe con tus palabras el concepto de herencia e ilustra el concepto con imágenes.
Se puede describir a la herencia como el generar subclases provenientes de una clase principal con atributos en común.
### Tenemos de ejemplo que los hijos serian las "subclases" de los padres, ya que estos comparten algunas similitudes con ellos
![Herencia1](https://github.com/jr110/POO/blob/master/POO%20Imagenes/Herencia%201.jpg)

### Tenemos que los hervivoros, carnivoros y omnivoros son parte de la clase "Animales"
![Herencia2](https://github.com/jr110/POO/blob/master/POO%20Imagenes/Herencia%202.gif)

# UML: diagrama de clases.
## 1. Investiga la historia y haz un resumen del Lenguaje de Modelado Unificado, donde se mencione: quienes son sus principales autores (Booch, Rumbaugh, Jacobson), en qué tipo de sistemas se utiliza, en particular el Diagrama de Clases. Menciona algunas de las herramientas para el modelado en UML. ¿Sabes de alguna empresa local que utilice este lenguaje?
Todo empezó cuando Rational Software Corporation decidiera contratar a **Rumbaugh**, quien en 1994 trabajara anteriormente en General Electric, Haciendo Que Rational software posea 2 de los esquemas orientados a objetos más populares de la época, uno era de Rumbaugh el cual se llamaba **"Object-Modeling Technique"** o por sus siglas "OMT" y otro modelado orientado a objetos llamado **El método de Boock**, creado por **Grady Booch**, estos esquemas tenían diferentes enfoques, ya que uno era enfocado a el analsis de objetos (El OMT) y el otro enfocado a diseño de objetos (El método Boock). En 1995 se uniría un tercer integrante a Rational software. **Ivar Jacobson**, el creador del **método de ingeniería de software orientado a objetos**.
Estos metodologías organizaron en 1996 un consorcio internacional llamado UML partners. Este consorcio fue el comienzo de una serie de colaboraciones que desencadenaron en una estandarizacion del UML el cual fue aprobó por la ISO en 2004.
UML tuvo diferentes versiones. Desde UML 1.x, UML 2.x, y la más reciente y estable lanzada en octubre del 2012, la UML 2.5, el cual contiene 2 tipos de diagramas, los diagramas estructurales y diagramas de comportamiento, los cuales se dividen en otros tipos de diagramas que tienen diferentes enfoques como veremos en la siguiente imagen:
![TiposDeDiagramas](https://github.com/jr110/POO/blob/master/POO%20Imagenes/600px-Uml_diagram-es.svg.png)

No tengo conociemiento de alguna empresa que utilize este modelo, pero puedo suponer que las utilizan algunas compañias que manejen informacion delicada y compleja como los bancos.

## 2. Escribe una propuesta de una máquina que venda distintos artículos y haz el diagrama de clases del sistema que propones. Recuerda que puede haber composición (un teclado se compone de botones) y generalización (tipo de productos, tipo de pago).
Una maquina expendedora de alimentos:
![maquina](https://github.com/jr110/POO/blob/master/POO%20Imagenes/Propuesta.png)

