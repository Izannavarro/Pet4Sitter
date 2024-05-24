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

##Trigger after delete usuarios:
CREATE DEFINER=`root`@`%` TRIGGER `users_after_delete` AFTER DELETE ON `users` FOR EACH ROW BEGIN
 INSERT INTO user_logs (id_user, action, details) 
    VALUES (null, 'DELETE', CONCAT('Usuario eliminado con ID: ', OLD.id_user, ', Nombre: ', OLD.name));
END
