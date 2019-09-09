# Barbiere [![Build Status](https://travis-ci.org/tiaringhio/Barbiere_WCF.svg?branch=master)](https://travis-ci.org/tiaringhio/Barbiere_WCF) [![Codacy Badge](https://api.codacy.com/project/badge/Grade/33ce920e933a454488a97253412cf862)](https://www.codacy.com/manual/tiaringhio/Barbiere_WCF?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=tiaringhio/Barbiere_WCF&amp;utm_campaign=Badge_Grade) [![buddy pipeline](https://app.buddy.works/mattiaricci000/barbiere-wcf/pipelines/pipeline/209265/badge.svg?token=b352d09ea8d3f10aca20d9070ee6d9924cae29eb7626929fbee30959f5a9844a "buddy pipeline")](https://app.buddy.works/mattiaricci000/barbiere-wcf/pipelines/pipeline/209265)
 This is a program that uses WCF Services to book appointments with your barber trough an intuitive GUI.
 
 - Checked with [Travis Ci](https://travis-ci.org/)
 - Checked with [Codacy](https://app.codacy.com)
 - Checked with [Buddy Works](https://buddy.works)
 
## Requirements
- SQL Express
- EasyEncryption
- Microsoft IIS
- .NET Framework (included in Visual Studio)

### [SQL Express](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)
Included you will find  `Barbiere.sql`, this file contains everything you need  to create the database required to run Barbiere, included all the tables and stored procedures.

### [EasyEncryption](https://github.com/polischuk/EasyEncryption)
 To install EasyEncryption just write:
 
 `Install-Package EasyEncryption`
 
 in the package manager console of Visual Studio.
 ### [Microsoft IIS](https://www.iis.net/)

The program uses IIS, Internet Information Services (IIS) for Windows® Server is a flexible, secure and manageable Web server for hosting anything on the Web. From media streaming to web applications, IIS's scalable and open architecture is ready to handle the most demanding tasks.
