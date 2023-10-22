# Practica5-InterfacesInteligentes
## Escenas Cardboard
### Alicia Guadalupe Cruz Pérez

Se ha creado un proyecto Cardboard en Unity, experimentando con la interacción del gazet:

![Escena Unity](/gif/cardBoard_basket.gif)

En dicha escena podemos observar una cancha de baloncesto donde podemos jugar con el balón. Para ello, se han seguido los pasos de la [guía de las Google Cardboard para Unity](https://developers.google.com/cardboard/develop/unity/quickstart?hl=es-419) y se ha usado el objeto **player** que se encuentra dentro de la escena **HelloCardboard**. Previamente, se ha importado de la AssetStore la escena **Basket Ball With Court** y se ha modificado.

Para que nuestro juego funcione se han usado dos scripts que permiten lanzar la bola al presionar en la pantalla de nuestro dispositivo.

- [Script de la cámara](/scripts/GazeEvent.cs):
Este script de Unity, llamado **GazeEvent**, maneja eventos de mirada en el contexto de una pantalla táctil. Cuando hay un toque en la pantalla, el script mueve un objeto llamado **ball** a una posición específica frente al objeto al que está adjunto. Luego, aplica una fuerza (launchForce) al objeto **ball**, lanzándolo hacia adelante en la dirección en la que el objeto al que está adjunto está mirando.

- [Script del balón](/scripts/BallThrow.cs):
Este script de Unity, llamado **BallThrow**, se encarga de controlar el comportamiento de un objeto en el juego en respuesta a colisiones. Cuando el objeto colisiona con otros objetos en la escena y el nombre del objeto con el que colisiona es "basketball_court:ground 1" o "basketball_court:court", el objeto vuelve a su posición inicial. La posición inicial del objeto se guarda en la variable privada **_startingPosition**.
