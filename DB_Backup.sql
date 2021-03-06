USE [db_teknikservis]
GO
/****** Object:  Table [dbo].[Ariza]    Script Date: 7/25/2018 2:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ariza](
	[Ariza_ID] [int] IDENTITY(1,1) NOT NULL,
	[Tip_ID] [int] NOT NULL,
	[Tarih] [datetime] NOT NULL,
	[Mus_ID] [int] NOT NULL,
	[Detay] [nvarchar](500) NOT NULL,
	[Durum] [bit] NOT NULL,
	[Urun_Ad] [nvarchar](50) NOT NULL,
	[Urun_Kategori] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ariza] PRIMARY KEY CLUSTERED 
(
	[Ariza_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ariza_Tip]    Script Date: 7/25/2018 2:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ariza_Tip](
	[Tip_ID] [int] IDENTITY(1,1) NOT NULL,
	[Tip] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ariza_Tip] PRIMARY KEY CLUSTERED 
(
	[Tip_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 7/25/2018 2:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[Kullanici_ID] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici_Adi] [nvarchar](50) NOT NULL,
	[Sifre] [char](10) NOT NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[Kullanici_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Malzeme]    Script Date: 7/25/2018 2:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Malzeme](
	[Malzeme_ID] [int] IDENTITY(1,1) NOT NULL,
	[Malzeme_Ad] [nvarchar](50) NOT NULL,
	[Adet] [int] NOT NULL,
	[Fiyat] [float] NOT NULL,
 CONSTRAINT [PK_Malzeme] PRIMARY KEY CLUSTERED 
(
	[Malzeme_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 7/25/2018 2:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[Mus_ID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [char](11) NOT NULL,
	[Ad] [nvarchar](20) NOT NULL,
	[Soyad] [nvarchar](20) NOT NULL,
	[Adres] [nvarchar](200) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[Mus_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Onarim]    Script Date: 7/25/2018 2:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Onarim](
	[Onarim_ID] [int] IDENTITY(1,1) NOT NULL,
	[Ariza_ID] [int] NOT NULL,
	[Islem] [nvarchar](500) NOT NULL,
	[Ucret] [float] NOT NULL,
 CONSTRAINT [PK_Onarim] PRIMARY KEY CLUSTERED 
(
	[Onarim_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Onarim_Malzeme]    Script Date: 7/25/2018 2:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Onarim_Malzeme](
	[Onarim_ID] [int] NOT NULL,
	[Malzeme_ID] [int] NOT NULL,
 CONSTRAINT [PK_Onarim_Malzeme] PRIMARY KEY CLUSTERED 
(
	[Onarim_ID] ASC,
	[Malzeme_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tedarik]    Script Date: 7/25/2018 2:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tedarik](
	[Tedarik_ID] [int] IDENTITY(1,1) NOT NULL,
	[Malzeme_ID] [int] NOT NULL,
	[Tedarik_Adet] [int] NOT NULL,
	[Siparis_Tarih] [datetime] NOT NULL,
	[Fiyat] [float] NOT NULL,
 CONSTRAINT [PK_Tedarik] PRIMARY KEY CLUSTERED 
(
	[Tedarik_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Ariza] ON 

INSERT [dbo].[Ariza] ([Ariza_ID], [Tip_ID], [Tarih], [Mus_ID], [Detay], [Durum], [Urun_Ad], [Urun_Kategori]) VALUES (1, 1, CAST(N'2018-07-19T00:00:00.000' AS DateTime), 1, N'Fanımdan ses geliyor.', 0, N'hewlet Pecket', N'masaüstü')
INSERT [dbo].[Ariza] ([Ariza_ID], [Tip_ID], [Tarih], [Mus_ID], [Detay], [Durum], [Urun_Ad], [Urun_Kategori]) VALUES (2, 2, CAST(N'2018-07-20T00:00:00.000' AS DateTime), 1, N'Ram bozuk', 0, N'ASUS LAPTOP', N'DİZÜSTÜ')
INSERT [dbo].[Ariza] ([Ariza_ID], [Tip_ID], [Tarih], [Mus_ID], [Detay], [Durum], [Urun_Ad], [Urun_Kategori]) VALUES (6, 1, CAST(N'2018-07-25T00:00:00.000' AS DateTime), 1, N'Fanımdan ses geliyor. Cihazım çok ısınıyor.', 1, N'ASUS LAPTOP', N'LAPTOP')
SET IDENTITY_INSERT [dbo].[Ariza] OFF
SET IDENTITY_INSERT [dbo].[Ariza_Tip] ON 

INSERT [dbo].[Ariza_Tip] ([Tip_ID], [Tip]) VALUES (1, N'Donanım')
INSERT [dbo].[Ariza_Tip] ([Tip_ID], [Tip]) VALUES (2, N'Yazılım')
SET IDENTITY_INSERT [dbo].[Ariza_Tip] OFF
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([Kullanici_ID], [Kullanici_Adi], [Sifre]) VALUES (1, N'yusuf', N'1234      ')
INSERT [dbo].[Kullanici] ([Kullanici_ID], [Kullanici_Adi], [Sifre]) VALUES (2, N'admin', N'1234      ')
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
SET IDENTITY_INSERT [dbo].[Malzeme] ON 

INSERT [dbo].[Malzeme] ([Malzeme_ID], [Malzeme_Ad], [Adet], [Fiyat]) VALUES (1, N'DDR3 Ram (8GB)', 20, 8500)
INSERT [dbo].[Malzeme] ([Malzeme_ID], [Malzeme_Ad], [Adet], [Fiyat]) VALUES (2, N'Asus Anakart Gaming', 3, 3004)
SET IDENTITY_INSERT [dbo].[Malzeme] OFF
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([Mus_ID], [TC], [Ad], [Soyad], [Adres], [Mail], [Telefon]) VALUES (1, N'13799999999', N'Yusuf', N'Kaya', N'Düzce', N'yusuf@gmail.com', N'05555555555')
INSERT [dbo].[Musteri] ([Mus_ID], [TC], [Ad], [Soyad], [Adres], [Mail], [Telefon]) VALUES (1002, N'13778012112', N'Emre', N'Can', N'Ordu', N'emre@gmail.com', N'111222333')
INSERT [dbo].[Musteri] ([Mus_ID], [TC], [Ad], [Soyad], [Adres], [Mail], [Telefon]) VALUES (1003, N'44433322211', N'Haluk', N'Bey', N'Malatya', N'halukbey@gmail.com', N'22233344411')
INSERT [dbo].[Musteri] ([Mus_ID], [TC], [Ad], [Soyad], [Adres], [Mail], [Telefon]) VALUES (1005, N'12312312312', N'oguzhan', N'soyadım', N'istanbul', N'oguzhan@gmail.com', N'123123123')
SET IDENTITY_INSERT [dbo].[Musteri] OFF
SET IDENTITY_INSERT [dbo].[Tedarik] ON 

INSERT [dbo].[Tedarik] ([Tedarik_ID], [Malzeme_ID], [Tedarik_Adet], [Siparis_Tarih], [Fiyat]) VALUES (1, 1, 1000, CAST(N'2018-07-24T00:00:00.000' AS DateTime), 100000)
SET IDENTITY_INSERT [dbo].[Tedarik] OFF
ALTER TABLE [dbo].[Ariza] ADD  CONSTRAINT [DF_Ariza_Durum]  DEFAULT ((1)) FOR [Durum]
GO
ALTER TABLE [dbo].[Ariza]  WITH CHECK ADD  CONSTRAINT [FK_Ariza_Ariza_Tip] FOREIGN KEY([Tip_ID])
REFERENCES [dbo].[Ariza_Tip] ([Tip_ID])
GO
ALTER TABLE [dbo].[Ariza] CHECK CONSTRAINT [FK_Ariza_Ariza_Tip]
GO
ALTER TABLE [dbo].[Ariza]  WITH CHECK ADD  CONSTRAINT [FK_Ariza_Musteri] FOREIGN KEY([Mus_ID])
REFERENCES [dbo].[Musteri] ([Mus_ID])
GO
ALTER TABLE [dbo].[Ariza] CHECK CONSTRAINT [FK_Ariza_Musteri]
GO
ALTER TABLE [dbo].[Onarim]  WITH CHECK ADD  CONSTRAINT [FK_Onarim_Ariza] FOREIGN KEY([Ariza_ID])
REFERENCES [dbo].[Ariza] ([Ariza_ID])
GO
ALTER TABLE [dbo].[Onarim] CHECK CONSTRAINT [FK_Onarim_Ariza]
GO
ALTER TABLE [dbo].[Onarim_Malzeme]  WITH CHECK ADD  CONSTRAINT [FK_Onarim_Malzeme_Malzeme] FOREIGN KEY([Malzeme_ID])
REFERENCES [dbo].[Malzeme] ([Malzeme_ID])
GO
ALTER TABLE [dbo].[Onarim_Malzeme] CHECK CONSTRAINT [FK_Onarim_Malzeme_Malzeme]
GO
ALTER TABLE [dbo].[Onarim_Malzeme]  WITH CHECK ADD  CONSTRAINT [FK_Onarim_Malzeme_Onarim] FOREIGN KEY([Onarim_ID])
REFERENCES [dbo].[Onarim] ([Onarim_ID])
GO
ALTER TABLE [dbo].[Onarim_Malzeme] CHECK CONSTRAINT [FK_Onarim_Malzeme_Onarim]
GO
ALTER TABLE [dbo].[Tedarik]  WITH CHECK ADD  CONSTRAINT [FK_Tedarik_Malzeme] FOREIGN KEY([Malzeme_ID])
REFERENCES [dbo].[Malzeme] ([Malzeme_ID])
GO
ALTER TABLE [dbo].[Tedarik] CHECK CONSTRAINT [FK_Tedarik_Malzeme]
GO
