create database CaseStudy
use casestudy

create table student(
 student_id int primary key,
 student_name varchar(30),
 student_dob Date)

 select * from student

 create table course(
 course_id int primary key,
 course_name varchar(30))

 select * from course

 create table enroll(
 student_id int foreign key references student(student_id)  ,
 course_id int foreign key references course(course_id) ,
 student_name varchar(30),
 student_dob Date,
 course_name varchar(30),
 enrolldate Date,
 primary key (student_id,course_id))

 select * from enroll