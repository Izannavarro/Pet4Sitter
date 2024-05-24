##Trigger para after insert usuarios:
CREATE DEFINER=`root`@`%` TRIGGER `users_after_insert` AFTER INSERT ON `users` FOR EACH ROW BEGIN
INSERT INTO user_logs (id_user, action, details)
    VALUES (NEW.id_user, 'INSERT', CONCAT('Nuevo usuario: ', NEW.name, ' ', NEW.surname));
END

##Trigger para after update usuarios:
CREATE DEFINER=`root`@`%` TRIGGER `users_after_update` AFTER UPDATE ON `users` FOR EACH ROW BEGIN
INSERT INTO user_logs (id_user, action, details) 
    VALUES (NEW.id_user, 'UPDATE', CONCAT('Usuario actualizado con ID: ', NEW.id_user, ', Nombre: ', NEW.name));
END

