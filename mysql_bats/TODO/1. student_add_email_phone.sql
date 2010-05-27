ALTER TABLE `nirs`.`student` ADD COLUMN `email` VARCHAR(64) NOT NULL AFTER `grant`,
 ADD COLUMN `phone` VARCHAR(45) NOT NULL AFTER `email`;
