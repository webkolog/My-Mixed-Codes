CREATE TABLE Prim (
CalisanID INT NOT NULL,
PrimMiktari MONEY NOT NULL
)

CREATE TRIGGER trg_SiparisDetaylari
ON [Siparis Detaylari]
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
DECLARE @SipID INT, @CalID INT, @PrimMiktar MONEY, @UrunAdeti INT, @UrunID INT
	IF EXISTS(SELECT * FROM deleted) AND EXISTS(SELECT * FROM inserted)
	BEGIN
	--güncelle
	DECLARE @eskiUrunAdeti INT, @eskiPrimMiktar MONEY
	SELECT @eskiUrunAdeti = Adet, @eskiPrimMiktar = (Fiyat * 2 / 100) * Adet, @SipID = SiparisID, @UrunID = UrunID FROM deleted
	SELECT @UrunAdeti = Adet, @PrimMiktar = (Fiyat * 2 / 100) * Adet FROM inserted
	SELECT @CalID = CalisanID FROM Siparisler WHERE SiparisID = @SipID
		IF @eskiUrunAdeti > @UrunAdeti
		BEGIN
		--ürünün bir kýsmý iade ediliyorsa
		UPDATE Prim SET PrimMiktari -= (@eskiPrimMiktar - @PrimMiktar) WHERE CalisanID = @CalID
		UPDATE Urunler SET StoktakiBirimSayisi -= (@eskiUrunAdeti - @UrunAdeti) WHERE UrunID = @UrunID
		END
		ELSE IF @eskiUrunAdeti < @UrunAdeti
		BEGIN
		--ürünün sipariþteki sayýsý artýrýlýrsa
		UPDATE Prim SET PrimMiktari += (@PrimMiktar - @eskiPrimMiktar) WHERE CalisanID = @CalID
		UPDATE Urunler SET StoktakiBirimSayisi += (@UrunAdeti - @eskiUrunAdeti) WHERE UrunID = @UrunID
		END
	END
	ELSE IF EXISTS(SELECT * FROM deleted)
	BEGIN
	--sil
	SELECT @SipID = SiparisID, @PrimMiktar = Fiyat * 2 / 100, @UrunAdeti = Adet, @UrunID = UrunID FROM deleted
	SELECT @CalID = CalisanID FROM Siparisler WHERE SiparisID = @SipID
	--ürünün tamamý iade ediliyorsa
	UPDATE Urunler SET StoktakiBirimSayisi += @UrunAdeti WHERE UrunID = @UrunID
	UPDATE Prim SET PrimMiktari -= (@PrimMiktar * @UrunAdeti) WHERE CalisanID = @CalID
	END
	ELSE IF EXISTS(SELECT * FROM inserted)
	BEGIN
	--ekle
	SELECT @SipID = SiparisID, @PrimMiktar = Fiyat * 2 / 100, @UrunAdeti = Adet, @UrunID = UrunID FROM inserted
	SELECT @CalID = CalisanID FROM Siparisler WHERE SiparisID = @SipID
	UPDATE Urunler SET StoktakiBirimSayisi -= @UrunAdeti WHERE UrunID = @UrunID
		IF EXISTS(SELECT * FROM Prim WHERE CalisanID = @CalID)
		BEGIN
		--çalýþanýn daha önce prim kayýdý varsa: PrimMiltarýný artýr
		UPDATE Prim SET PrimMiktari += (@PrimMiktar * @UrunAdeti) WHERE CalisanID = @CalID
		END
		ELSE
		BEGIN
		--çalýþanýn daha önce prim kayýdý yoksa: çalýþan ve prim miktarýný ekle
		INSERT INTO Prim VALUES (@CalID, (@PrimMiktar * @UrunAdeti))
		END
	END
END

--  **--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**
--  **																			**
--  **  Bir adet Prim Tablosu oluþturulacak PErsonelID, PrimMiktari				**
--  **  Bir Satýþ gerçekleþtiði taktirde personel sattýðý urunun %2 oranýnda	**
--  **  prim alacaktýr.															**
--  **  Eger satýlan urun iade yada bir kýsmý iade olursa aradaki fark			**
--  **  primden dusulecektir.													**
--  **  Eger satýþ kaydý silinirse prim oranýda eksiltilecektir.				**
--  **  Iade ve Satýslarda stok Hareketleride Urunler tablosuna yansýtýlacak	**
--  **  Bunlar TEK bir trigger ile olacaktýr.									**
--  **																			**
--  **--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**
-- 30.01.2012 --> 23.02.2012