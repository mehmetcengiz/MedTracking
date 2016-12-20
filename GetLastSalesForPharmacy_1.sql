DECLARE @maxCount INT = 30;

SELECT TOP (@maxCount) *
FROM Sale, Prescription
ORDER BY SoldAt DESC;