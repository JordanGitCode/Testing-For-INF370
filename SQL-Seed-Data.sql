--User table
MERGE [User] AS target
USING (VALUES
    (2, 1, 1, 1, 1, 'Alice', 'Smith', '9501015009081', '0712345678', 'alice.smith@example.com', '1995-01-01', 'hash123Alice', 'Data Analyst'),
    (3, 1, 1, 1, 1, 'Brian', 'Johnson', '9203056001083', '0823456789', 'brian.johnson@example.com', '1992-03-05', 'hash123Brian', 'Project Manager'),
    (4, 1, 1, 1, 1, 'Cynthia', 'Lee', '8802147002086', '0834567890', 'cynthia.lee@example.com', '1988-02-14', 'hash123Cynthia', 'QA Engineer'),
    (5, 1, 1, 1, 1, 'David', 'Nguyen', '9906158009082', '0745678901', 'david.nguyen@example.com', '1999-06-15', 'hash123David', 'Software Developer'),
    (6, 1, 1, 1, 1, 'Elena', 'Garcia', '8709099001084', '0856789012', 'elena.garcia@example.com', '1987-09-09', 'hash123Elena', 'UX Designer'),
    (7, 1, 1, 1, 1, 'Frank', 'Morris', '9504221007089', '0767890123', 'frank.morris@example.com', '1995-04-22', 'hash123Frank', 'System Administrator'),
    (8, 1, 1, 1, 1, 'Grace', 'Taylor', '9312156002087', '0778901234', 'grace.taylor@example.com', '1993-12-15', 'hash123Grace', 'Product Owner'),
    (9, 1, 1, 1, 1, 'Henry', 'Wang', '9103054003088', '0789012345', 'henry.wang@example.com', '1991-03-05', 'hash123Henry', 'DevOps Engineer'),
    (10, 1, 1, 1, 1, 'Isabelle', 'Brown', '9610083004081', '0790123456', 'isabelle.brown@example.com', '1996-10-08', 'hash123Isabelle', 'Scrum Master'),
    (11, 1, 1, 1, 1, 'James', 'Clark', '9007212005083', '0801234567', 'james.clark@example.com', '1990-07-21', 'hash123James', 'Business Analyst')
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