--User table
MERGE [User] AS target
USING (VALUES
    (1, 1, 1, 1, 2, 'John', 'Doe', '9001015009087', '0123456789', 'john.doe@example.com', '1990-01-01', 'hashed_password_1', 'Software Developer'),
    (2, 2, 2, 2, 3, 'Jane', 'Smith', '9203050087089', '0987654321', 'jane.smith@example.com', '1992-03-05', 'hashed_password_2', 'Data Analyst')
) AS source (
    User_ID, Title_ID, Race_ID, Gender_ID, Role_ID, Name, Surname, IDNumber, PhoneNumber, EmailAddress, DateOfBirth, PasswordHash, CurrentPosition
)
ON target.User_ID = source.User_ID
WHEN MATCHED THEN
    UPDATE SET 
        Title_ID = source.Title_ID,
        Race_ID = source.Race_ID,
        Gender_ID = source.Gender_ID,
        Role_ID = source.Role_ID,
        Name = source.Name,
        Surname = source.Surname,
        IDNumber = source.IDNumber,
        PhoneNumber = source.PhoneNumber,
        EmailAddress = source.EmailAddress,
        DateOfBirth = source.DateOfBirth,
        PasswordHash = source.PasswordHash,
        CurrentPosition = source.CurrentPosition
WHEN NOT MATCHED BY TARGET THEN
    INSERT (
        User_ID, Title_ID, Race_ID, Gender_ID, Role_ID, Name, Surname, IDNumber, PhoneNumber, EmailAddress, DateOfBirth, PasswordHash, CurrentPosition
    )
    VALUES (
        source.User_ID, source.Title_ID, source.Race_ID, source.Gender_ID, source.Role_ID, source.Name, source.Surname, source.IDNumber, source.PhoneNumber, source.EmailAddress, source.DateOfBirth, source.PasswordHash, source.CurrentPosition
    );

--Gender table
MERGE Gender AS target
USING (VALUES
    (1, 'Male'),
    (2, 'Female'),
    (3, 'Prefer Not to Say')
) AS source (Gender_ID, Gender)
ON target.Gender_ID = source.Gender_ID
WHEN MATCHED THEN
    UPDATE SET Gender = source.Gender
WHEN NOT MATCHED BY TARGET THEN
    INSERT (Gender_ID, Gender)
    VALUES (source.Gender_ID, source.Gender);

--Race table
MERGE Race AS target
USING (VALUES
    (1, 'Black'),
    (2, 'White'),
    (3, 'Coloured'),
    (4, 'Indian'),
    (5, 'Other')
) AS source (Race_ID, Race)
ON target.Race_ID = source.Race_ID
WHEN MATCHED THEN
    UPDATE SET Race = source.Race
WHEN NOT MATCHED BY TARGET THEN
    INSERT (Race_ID, Race)
    VALUES (source.Race_ID, source.Race);

--Using MERGE to make sure the table matches source
MERGE Title AS target
USING (VALUES
    (1, 'Mr'),
    (2, 'Ms'),
    (3, 'Mrs'),
    (4, 'Dr'),
    (5, 'Prof')
) AS source (Title_ID, Title)
ON target.Title_ID = source.Title_ID
WHEN MATCHED THEN
    UPDATE SET Title = source.Title
WHEN NOT MATCHED BY TARGET THEN
    INSERT (Title_ID, Title)
    VALUES (source.Title_ID, source.Title);

--Role table
MERGE Role AS target
USING (VALUES
    (1, 'Admin', 'Full system access', GETDATE(), GETDATE()),
    (2, 'User', 'General access to system features', GETDATE(), GETDATE()),
    (3, 'Guest', 'Limited access for viewing only', GETDATE(), GETDATE())
) AS source (Role_ID, Name, Description, CreatedAt, UpdatedAt)
ON target.Role_ID = source.Role_ID
WHEN MATCHED THEN
    UPDATE SET 
        Name = source.Name,
        Description = source.Description,
        UpdatedAt = GETDATE()
WHEN NOT MATCHED BY TARGET THEN
    INSERT (Role_ID, Name, Description, CreatedAt, UpdatedAt)
    VALUES (source.Role_ID, source.Name, source.Description, source.CreatedAt, source.UpdatedAt);