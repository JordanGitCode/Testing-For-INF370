
-- Generated SQL schema for INF 370 - Team 20 Database

-- ============================
-- Location Hierarchy
-- ============================

CREATE TABLE Country
(
    Country_ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

CREATE TABLE Province
(
    Province_ID INT PRIMARY KEY,
    Country_ID INT,
    Name VARCHAR(100),
    FOREIGN KEY (Country_ID) REFERENCES Country(Country_ID)
);

CREATE TABLE City
(
    City_ID INT PRIMARY KEY,
    Province_ID INT,
    Name VARCHAR(100),
    FOREIGN KEY (Province_ID) REFERENCES Province(Province_ID)
);

CREATE TABLE Suburb
(
    Suburb_ID INT PRIMARY KEY,
    City_ID INT,
    Name VARCHAR(100),
    FOREIGN KEY (City_ID) REFERENCES City(City_ID)
);

-- ============================
-- [User] and Identity
-- ============================
CREATE TABLE Role
(
    Role_ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Description TEXT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

CREATE TABLE Title
(
    Title_ID INT PRIMARY KEY,
    Title VARCHAR(50)
);

CREATE TABLE Race
(
    Race_ID INT PRIMARY KEY,
    Race VARCHAR(50)
);

CREATE TABLE Gender
(
    Gender_ID INT PRIMARY KEY,
    Gender VARCHAR(50)
);

CREATE TABLE [User]
(
    User_ID INT PRIMARY KEY,
    Title_ID INT,
    Race_ID INT,
    Gender_ID INT,
    Role_ID INT,
    Name VARCHAR(100),
    Surname VARCHAR(100),
    IDNumber VARCHAR(20),
    PhoneNumber VARCHAR(20),
    EmailAddress VARCHAR(100),
    DateOfBirth DATE,
    PasswordHash TEXT,
    CurrentPosition VARCHAR(100),
    FOREIGN KEY (Title_ID) REFERENCES Title(Title_ID),
    FOREIGN KEY (Race_ID) REFERENCES Race(Race_ID),
    FOREIGN KEY (Gender_ID) REFERENCES Gender(Gender_ID),
    FOREIGN KEY (Role_ID) REFERENCES Role(Role_ID)
);

CREATE TABLE UserSession
(
    UserSession_ID INT PRIMARY KEY,
    User_ID INT,
    Session_Start DATETIME,
    Session_End DATETIME,
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID)
);

-- ============================
-- Permission and Security
-- ============================
CREATE TABLE PermissionCategory
(
    PermissionCategory_ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Description TEXT
);

CREATE TABLE Permission
(
    Permission_ID INT PRIMARY KEY,
    PermissionCategory_ID INT,
    Name VARCHAR(100),
    Description TEXT,
    FOREIGN KEY (PermissionCategory_ID) REFERENCES PermissionCategory(PermissionCategory_ID)
);

CREATE TABLE RolePermission
(
    Permission_ID INT,
    Role_ID INT,
    PRIMARY KEY (Permission_ID, Role_ID),
    FOREIGN KEY (Permission_ID) REFERENCES Permission(Permission_ID),
    FOREIGN KEY (Role_ID) REFERENCES Role(Role_ID)
);

-- ============================
-- Branches and Employees
-- ============================
CREATE TABLE Branch
(
    Branch_ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Address VARCHAR(200),
    Country_ID INT,
    Province_ID INT,
    City_ID INT,
    Suburb_ID INT,
    FOREIGN KEY (Country_ID) REFERENCES Country(Country_ID),
    FOREIGN KEY (Province_ID) REFERENCES Province(Province_ID),
    FOREIGN KEY (City_ID) REFERENCES City(City_ID),
    FOREIGN KEY (Suburb_ID) REFERENCES Suburb(Suburb_ID)
);

CREATE TABLE Job
(
    Job_ID INT PRIMARY KEY,
    Title VARCHAR(100),
    Description TEXT,
    Location VARCHAR(100),
    SalaryRangeMin DECIMAL(10,2),
    SalaryRangeMax DECIMAL(10,2),
    NumberVacancies INT
);

CREATE TABLE Employee
(
    Employee_ID INT PRIMARY KEY,
    User_ID INT,
    Branch_ID INT,
    Job_ID INT,
    CurrentSalary DECIMAL(10,2),
    HireDate DATE,
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Branch_ID) REFERENCES Branch(Branch_ID),
    FOREIGN KEY (Job_ID) REFERENCES Job(Job_ID)
);

-- ============================
-- Applications and Vacancies
-- ============================
CREATE TABLE Application
(
    Application_ID INT PRIMARY KEY,
    User_ID INT,
    DateApplied DATE,
    SalaryExpectation DECIMAL(10,2),
    ApplicantNote TEXT,
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID)
);

CREATE TABLE Vacancy
(
    Vacancy_ID INT PRIMARY KEY,
    Application_ID INT,
    Job_ID INT,
    Branch_ID INT,
    PostingDate DATE,
    UpdatedAt DATE,
    ApplicationDeadline DATE,
    FOREIGN KEY (Application_ID) REFERENCES Application(Application_ID),
    FOREIGN KEY (Job_ID) REFERENCES Job(Job_ID),
    FOREIGN KEY (Branch_ID) REFERENCES Branch(Branch_ID)
);

CREATE TABLE Shortlist
(
    Shortlist_ID INT PRIMARY KEY,
    Vacancy_ID INT,
    CreatedAt DATETIME,
    Stage VARCHAR(100),
    FOREIGN KEY (Vacancy_ID) REFERENCES Vacancy(Vacancy_ID)
);

CREATE TABLE ShortlistedCandidate
(
    User_ID INT,
    Shortlist_ID INT,
    PRIMARY KEY (User_ID, Shortlist_ID),
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Shortlist_ID) REFERENCES Shortlist(Shortlist_ID)
);

-- ============================
-- Interviews and Feedback
-- ============================
CREATE TABLE Interview
(
    Interview_ID INT PRIMARY KEY,
    User_ID INT,
    Employee_ID INT,
    Vacancy_ID INT,
    Location VARCHAR(100),
    Date DATE,
    Time TIME,
    Status VARCHAR(100),
    Result VARCHAR(100),
    InterviewType VARCHAR(100),
    InterviewRound VARCHAR(100),
    Duration INT,
    Score DECIMAL(5,2),
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Employee_ID) REFERENCES Employee(Employee_ID),
    FOREIGN KEY (Vacancy_ID) REFERENCES Vacancy(Vacancy_ID)
);

CREATE TABLE InterviewNote
(
    InterviewNote_ID INT PRIMARY KEY,
    Interview_ID INT,
    Note TEXT,
    CreatedAt DATETIME,
    LastUpdatedAt DATETIME,
    FOREIGN KEY (Interview_ID) REFERENCES Interview(Interview_ID)
);

CREATE TABLE ApplicationFeedback
(
    Feedback_ID INT PRIMARY KEY,
    Application_ID INT,
    Employee_ID INT,
    Comment TEXT,
    Date DATE,
    Time TIME,
    FOREIGN KEY (Application_ID) REFERENCES Application(Application_ID),
    FOREIGN KEY (Employee_ID) REFERENCES Employee(Employee_ID)
);

CREATE TABLE InterviewFeedback
(
    Feedback_ID INT PRIMARY KEY,
    Interview_ID INT,
    Comment TEXT,
    Date DATE,
    Time TIME,
    FOREIGN KEY (Interview_ID) REFERENCES Interview(Interview_ID)
);

-- ============================
-- Communication
-- ============================
CREATE TABLE Conversation
(
    Conversation_ID INT PRIMARY KEY,
    User_ID INT,
    Employee_ID INT,
    Subject VARCHAR(255),
    CreatedAt DATETIME,
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Employee_ID) REFERENCES Employee(Employee_ID)
);

CREATE TABLE Message
(
    Message_ID INT PRIMARY KEY,
    User_ID INT,
    Conversation_ID INT,
    MessageText TEXT,
    SentAt DATETIME,
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID),
    FOREIGN KEY (Conversation_ID) REFERENCES Conversation(Conversation_ID)
);

CREATE TABLE ConverationParticipant
(
    Conversation_ID INT,
    User_ID INT,
    JoinedAt DATETIME,
    PRIMARY KEY (Conversation_ID, User_ID),
    FOREIGN KEY (Conversation_ID) REFERENCES Conversation(Conversation_ID),
    FOREIGN KEY (User_ID) REFERENCES [User](User_ID)
);