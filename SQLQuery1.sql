create database HospitalManagement;

use HospitalManagement;

create table Doctor(DoctorId Int primary key,DoctorName varchar(100),Department varchar(100));

create table Patient(PatientId Int primary key,PatientName varchar(100),DiseaseName varchar(100));

create table PrescriptionManagement(DrugNo Int primary key,DrugName varchar(100),DrugDosage varchar(100) );

create table RoomsManagement(RoomNo Int primary key,NoOfBed numeric(20),NoOfBedAvailable numeric(20) );

create table AppointmentsManagement(NoOfAppointment Int primary key,AppointmentDate datetime,Department varchar(100));

create table BillingDetails(BillingNo int primary key,BillingDescription varchar(100),BillingAmount numeric(20));

create table PatientHistory(PatientId int FOREIGN KEY (PatientId) REFERENCES Patient(PatientId),PatientName varchar(100),JoiningDate date,Dischargedate date,DieaseName varchar(100));