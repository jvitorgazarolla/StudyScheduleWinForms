USE [StudySchedule]
GO
/****** Object:  StoredProcedure [dbo].[cadastro_jornada_inserir]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[cadastro_jornada_inserir]
    @profissional_id INT,
    @profissional_especialidade_id INT,
    @data DATE,
    @horario TIME(0)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM cadastro_jornada
        WHERE profissional_id = @profissional_id
          AND data = @data
          AND horario = @horario
    )
    BEGIN

        THROW 50000, N'Já existe um agendamento nesse dia e horário para este profissional.', 1;
        RETURN;
    END

    INSERT INTO cadastro_jornada (
        profissional_id,
        profissional_especialidade_id,
        data,
        horario
    )
    VALUES (
        @profissional_id,
        @profissional_especialidade_id,
        @data,
        @horario
    );


    SELECT SCOPE_IDENTITY() AS ID; 
END


GO
/****** Object:  StoredProcedure [dbo].[cadastro_profissional_especialidade_buscar]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[cadastro_profissional_especialidade_buscar]
    @profissional_id   INT = NULL,
    @especialidade_id  INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT  cpe.id,
            cpe.profissional_id,
            cpe.especialidade_id,
            ce.descricao
    FROM    cadastro_profissional_especialidade cpe
    JOIN    cadastro_especialidade ce
            ON ce.id = cpe.especialidade_id
    WHERE   ce.status = 1
      AND   (@profissional_id IS NULL OR cpe.profissional_id = @profissional_id)
      AND   (@especialidade_id IS NULL OR cpe.especialidade_id = @especialidade_id);
END
GO
/****** Object:  StoredProcedure [dbo].[especialidade_atualizar]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[especialidade_atualizar]
	@id INT, 
	@descricao NVARCHAR(120) = NULL,
	@status INT = NULL
AS 
BEGIN
	SET nocount ON;

	update cadastro_especialidade 
	set descricao =  COALESCE(@descricao, descricao),
		status =  COALESCE(@status, status)
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[especialidade_buscar]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[especialidade_buscar]
    @termo VARCHAR(100) = NULL, -- Nome ou Descrição
    @status INT = NULL          -- 1 para ativo, 0 para Inativo, NULL para todos
AS
BEGIN
    SELECT id, descricao, status
    FROM cadastro_especialidade
    WHERE 
        -- Se @termo for nulo ou vazio, ignora esse filtro
        (@termo IS NULL OR @termo = '' OR descricao LIKE '%' + @termo + '%')
        AND
        -- Se @status for nulo, traz ativos e inativos
        (@status IS NULL OR status = @status)
    ORDER BY descricao;
END
GO
/****** Object:  StoredProcedure [dbo].[especialidade_excluir]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[especialidade_excluir]
	@id INT

AS 
BEGIN
	SET nocount ON;

	delete from cadastro_especialidade
	where	id = @id

END
GO
/****** Object:  StoredProcedure [dbo].[especialidade_inserir]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[especialidade_inserir]
	@descricao NVARCHAR(120),
	@status int

as
begin 
	set NOCOUNT ON;

	insert into cadastro_especialidade (descricao, status) values(@descricao, @status)

end
GO
/****** Object:  StoredProcedure [dbo].[especialidade_listar]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[especialidade_listar]
as 
begin
set nocount on;
	select		*
	from		cadastro_especialidade
end
GO
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[login]
	@usuario NVARCHAR(60),
	@senha NVARCHAR(12)
AS
BEGIN 
	SET NOCOUNT ON;

	select		id, nome, usuario, senha, ativo
	from		cadastro_usuario
	where		usuario = @usuario
	and			senha = @senha


end
GO
/****** Object:  StoredProcedure [dbo].[profissional_atualizar]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[profissional_atualizar]
    @id INT,
    @nome NVARCHAR(150) = NULL,
    @telefone NVARCHAR(20) = NULL,
    @status BIT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE cadastro_profissional
    SET
        nome     = COALESCE(@nome, nome),
        telefone = COALESCE(@telefone, telefone),
        status   = COALESCE(@status, status)
    WHERE id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[profissional_buscar]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[profissional_buscar]
    @termo VARCHAR(100) = NULL, -- Nome ou Descrição
    @status INT = NULL          -- 1 para ativo, 0 para Inativo, NULL para todos
AS
BEGIN
    SELECT cadastro_profissional.id, 
    nome, 
    telefone, 
    cadastro_profissional.status,
    cadastro_profissional_especialidade.especialidade_id as 'especialidade_id',
    cadastro_especialidade.descricao as 'especialidade_nome'

    FROM cadastro_profissional
    join  cadastro_profissional_especialidade 
    on      cadastro_profissional_especialidade.profissional_id = cadastro_profissional.id
    join    cadastro_especialidade 
    on      cadastro_especialidade.id = cadastro_profissional_especialidade.especialidade_id
    WHERE 
        -- Se @termo for nulo ou vazio, ignora esse filtro
        (@termo IS NULL OR @termo = '' OR nome LIKE '%' + @termo + '%')
        AND
        -- Se @status for nulo, traz ativos e inativos
        (@status IS NULL OR cadastro_profissional.status = @status)
    ORDER BY nome;
END
GO
/****** Object:  StoredProcedure [dbo].[profissional_excluir]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[profissional_excluir]
@id INT
AS BEGIN
	delete from cadastro_profissional
	where	id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[profissional_inserir]    Script Date: 17/02/2026 08:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[profissional_inserir]
@nome NVARCHAR(120),
@telefone NVARCHAR(60),
@status BIT,
@especialidade_id int
as 
begin
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
 BEGIN TRAN 

 insert into cadastro_profissional(nome,telefone,status) values(@nome, @telefone, @status);

 DECLARE @profissional_id INT = SCOPE_IDENTITY();

 insert into cadastro_profissional_especialidade(profissional_id, especialidade_id) values(@profissional_id, @especialidade_id);

 commit;

 SELECT @profissional_id AS id;

 end;

GO
