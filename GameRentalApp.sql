/*==============================================================*/
/* DBMS name:      Microsoft SQL Server                          */
/* Created on:     5/16/2025                                     */
/*==============================================================*/

-- Drop foreign keys if they exist
IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_DEVELEOP_DEVELEOPS_VENDOR') AND parent_object_id = OBJECT_ID(N'DEVELEOPS'))
    ALTER TABLE DEVELEOPS DROP CONSTRAINT FK_DEVELEOP_DEVELEOPS_VENDOR;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_DEVELEOP_DEVELEOPS_GAME') AND parent_object_id = OBJECT_ID(N'DEVELEOPS'))
    ALTER TABLE DEVELEOPS DROP CONSTRAINT FK_DEVELEOP_DEVELEOPS_GAME;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_GAME_MANAGES_ADMIN') AND parent_object_id = OBJECT_ID(N'GAME'))
    ALTER TABLE GAME DROP CONSTRAINT FK_GAME_MANAGES_ADMIN;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_GAME_RELATIONS_GENRE') AND parent_object_id = OBJECT_ID(N'GAME'))
    ALTER TABLE GAME DROP CONSTRAINT FK_GAME_RELATIONS_GENRE;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_GAME_RENT_CLIENT') AND parent_object_id = OBJECT_ID(N'GAME'))
    ALTER TABLE GAME DROP CONSTRAINT FK_GAME_RENT_CLIENT;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_RENTED_RENTED_GAME') AND parent_object_id = OBJECT_ID(N'RENTED'))
    ALTER TABLE RENTED DROP CONSTRAINT FK_RENTED_RENTED_GAME;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_RENTED_RENTED2_RENTAL') AND parent_object_id = OBJECT_ID(N'RENTED'))
    ALTER TABLE RENTED DROP CONSTRAINT FK_RENTED_RENTED2_RENTAL;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_RENTS_RENTS_CLIENT') AND parent_object_id = OBJECT_ID(N'RENTS'))
    ALTER TABLE RENTS DROP CONSTRAINT FK_RENTS_RENTS_CLIENT;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_RENTS_RENTS2_RENTAL') AND parent_object_id = OBJECT_ID(N'RENTS'))
    ALTER TABLE RENTS DROP CONSTRAINT FK_RENTS_RENTS2_RENTAL;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_REVIEWED_REVIEWED_GAME') AND parent_object_id = OBJECT_ID(N'REVIEWED'))
    ALTER TABLE REVIEWED DROP CONSTRAINT FK_REVIEWED_REVIEWED_GAME;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_REVIEWED_REVIEWED2_REVIEW') AND parent_object_id = OBJECT_ID(N'REVIEWED'))
    ALTER TABLE REVIEWED DROP CONSTRAINT FK_REVIEWED_REVIEWED2_REVIEW;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_REVIEWS_REVIEWS_CLIENT') AND parent_object_id = OBJECT_ID(N'REVIEWS'))
    ALTER TABLE REVIEWS DROP CONSTRAINT FK_REVIEWS_REVIEWS_CLIENT;

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'FK_REVIEWS_REVIEWS2_REVIEW') AND parent_object_id = OBJECT_ID(N'REVIEWS'))
    ALTER TABLE REVIEWS DROP CONSTRAINT FK_REVIEWS_REVIEWS2_REVIEW;

-- Drop tables if they exist
IF OBJECT_ID('REVIEWS', 'U') IS NOT NULL
    DROP TABLE REVIEWS;

IF OBJECT_ID('REVIEWED', 'U') IS NOT NULL
    DROP TABLE REVIEWED;

IF OBJECT_ID('REVIEW', 'U') IS NOT NULL
    DROP TABLE REVIEW;

IF OBJECT_ID('RENTS', 'U') IS NOT NULL
    DROP TABLE RENTS;

IF OBJECT_ID('RENTED', 'U') IS NOT NULL
    DROP TABLE RENTED;

IF OBJECT_ID('RENTAL', 'U') IS NOT NULL
    DROP TABLE RENTAL;

IF OBJECT_ID('GAME', 'U') IS NOT NULL
    DROP TABLE GAME;

IF OBJECT_ID('GENRE', 'U') IS NOT NULL
    DROP TABLE GENRE;

IF OBJECT_ID('DEVELEOPS', 'U') IS NOT NULL
    DROP TABLE DEVELEOPS;

IF OBJECT_ID('CLIENT', 'U') IS NOT NULL
    DROP TABLE CLIENT;

IF OBJECT_ID('ADMIN', 'U') IS NOT NULL
    DROP TABLE ADMIN;

IF OBJECT_ID('VENDOR', 'U') IS NOT NULL
    DROP TABLE VENDOR;

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
CREATE TABLE ADMIN (
   ADMINID_             INT                NOT NULL,
   USERNAME             VARCHAR(250)       NULL,
   PASSWORD             INT                NULL,
   FULLNAME_            VARCHAR(250)       NULL,
   EMAIL                VARCHAR(250)       NULL,
   PHONE                INT                NULL,
   CONSTRAINT PK_ADMIN PRIMARY KEY (ADMINID_)
);

/*==============================================================*/
/* Index: ADMIN_PK                                              */
/*==============================================================*/
CREATE UNIQUE INDEX ADMIN_PK ON ADMIN (
ADMINID_ ASC
);

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
CREATE TABLE CLIENT (
   CLIENTID             INT                NOT NULL,
   USERNAME             VARCHAR(250)       NULL,
   FULLNAME             VARCHAR(250)       NULL,
   EMAIL                VARCHAR(250)       NULL,
   ADDRESS              VARCHAR(250)       NULL,
   PASSWORD             INT                NULL,
   PHONE                INT                NULL,
   CONSTRAINT PK_CLIENT PRIMARY KEY (CLIENTID)
);

/*==============================================================*/
/* Index: CLIENT_PK                                             */
/*==============================================================*/
CREATE UNIQUE INDEX CLIENT_PK ON CLIENT (
CLIENTID ASC
);

/*==============================================================*/
/* Table: VENDOR                                                */
/*==============================================================*/
CREATE TABLE VENDOR (
   VENDORID             INT                NOT NULL,
   VENDORNAME           VARCHAR(250)       NULL,
   CONTATCT_INFO        VARCHAR(250)      NULL,
   CONSTRAINT PK_VENDOR PRIMARY KEY (VENDORID)
);

/*==============================================================*/
/* Index: VENDOR_PK                                             */
/*==============================================================*/
CREATE UNIQUE INDEX VENDOR_PK ON VENDOR (
VENDORID ASC
);

/*==============================================================*/
/* Table: GENRE                                                 */
/*==============================================================*/
CREATE TABLE GENRE (
   GENRENAME            VARCHAR(250)      NOT NULL,
   CONSTRAINT PK_GENRE PRIMARY KEY (GENRENAME)
);

/*==============================================================*/
/* Index: GENRE_PK                                              */
/*==============================================================*/
CREATE UNIQUE INDEX GENRE_PK ON GENRE (
GENRENAME ASC
);

/*==============================================================*/
/* Table: GAME                                                  */
/*==============================================================*/
CREATE TABLE GAME (
   GAMEID               INT                NOT NULL,
   ADMINID_             INT                NOT NULL,
   GENRENAME            VARCHAR(250)      NULL,
   CLIENTID             INT                NULL,
   ATTRIBUTE_20         INT                NULL,
   ATTRIBUTE_21         INT                NULL,
   ATTRIBUTE_22         VARCHAR(205)       NULL,
   ATTRIBUTE_23         INT                NULL,
   CONSTRAINT PK_GAME PRIMARY KEY (GAMEID)
);

/*==============================================================*/
/* Index: GAME_PK                                               */
/*==============================================================*/
CREATE UNIQUE INDEX GAME_PK ON GAME (
GAMEID ASC
);

/*==============================================================*/
/* Index: MANAGES_FK                                            */
/*==============================================================*/
CREATE INDEX MANAGES_FK ON GAME (
ADMINID_ ASC
);

/*==============================================================*/
/* Index: RENT_FK                                               */
/*==============================================================*/
CREATE INDEX RENT_FK ON GAME (
CLIENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_8_FK                                     */
/*==============================================================*/
CREATE INDEX RELATIONSHIP_8_FK ON GAME (
GENRENAME ASC
);

/*==============================================================*/
/* Table: DEVELEOPS                                             */
/*==============================================================*/
CREATE TABLE DEVELEOPS (
   VENDORID             INT                NOT NULL,
   GAMEID               INT                NOT NULL,
   CONSTRAINT PK_DEVELEOPS PRIMARY KEY (VENDORID, GAMEID)
);

/*==============================================================*/
/* Index: DEVELEOPS_FK                                          */
/*==============================================================*/
CREATE INDEX DEVELEOPS_FK ON DEVELEOPS (
VENDORID ASC
);

/*==============================================================*/
/* Index: DEVELEOPS2_FK                                         */
/*==============================================================*/
CREATE INDEX DEVELEOPS2_FK ON DEVELEOPS (
GAMEID ASC
);

/*==============================================================*/
/* Table: RENTAL                                                */
/*==============================================================*/
CREATE TABLE RENTAL (
   ATTRIBUTE_25         INT                NOT NULL,
   ATTRIBUTE_26         VARCHAR(250)       NULL,
   ATTRIBUTE_27         VARCHAR(250)      NULL,
   ATTRIBUTE_28         VARCHAR(250)       NULL,
   CONSTRAINT PK_RENTAL PRIMARY KEY (ATTRIBUTE_25)
);

/*==============================================================*/
/* Index: RENTAL_PK                                             */
/*==============================================================*/
CREATE UNIQUE INDEX RENTAL_PK ON RENTAL (
ATTRIBUTE_25 ASC
);

/*==============================================================*/
/* Table: RENTED                                                */
/*==============================================================*/
CREATE TABLE RENTED (
   GAMEID               INT                NOT NULL,
   ATTRIBUTE_25         INT                NOT NULL,
   CONSTRAINT PK_RENTED PRIMARY KEY (GAMEID, ATTRIBUTE_25)
);

/*==============================================================*/
/* Index: RENTED_FK                                             */
/*==============================================================*/
CREATE INDEX RENTED_FK ON RENTED (
GAMEID ASC
);

/*==============================================================*/
/* Index: RENTED2_FK                                            */
/*==============================================================*/
CREATE INDEX RENTED2_FK ON RENTED (
ATTRIBUTE_25 ASC
);

/*==============================================================*/
/* Table: RENTS                                                 */
/*==============================================================*/
CREATE TABLE RENTS (
   CLIENTID             INT                NOT NULL,
   ATTRIBUTE_25         INT                NOT NULL,
   CONSTRAINT PK_RENTS PRIMARY KEY (CLIENTID, ATTRIBUTE_25)
);

/*==============================================================*/
/* Index: RENTS_FK                                              */
/*==============================================================*/
CREATE INDEX RENTS_FK ON RENTS (
CLIENTID ASC
);

/*==============================================================*/
/* Index: RENTS2_FK                                             */
/*==============================================================*/
CREATE INDEX RENTS2_FK ON RENTS (
ATTRIBUTE_25 ASC
);

/*==============================================================*/
/* Table: REVIEW                                                */
/*==============================================================*/
CREATE TABLE REVIEW (
   REVIEWID             INT                NOT NULL,
   RATING               INT                NULL,
   [COMMENT]            VARCHAR(250)       NULL, -- Using square brackets for reserved keyword
   REVIEWDATE           VARCHAR(250)       NULL,
   CONSTRAINT PK_REVIEW PRIMARY KEY (REVIEWID)
);

/*==============================================================*/
/* Index: REVIEW_PK                                             */
/*==============================================================*/
CREATE UNIQUE INDEX REVIEW_PK ON REVIEW (
REVIEWID ASC
);

/*==============================================================*/
/* Table: REVIEWED                                              */
/*==============================================================*/
CREATE TABLE REVIEWED (
   GAMEID               INT                NOT NULL,
   REVIEWID             INT                NOT NULL,
   CONSTRAINT PK_REVIEWED PRIMARY KEY (GAMEID, REVIEWID)
);

/*==============================================================*/
/* Index: REVIEWED_FK                                           */
/*==============================================================*/
CREATE INDEX REVIEWED_FK ON REVIEWED (
GAMEID ASC
);

/*==============================================================*/
/* Index: REVIEWED2_FK                                          */
/*==============================================================*/
CREATE INDEX REVIEWED2_FK ON REVIEWED (
REVIEWID ASC
);

/*==============================================================*/
/* Table: REVIEWS                                               */
/*==============================================================*/
CREATE TABLE REVIEWS (
   CLIENTID             INT                NOT NULL,
   REVIEWID             INT                NOT NULL,
   CONSTRAINT PK_REVIEWS PRIMARY KEY (CLIENTID, REVIEWID)
);

/*==============================================================*/
/* Index: REVIEWS_FK                                            */
/*==============================================================*/
CREATE INDEX REVIEWS_FK ON REVIEWS (
CLIENTID ASC
);

/*==============================================================*/
/* Index: REVIEWS2_FK                                           */
/*==============================================================*/
CREATE INDEX REVIEWS2_FK ON REVIEWS (
REVIEWID ASC
);

-- Add all foreign key constraints
ALTER TABLE DEVELEOPS
   ADD CONSTRAINT FK_DEVELEOP_DEVELEOPS_VENDOR FOREIGN KEY (VENDORID)
      REFERENCES VENDOR (VENDORID);

ALTER TABLE DEVELEOPS
   ADD CONSTRAINT FK_DEVELEOP_DEVELEOPS_GAME FOREIGN KEY (GAMEID)
      REFERENCES GAME (GAMEID);

ALTER TABLE GAME
   ADD CONSTRAINT FK_GAME_MANAGES_ADMIN FOREIGN KEY (ADMINID_)
      REFERENCES ADMIN (ADMINID_);

ALTER TABLE GAME
   ADD CONSTRAINT FK_GAME_RELATIONS_GENRE FOREIGN KEY (GENRENAME)
      REFERENCES GENRE (GENRENAME);

ALTER TABLE GAME
   ADD CONSTRAINT FK_GAME_RENT_CLIENT FOREIGN KEY (CLIENTID)
      REFERENCES CLIENT (CLIENTID);

ALTER TABLE RENTED
   ADD CONSTRAINT FK_RENTED_RENTED_GAME FOREIGN KEY (GAMEID)
      REFERENCES GAME (GAMEID);

ALTER TABLE RENTED
   ADD CONSTRAINT FK_RENTED_RENTED2_RENTAL FOREIGN KEY (ATTRIBUTE_25)
      REFERENCES RENTAL (ATTRIBUTE_25);

ALTER TABLE RENTS
   ADD CONSTRAINT FK_RENTS_RENTS_CLIENT FOREIGN KEY (CLIENTID)
      REFERENCES CLIENT (CLIENTID);

ALTER TABLE RENTS
   ADD CONSTRAINT FK_RENTS_RENTS2_RENTAL FOREIGN KEY (ATTRIBUTE_25)
      REFERENCES RENTAL (ATTRIBUTE_25);

ALTER TABLE REVIEWED
   ADD CONSTRAINT FK_REVIEWED_REVIEWED_GAME FOREIGN KEY (GAMEID)
      REFERENCES GAME (GAMEID);

ALTER TABLE REVIEWED
   ADD CONSTRAINT FK_REVIEWED_REVIEWED2_REVIEW FOREIGN KEY (REVIEWID)
      REFERENCES REVIEW (REVIEWID);

ALTER TABLE REVIEWS
   ADD CONSTRAINT FK_REVIEWS_REVIEWS_CLIENT FOREIGN KEY (CLIENTID)
      REFERENCES CLIENT (CLIENTID);

ALTER TABLE REVIEWS
   ADD CONSTRAINT FK_REVIEWS_REVIEWS2_REVIEW FOREIGN KEY (REVIEWID)
      REFERENCES REVIEW (REVIEWID);