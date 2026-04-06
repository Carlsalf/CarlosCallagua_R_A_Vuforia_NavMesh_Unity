# Práctica — Realidad Aumentada con Vuforia y NavMesh en Unity

## Descripción
En esta práctica se desarrolló una escena de Realidad Aumentada en Unity utilizando Vuforia, donde distintos ImageTargets permiten mostrar objetos 3D en un dispositivo móvil iOS.

Se configuró un marcador principal para el escenario y dos marcadores adicionales para los personajes. Además, se integró navegación con NavMesh e interacción táctil para desplazar los personajes hacia un punto del escenario.

## Qué se ha hecho
- Configuración del proyecto en Unity con Vuforia Engine.
- Importación y uso de una base de datos de marcadores.
- Creación de tres ImageTargets:
  - uno para el escenario
  - uno para el personaje 1
  - uno para el personaje 2
- Asociación de objetos 3D a cada marcador.
- Configuración de materiales y colores para mejorar la visualización.
- Configuración de NavMesh sobre el escenario.
- Añadido de componentes NavMeshAgent a los personajes.
- Implementación del script `TouchNavigation` para la interacción táctil.
- Exportación a Xcode y ejecución en un iPhone real.

## Problemas encontrados
1. Problemas iniciales al abrir Xcode y tiempos largos de compilación.
2. Error de instalación en iPhone por límite de apps con cuenta gratuita de desarrollador.
3. Problemas de escala y posicionamiento de objetos 3D sobre los marcadores.
4. El plano del suelo tapaba completamente la imagen del marcador.
5. Referencias perdidas en el array `Agents` del script `TouchNavigation`.
6. Archivos muy pesados al intentar subir el proyecto a GitHub.

## Cómo se han resuelto los problemas
- Se reinició Xcode y se realizó limpieza del proyecto cuando fue necesario.
- Se eliminaron apps previas del iPhone para liberar espacio de instalación con perfil gratuito.
- Se ajustaron escalas, posiciones y materiales de los objetos para mejorar la presentación.
- Se eliminó el plano de suelo innecesario sobre el marker principal para evitar ocultar la imagen.
- Se reasignaron correctamente los `NavMeshAgent` en el objeto `GameManager`.
- Se limpió el proyecto antes de subirlo a GitHub, eliminando archivos temporales y paquetes pesados no necesarios.
- Se utilizó un `.gitignore` adecuado para Unity.

## Estructura del proyecto
- Assets/
- Packages/
- ProjectSettings/

## Ejecución
El proyecto fue probado en un dispositivo real iPhone mediante exportación a Xcode.

## Repositorio
Repositorio GitHub:
https://github.com/Carlsalf/CarlosCallagua_R_A_Vuforia_NavMesh_Unity

## Evidencia
Se adjunta un vídeo demostrativo donde se muestra el funcionamiento de la práctica.

## Autor
Carlos Alfredo Callagua Llaque
