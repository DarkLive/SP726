--CREATE DATABASE Emlak;

USE Emlak;

CREATE TABLE Personel (
PersonelID int IDENTITY(1,1) PRIMARY KEY,
PersonelAd nvarchar(50),
PersonelSoyad nvarchar(50),
Sifre nvarchar(70),
AktifCalisan bit)

CREATE TABLE EmlakTipleri (
EmlakTipID int IDENTITY(1,1) PRIMARY KEY,
EmlakTipAdi nvarchar(50) UNIQUE)
CREATE INDEX IX_LastName ON EmlakTipleri(EmlakTipAdi);

CREATE TABLE Emlak (
EmlakID int IDENTITY(1,1) PRIMARY KEY,
EmlakTipi nvarchar(50),
EmlakOdaSayýsý smallint,
EmlakSalonSayýsý smallint,
EmlakBulunduðuKat smallint,
EmlakKatSayýsý smallint,
EmlakAdres nvarchar(250),
EmlakFiyat money,
Cephe nvarchar(50),
Otopark bit,
CONSTRAINT CHK_Price CHECK (EmlakFiyat < 500.000),
CONSTRAINT CHK_Floor CHECK (EmlakBulunduðuKat <= EmlakKatSayýsý))

CREATE TABLE Musteri (
MusteriID int IDENTITY(1,1) PRIMARY KEY,
MusteriAdi nvarchar(50))

CREATE TABLE SatisTablosu (
SatisID int IDENTITY(1,1) PRIMARY KEY,
PersonelID int,
MusteriID int,
EmlakID int,
SatisTipi nvarchar(50))

ALTER TABLE SatisTablosu ADD FOREIGN KEY (PersonelID) REFERENCES Personel(PersonelID)
ALTER TABLE SatisTablosu ADD FOREIGN KEY (MusteriID) REFERENCES Musteri(MusteriID)
ALTER TABLE SatisTablosu ADD FOREIGN KEY (EmlakID) REFERENCES Emlak(EmlakID)

--BACKUP DATABASE Emlak
--TO DISK = 'C:\xapps\SQLBackup\Emlak.bak';