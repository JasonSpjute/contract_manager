USE contracts;

-- CREATE TABLE jobs
-- (
--    id INT AUTO_INCREMENT,
--    name VARCHAR(255) NOT NULL UNIQUE,
--    description VARCHAR(255),
--    estimate DECIMAL(6 , 2),
--    PRIMARY KEY (id) 
-- );
-- CREATE TABLE contractors
-- (
--    id INT AUTO_INCREMENT,
--    name VARCHAR(255) NOT NULL UNIQUE,
--    PRIMARY KEY (id) 
-- );
-- CREATE TABLE contracts
-- (
--    id INT AUTO_INCREMENT,
--    jobId INT,
--    contractorId INT,
--    finalPrice DECIMAL(6 , 2),
--    completed TINYINT,
--    PRIMARY KEY (id),
--    FOREIGN KEY (jobId)
--    REFERENCES jobs(id)
--    ON DELETE CASCADE,
--    FOREIGN KEY (contractorId)
--    REFERENCES contractors(id)
--    ON DELETE CASCADE
-- );