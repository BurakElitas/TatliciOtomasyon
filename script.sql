USE [Tatlici]
GO
/****** Object:  Table [dbo].[Egitim]    Script Date: 26.03.2019 22:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Egitim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Egitim] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Firma]    Script Date: 26.03.2019 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Firma](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Adres] [nvarchar](500) NOT NULL,
	[TelNo] [char](15) NOT NULL,
	[Mail] [nvarchar](50) NULL,
	[Aktif] [bit] NOT NULL,
 CONSTRAINT [PK_Firma] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gelir]    Script Date: 26.03.2019 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gelir](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ucret] [money] NOT NULL,
	[Tarih] [date] NOT NULL,
	[Aktif] [bit] NOT NULL,
 CONSTRAINT [PK_Gelir] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gider]    Script Date: 26.03.2019 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gider](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ucret] [money] NOT NULL,
	[Tarih] [date] NOT NULL,
	[Aktif] [bit] NOT NULL,
 CONSTRAINT [PK_Gider] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuvenlikSoru]    Script Date: 26.03.2019 22:06:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuvenlikSoru](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Soru] [nvarchar](500) NULL,
 CONSTRAINT [PK_GuvenlikSoru] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 26.03.2019 22:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[KullaniciTip] [int] NULL,
	[Sifre] [nvarchar](50) NOT NULL,
	[Soruid] [int] NULL,
	[Cevap] [nvarchar](50) NOT NULL,
	[Aktif] [bit] NOT NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullaniciTip]    Script Date: 26.03.2019 22:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullaniciTip](
	[Id] [int] NOT NULL,
	[Tip] [nvarchar](50) NULL,
	[Aktif] [bit] NOT NULL,
 CONSTRAINT [PK_KullaniciTip] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Malzeme]    Script Date: 26.03.2019 22:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Malzeme](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Fiyat] [money] NOT NULL,
 CONSTRAINT [PK_Malzeme] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Malzeme_Urun]    Script Date: 26.03.2019 22:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Malzeme_Urun](
	[UrunId] [int] NOT NULL,
	[MalzemeId] [int] NOT NULL,
	[Miktar] [float] NOT NULL,
 CONSTRAINT [PK_Malzeme_Urun] PRIMARY KEY CLUSTERED 
(
	[UrunId] ASC,
	[MalzemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 26.03.2019 22:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NOT NULL,
	[Tckn] [char](11) NOT NULL,
	[TelNo] [char](14) NOT NULL,
	[Mail] [nvarchar](50) NULL,
	[FirmaId] [int] NULL,
	[Aktif] [bit] NULL,
 CONSTRAINT [PK_Müsteri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriSiparis]    Script Date: 26.03.2019 22:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriSiparis](
	[MusteriId] [int] NOT NULL,
	[SiparisId] [int] NOT NULL,
 CONSTRAINT [PK_MusteriSiparis] PRIMARY KEY CLUSTERED 
(
	[MusteriId] ASC,
	[SiparisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 26.03.2019 22:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Id] [nvarchar](50) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NOT NULL,
	[Maas] [money] NULL,
	[Tckn] [char](11) NOT NULL,
	[DogumTarih] [date] NULL,
	[IsegirisTarih] [date] NULL,
	[Adres] [nvarchar](500) NULL,
	[TelNo] [char](15) NOT NULL,
	[Mail] [nvarchar](50) NULL,
	[MedeniDurum] [bit] NULL,
	[EgitimId] [int] NULL,
	[Aktif] [bit] NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SatınAlmaMalzeme]    Script Date: 26.03.2019 22:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SatınAlmaMalzeme](
	[SatınAlmaId] [int] NOT NULL,
	[MalzemeId] [int] NOT NULL,
	[Miktar] [float] NULL,
 CONSTRAINT [PK_SatınAlmaMalzeme] PRIMARY KEY CLUSTERED 
(
	[SatınAlmaId] ASC,
	[MalzemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SatinAlma]    Script Date: 26.03.2019 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SatinAlma](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [date] NOT NULL,
	[Ucret] [money] NOT NULL,
	[Aciklama] [nvarchar](500) NOT NULL,
	[aktif] [bit] NOT NULL,
 CONSTRAINT [PK_SatınAlma] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servisler]    Script Date: 26.03.2019 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servisler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlakaNo] [nvarchar](50) NULL,
	[SoforId] [nvarchar](50) NULL,
 CONSTRAINT [PK_Servisler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparis]    Script Date: 26.03.2019 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [date] NOT NULL,
	[Personel] [nvarchar](50) NULL,
	[OnaylandiMi] [bit] NOT NULL,
	[SiparisTutari] [money] NOT NULL,
	[OdemeYapildiMi] [bit] NOT NULL,
	[HazirMi] [bit] NOT NULL,
	[Aktif] [bit] NOT NULL,
 CONSTRAINT [PK_Siparis] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiparisUrun]    Script Date: 26.03.2019 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiparisUrun](
	[SiparisId] [int] NOT NULL,
	[UrunId] [int] NOT NULL,
	[Miktar] [float] NULL,
 CONSTRAINT [PK_SiparisUrun] PRIMARY KEY CLUSTERED 
(
	[SiparisId] ASC,
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stok]    Script Date: 26.03.2019 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stok](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MalzemeId] [int] NOT NULL,
	[Miktar] [float] NOT NULL,
 CONSTRAINT [PK_Stok] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tedarikci]    Script Date: 26.03.2019 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tedarikci](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Adres] [nvarchar](500) NOT NULL,
	[TelNo] [char](15) NOT NULL,
	[Mail] [nvarchar](50) NULL,
	[Aktif] [bit] NOT NULL,
 CONSTRAINT [PK_Tedarikci] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TedarikciMalzeme]    Script Date: 26.03.2019 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TedarikciMalzeme](
	[TedarikciId] [int] NOT NULL,
	[MalzemeId] [int] NOT NULL,
 CONSTRAINT [PK_TedarikciMalzeme] PRIMARY KEY CLUSTERED 
(
	[TedarikciId] ASC,
	[MalzemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 26.03.2019 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NULL,
	[Fiyat] [money] NULL,
	[Aktif] [bit] NOT NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Egitim] ON 

INSERT [dbo].[Egitim] ([Id], [Adi]) VALUES (1, N'Üniversite')
INSERT [dbo].[Egitim] ([Id], [Adi]) VALUES (2, N'Lise')
INSERT [dbo].[Egitim] ([Id], [Adi]) VALUES (3, N'Ortaokul')
INSERT [dbo].[Egitim] ([Id], [Adi]) VALUES (4, N'İlkokul')
INSERT [dbo].[Egitim] ([Id], [Adi]) VALUES (5, N'Yüksek Lisans')
INSERT [dbo].[Egitim] ([Id], [Adi]) VALUES (6, N'Doktora')
SET IDENTITY_INSERT [dbo].[Egitim] OFF
SET IDENTITY_INSERT [dbo].[Firma] ON 

INSERT [dbo].[Firma] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (1, N'ELİTAŞ YAZİLİM', N'Burhaniye', N'4220263        ', N'elitasyazilim@gmail.com', 1)
INSERT [dbo].[Firma] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (2, N'SABRİ YAZILIM', N'Burhaniye ', N'4855848        ', N'sabri@gmail.com', 1)
INSERT [dbo].[Firma] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (3, N'GÜL PASTANESİ', N'beşiktaş ', N'552528665      ', N'gul@gmail.com', 1)
INSERT [dbo].[Firma] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (4, N'NKU YAZILIM', N'Çorlu', N'652926242      ', N'nku@gmail.com', 0)
INSERT [dbo].[Firma] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (1004, N'BOŞ', N'-', N'-              ', N'-', 1)
INSERT [dbo].[Firma] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (1005, N'BATE', N'srtnxfgnvbnvbn', N'23456789909    ', N'ptufekci16@gmail.com', 1)
INSERT [dbo].[Firma] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (1006, N'ARKIN', N'burhaniye', N'2552525        ', N'arkin@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[Firma] OFF
SET IDENTITY_INSERT [dbo].[GuvenlikSoru] ON 

INSERT [dbo].[GuvenlikSoru] ([Id], [Soru]) VALUES (1, N'Hangi arabaya sahip olmak istersin?')
INSERT [dbo].[GuvenlikSoru] ([Id], [Soru]) VALUES (2, N'İlkokulda en sevdiğin hocanın adı neydi?')
INSERT [dbo].[GuvenlikSoru] ([Id], [Soru]) VALUES (3, N'Favori yemeğin nedir?')
SET IDENTITY_INSERT [dbo].[GuvenlikSoru] OFF
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([Id], [KullaniciAdi], [KullaniciTip], [Sifre], [Soruid], [Cevap], [Aktif]) VALUES (8, N'songül', 3, N'1234', 1, N'bmw', 1)
INSERT [dbo].[Kullanici] ([Id], [KullaniciAdi], [KullaniciTip], [Sifre], [Soruid], [Cevap], [Aktif]) VALUES (9, N'gokhan', 2, N'12345', 2, N'derya', 1)
INSERT [dbo].[Kullanici] ([Id], [KullaniciAdi], [KullaniciTip], [Sifre], [Soruid], [Cevap], [Aktif]) VALUES (10, N'ethem', 2, N'ethem', 1, N'audi', 1)
INSERT [dbo].[Kullanici] ([Id], [KullaniciAdi], [KullaniciTip], [Sifre], [Soruid], [Cevap], [Aktif]) VALUES (11, N'samet', 2, N'123', 3, N'tavuk', 1)
INSERT [dbo].[Kullanici] ([Id], [KullaniciAdi], [KullaniciTip], [Sifre], [Soruid], [Cevap], [Aktif]) VALUES (12, N'dayı', 2, N'burak', 3, N'tavuk', 0)
INSERT [dbo].[Kullanici] ([Id], [KullaniciAdi], [KullaniciTip], [Sifre], [Soruid], [Cevap], [Aktif]) VALUES (13, N'', 3, N'', 1, N'', 0)
INSERT [dbo].[Kullanici] ([Id], [KullaniciAdi], [KullaniciTip], [Sifre], [Soruid], [Cevap], [Aktif]) VALUES (14, N'pinar', 3, N'pinar', 1, N'oto', 1)
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
INSERT [dbo].[KullaniciTip] ([Id], [Tip], [Aktif]) VALUES (1, N'Yönetici', 1)
INSERT [dbo].[KullaniciTip] ([Id], [Tip], [Aktif]) VALUES (2, N'Sipariş Sorumlusu', 1)
INSERT [dbo].[KullaniciTip] ([Id], [Tip], [Aktif]) VALUES (3, N'Üretim Sorumlusu', 1)
INSERT [dbo].[KullaniciTip] ([Id], [Tip], [Aktif]) VALUES (4, N'Depo Sorumlusu', 1)
SET IDENTITY_INSERT [dbo].[Malzeme] ON 

INSERT [dbo].[Malzeme] ([Id], [Adi], [Fiyat]) VALUES (1, N'UN', 2.0000)
INSERT [dbo].[Malzeme] ([Id], [Adi], [Fiyat]) VALUES (2, N'ŞEKER', 3.5000)
INSERT [dbo].[Malzeme] ([Id], [Adi], [Fiyat]) VALUES (3, N'YUMURTA', 5.0000)
INSERT [dbo].[Malzeme] ([Id], [Adi], [Fiyat]) VALUES (4, N'FISTIK', 45.5000)
INSERT [dbo].[Malzeme] ([Id], [Adi], [Fiyat]) VALUES (5, N'CEVİZ', 40.0000)
INSERT [dbo].[Malzeme] ([Id], [Adi], [Fiyat]) VALUES (6, N'YAĞ', 9.0000)
INSERT [dbo].[Malzeme] ([Id], [Adi], [Fiyat]) VALUES (7, N'KUŞ ÜZÜMÜ', 20.0000)
INSERT [dbo].[Malzeme] ([Id], [Adi], [Fiyat]) VALUES (8, N'EMİRHAN', 1.0000)
SET IDENTITY_INSERT [dbo].[Malzeme] OFF
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (7, 3, 5)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (7, 4, 1)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (7, 5, 2.5)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (8, 2, 1.5)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (8, 3, 5)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (8, 4, 3)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (9, 1, 3.5)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (9, 2, 6.5)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (9, 6, 1)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (11, 1, 3)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (11, 2, 7)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (1004, 1, 4)
INSERT [dbo].[Malzeme_Urun] ([UrunId], [MalzemeId], [Miktar]) VALUES (1004, 3, 4)
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (1, N'BURAKS', N'ELİTAŞ', N'55342284700', N'5375254803    ', N'burak@gmail.com', 1, 0)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (2, N'YUNUS EMRE', N'YÜCEL', N'1515266    ', N'552525        ', N'emre@gmail.com', 1, 0)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (3, N'BATUHAN ', N'BAKAR', N'24224334343', N'052345        ', N'BATU@GMAİL.COM', 1, 1)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (4, N'BURAK', N'ELİTAS', N'455626625  ', N'6262515       ', N'burak@hotmail.com', 1, 0)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (5, N'MAHMUT', N'EP', N'75373737375', N'47477         ', N'mahmur', 1, 1)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (6, N'EZGİ', N'KORKUT', N'4552515151 ', N'5373737       ', N'573737373', 1, 0)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (7, N'AYÇA', N'DENİZ', N'753573     ', N'7537537373    ', N'', 1, 0)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (8, N'SONGÜL', N'ELİTAŞ', N'43735737   ', N'43434345      ', N'sdgdsgsgsg', 1, 0)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (9, N'YILMAZ BEŞİR', N'ÖLÜR', N'43434343434', N'56522147522145', N'asgasgsagasg', 1, 0)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (10, N'ASLİ', N'IŞIK', N'4534544    ', N'45454545      ', N'asli@gmail.com', 1, 0)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (14, N'ONUR SEMİH', N'SOKULLU', N'22626262625', N'2525225155    ', N'onur@gmail.com', 1, 0)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (15, N'ONUR', N'', N'           ', N'              ', N'', 1, 0)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (1014, N'YILMAZ', N'ÖLMEZ', N'555251562  ', N'5264825       ', N'yilmaz@gmail.com', 1, 0)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (1015, N'BURAK', N'ELİTAŞ', N'4562662626 ', N'05375254803   ', N'burak@gmail.com', 2, 1)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (1017, N'FURKAN', N'UZUN', N'5151262626 ', N'64852526061552', N'furkan@gmail.com', 2, 1)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (1018, N'ETHEM', N'AKSAKAL', N'625959636  ', N'151252622     ', N'aksakal@gmail.com', 3, 1)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (1019, N'PINAR', N'TÜFEKCİ', N'123456789  ', N'123456789     ', N'ptufekci16@gmail.com', 1005, 1)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (1020, N'AYBÜKE', N'YA', N'52662948566', N'1515525251515 ', N'aybuke@gmail.com', 3, 1)
INSERT [dbo].[Musteri] ([Id], [Adi], [Soyadi], [Tckn], [TelNo], [Mail], [FirmaId], [Aktif]) VALUES (1021, N'CÜNEYT', N'ARKIN', N'35982962525', N'3625266       ', N'Nevet@gmail.com', 1, 1)
SET IDENTITY_INSERT [dbo].[Musteri] OFF
INSERT [dbo].[MusteriSiparis] ([MusteriId], [SiparisId]) VALUES (3, 13)
INSERT [dbo].[MusteriSiparis] ([MusteriId], [SiparisId]) VALUES (5, 19)
INSERT [dbo].[MusteriSiparis] ([MusteriId], [SiparisId]) VALUES (5, 26)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Maas], [Tckn], [DogumTarih], [IsegirisTarih], [Adres], [TelNo], [Mail], [MedeniDurum], [EgitimId], [Aktif]) VALUES (N'1', N'ASDASFSAF', N'', 0.0000, N'           ', CAST(N'2018-04-20' AS Date), CAST(N'2018-04-20' AS Date), N'', N'               ', N'', 1, 2, 0)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Maas], [Tckn], [DogumTarih], [IsegirisTarih], [Adres], [TelNo], [Mail], [MedeniDurum], [EgitimId], [Aktif]) VALUES (N'1002', N'MUSTAFA ', N'KAYHAN', 1500.0000, N'5387383    ', CAST(N'2018-04-03' AS Date), CAST(N'2018-03-31' AS Date), N'', N'573737357      ', N'', 0, 4, 0)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Maas], [Tckn], [DogumTarih], [IsegirisTarih], [Adres], [TelNo], [Mail], [MedeniDurum], [EgitimId], [Aktif]) VALUES (N'1003', N'SABRİ', N'ELİTAŞ', 2500.0000, N'5373573    ', CAST(N'2018-04-19' AS Date), CAST(N'2018-04-20' AS Date), N'', N'5837373        ', N'pölççişi', 1, 4, 1)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Maas], [Tckn], [DogumTarih], [IsegirisTarih], [Adres], [TelNo], [Mail], [MedeniDurum], [EgitimId], [Aktif]) VALUES (N'1004', N'BURAK', N'ELİTAŞ', 100000.0000, N'53285383838', CAST(N'2018-04-20' AS Date), CAST(N'2018-04-14' AS Date), N'', N'5383838        ', N'53535353', 0, 6, 1)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Maas], [Tckn], [DogumTarih], [IsegirisTarih], [Adres], [TelNo], [Mail], [MedeniDurum], [EgitimId], [Aktif]) VALUES (N'1005', N'YUNUS EMRE', N'ÇAKAR', 2500.0000, N'52661622632', CAST(N'1999-06-16' AS Date), CAST(N'2018-05-02' AS Date), N'', N'12515260625252 ', N'', 1, 3, 1)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Maas], [Tckn], [DogumTarih], [IsegirisTarih], [Adres], [TelNo], [Mail], [MedeniDurum], [EgitimId], [Aktif]) VALUES (N'2', N'DİLARA', N'ELİTAŞ', 100.0000, N'4535757275 ', CAST(N'1994-07-08' AS Date), CAST(N'2018-04-12' AS Date), N'', N'434345343543   ', N'dilara@hotmail', 0, 1, 0)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Maas], [Tckn], [DogumTarih], [IsegirisTarih], [Adres], [TelNo], [Mail], [MedeniDurum], [EgitimId], [Aktif]) VALUES (N'3', N'DENİZ', N'KOÇ', 100.0000, N'427273     ', CAST(N'2018-04-09' AS Date), CAST(N'2018-04-21' AS Date), N'Ümraniye asgagsagdsgsgsgs', N'753737373      ', N'deniz@gmail.com', 1, 1, 0)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Maas], [Tckn], [DogumTarih], [IsegirisTarih], [Adres], [TelNo], [Mail], [MedeniDurum], [EgitimId], [Aktif]) VALUES (N'4', N'SDGDSGS', N'SDGSDGS', 100.0000, N'           ', CAST(N'2018-04-15' AS Date), CAST(N'2018-04-15' AS Date), N'', N'45343543       ', N'453453543', 0, 4, 0)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Maas], [Tckn], [DogumTarih], [IsegirisTarih], [Adres], [TelNo], [Mail], [MedeniDurum], [EgitimId], [Aktif]) VALUES (N'5', N'EZGİ ', N'KORKUT', 100.0000, N'48552525   ', CAST(N'1995-02-19' AS Date), CAST(N'2018-04-11' AS Date), N'beşiktaş belediyesi fidan sokak', N'515256265251   ', N'ezgi@gmail.com', 0, 1, 0)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Maas], [Tckn], [DogumTarih], [IsegirisTarih], [Adres], [TelNo], [Mail], [MedeniDurum], [EgitimId], [Aktif]) VALUES (N'6', N'AHMET', N'ELİTAŞ', 2000.0000, N'51625252525', CAST(N'2002-05-26' AS Date), CAST(N'2018-04-19' AS Date), N'sdgsgsgsdg', N'0537 525 48 03 ', N'ahmet@gmail.com', 0, 2, 1)
INSERT [dbo].[SatınAlmaMalzeme] ([SatınAlmaId], [MalzemeId], [Miktar]) VALUES (1, 3, 5)
INSERT [dbo].[SatınAlmaMalzeme] ([SatınAlmaId], [MalzemeId], [Miktar]) VALUES (4, 2, 10)
INSERT [dbo].[SatınAlmaMalzeme] ([SatınAlmaId], [MalzemeId], [Miktar]) VALUES (4, 4, 5)
INSERT [dbo].[SatınAlmaMalzeme] ([SatınAlmaId], [MalzemeId], [Miktar]) VALUES (4, 5, 5)
INSERT [dbo].[SatınAlmaMalzeme] ([SatınAlmaId], [MalzemeId], [Miktar]) VALUES (7, 8, 1)
INSERT [dbo].[SatınAlmaMalzeme] ([SatınAlmaId], [MalzemeId], [Miktar]) VALUES (8, 6, 1)
INSERT [dbo].[SatınAlmaMalzeme] ([SatınAlmaId], [MalzemeId], [Miktar]) VALUES (8, 7, 10)
SET IDENTITY_INSERT [dbo].[SatinAlma] ON 

INSERT [dbo].[SatinAlma] ([Id], [Tarih], [Ucret], [Aciklama], [aktif]) VALUES (1, CAST(N'2018-05-03' AS Date), 150.0000, N'Yağ-Un', 1)
INSERT [dbo].[SatinAlma] ([Id], [Tarih], [Ucret], [Aciklama], [aktif]) VALUES (2, CAST(N'2018-04-30' AS Date), 20.0000, N'asfafasfs', 0)
INSERT [dbo].[SatinAlma] ([Id], [Tarih], [Ucret], [Aciklama], [aktif]) VALUES (3, CAST(N'2018-04-02' AS Date), 250.0000, N'nmıjıkopş', 1)
INSERT [dbo].[SatinAlma] ([Id], [Tarih], [Ucret], [Aciklama], [aktif]) VALUES (4, CAST(N'2018-05-02' AS Date), 10.0000, N'dsgdsgdg', 1)
INSERT [dbo].[SatinAlma] ([Id], [Tarih], [Ucret], [Aciklama], [aktif]) VALUES (5, CAST(N'2018-05-09' AS Date), 150.0000, N'yağ-un', 1)
INSERT [dbo].[SatinAlma] ([Id], [Tarih], [Ucret], [Aciklama], [aktif]) VALUES (6, CAST(N'2018-04-02' AS Date), 250.0000, N'gfujghkjghkghkghkg', 1)
INSERT [dbo].[SatinAlma] ([Id], [Tarih], [Ucret], [Aciklama], [aktif]) VALUES (7, CAST(N'2018-06-27' AS Date), 1500.0000, N'rhdfhdfh', 1)
INSERT [dbo].[SatinAlma] ([Id], [Tarih], [Ucret], [Aciklama], [aktif]) VALUES (8, CAST(N'2019-01-17' AS Date), 1500.0000, N'2 yağ kg', 1)
SET IDENTITY_INSERT [dbo].[SatinAlma] OFF
SET IDENTITY_INSERT [dbo].[Siparis] ON 

INSERT [dbo].[Siparis] ([Id], [Tarih], [Personel], [OnaylandiMi], [SiparisTutari], [OdemeYapildiMi], [HazirMi], [Aktif]) VALUES (13, CAST(N'2018-05-10' AS Date), N'gokhan', 0, 10.0000, 1, 0, 1)
INSERT [dbo].[Siparis] ([Id], [Tarih], [Personel], [OnaylandiMi], [SiparisTutari], [OdemeYapildiMi], [HazirMi], [Aktif]) VALUES (19, CAST(N'2018-05-03' AS Date), N'dayı', 0, 120.0000, 0, 0, 1)
INSERT [dbo].[Siparis] ([Id], [Tarih], [Personel], [OnaylandiMi], [SiparisTutari], [OdemeYapildiMi], [HazirMi], [Aktif]) VALUES (20, CAST(N'2018-05-01' AS Date), N'dayı', 0, 100.0000, 1, 0, 1)
INSERT [dbo].[Siparis] ([Id], [Tarih], [Personel], [OnaylandiMi], [SiparisTutari], [OdemeYapildiMi], [HazirMi], [Aktif]) VALUES (21, CAST(N'2018-05-03' AS Date), N'dayı', 0, 120.0000, 1, 0, 1)
INSERT [dbo].[Siparis] ([Id], [Tarih], [Personel], [OnaylandiMi], [SiparisTutari], [OdemeYapildiMi], [HazirMi], [Aktif]) VALUES (22, CAST(N'2018-05-03' AS Date), N'dayı', 0, 45.0000, 1, 0, 1)
INSERT [dbo].[Siparis] ([Id], [Tarih], [Personel], [OnaylandiMi], [SiparisTutari], [OdemeYapildiMi], [HazirMi], [Aktif]) VALUES (23, CAST(N'2018-05-03' AS Date), N'dayı', 0, 110.0000, 0, 0, 1)
INSERT [dbo].[Siparis] ([Id], [Tarih], [Personel], [OnaylandiMi], [SiparisTutari], [OdemeYapildiMi], [HazirMi], [Aktif]) VALUES (24, CAST(N'2018-05-03' AS Date), N'dayı', 0, 100.0000, 1, 0, 1)
INSERT [dbo].[Siparis] ([Id], [Tarih], [Personel], [OnaylandiMi], [SiparisTutari], [OdemeYapildiMi], [HazirMi], [Aktif]) VALUES (25, CAST(N'2018-05-01' AS Date), N'dayı', 0, 100.0000, 0, 0, 1)
INSERT [dbo].[Siparis] ([Id], [Tarih], [Personel], [OnaylandiMi], [SiparisTutari], [OdemeYapildiMi], [HazirMi], [Aktif]) VALUES (26, CAST(N'2018-05-03' AS Date), N'dayı', 0, 100.0000, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[Siparis] OFF
INSERT [dbo].[SiparisUrun] ([SiparisId], [UrunId], [Miktar]) VALUES (13, 8, 12)
INSERT [dbo].[SiparisUrun] ([SiparisId], [UrunId], [Miktar]) VALUES (13, 9, 10)
INSERT [dbo].[SiparisUrun] ([SiparisId], [UrunId], [Miktar]) VALUES (13, 13, 1.5)
INSERT [dbo].[SiparisUrun] ([SiparisId], [UrunId], [Miktar]) VALUES (19, 10, 10)
INSERT [dbo].[SiparisUrun] ([SiparisId], [UrunId], [Miktar]) VALUES (26, 12, 35)
SET IDENTITY_INSERT [dbo].[Tedarikci] ON 

INSERT [dbo].[Tedarikci] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (1, N'BURAK''S ', N'burhaniye', N'5345254803     ', N'burak@gmail.com', 1)
INSERT [dbo].[Tedarikci] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (2, N'DENEME', N'sdgshsdhs', N'362625626626   ', N'sagagagsg', 1)
INSERT [dbo].[Tedarikci] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (3, N'NKU', N'Çorlu', N'6151515        ', N'nku@gmail.com', 0)
INSERT [dbo].[Tedarikci] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (1003, N'ORİON', N'sdgsgsgs', N'5515215        ', N'orion@gmail.com', 1)
INSERT [dbo].[Tedarikci] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (1004, N'ALİ', N'qwert', N'veli           ', N'wert', 1)
INSERT [dbo].[Tedarikci] ([Id], [Adi], [Adres], [TelNo], [Mail], [Aktif]) VALUES (1005, N'BİLCOD', N'fdhdfhdh', N'556265         ', N'dsgdsgsdgd', 1)
SET IDENTITY_INSERT [dbo].[Tedarikci] OFF
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (1, 6)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (2, 1)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (2, 4)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (2, 5)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (3, 2)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (3, 4)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (3, 5)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (1003, 1)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (1003, 2)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (1003, 5)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (1004, 5)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (1004, 7)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (1005, 3)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (1005, 4)
INSERT [dbo].[TedarikciMalzeme] ([TedarikciId], [MalzemeId]) VALUES (1005, 8)
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (7, N'CEVİZLİ BAKLAVA', 5.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (8, N'FISTIKLI BAKLAVA', 18.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (9, N'BÜLBÜL', 12.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (10, N'ŞÖBİYET', 12.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (11, N'SARAY SARMA', 12.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (12, N'SARI BURMA', 12.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (13, N'HAVUÇ DİLİM', 12.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (14, N'PRENSES', 18.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (15, N'KADAYIF', 13.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (16, N'BURMA KADAYIF', 13.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (17, N'EV BAKLAVASI', 15.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (18, N'BEYAZ BAKLAVA', 12.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (19, N'ÇİKOLATALI BAKLAVA', 15.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (20, N'SÜTLÜ NURİYE', 18.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (21, N'ŞEKERPARE', 10.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (22, N'ANTEP ÖZEL', 18.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (23, N'ANKARA ÖZEL', 18.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (25, N'YEŞİL DÜRÜM', 30.0000, 1)
INSERT [dbo].[Urunler] ([Id], [Adi], [Fiyat], [Aktif]) VALUES (1004, N'ŞEKERPARE', 5.0000, 1)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_TC]    Script Date: 26.03.2019 22:06:55 ******/
ALTER TABLE [dbo].[Musteri] ADD  CONSTRAINT [UNQ_TC] UNIQUE NONCLUSTERED 
(
	[Tckn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_Sofor]    Script Date: 26.03.2019 22:06:55 ******/
ALTER TABLE [dbo].[Servisler] ADD  CONSTRAINT [UNQ_Sofor] UNIQUE NONCLUSTERED 
(
	[SoforId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UNQ_MalzemeId]    Script Date: 26.03.2019 22:06:55 ******/
ALTER TABLE [dbo].[Stok] ADD  CONSTRAINT [UNQ_MalzemeId] UNIQUE NONCLUSTERED 
(
	[MalzemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Firma] ADD  CONSTRAINT [DF_Firma_Aktif]  DEFAULT ((1)) FOR [Aktif]
GO
ALTER TABLE [dbo].[Gider] ADD  CONSTRAINT [DF_Gider_Aktif]  DEFAULT ((1)) FOR [Aktif]
GO
ALTER TABLE [dbo].[Kullanici] ADD  CONSTRAINT [DF_Kullanici_Aktif]  DEFAULT ((1)) FOR [Aktif]
GO
ALTER TABLE [dbo].[KullaniciTip] ADD  CONSTRAINT [DF_KullaniciTip_Aktif]  DEFAULT ((1)) FOR [Aktif]
GO
ALTER TABLE [dbo].[Musteri] ADD  CONSTRAINT [DF_Müsteri_Aktif]  DEFAULT ((1)) FOR [Aktif]
GO
ALTER TABLE [dbo].[Personel] ADD  CONSTRAINT [DF_Personel_Aktif]  DEFAULT ((1)) FOR [Aktif]
GO
ALTER TABLE [dbo].[SatinAlma] ADD  CONSTRAINT [DF_SatınAlma_aktif]  DEFAULT ((1)) FOR [aktif]
GO
ALTER TABLE [dbo].[Siparis] ADD  CONSTRAINT [DF_Siparis_OnaylandiMi]  DEFAULT ((0)) FOR [OnaylandiMi]
GO
ALTER TABLE [dbo].[Siparis] ADD  CONSTRAINT [DF_Siparis_HazirMi]  DEFAULT ((0)) FOR [HazirMi]
GO
ALTER TABLE [dbo].[Siparis] ADD  CONSTRAINT [DF_Siparis_Aktif]  DEFAULT ((1)) FOR [Aktif]
GO
ALTER TABLE [dbo].[Tedarikci] ADD  CONSTRAINT [DF_Tedarikci_Aktif]  DEFAULT ((1)) FOR [Aktif]
GO
ALTER TABLE [dbo].[Urunler] ADD  CONSTRAINT [DF_Urunler_Aktif]  DEFAULT ((1)) FOR [Aktif]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_GuvenlikSoru] FOREIGN KEY([Soruid])
REFERENCES [dbo].[GuvenlikSoru] ([Id])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_GuvenlikSoru]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_KullaniciTip] FOREIGN KEY([KullaniciTip])
REFERENCES [dbo].[KullaniciTip] ([Id])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_KullaniciTip]
GO
ALTER TABLE [dbo].[Malzeme_Urun]  WITH CHECK ADD  CONSTRAINT [FK_Malzeme_Urun_Malzeme] FOREIGN KEY([MalzemeId])
REFERENCES [dbo].[Malzeme] ([Id])
GO
ALTER TABLE [dbo].[Malzeme_Urun] CHECK CONSTRAINT [FK_Malzeme_Urun_Malzeme]
GO
ALTER TABLE [dbo].[Malzeme_Urun]  WITH CHECK ADD  CONSTRAINT [FK_Malzeme_Urun_Urunler] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urunler] ([Id])
GO
ALTER TABLE [dbo].[Malzeme_Urun] CHECK CONSTRAINT [FK_Malzeme_Urun_Urunler]
GO
ALTER TABLE [dbo].[Musteri]  WITH CHECK ADD  CONSTRAINT [FK_Müsteri_Firma] FOREIGN KEY([FirmaId])
REFERENCES [dbo].[Firma] ([Id])
GO
ALTER TABLE [dbo].[Musteri] CHECK CONSTRAINT [FK_Müsteri_Firma]
GO
ALTER TABLE [dbo].[MusteriSiparis]  WITH CHECK ADD  CONSTRAINT [FK_MusteriSiparis_Musteri] FOREIGN KEY([MusteriId])
REFERENCES [dbo].[Musteri] ([Id])
GO
ALTER TABLE [dbo].[MusteriSiparis] CHECK CONSTRAINT [FK_MusteriSiparis_Musteri]
GO
ALTER TABLE [dbo].[MusteriSiparis]  WITH CHECK ADD  CONSTRAINT [FK_MusteriSiparis_Siparis] FOREIGN KEY([SiparisId])
REFERENCES [dbo].[Siparis] ([Id])
GO
ALTER TABLE [dbo].[MusteriSiparis] CHECK CONSTRAINT [FK_MusteriSiparis_Siparis]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Egitim] FOREIGN KEY([EgitimId])
REFERENCES [dbo].[Egitim] ([Id])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Egitim]
GO
ALTER TABLE [dbo].[SatınAlmaMalzeme]  WITH CHECK ADD  CONSTRAINT [FK_SatınAlmaMalzeme_Malzeme] FOREIGN KEY([MalzemeId])
REFERENCES [dbo].[Malzeme] ([Id])
GO
ALTER TABLE [dbo].[SatınAlmaMalzeme] CHECK CONSTRAINT [FK_SatınAlmaMalzeme_Malzeme]
GO
ALTER TABLE [dbo].[SatınAlmaMalzeme]  WITH CHECK ADD  CONSTRAINT [FK_SatınAlmaMalzeme_SatınAlma] FOREIGN KEY([SatınAlmaId])
REFERENCES [dbo].[SatinAlma] ([Id])
GO
ALTER TABLE [dbo].[SatınAlmaMalzeme] CHECK CONSTRAINT [FK_SatınAlmaMalzeme_SatınAlma]
GO
ALTER TABLE [dbo].[Servisler]  WITH CHECK ADD  CONSTRAINT [FK_Servisler_Personel] FOREIGN KEY([SoforId])
REFERENCES [dbo].[Personel] ([Id])
GO
ALTER TABLE [dbo].[Servisler] CHECK CONSTRAINT [FK_Servisler_Personel]
GO
ALTER TABLE [dbo].[SiparisUrun]  WITH CHECK ADD  CONSTRAINT [FK_SiparisUrun_Siparis] FOREIGN KEY([SiparisId])
REFERENCES [dbo].[Siparis] ([Id])
GO
ALTER TABLE [dbo].[SiparisUrun] CHECK CONSTRAINT [FK_SiparisUrun_Siparis]
GO
ALTER TABLE [dbo].[SiparisUrun]  WITH CHECK ADD  CONSTRAINT [FK_SiparisUrun_Urunler] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urunler] ([Id])
GO
ALTER TABLE [dbo].[SiparisUrun] CHECK CONSTRAINT [FK_SiparisUrun_Urunler]
GO
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Malzeme] FOREIGN KEY([MalzemeId])
REFERENCES [dbo].[Malzeme] ([Id])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Malzeme]
GO
ALTER TABLE [dbo].[TedarikciMalzeme]  WITH CHECK ADD  CONSTRAINT [FK_TedarikciMalzeme_Malzeme] FOREIGN KEY([MalzemeId])
REFERENCES [dbo].[Malzeme] ([Id])
GO
ALTER TABLE [dbo].[TedarikciMalzeme] CHECK CONSTRAINT [FK_TedarikciMalzeme_Malzeme]
GO
ALTER TABLE [dbo].[TedarikciMalzeme]  WITH CHECK ADD  CONSTRAINT [FK_TedarikciMalzeme_Tedarikci] FOREIGN KEY([TedarikciId])
REFERENCES [dbo].[Tedarikci] ([Id])
GO
ALTER TABLE [dbo].[TedarikciMalzeme] CHECK CONSTRAINT [FK_TedarikciMalzeme_Tedarikci]
GO
/****** Object:  StoredProcedure [dbo].[pro_Egitim_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Egitim_Listele]
as
select * from Egitim
GO
/****** Object:  StoredProcedure [dbo].[pro_Firma_Ara]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Firma_Ara]
@Ad nvarchar(50),
@Soyad nvarchar(500)
as
select * from Firma where Adi like '%'+@Ad+'%'
GO
/****** Object:  StoredProcedure [dbo].[pro_Firma_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Firma_Ekle]
@Id int,
@Adi nvarchar(50),
@Adres nvarchar(500),
@TelNo char(15),
@Mail nvarchar(50),
@Aktif bit
as
Insert Into Firma (Adi,Adres,TelNo,Mail)
values (@Adi,@Adres,@TelNo,@Mail)
GO
/****** Object:  StoredProcedure [dbo].[pro_Firma_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Firma_Guncelle]
@Id int,
@Adi nvarchar(50),
@Adres nvarchar(500),
@TelNo char(15),
@Mail nvarchar(50),
@Aktif bit
as
Update Firma Set Adi=@Adi,Adres=@Adres,TelNo=@TelNo,Mail=@Mail where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_Firma_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Firma_Listele]
as
select * from Firma where Aktif=1
GO
/****** Object:  StoredProcedure [dbo].[pro_Firma_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Firma_Sil]
@Id int,
@Adi nvarchar(50),
@Adres nvarchar(500),
@TelNo char(15),
@Mail nvarchar(50),
@Aktif bit
as
update Firma set Adi=@Adi,Adres=@Adres,TelNo=@TelNo,Mail=@Mail,Aktif=0 where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_Giris]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Giris]
@kullaniciadi nvarchar(50),
@sifre nvarchar(50)
as
select * from Kullanici where (KullaniciAdi=@kullaniciadi and Sifre=@sifre) and Aktif=1
GO
/****** Object:  StoredProcedure [dbo].[pro_GüvenlikSoru_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_GüvenlikSoru_Listele]
as
select * from GuvenlikSoru 
GO
/****** Object:  StoredProcedure [dbo].[pro_Kullanici_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Kullanici_Ekle]
@Id int,
@KullaniciAdi nvarchar(50),
@KullaniciTip int,
@Sifre nvarchar(50),
@Soruid int,
@Cevap nvarchar(50),
@Aktif bit
as
Insert Into Kullanici (KullaniciAdi,KullaniciTip,Sifre,Soruid,Cevap)
values(@KullaniciAdi,@KullaniciTip,@Sifre,@Soruid,@Cevap)
GO
/****** Object:  StoredProcedure [dbo].[pro_Kullanici_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Kullanici_Guncelle]
@Id int,
@KullaniciAdi nvarchar(50),
@KullaniciTip int,
@Sifre nvarchar(50),
@Soruid int,
@Cevap nvarchar(50),
@Aktif bit
as
Update Kullanici set KullaniciAdi=@KullaniciAdi,KullaniciTip=@KullaniciTip,Sifre=@Sifre,Soruid=@Soruid,Cevap=@Cevap where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_Kullanici_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Kullanici_Listele]
as
select * from KullaniciTip Inner join Kullanici on KullaniciTip.Id=Kullanici.KullaniciTip inner join GuvenlikSoru on Kullanici.Soruid=GuvenlikSoru.Id where Kullanici.Aktif=1
GO
/****** Object:  StoredProcedure [dbo].[pro_Kullanici_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Kullanici_Sil]
@Id int,
@KullaniciAdi nvarchar(50),
@KullaniciTip int,
@Sifre nvarchar(50),
@Soruid int,
@Cevap nvarchar(50),
@Aktif bit
as
Update Kullanici set KullaniciAdi=@KullaniciAdi,KullaniciTip=@KullaniciTip,Sifre=@Sifre,Soruid=@Soruid,Cevap=@Cevap,Aktif=0 where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_KullaniciTip_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_KullaniciTip_Listele]
as
select * from KullaniciTip where Aktif=1
GO
/****** Object:  StoredProcedure [dbo].[pro_Malzeme_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Malzeme_Ekle]
@Id int,
@Adi nvarchar(50),
@Fiyat money
as
Insert Into Malzeme (Adi,Fiyat) values (@Adi,@Fiyat)
GO
/****** Object:  StoredProcedure [dbo].[pro_Malzeme_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Malzeme_Guncelle]
@Id int,
@Adi nvarchar(50),
@Fiyat money
as
Update Malzeme set Adi=@Adi,Fiyat=@Fiyat where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_Malzeme_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Malzeme_Listele]
as
select * from Malzeme
GO
/****** Object:  StoredProcedure [dbo].[pro_Malzeme_Listele2]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Malzeme_Listele2]
@TedarikciId int
as
select * from Tedarikci inner join TedarikciMalzeme on Tedarikci.Id=TedarikciMalzeme.TedarikciId inner join Malzeme on TedarikciMalzeme.MalzemeId=Malzeme.Id where Tedarikci.Id=@TedarikciId
GO
/****** Object:  StoredProcedure [dbo].[pro_Malzeme_Urun_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Malzeme_Urun_Ekle]
@UrunId int,
@MalzemeId int,
@Miktar float
as
Insert Into Malzeme_Urun values (@UrunId,@MalzemeId,@Miktar)
GO
/****** Object:  StoredProcedure [dbo].[pro_Malzeme_Urun_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Malzeme_Urun_Guncelle]
@UrunId int,
@MalzemeId int,
@Miktar float
as
Update Malzeme_Urun set UrunId=@UrunId,MalzemeId=@MalzemeId,Miktar=@Miktar where UrunId=@UrunId and MalzemeId=@MalzemeId
GO
/****** Object:  StoredProcedure [dbo].[pro_Malzeme_Urun_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Malzeme_Urun_Sil]
@UrunId int,
@MalzemeId int,
@Miktar float
as
delete from Malzeme_Urun where UrunId=@UrunId and MalzemeId=@MalzemeId
GO
/****** Object:  StoredProcedure [dbo].[pro_Miktar]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Miktar]
@UrunId int,
@MalzemeId int
as
select Miktar from Malzeme_Urun where (UrunId=@UrunId and MalzemeId=@MalzemeId)
GO
/****** Object:  StoredProcedure [dbo].[pro_Musteri_Ara]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Musteri_Ara]
@Ad nvarchar(50),
@Soyad nvarchar(50)
as
select * from Musteri Inner join Firma on Musteri.FirmaId=Firma.Id where (Musteri.Adi like '%'+@Ad+'%') and (Musteri.Soyadi like '%'+@Soyad+'%') and Musteri.Aktif=1
GO
/****** Object:  StoredProcedure [dbo].[pro_Musteri_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Musteri_Guncelle]
@Id int,
@Adi nvarchar(50),
@Soyadi nvarchar(50),
@Tckn char(11),
@TelNo char(14),
@Mail nvarchar(50),
@FirmaId int,
@Aktif bit
as
Update Musteri set Adi=@Adi, Soyadi=@Soyadi,Tckn=@Tckn,TelNo=@TelNo,Mail=@Mail,FirmaId=@FirmaId
where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_Musteri_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Musteri_Listele]
as
select * from Musteri Inner join Firma on Musteri.FirmaId=Firma.Id where Musteri.Aktif=1
GO
/****** Object:  StoredProcedure [dbo].[pro_Musteri_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Musteri_Sil]
@Id int,
@Adi nvarchar(50),
@Soyadi nvarchar(50),
@Tckn char(11),
@TelNo char(14),
@Mail nvarchar(50),
@FirmaId int,
@Aktif bit
as
Update Musteri Set Adi=@Adi,Soyadi=@Soyadi,Tckn=@Tckn,Mail=@Mail,TelNo=@TelNo,FirmaId=@FirmaId,Aktif=0 where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_MusteriSiparis_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_MusteriSiparis_Ekle]
@MusteriId int,
@SiparisId int
as
Insert Into MusteriSiparis values (@MusteriId,@SiparisId)
GO
/****** Object:  StoredProcedure [dbo].[pro_MusteriSiparis_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_MusteriSiparis_Guncelle]
@MusteriId int,
@SiparisId int
as
Update MusteriSiparis set MusteriId=@MusteriId, SiparisId=@SiparisId where MusteriId=@MusteriId and SiparisId=@SiparisId
GO
/****** Object:  StoredProcedure [dbo].[pro_Personel_Ara]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Personel_Ara]
@Ad nvarchar(50),
@Soyad nvarchar(50)
as
select * from Personel where Adi like '%'+@Ad+'%' and  Aktif=1 
GO
/****** Object:  StoredProcedure [dbo].[pro_Personel_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Personel_Ekle]
@Id int,
@Adi nvarchar(50),
@Soyadi nvarchar(50),
@Maas money,
@Tckn char(11),
@DogumTarih date,
@IsegirisTarih date,
@Adres nvarchar(500),
@TelNo char(15),
@Mail nvarchar(50),
@MedeniDurum bit,
@EgitimId int,
@Aktif bit
as
Insert Into Personel (Adi,Soyadi,Maas,Tckn,DogumTarih,IsegirisTarih,Adres,TelNo,Mail,MedeniDurum,EgitimId)
values(@Adi,@Soyadi,@Maas,@Tckn,@DogumTarih,@IsegirisTarih,@Adres,@TelNo,@Mail,@MedeniDurum,@EgitimId)
GO
/****** Object:  StoredProcedure [dbo].[pro_Personel_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Personel_Guncelle]
@Id int,
@Adi nvarchar(50),
@Soyadi nvarchar(50),
@Maas money,
@Tckn char(11),
@DogumTarih date,
@IsegirisTarih date,
@Adres nvarchar(500),
@TelNo char(15),
@Mail nvarchar(50),
@MedeniDurum bit,
@EgitimId int,
@Aktif bit
as
Update Personel Set Adi=@Adi,Soyadi=@Soyadi,Maas=@Maas,Tckn=@Tckn,DogumTarih=@DogumTarih,IsegirisTarih=@IsegirisTarih,
Adres=@Adres,TelNo=@TelNo,Mail=@Mail,MedeniDurum=@MedeniDurum,EgitimId=@EgitimId where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_Personel_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Personel_Listele]
as
select * from Personel where Aktif=1
GO
/****** Object:  StoredProcedure [dbo].[pro_Personel_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Personel_Sil]
@Id int,
@Adi nvarchar(50),
@Soyadi nvarchar(50),
@Maas money,
@Tckn char(11),
@DogumTarih date,
@IsegirisTarih date,
@Adres nvarchar(500),
@TelNo char(15),
@Mail nvarchar(50),
@MedeniDurum bit,
@EgitimId int,
@Aktif bit
as
Update Personel set Aktif=0,Adi=@Adi,Soyadi=@Soyadi,Maas=@Maas,Tckn=@Tckn,DogumTarih=@DogumTarih,IsegirisTarih=@IsegirisTarih,Adres=@Adres,TelNo=@TelNo,
Mail=@Mail,MedeniDurum=@MedeniDurum,EgitimId=@EgitimId where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_SatınAlma_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_SatınAlma_Sil]
@Id int,
@Tarih date,
@Ucret money,
@Aciklama nvarchar(500),
@aktif bit
as
update SatinAlma set Tarih=@Tarih,Ucret=@Ucret,Aciklama=@Aciklama,aktif=0 where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_SatınAlmaMalzeme_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_SatınAlmaMalzeme_Ekle]
@SatınAlmaId int,
@MalzemeId int,
@Miktar float
as
Insert Into SatınAlmaMalzeme values(@SatınAlmaId,@MalzemeId,@Miktar)
GO
/****** Object:  StoredProcedure [dbo].[pro_SatınAlmaMalzeme_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_SatınAlmaMalzeme_Guncelle]
@SatınAlmaId int,
@MalzemeId int,
@Miktar float
as
Update SatınAlmaMalzeme set SatınAlmaId=@SatınAlmaId,MalzemeId=@MalzemeId,Miktar=@Miktar where SatınAlmaId=@SatınAlmaId and MalzemeId=@MalzemeId
GO
/****** Object:  StoredProcedure [dbo].[pro_SatınAlmaMalzeme_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_SatınAlmaMalzeme_Sil]
@SatınAlmaId int,
@MalzemeId int,
@Miktar float
as
delete SatınAlmaMalzeme where SatınAlmaId=@SatınAlmaId and MalzemeId=@MalzemeId
GO
/****** Object:  StoredProcedure [dbo].[pro_SatinAlma_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_SatinAlma_Ekle]
@Id int,
@Tarih date,
@Ucret money,
@Aciklama nvarchar(500),
@aktif bit
as
Insert Into SatinAlma (Tarih,Ucret,Aciklama) values (@Tarih,@Ucret,@Aciklama)
GO
/****** Object:  StoredProcedure [dbo].[pro_SatinAlma_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_SatinAlma_Guncelle]
@Id int,
@Tarih date,
@Ucret money,
@Aciklama nvarchar(500),
@aktif bit
as
Update SatinAlma set Tarih=@Tarih,Ucret=@Ucret,Aciklama=@Aciklama where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_SatinAlma_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_SatinAlma_Listele]
as
select * from SatinAlma where aktif=1
GO
/****** Object:  StoredProcedure [dbo].[pro_SatinAlma_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_SatinAlma_Sil]
@Id int,
@Tarih date,
@Ucret money,
@Aciklama nvarchar(500),
@aktif bit
as
update SatinAlma set Tarih=@Tarih,Ucret=@Ucret,Aciklama=@Aciklama,aktif=0 where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_SatinAlmaMalzeme_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_SatinAlmaMalzeme_Listele]
@SatınAlmaId int
as
select * from SatinAlma Inner join SatınAlmaMalzeme on SatinAlma.Id=SatınAlmaMalzeme.SatınAlmaId inner join Malzeme on SatınAlmaMalzeme.MalzemeId=Malzeme.Id where SatinAlma.Id=@SatınAlmaId
GO
/****** Object:  StoredProcedure [dbo].[pro_SifreYenile]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_SifreYenile]
@Kullaniciadi nvarchar(50)
as
select Soru from GuvenlikSoru where Id=(select Soruid from Kullanici where KullaniciAdi=@Kullaniciadi)
GO
/****** Object:  StoredProcedure [dbo].[pro_Siparis_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Siparis_Ekle]
@Id int,
@Tarih date,
@Personel nvarchar(50),
@OnaylandiMi bit,
@SiparisTutari money,
@OdemeYapildiMi bit,
@HazirMi bit,
@Aktif bit
as
Insert Into Siparis (Tarih,Personel,SiparisTutari,OdemeYapildiMi) values (@Tarih,@Personel,@SiparisTutari,@OdemeYapildiMi)
GO
/****** Object:  StoredProcedure [dbo].[pro_Siparis_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Siparis_Guncelle]
@Id int,
@Tarih date,
@Personel nvarchar(50),
@OnaylandiMi bit,
@SiparisTutari money,
@OdemeYapildiMi bit,
@HazirMi bit,
@Aktif bit
as
update Siparis set Tarih=@Tarih,Personel=@Personel,SiparisTutari=@SiparisTutari,OdemeYapildiMi=@OdemeYapildiMi where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_Siparis_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Siparis_Listele]
as
select * from Siparis inner join MusteriSiparis on Siparis.Id=MusteriSiparis.SiparisId inner join Musteri on MusteriSiparis.MusteriId=Musteri.Id where Siparis.Aktif =1 and OnaylandiMi=0
GO
/****** Object:  StoredProcedure [dbo].[pro_Siparis_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Siparis_Sil]
@Id int,
@Tarih date,
@Personel nvarchar(50),
@OnaylandiMi bit,
@SiparisTutari money,
@OdemeYapildiMi bit,
@HazirMi bit,
@Aktif bit
as
delete Siparis where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_SiparisUrun_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_SiparisUrun_Ekle]
@SiparisId int,
@UrunId int,
@Miktar float
as
Insert Into SiparisUrun values (@SiparisId,@UrunId,@Miktar)
GO
/****** Object:  StoredProcedure [dbo].[pro_SiparisUrun_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_SiparisUrun_Listele]
@SiparisId int
as
select * from Siparis inner join SiparisUrun on Siparis.Id=SiparisUrun.SiparisId inner join Urunler on SiparisUrun.UrunId=Urunler.Id where Siparis.Id=@SiparisId
GO
/****** Object:  StoredProcedure [dbo].[pro_SiparisUrunIcerik]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_SiparisUrunIcerik]
@SiparisId int
as
select * from Siparis inner join SiparisUrun on Siparis.Id=SiparisUrun.SiparisId inner join Urunler on SiparisUrun.UrunId=Urunler.Id where Siparis.Id=@SiparisId
GO
/****** Object:  StoredProcedure [dbo].[pro_Son]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Son]
as

SELECT TOP 1 * FROM Siparis ORDER BY Id DESC
GO
/****** Object:  StoredProcedure [dbo].[pro_Tedarikci_Ara]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Tedarikci_Ara]
@Adi nvarchar(50)
as
select * from Tedarikci where Adi like '%'+@Adi+'%'
GO
/****** Object:  StoredProcedure [dbo].[pro_Tedarikci_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Tedarikci_Ekle]
@Id int,
@Adi nvarchar(50),
@Adres nvarchar(500),
@TelNo char(15),
@Mail nvarchar(50),
@Aktif bit
as
Insert Into Tedarikci (Adi,Adres,TelNo,Mail) values (@Adi,@Adres,@TelNo,@Mail)
GO
/****** Object:  StoredProcedure [dbo].[pro_Tedarikci_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Tedarikci_Guncelle]
@Id int,
@Adi nvarchar(50),
@Adres nvarchar(500),
@TelNo char(15),
@Mail nvarchar(50),
@Aktif bit
as
Update Tedarikci set Adi=@Adi,Adres=@Adres,TelNo=@TelNo,Mail=@Mail where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_Tedarikci_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Tedarikci_Listele]
as
select * from Tedarikci where Aktif=1
GO
/****** Object:  StoredProcedure [dbo].[pro_Tedarikci_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Tedarikci_Sil]
@Id int,
@Adi nvarchar(50),
@Adres nvarchar(500),
@TelNo char(15),
@Mail nvarchar(50),
@Aktif bit
as
update Tedarikci set Adi=@Adi,Adres=@Adres,TelNo=@TelNo,Mail=@Mail,Aktif=0 where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_TedarikciMalzeme_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_TedarikciMalzeme_Ekle]
@TedarikciId int,
@MalzemeId int
as
Insert Into TedarikciMalzeme (TedarikciId,MalzemeId) values (@TedarikciId,@MalzemeId)
GO
/****** Object:  StoredProcedure [dbo].[pro_TedarikciMalzeme_Icerik]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_TedarikciMalzeme_Icerik]
@TedarikciId int
as
select * from Tedarikci Inner join TedarikciMalzeme on Tedarikci.Id=TedarikciMalzeme.TedarikciId inner join Malzeme on TedarikciMalzeme.MalzemeId=Malzeme.Id where TedarikciId=@TedarikciId
GO
/****** Object:  StoredProcedure [dbo].[pro_TedarikciMalzeme_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_TedarikciMalzeme_Sil]
@TedarikciId int,
@MalzemeId int
as
delete from TedarikciMalzeme where TedarikciId=@TedarikciId and MalzemeId=@MalzemeId
GO
/****** Object:  StoredProcedure [dbo].[pro_Urun_Icerik]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Urun_Icerik]
@UrunId int
as
SELECT * FROM Urunler INNER JOIN Malzeme_Urun ON 
     Urunler.Id=Malzeme_Urun.UrunId INNER JOIN 
     Malzeme ON Malzeme_Urun.MalzemeId=Malzeme.Id where UrunId=@UrunId
GO
/****** Object:  StoredProcedure [dbo].[pro_Urunler_Ekle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Urunler_Ekle]
@Id int,
@Adi nvarchar(50),
@Fiyat money,
@Aktif bit
as
Insert Into Urunler (Adi,Fiyat)
values (@Adi,@Fiyat)
GO
/****** Object:  StoredProcedure [dbo].[pro_Urunler_Guncelle]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pro_Urunler_Guncelle]
@Id int,
@Adi nvarchar(50),
@Fiyat money,
@Aktif bit
as
Update Urunler set Adi=@Adi,Fiyat=@Fiyat,Aktif=1 where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[pro_Urunler_Listele]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Urunler_Listele]
as
select * from Urunler where Aktif=1
GO
/****** Object:  StoredProcedure [dbo].[pro_Urunler_Sil]    Script Date: 26.03.2019 22:06:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pro_Urunler_Sil]
@Id int,
@Adi nvarchar(50),
@Fiyat money,
@Aktif bit
as
Update  Urunler Set Adi=@Adi, Fiyat=@Fiyat, Aktif=0 where Id=@Id
GO
