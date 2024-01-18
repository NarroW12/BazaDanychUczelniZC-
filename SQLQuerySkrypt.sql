USE Uczelnia;
-- Struktura bazy danych
CREATE TABLE Uczniowie (
    UczenID INT PRIMARY KEY IDENTITY(1,1),
    Imie NVARCHAR(50),
    Nazwisko NVARCHAR(50),
    NrIndeksu NVARCHAR(10),
    Semestr INT
	-- dodaæ co siê uczy (jaki zak³ad)
);

CREATE TABLE Wykladowcy (
    WykladowcaID INT PRIMARY KEY IDENTITY(1,1),
    Imie NVARCHAR(50),
    Nazwisko NVARCHAR(50),
    Stopien NVARCHAR(50),
    Specjalizacja NVARCHAR(100)
);

CREATE TABLE HR (
    HRID INT PRIMARY KEY IDENTITY(1,1),
    Imie NVARCHAR(50),
    Nazwisko NVARCHAR(50),
    Stanowisko NVARCHAR(50)
);

CREATE TABLE Wydzialy (
    WydzialID INT PRIMARY KEY IDENTITY(1,1),
    Nazwa NVARCHAR(50),
    Zaklad NVARCHAR(50)
);

CREATE TABLE KierownicyWydzialu (
    KierownikID INT PRIMARY KEY IDENTITY(1,1),
    Imie NVARCHAR(50),
    Nazwisko NVARCHAR(50),
    WydzialID INT,
    FOREIGN KEY (WydzialID) REFERENCES Wydzialy(WydzialID)
);

CREATE TABLE Oceny (
    OcenaID INT PRIMARY KEY IDENTITY(1,1),
    UczenID INT,
    Przedmiot NVARCHAR(50),
    Ocena INT,
    FOREIGN KEY (UczenID) REFERENCES Uczniowie(UczenID)
);

-- Dodanie indeksów
CREATE INDEX idx_NrIndeksu ON Uczniowie(NrIndeksu);
CREATE INDEX idx_Specjalizacja ON Wykladowcy(Specjalizacja);

-- Dodanie procedury do dodawania ucznia
GO
CREATE PROCEDURE DodajUcznia
    @Imie NVARCHAR(50),
    @Nazwisko NVARCHAR(50),
    @NrIndeksu NVARCHAR(10),
    @Semestr INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        INSERT INTO Uczniowie (Imie, Nazwisko, NrIndeksu, Semestr)
        VALUES (@Imie, @Nazwisko, @NrIndeksu, @Semestr);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;
-- Dodanie procedury do dodawania wyk³adowcy
GO
CREATE or ALTER PROCEDURE DodajWykladowce
    @Imie NVARCHAR(50),
    @Nazwisko NVARCHAR(50),
    @Stopien NVARCHAR(10),
    @Specjalizacja NVARCHAR(100)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        INSERT INTO Wykladowcy(Imie, Nazwisko, Stopien, Specjalizacja)
        VALUES (@Imie, @Nazwisko, @Stopien, @Specjalizacja);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;
-- Dodanie procedury do dodawania HR
GO
CREATE or ALTER PROCEDURE DodajHR
    @Imie NVARCHAR(50),
    @Nazwisko NVARCHAR(50),
    @Stanowisko NVARCHAR(50)
 
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        INSERT INTO HR(Imie, Nazwisko, Stanowisko)
        VALUES (@Imie, @Nazwisko, @Stanowisko);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;
-- Dodanie procedury do dodawania Wydzia³y
GO
CREATE or ALTER PROCEDURE DodajWydzial
    @Nazwa NVARCHAR(50),
    @Zaklad NVARCHAR(50)
 
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        INSERT INTO Wydzialy(Nazwa, Zaklad)
        VALUES (@Nazwa, @Zaklad);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;
-- Dodanie triggera do aktualizacji semestru ucznia po dodaniu oceny
GO
CREATE TRIGGER AktualizujSemestr
ON Oceny
AFTER INSERT
AS
BEGIN
    UPDATE Uczniowie
    SET Semestr = Semestr + 1
    FROM Uczniowie
    JOIN inserted ON Uczniowie.UczenID = inserted.UczenID;
END;

-- Pozosta³e procedury, triggery itp. mo¿na dodawaæ podobnie
Select * From Uczniowie;
Select * From Wykladowcy;
Select * From HR;
Select * From Wydzialy;

-- Dodanie nowej kolumny Zaklad
