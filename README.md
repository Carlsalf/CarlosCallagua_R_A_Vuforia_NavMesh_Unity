# Práctica — Realidad Aumentada con Vuforia y NavMesh en Unity

## Descripción

En esta práctica se desarrolló una escena de Realidad Aumentada en Unity utilizando Vuforia, donde distintos *ImageTargets* permiten visualizar objetos 3D en un dispositivo móvil iOS.

Se configuró un marcador principal para el escenario y dos marcadores adicionales para los personajes. Asimismo, se integró navegación mediante *NavMesh* e interacción táctil para desplazar los personajes hacia un punto del escenario.

---

## Funcionalidades implementadas

* Configuración del proyecto en Unity con Vuforia Engine.
* Importación y uso de una base de datos de marcadores.
* Creación de tres *ImageTargets*:

  * Escenario principal
  * Personaje 1
  * Personaje 2
* Asociación de objetos 3D a cada marcador.
* Configuración de materiales y colores para mejorar la visualización.
* Generación de *NavMesh* sobre el escenario.
* Uso de *NavMeshAgent* en los personajes.
* Implementación del script `TouchNavigation` para interacción táctil.
* Exportación a Xcode y ejecución en un dispositivo iPhone real.

---

## Problemas encontrados

* Problemas iniciales al abrir Xcode y tiempos largos de compilación.
* Error de instalación en iPhone por límite de aplicaciones con cuenta gratuita de desarrollador.
* Problemas de escala y posicionamiento de objetos 3D sobre los marcadores.
* El plano del suelo ocultaba la imagen del marcador.
* Referencias perdidas en el array de *Agents* en el script `TouchNavigation`.
* Tamaño elevado del proyecto al intentar subirlo a GitHub.

---

## Soluciones aplicadas

* Reinicio de Xcode y limpieza del proyecto cuando fue necesario.
* Eliminación de aplicaciones previas en el dispositivo para permitir nuevas instalaciones.
* Ajuste de escalas, posiciones y materiales de los objetos.
* Eliminación del plano innecesario que interfería con el marcador.
* Reasignación correcta de los *NavMeshAgent* en el objeto `GameManager`.
* Limpieza del proyecto eliminando carpetas temporales (`Library`, `Temp`, etc.).
* Uso de un `.gitignore` adecuado para proyectos Unity.

---

## Estructura del proyecto

* Assets/
* Packages/
* ProjectSettings/

---

## Ejecución

El proyecto fue probado y ejecutado correctamente en un dispositivo real (iPhone) mediante exportación a Xcode.

---

## Nota técnica

El repositorio contiene el código fuente, escenas y recursos del proyecto.
La apertura del proyecto en otros entornos puede requerir la resolución de la dependencia externa de Vuforia en Unity.

---

## Repositorio

https://github.com/Carlsalf/CarlosCallagua_R_A_Vuforia_NavMesh_Unity

---

## Evidencia

Se adjunta un vídeo demostrativo donde se muestra el funcionamiento completo de la práctica.

---

## Autor

Carlos Alfredo Callagua Llaque
