# Barbiere [![Build Status](https://travis-ci.org/tiaringhio/Barbiere_WCF.svg?branch=master)](https://travis-ci.org/tiaringhio/Barbiere_WCF) [![Codacy Badge](https://api.codacy.com/project/badge/Grade/33ce920e933a454488a97253412cf862)](https://www.codacy.com/manual/tiaringhio/Barbiere_WCF?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=tiaringhio/Barbiere_WCF&amp;utm_campaign=Badge_Grade) [![buddy pipeline](https://app.buddy.works/mattiaricci000/barbiere-wcf/pipelines/pipeline/209265/badge.svg?token=b352d09ea8d3f10aca20d9070ee6d9924cae29eb7626929fbee30959f5a9844a "buddy pipeline")](https://app.buddy.works/mattiaricci000/barbiere-wcf/pipelines/pipeline/209265)
 This is a program that uses WCF Services to book appointments with your barber trough an intuitive GUI.
 
 **Created by:**
 
 -  [Mattia Ricci](https://github.com/tiaringhio)
 -  [Mattia Greci](https://github.com/MattiaG98)
 
 **Checked With:**
 
 -  [Travis Ci](https://travis-ci.org/)
 -  [Codacy](https://app.codacy.com)
 -  [Buddy Works](https://buddy.works)
 
## Requirements
-  SQL Server Express
-  SQL Server Management Studio (SSMS)
-  EasyEncryption
-  Microsoft IIS
-  .NET Framework (included in Visual Studio)

### [SQL Express](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)
Included you will find  `Barbiere.sql`, this file contains everything you need  to create the database required to run Barbiere, included all the tables and stored procedures.

### [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017)
We used SSMS to manage our db, it's very powerful and easy to use.

### [EasyEncryption](https://github.com/polischuk/EasyEncryption)
 To install EasyEncryption just write:
 
 `Install-Package EasyEncryption`
 
 in the package manager console of Visual Studio.
 
 ### [Microsoft IIS](https://www.iis.net/)

The program uses IIS, Internet Information Services (IIS) for Windows®

## Installation

-  Clone the repository
-  Create the database
   -  Under `\Resources` you will find `Barbiere.sql`, open it in SSMS and execute the query, you will create the db, everything included!
-  Open `Barbiere_WCF.sln`.
-  In the `Server Explorer` tab, refresh `Data Connections`, you should see `Barbiere`.
-  Install EasyEncryption.
-  Run the code! `F5`.

### Troubleshooting

You may want to change the connection string, although it should not be necessary, you can do it this way:
-  Right Click on Barbiere_WCF.sln
-  Properties
-  Settings
-  Here you will find the Connection String, feel free to change it!
### Polish

Just some things that improve the experience!

**Start every project at the same time:**
-  Right Click on Solution
-  Set StartUp Projects

![Start Multiple](https://github.com/tiaringhio/Barbiere_WCF/blob/master/Resources/multiple%20startup.jpg)

**Don't show WCF Test windows at start:**
-  Right click on Barbiere_WCF_Server
-  Properties

![Don't Show](https://github.com/tiaringhio/Barbiere_WCF/blob/master/Resources/no%20startup%20wcf.jpg)

### Contacts

Feel free to contact me on [Telegram](https://t.me/tiaringhio)
