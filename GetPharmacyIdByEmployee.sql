DECLARE @userName VARCHAR(255) = 'John';
DECLARE @password VARCHAR(255) = 'Doe';

SELECT Pharmacy.Id FROM Pharmacy
INNER JOIN Employee ON Pharmacy.Id = Employee.PharmacyId
WHERE Employee.Name = @userName AND Employee.Surname = @password;