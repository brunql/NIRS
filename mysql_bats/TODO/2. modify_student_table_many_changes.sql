ALTER TABLE `nirs`.`student` MODIFY COLUMN `born` DATE,
 MODIFY COLUMN `study` VARCHAR(45) CHARACTER SET utf8 COLLATE utf8_general_ci,
 MODIFY COLUMN `grant` VARCHAR(45) CHARACTER SET utf8 COLLATE utf8_general_ci,
 MODIFY COLUMN `email` VARCHAR(64) CHARACTER SET utf8 COLLATE utf8_general_ci,
 MODIFY COLUMN `phone` VARCHAR(45) CHARACTER SET utf8 COLLATE utf8_general_ci,
 ADD COLUMN `gpa` VARCHAR(45) AFTER `phone`,
 ADD COLUMN `nir_years` INTEGER UNSIGNED ZEROFILL AFTER `gpa`,
 ADD COLUMN `scince_theme` TEXT AFTER `nir_years`,
 ADD COLUMN `address_home` VARCHAR(45) AFTER `scince_theme`,
 ADD COLUMN `scince_works` TEXT AFTER `address_home`,
 ADD COLUMN `publications_count` INTEGER UNSIGNED ZEROFILL AFTER `scince_works`,
 ADD COLUMN `articles_count` INTEGER UNSIGNED ZEROFILL AFTER `publications_count`,
 ADD COLUMN `intelectual_and_industryal_property_count` INTEGER UNSIGNED ZEROFILL AFTER `articles_count`,
 ADD COLUMN `patents_count` INTEGER UNSIGNED ZEROFILL AFTER `intelectual_and_industryal_property_count`,
 ADD COLUMN `sertificate_on_pc_soft_count` INTEGER UNSIGNED ZEROFILL AFTER `patents_count`,
 ADD COLUMN `positive_solutions_on_inventions_and_utility_models_count` INTEGER UNSIGNED ZEROFILL AFTER `sertificate_on_pc_soft_count`,
 ADD COLUMN `requests_on_inventions_and_untity_models_count` INTEGER UNSIGNED ZEROFILL AFTER `positive_solutions_on_inventions_and_utility_models_count`,
 ADD COLUMN `pc_soft_count` INTEGER UNSIGNED ZEROFILL AFTER `requests_on_inventions_and_untity_models_count`,
 ADD COLUMN `implementation_in_industry` INTEGER UNSIGNED ZEROFILL AFTER `pc_soft_count`,
 ADD COLUMN `implementation_in_study` INTEGER UNSIGNED ZEROFILL AFTER `implementation_in_industry`,
 ADD COLUMN `awards_for_scientific_work` TEXT AFTER `implementation_in_study`,
 ADD COLUMN `would_u_like_to_study_in_graduate_school` BOOLEAN AFTER `awards_for_scientific_work`,
 ADD COLUMN `would_u_like_to_work_in_science_education_field` BOOLEAN AFTER `would_u_like_to_study_in_graduate_school`,
 ADD COLUMN `division_wants_to_leave_student_in_division` BOOLEAN AFTER `would_u_like_to_work_in_science_education_field`;