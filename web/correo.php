<?php
if(isset($_POST['enviar'])) { 
    if(!empty($_POST['nombre']) && !empty($_POST['asunto']) && !empty($_POST['mensaje']) && !empty($_POST['email'])) {
        $nombre = $_POST['nombre'];
        $asunto = $_POST['asunto'];
        $mensaje = $_POST['mensaje'];
        $email = $_POST['email'];
        $header = "From: noreply@example.com\r\n";
        $header .= "Reply-to: $email\r\n";
        $header .= "X-Mailer: PHP/" . phpversion();
        $mail = mail($email, $asunto, $msg, $header);
        if ($mail) {
            echo "<h4>¡Mail enviado exitosamente!</h4>";
        } else {
            echo "<h4>Error al enviar el correo.</h4>";
        }
    } else {
        echo "<h4>Todos los campos son requeridos.</h4>";
    }
}
?>