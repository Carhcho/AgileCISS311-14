USE master;

 

IF DB_ID(N'TeachingDB') IS NOT NULL DROP DATABASE TeachingDB;

CREATE DATABASE TeachingDB;

GO

 

USE TeachingDB;

GO

CREATE TABLE instructor

(

           instructorId         INT NOT NULL IDENTITY,

           instructorName NVARCHAR(100) NOT NULL,

           CONSTRAINT pk_instructor PRIMARY KEY (instructorId)

);

CREATE TABLE course

(

           courseId INT NOT NULL IDENTITY,

           courseTitle NVARCHAR(100) NOT NULL,

           instructorId INT NOT NULL,

           CONSTRAINT pk_course PRIMARY KEY (courseId),

       --    CONSTRAINT fk_course_instructor FOREIGN KEY (instructorId)

                --  REFERENCES instructor(instructorId)

);
SET IDENTITY_INSERT instructor ON
 

INSERT INTO instructor (instructorName, instructorId) VALUES ('Cesar Roncancio', 1);

INSERT INTO instructor (instructorName, instructorId) VALUES ('Caley Cooper', 2);

INSERT INTO instructor (instructorName, instructorId) VALUES ('Kayla Crowley', 3);

 

INSERT INTO course (courseTitle, instructorId) VALUES ('Counters and blue', 1);

INSERT INTO course (courseTitle, instructorId) VALUES ('Green and Growth', 3);

INSERT INTO course (courseTitle, instructorId) VALUES ('Black and Discard', 3);

 

INSERT INTO course (courseTitle, instructorId) VALUES ('Artifacts and colorless', 2);

INSERT INTO course (courseTitle, instructorId) VALUES ('Damage and Red', 2);

INSERT INTO course (courseTitle, instructorId) VALUES ('White and summoning', 3);



 


 SELECT * FROM instructor
 SELECT * FROM course