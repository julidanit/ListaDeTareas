# ListaDeTareas
Práctica con c# .net

Se detallan las instrucciones:

Aplicación de lista de tareas. 

Esta aplicación permitirá a los usuarios agregar y administrar tareas pendientes.

Puedes comenzar creando una interfaz de usuario simple con Windows Forms que incluya los siguientes elementos:

Un TextBox para que los usuarios ingresen nuevas tareas.
Un botón "Agregar tarea" que agregue la tarea ingresada al ListBox.
Un ListBox que muestre todas las tareas agregadas.
Un botón "Eliminar tarea" que elimine la tarea seleccionada del ListBox.

Una vez que hayas creado la interfaz básica, puedes implementar la lógica detrás de los botones. 
Al hacer clic en el botón "Agregar tarea", debes tomar el texto del TextBox y agregarlo al ListBox. 
Puedes usar la propiedad Items del ListBox para agregar elementos.

Por otro lado, al hacer clic en el botón "Eliminar tarea", debes verificar si hay alguna tarea seleccionada en el ListBox y eliminarla. 
Puedes usar la propiedad SelectedIndex del ListBox para determinar el índice de la tarea seleccionada y 
luego eliminarla utilizando el método RemoveAt de la propiedad Items.

Además, puedes agregar características adicionales según tus habilidades y conocimientos, como:

Permitir que los usuarios marquen las tareas como completadas.
Agregar un campo de fecha límite para cada tarea.

Implementar opciones de filtrado para mostrar solo tareas completadas o incompletas.
Permitir la edición de tareas existentes.
