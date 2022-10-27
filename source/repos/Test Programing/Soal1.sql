SELECT NIK, AVG(Nilai) AS RataRata FROM Table2 GROUP BY NIK
SELECT * FROM Tabel1 
--SELECT Tabel1.NIK, Tabel1.Nama, AVG(Table2.Nilai) AS RataRata FROM Tabel1, Table2 WHERE Tabel1.NIK = Table2.NIK GROUP BY Tabel1.NIK, Tabel1.Nama
SELECT Tabel1.NIK, Tabel1.Nama, AVG(Table2.Nilai) AS RataRata FROM Tabel1, Table2 WHERE Tabel1.NIK = Table2.NIK GROUP BY Tabel1.NIK, Tabel1.Nama

