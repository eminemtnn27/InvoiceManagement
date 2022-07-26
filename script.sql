USE [FinishProject]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dues]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dues](
	[DuesId] [int] IDENTITY(1,1) NOT NULL,
	[DueAmount] [nvarchar](max) NULL,
	[PaymentType] [nvarchar](max) NULL,
	[UserId] [int] NOT NULL,
	[DueDate] [datetime2](7) NOT NULL,
	[billingDate] [datetime2](7) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_dues] PRIMARY KEY CLUSTERED 
(
	[DuesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[flats]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[flats](
	[FlatId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[FlatOwnerName] [nvarchar](max) NULL,
	[FlatNo] [nvarchar](max) NULL,
	[FlatType] [nvarchar](max) NULL,
	[FlatLocation] [nvarchar](max) NULL,
	[BlockNo] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_flats] PRIMARY KEY CLUSTERED 
(
	[FlatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[invoice]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[invoice](
	[InvoiceId] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNo] [int] NOT NULL,
	[Amount] [nvarchar](max) NULL,
	[PaymentType] [nvarchar](max) NULL,
	[UserId] [int] NOT NULL,
	[DueDate] [datetime2](7) NOT NULL,
	[billingDate] [datetime2](7) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[messages]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[messages](
	[MessageId] [int] IDENTITY(1,1) NOT NULL,
	[SenderId] [int] NOT NULL,
	[ReceiveId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Subject] [nvarchar](max) NULL,
	[Messages] [nvarchar](max) NULL,
	[MessageDate] [datetime2](7) NOT NULL,
	[MessageStatus] [bit] NOT NULL,
 CONSTRAINT [PK_messages] PRIMARY KEY CLUSTERED 
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[PaymentId] [int] IDENTITY(1,1) NOT NULL,
	[BillingSum] [decimal](18, 2) NOT NULL,
	[BillingDate] [datetime2](7) NOT NULL,
	[IsPaid] [bit] NOT NULL,
	[FlatId] [int] NOT NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 14.08.2022 20:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Surname] [nvarchar](max) NULL,
	[TcNo] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[PhoneNo] [nvarchar](max) NULL,
	[NumberPlate] [nvarchar](max) NULL,
	[UserRole] [nvarchar](max) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220814135146_updatedMigration', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220814135221_authMigration', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220814135731_updatedsMigration', N'5.0.17')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Admin', N'EMINE@GMAIL.COM', N'09370d7e-07a3-4858-a7b1-8e8d1f753ee2')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'User', N'EDA@GMAIL.COM', N'31bf753d-d2c3-490e-927c-3863e5345502')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1c88f8ff-8ccf-4543-8b92-59e9f0f08aff', N'1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ebe99907-1d39-4d65-9a9c-145ebcf997e5', N'2')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1c88f8ff-8ccf-4543-8b92-59e9f0f08aff', N'emine@gmail.com', N'EMINE@GMAIL.COM', N'emine@gmail.com', N'EMINE@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELbtzPLpxX0cHCXm9lep4jmE8RlpJbEgqNOfN6zh96F3mG6FDOkz4gv4DanP8NJjfg==', N'7VDSG2O2QDYWUAG53B2CUNUSR2LFXZRP', N'09370d7e-07a3-4858-a7b1-8e8d1f753ee2', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4683c0af-3a6f-4541-8ace-78323f98e3b0', N'seda@gmail.com', N'SEDA@GMAIL.COM', N'seda@gmail.com', N'SEDA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEDUNlyJlzFq3ikCOc+C5cK0BCCKJ/WLF3A/1pmqxIgcRDn3+GPvNrclEddnTYZOQQg==', N'2JULMRGIQV2HDEZCUQ25G6VVVOTXD3RK', N'5f8773aa-f520-4068-a44d-e328fc6ca6f8', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'8fece539-3f88-4fcf-9855-b84249fc680d', N'edaa@gmail.com', N'EDAA@GMAIL.COM', N'edaa@gmail.com', N'EDAA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGRtDMRzjPqQZK5jDXwCRiiWDyLYqibYCOTxV0IJ/2oiTufGCBxCVNwTWFZ3kLS8Wg==', N'IJZ4LPVLAKJZ7ZYVTXTN7OWH5BSNANXY', N'f33bdc03-29c2-49af-b512-e10a2dc7aa12', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'9e22db52-87b1-4918-8de9-ce4b9480340f', N'edam@gmail.com', N'EDAM@GMAIL.COM', N'edam@gmail.com', N'EDAM@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEENZgt9WawXCy81JajK4IwXGy4lTE0ZEa0Yop2UM4LP52ced6JQ1/4ZfNqQtlN2eiA==', N'BPW7VXXQEMF4ZHO7LQUOZ2LEZTKZGVYG', N'82f8244e-21d9-427b-80ea-c642d349155f', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'ebe99907-1d39-4d65-9a9c-145ebcf997e5', N'eda@gmail.com', N'EDA@GMAIL.COM', N'eda@gmail.com', N'EDA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJWh1lCLXE/DMikDvmBFwynL1iM6GE22SoW9B2VgsCYtNzTs8Wv4PT/2e90r64BSGA==', N'WIKJK4JX5GEIGEGMKRDLO2IENJD75FDN', N'31bf753d-d2c3-490e-927c-3863e5345502', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[dues] ON 

INSERT [dbo].[dues] ([DuesId], [DueAmount], [PaymentType], [UserId], [DueDate], [billingDate], [Status]) VALUES (4, N'350', N'Credit Card', 1, CAST(N'2022-08-02T00:00:00.0000000' AS DateTime2), CAST(N'2022-08-20T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[dues] ([DuesId], [DueAmount], [PaymentType], [UserId], [DueDate], [billingDate], [Status]) VALUES (5, N'257', N'Credit Card', 5, CAST(N'2022-07-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-08-15T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[dues] ([DuesId], [DueAmount], [PaymentType], [UserId], [DueDate], [billingDate], [Status]) VALUES (6, N'345', N'Credit Card', 34, CAST(N'2022-10-11T00:00:00.0000000' AS DateTime2), CAST(N'2022-08-10T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[dues] OFF
GO
SET IDENTITY_INSERT [dbo].[flats] ON 

INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (35, 1, N'Emine Metin', N'5', N'3+1', N'2', N'70', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (36, 2, N'Sauncho Crouch', N'7', N'3+1', N'2', N'6', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (37, 3, N'Nelli O''Carney', N'6', N'2+1', N'4', N'17', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (38, 4, N'Yancey Spandley', N'15', N'3+1', N'344', N'20', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (39, 1, N'Velvet Enocksson', N'50', N'3+1', N'5', N'24', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (40, 1, N'Felicdad Babbidge', N'46', N'3+1', N'6', N'25', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (41, 1, N'Max Dureden', N'7', N'3+1', N'3', N'28', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (42, 1, N'Carole Undrell', N'1', N'3+1', N'1', N'29', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (43, 1, N'Elbertina McGarrell', N'1', N'2+1', N'4', N'32', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (44, 1, N'Cyndi Eaddy', N'1', N'3+1', N'1', N'33', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (45, 1, N'Gillie Gosswell', N'31', N'2+1', N'2', N'34', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (46, 1, N'Sheba Watting', N'1', N'2+1', N'6', N'38', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (47, 1, N'Kara-lynn Mellings', N'7', N'3+1', N'1', N'39', 0)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (48, 1, N'Eadie Tenaunt', N'45', N'3+1', N'2', N'40', 0)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (49, 1, N'Iago Geelan', N'38', N'2+1', N'1', N'43', 0)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (50, 1, N'Hadley Lightowler', N'9', N'3+1', N'1', N'50', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (51, 1, N'Shanda Ridwood', N'47', N'3+1', N'3', N'52', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (52, 1, N'Reagen Livingstone', N'50', N'3+1', N'3', N'61', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (53, 1, N'Isabeau Grewer', N'4', N'3+1', N'2', N'68', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (54, 1, N'Mariejeanne Cuttelar', N'12', N'2+1', N'5', N'70', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (55, 1, N'Lizzie Sydry', N'6', N'2+1', N'4', N'72', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (56, 1, N'Albertina O''Lochan', N'5', N'3+1', N'6', N'74', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (57, 1, N'Lambert Keston', N'8', N'2+1', N'1', N'85', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (58, 1, N'Finn Coare', N'39', N'2+1', N'2', N'86', 0)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (59, 1, N'Ransell Dancer', N'6', N'2+1', N'3', N'88', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (60, 1, N'Brittne McCafferky', N'12', N'2+1', N'5', N'91', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (61, 1, N'Alissa Fleischer', N'8', N'2+1', N'2', N'92', 0)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (62, 1, N'Janine Geldart', N'28', N'2+1', N'1', N'95', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (63, 1, N'Olenka Firman', N'9', N'2+1', N'5', N'96', 0)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (64, 1, N'Erny Leask', N'50', N'3+1', N'4', N'97', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (65, 1, N'Leopold Cassidy', N'28', N'3+1', N'3', N'99', 0)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (66, 1, N'Deniz Gök', N'4', N'3+1', N'2', N'27', 1)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (67, 1, N'zeynep', N'2', N'2+1', N'4', N'45', 0)
INSERT [dbo].[flats] ([FlatId], [UserId], [FlatOwnerName], [FlatNo], [FlatType], [FlatLocation], [BlockNo], [Status]) VALUES (68, 1, N'Rıza', N'435', N'2+1', N'4', N'67', 0)
SET IDENTITY_INSERT [dbo].[flats] OFF
GO
SET IDENTITY_INSERT [dbo].[invoice] ON 

INSERT [dbo].[invoice] ([InvoiceId], [InvoiceNo], [Amount], [PaymentType], [UserId], [DueDate], [billingDate], [Status]) VALUES (1, 425452446, N'543', N'Credit Card', 1, CAST(N'2022-08-04T00:00:00.0000000' AS DateTime2), CAST(N'2022-08-18T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[invoice] ([InvoiceId], [InvoiceNo], [Amount], [PaymentType], [UserId], [DueDate], [billingDate], [Status]) VALUES (2, 25862147, N'250', N'Credit Card', 3, CAST(N'2022-08-02T00:00:00.0000000' AS DateTime2), CAST(N'2022-08-22T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[invoice] ([InvoiceId], [InvoiceNo], [Amount], [PaymentType], [UserId], [DueDate], [billingDate], [Status]) VALUES (3, 34265545, N'43545', NULL, 35, CAST(N'2022-08-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-08-19T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[invoice] OFF
GO
SET IDENTITY_INSERT [dbo].[messages] ON 

INSERT [dbo].[messages] ([MessageId], [SenderId], [ReceiveId], [UserId], [Subject], [Messages], [MessageDate], [MessageStatus]) VALUES (3, 8, 1, 2, N'deneme', N'bana yardımcı olur musunuz?', CAST(N'2022-08-02T02:22:10.0000000' AS DateTime2), 1)
INSERT [dbo].[messages] ([MessageId], [SenderId], [ReceiveId], [UserId], [Subject], [Messages], [MessageDate], [MessageStatus]) VALUES (4, 10, 1, 3, N'deney', N'faturam yanlış gelmiş', CAST(N'2022-08-25T00:15:03.0000000' AS DateTime2), 0)
INSERT [dbo].[messages] ([MessageId], [SenderId], [ReceiveId], [UserId], [Subject], [Messages], [MessageDate], [MessageStatus]) VALUES (5, 0, 0, 36, N'Doğalgaz Faturası', N'Merhaba ben deniz faturamı ödedim fakat ödeme yapılmamış görünüyor. Yardım eder misiniz?', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[messages] OFF
GO
SET IDENTITY_INSERT [dbo].[Payments] ON 

INSERT [dbo].[Payments] ([PaymentId], [BillingSum], [BillingDate], [IsPaid], [FlatId]) VALUES (4, CAST(3345.00 AS Decimal(18, 2)), CAST(N'2022-04-23T00:00:00.0000000' AS DateTime2), 1, 37)
SET IDENTITY_INSERT [dbo].[Payments] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (1, N'Emine ', N'Metin', N'69656114012', N'emine@gmail.com', N'2052015818', N'32XX3256', N'Admin')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (2, N'Sauncho', N'Crouch', N'22222222222', N'mplowman2@yandex.ru', N'4117602633', N'24XG8965', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (3, N'Nelli', N'O''Carney', N'88888888888', N'rmaccague3@parallels.com', N'9876994341', N'25XF4588', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (4, N'Yancey', N'Spandley', N'12121212121', N'vpurry4@drupal.org', N'1611411817', N'22XX25984', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (5, N'Velvet', N'Enocksson', N'36363636363', N'gfarrans5@purevolume.com', N'9792434985', N'36XX568', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (6, N'Felicdad', N'Babbidge', N'19654315444', N'mboow6@biglobe.ne.jp', N'1724866429', N'65XX923', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (7, N'Max', N'Dureden', N'13201320132', N'ldmitrienko7@imgur.com', N'3599907173', N'14XX3695', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (8, N'Carole', N'Undrell', N'99999999999', N'nmcleary8@uol.com.br', N'8138585377', N'20XX69545', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (9, N'Elbertina', N'McGarrell', N'55555555555', N'frains9@linkedin.com', N'7914859031', N'35XX9564', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (10, N'Cyndi', N'Eaddy', N'77777777777', N'eknivetta@discovery.com', N'7642463934', N'18XX6494', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (11, N'Gillie', N'Gosswell', N'14141414141', N'arosenthalerb@networkadvertising.org', N'1257823604', N'30XX894', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (12, N'Sheba', N'Watting', N'21651212121', N'kanwellc@bbb.org', N'3474256981', N'64XX297', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (13, N'Kara-lynn', N'Mellings', N'32323232323', N'lmoreingd@adobe.com', N'8108343504', N'29XX695', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (14, N'Eadie', N'Tenaunt', N'20202020202', N'hstaterfielde@hatena.ne.jp', N'3945459629', N'14XX369', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (15, N'Iago', N'Geelan', N'54545454455', N'acorahf@patch.com', N'7999544654', N'11XX658', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (16, N'Hadley', N'Lightowler', N'97979797979', N'arollsg@cpanel.net', N'5468580184', N'88XX14956', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (17, N'Shanda', N'Ridwood', N'39393939393', N'istartinh@nsw.gov.au', N'2458447638', N'44XX5656', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (18, N'Reagen', N'Livingstone', N'17171717171', N'lcanai@blogger.com', N'1217171300', N'25XX6894', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (19, N'Isabeau', N'Grewer', N'28282828282', N'adelaeglisej@list-manage.com', N'3229465595', N'10XX5987', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (20, N'Mariejeanne', N' Cuttelar', N'49494949494', N'yfraanchyonokk@flickr.com', N'7983653765', N'65XX9985', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (21, N'Lizzie', N'Sydry', N'34313131313', N'skelwayl@t.co', N'8256483893', N'39XX648', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (22, N'Albertina', N'O''Lochan', N'20152020202', N'rmcalroym@vinaora.com', N'2298741073', N'97XX249', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (23, N'Lambert', N'Keston', N'51515151515', N'lringern@fda.gov', N'2978589144', N'16XX294', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (24, N'Finn', N'Coare', N'18181818181', N'fiveso@digg.com', N'4114166972', N'84XX256', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (25, N'Ransell', N'Dancer', N'10203040506', N'bfalconerp@yandex.ru', N'6263782747', N'26XX845', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (26, N'Brittne', N'McCafferky', N'65646456456', N'charriganq@slashdot.org', N'7958383088', N'53XX9645', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (27, N'Alissa', N'Fleischer', N'72727272727', N'utheisr@ocn.ne.jp', N'6851456273', N'19XX6848', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (28, N'Janine', N'Geldart', N'82828282828', N'mmichelles@nps.gov', N'8955739105', N'58XX7895', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (29, N'Olenka', N'Firman', N'39393939393', N'plavent@state.gov', N'9157517523', N'28XX4995', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (30, N'Erny', N'Leask', N'19191919191', N'scallissu@netlog.com', N'5946520463', N'54XX8569', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (31, N'Leopold', N'Cassidy', N'23232323232', N'cbrickellv@odnoklassniki.ru', N'5638729686', N'29XX2500', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (32, N'Deniz', N'Gök', N'91646464646', N'gfillimorew@phpbb.com', N'5554314854', N'28HX586', N'User')
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (33, N'kadir', N'ferman', N'13123433143', N'ekadir@gmail.com', N'5342342323', N'34tr67899', NULL)
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (34, N'halime', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (35, N'deneme', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[users] ([UserId], [Name], [Surname], [TcNo], [Email], [PhoneNo], [NumberPlate], [UserRole]) VALUES (36, NULL, NULL, NULL, N'emine@gmail.com', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[dues]  WITH CHECK ADD  CONSTRAINT [FK_dues_users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[dues] CHECK CONSTRAINT [FK_dues_users_UserId]
GO
ALTER TABLE [dbo].[flats]  WITH CHECK ADD  CONSTRAINT [FK_flats_users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[flats] CHECK CONSTRAINT [FK_flats_users_UserId]
GO
ALTER TABLE [dbo].[invoice]  WITH CHECK ADD  CONSTRAINT [FK_invoice_users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[invoice] CHECK CONSTRAINT [FK_invoice_users_UserId]
GO
ALTER TABLE [dbo].[messages]  WITH CHECK ADD  CONSTRAINT [FK_messages_users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[messages] CHECK CONSTRAINT [FK_messages_users_UserId]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_flats_FlatId] FOREIGN KEY([FlatId])
REFERENCES [dbo].[flats] ([FlatId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_flats_FlatId]
GO
