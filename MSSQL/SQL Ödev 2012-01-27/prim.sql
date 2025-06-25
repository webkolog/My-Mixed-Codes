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
	--g�ncelle
	DECLARE @eskiUrunAdeti INT, @eskiPrimMiktar MONEY
	SELECT @eskiUrunAdeti = Adet, @eskiPrimMiktar = (Fiyat * 2 / 100) * Adet, @SipID = SiparisID, @UrunID = UrunID FROM deleted
	SELECT @UrunAdeti = Adet, @PrimMiktar = (Fiyat * 2 / 100) * Adet FROM inserted
	SELECT @CalID = CalisanID FROM Siparisler WHERE SiparisID = @SipID
		IF @eskiUrunAdeti > @UrunAdeti
		BEGIN
		--�r�n�n bir k�sm� iade ediliyorsa
		UPDATE Prim SET PrimMiktari -= (@eskiPrimMiktar - @PrimMiktar) WHERE CalisanID = @CalID
		UPDATE Urunler SET StoktakiBirimSayisi -= (@eskiUrunAdeti - @UrunAdeti) WHERE UrunID = @UrunID
		END
		ELSE IF @eskiUrunAdeti < @UrunAdeti
		BEGIN
		--�r�n�n sipari�teki say�s� art�r�l�rsa
		UPDATE Prim SET PrimMiktari += (@PrimMiktar - @eskiPrimMiktar) WHERE CalisanID = @CalID
		UPDATE Urunler SET StoktakiBirimSayisi += (@UrunAdeti - @eskiUrunAdeti) WHERE UrunID = @UrunID
		END
	END
	ELSE IF EXISTS(SELECT * FROM deleted)
	BEGIN
	--sil
	SELECT @SipID = SiparisID, @PrimMiktar = Fiyat * 2 / 100, @UrunAdeti = Adet, @UrunID = UrunID FROM deleted
	SELECT @CalID = CalisanID FROM Siparisler WHERE SiparisID = @SipID
	--�r�n�n tamam� iade ediliyorsa
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
		--�al��an�n daha �nce prim kay�d� varsa: PrimMiltar�n� art�r
		UPDATE Prim SET PrimMiktari += (@PrimMiktar * @UrunAdeti) WHERE CalisanID = @CalID
		END
		ELSE
		BEGIN
		--�al��an�n daha �nce prim kay�d� yoksa: �al��an ve prim miktar�n� ekle
		INSERT INTO Prim VALUES (@CalID, (@PrimMiktar * @UrunAdeti))
		END
	END
END

--  **--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**
--  **																			**
--  **  Bir adet Prim Tablosu olu�turulacak PErsonelID, PrimMiktari				**
--  **  Bir Sat�� ger�ekle�ti�i taktirde personel satt��� urunun %2 oran�nda	**
--  **  prim alacakt�r.															**
--  **  Eger sat�lan urun iade yada bir k�sm� iade olursa aradaki fark			**
--  **  primden dusulecektir.													**
--  **  Eger sat�� kayd� silinirse prim oran�da eksiltilecektir.				**
--  **  Iade ve Sat�slarda stok Hareketleride Urunler tablosuna yans�t�lacak	**
--  **  Bunlar TEK bir trigger ile olacakt�r.									**
--  **																			**
--  **--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**--**
-- 30.01.2012 --> 23.02.2012