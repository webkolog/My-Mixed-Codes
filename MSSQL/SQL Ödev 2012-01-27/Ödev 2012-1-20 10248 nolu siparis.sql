SELECT
s.SiparisTarihi AS Tarih,
k.SirketAdi AS [Kargo �irketi],
m.YetkiliAdi AS [Alan Ki�i],
u.UrunAdi AS [�r�n Ad�],
sd.Fiyat AS [�r�n Fiyat�],
sd.Adet AS [�r�n Adeti],
c.Ad + ' ' + c.Soyad AS [Sipari�i Alan �al��an]
FROM Siparisler s
JOIN Kargolar k ON k.KargoID=s.KargoSirketi
JOIN Musteriler m ON m.MusteriID=s.MusteriID
JOIN [Siparis Detaylari] sd ON s.SiparisID=sd.SiparisID
JOIN Urunler u ON u.UrunID=sd.UrunID
JOIN Calisanlar c ON c.CalisanID=s.CalisanID
WHERE s.SiparisID='10248'