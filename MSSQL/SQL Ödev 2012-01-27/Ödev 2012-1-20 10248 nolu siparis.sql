SELECT
s.SiparisTarihi AS Tarih,
k.SirketAdi AS [Kargo Þirketi],
m.YetkiliAdi AS [Alan Kiþi],
u.UrunAdi AS [Ürün Adý],
sd.Fiyat AS [Ürün Fiyatý],
sd.Adet AS [Ürün Adeti],
c.Ad + ' ' + c.Soyad AS [Sipariþi Alan Çalýþan]
FROM Siparisler s
JOIN Kargolar k ON k.KargoID=s.KargoSirketi
JOIN Musteriler m ON m.MusteriID=s.MusteriID
JOIN [Siparis Detaylari] sd ON s.SiparisID=sd.SiparisID
JOIN Urunler u ON u.UrunID=sd.UrunID
JOIN Calisanlar c ON c.CalisanID=s.CalisanID
WHERE s.SiparisID='10248'