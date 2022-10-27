SELECT Nomor, NIK, Nama, Nilai, 
CASE WHEN nilai >= 0 AND Nilai <= 50 THEN 'E' 
WHEN Nilai >= 51 AND Nilai <=80 THEN 'C'
WHEN Nilai >=81 AND Nilai <=100 THEN 'A'
END AS Point,
CASE WHEN nilai >= 0 AND Nilai <= 50 THEN 'Tidak Lulus' 
WHEN Nilai >= 51 AND Nilai <=80 THEN 'Cukup'
WHEN Nilai >=81 AND Nilai <=100 THEN 'Sangat Memuaskan'
END AS Keterangan 
FROM Tabel_Nilai

