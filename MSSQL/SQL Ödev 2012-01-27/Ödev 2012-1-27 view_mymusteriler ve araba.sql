CREATE VIEW v_MyMusteriler
AS
SELECT 
mm.MusteriAdi,
CASE
WHEN mi.ILID IS NULL THEN
'216'
ELSE
mi.ILID
END AS [Tel Kodu],
CASE 
WHEN mi.ILID IS NULL THEN
'ISTANBUL ANADOLU'
ELSE
mi.IlAdi
END AS [Nereden Aradý],
CASE
WHEN LEN(mm.TelNo) = 7 THEN
'90 216 ' + mm.TelNo
WHEN LEN(mm.TelNo) = 10 THEN
'90 ' + LEFT(mm.TelNo,3) + ' ' + RIGHT(mm.TelNo,7)
ELSE
LEFT(mm.TelNo,2) + ' ' + SUBSTRING(mm.TelNo,3,3) + ' ' + RIGHT(mm.TelNo,7)
END AS [Telefon Numarasý]
FROM MyMusteriler mm LEFT JOIN MyIller mi ON mi.ILID = LEFT(REPLACE(LEFT(mm.TelNo,2),'90','') + SUBSTRING(mm.TelNo,3,LEN(mm.TelNo)-7),3)

---Kaç kez Þehirden aranmýþ
CREATE VIEW v_MyArayanUlkeler
AS
SELECT
mi.IlAdi AS Þehir,
COUNT(mi.ILID) AS Toplam
FROM MyMusteriler mm
LEFT JOIN MyIller mi ON mi.ILID = 
CASE
WHEN LEN(mm.TelNo) = 7 THEN
216
ELSE
SUBSTRING(REPLACE(SUBSTRING(mm.TelNo,1,2),'90','') + SUBSTRING(mm.TelNo,3,LEN(mm.TelNo)-7),1,3)
END
GROUP BY mi.ILID, mi.IlAdi

----Araba

INSERT INTO [Araba Seyehatleri] VALUES (212,312,'2012-10-10 01:00:00.000','2012-11-10 12:00:00.000')
INSERT INTO [Araba Seyehatleri] VALUES (312,216,'2012-10-10 02:00:00.000','2012-11-10 13:00:00.000')
INSERT INTO [Araba Seyehatleri] VALUES (216,212,'2012-10-10 01:00:00.000','2012-11-10 12:00:00.000')
INSERT INTO [Araba Seyehatleri] VALUES (212,216,'2012-10-13 10:00:00.000','2012-12-10 01:00:00.000')
INSERT INTO [Araba Seyehatleri] VALUES (216,312,'2012-12-13 01:00:00.000',NULL)

CREATE VIEW v_ArabaSeyehat
AS
SELECT
m1.IlAdi AS Nereden,
m2.IlAdi AS Nereye,
a.[Gidiþ Tarihi],
a.[Geliþ Tarihi],
DATEDIFF(HOUR, a.[Gidiþ Tarihi], a.[Geliþ Tarihi]) AS [Kaç Saat Sürdü],
CASE
WHEN a.[Geliþ Tarihi] IS NULL THEN
CONVERT(NVARCHAR(10),DATEDIFF(HOUR, GETDATE(), a.[Gidiþ Tarihi])) + ' Saatir yolda '
ELSE
'(Yolda Deðil)'
END AS [Kaç Saatir Yolda]
FROM [Araba Seyehatleri] a
JOIN MyIller m1 ON
a.Nereden=m1.ILID
JOIN MyIller m2 ON
a.Nereye=m2.ILID


