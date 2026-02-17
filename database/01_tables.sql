USE [StudySchedule]
GO
/****** Object:  Table [dbo].[cadastro_especialidade]    Script Date: 17/02/2026 08:19:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cadastro_especialidade](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](120) NOT NULL,
	[status] [int] NULL,
 CONSTRAINT [pk_especialidade] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cadastro_jornada]    Script Date: 17/02/2026 08:19:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cadastro_jornada](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[profissional_id] [int] NOT NULL,
	[profissional_especialidade_id] [int] NOT NULL,
	[data] [date] NOT NULL,
	[horario] [time](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cadastro_profissional]    Script Date: 17/02/2026 08:19:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cadastro_profissional](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](120) NOT NULL,
	[telefone] [varchar](11) NOT NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_profissional] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cadastro_profissional_especialidade]    Script Date: 17/02/2026 08:19:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cadastro_profissional_especialidade](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[profissional_id] [int] NOT NULL,
	[especialidade_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cadastro_usuario]    Script Date: 17/02/2026 08:19:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cadastro_usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](120) NULL,
	[usuario] [nvarchar](60) NOT NULL,
	[senha] [varchar](12) NULL,
	[ativo] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cadastro_jornada]  WITH CHECK ADD  CONSTRAINT [FK_cadastro_profissional] FOREIGN KEY([profissional_id])
REFERENCES [dbo].[cadastro_profissional] ([id])
GO
ALTER TABLE [dbo].[cadastro_jornada] CHECK CONSTRAINT [FK_cadastro_profissional]
GO
ALTER TABLE [dbo].[cadastro_jornada]  WITH CHECK ADD  CONSTRAINT [FK_profissional_especialidade] FOREIGN KEY([profissional_especialidade_id])
REFERENCES [dbo].[cadastro_profissional_especialidade] ([id])
GO
ALTER TABLE [dbo].[cadastro_jornada] CHECK CONSTRAINT [FK_profissional_especialidade]
GO
ALTER TABLE [dbo].[cadastro_profissional_especialidade]  WITH CHECK ADD  CONSTRAINT [FK_usuario_especialidade_especialidade] FOREIGN KEY([especialidade_id])
REFERENCES [dbo].[cadastro_especialidade] ([id])
GO
ALTER TABLE [dbo].[cadastro_profissional_especialidade] CHECK CONSTRAINT [FK_usuario_especialidade_especialidade]
GO
ALTER TABLE [dbo].[cadastro_profissional_especialidade]  WITH CHECK ADD  CONSTRAINT [FK_usuario_especialidade_profissional] FOREIGN KEY([profissional_id])
REFERENCES [dbo].[cadastro_profissional] ([id])
GO
ALTER TABLE [dbo].[cadastro_profissional_especialidade] CHECK CONSTRAINT [FK_usuario_especialidade_profissional]
GO
