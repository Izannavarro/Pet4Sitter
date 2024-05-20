<?php
// Recopila los datos del formulario
$nombre = $_POST['nombre'];
$email = $_POST['email'];
$asunto = $_POST['asunto'];
$mensaje = $_POST['mensaje'];

// Dirección de correo a la que se enviará el mensaje
$destinatario = 'aaronaparisi2005@gmail.com';

// Crea el cuerpo del correo electrónico
$contenido = "Nombre: $nombre\n";
$contenido .= "Correo Electrónico: $email\n";
$contenido .= "Asunto: $asunto\n";
$contenido .= "Mensaje:\n$mensaje\n";

// Envía el correo electrónico
mail($destinatario, $asunto, $contenido);

// Redirige de vuelta a la página de contacto
header('Location: contactUsES.html');
?>
